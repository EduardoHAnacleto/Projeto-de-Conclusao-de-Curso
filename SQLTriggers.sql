CREATE TRIGGER UpdateProductStock
ON SALES
AFTER INSERT
AS
BEGIN
  UPDATE PRODUCTS
  SET STOCK = STOCK - sp.QUANTITY
  FROM inserted s
  JOIN SALEITEMS sp ON s.id_sale = sp.SALE_ID
  WHERE PRODUCTS.id_product = sp.PRODUCT_ID
END;
------------------------------------------
CREATE TRIGGER LowStockAlert
ON PRODUCTS
AFTER UPDATE
AS
BEGIN
  DECLARE @ProductId INT
  DECLARE @NewStock INT
  
  SELECT @ProductId = id_product, @NewStock = STOCK
  FROM inserted

  IF @NewStock < 10
  BEGIN
    DECLARE @ErrorMessage VARCHAR(100)
    SET @ErrorMessage = 'ALERT : Low stock for product ' + CAST(@ProductId AS VARCHAR) + '. Stock at the moment: ' + CAST(@NewStock AS VARCHAR)
    RAISERROR (@ErrorMessage, 16, 1)
  END
END;
------------------------------
CREATE TRIGGER CheckStock
ON SALEITEMS
INSTEAD OF INSERT
AS
BEGIN
  -- Check if there is enough stock for all products in the sale
  IF EXISTS (
    SELECT si.PRODUCT_ID, si.Quantity, p.Stock
    FROM inserted s
    JOIN SALEITEMS si ON s.SALE_ID = si.SALE_ID
    JOIN PRODUCTS p ON si.PRODUCT_ID = p.id_product
    WHERE si.Quantity > p.Stock
  )
  BEGIN
    -- Roll back the transaction and cancel the sale
    RAISERROR ('Not enough stock for one or more products', 16, 1)
    ROLLBACK TRANSACTION
  END
  ELSE
  BEGIN
    -- Insert the sale items into the SaleItems table
    INSERT INTO SALEITEMS (SALE_ID, PRODUCT_ID, Quantity, ITEM_VALUE, ITEM_COST, DISCOUNT_CASH, DISCOUNT_PERC, TOTAL_VALUE, DATE_CREATION, DATE_LAST_UPDATE)
    SELECT SALE_ID, PRODUCT_ID, Quantity, ITEM_VALUE, ITEM_COST, DISCOUNT_CASH, DISCOUNT_PERC, TOTAL_VALUE, DATE_CREATION, DATE_LAST_UPDATE FROM inserted
  END
END;
-----------------------------------
CREATE TRIGGER CheckStock
ON SALEITEMS
INSTEAD OF UPDATE
AS
BEGIN
  -- Check if there is enough stock for all products in the sale
  IF EXISTS (
    SELECT si.PRODUCT_ID, i.Quantity, p.Stock
    FROM inserted i
    JOIN SALEITEMS si ON i.SALE_ID = si.SALE_ID AND i.PRODUCT_ID = si.PRODUCT_ID
    JOIN PRODUCTS p ON si.PRODUCT_ID = p.id_product
    WHERE i.Quantity > p.Stock
  )
  BEGIN
    -- Roll back the transaction and cancel the sale
    RAISERROR ('Not enough stock for one or more products', 16, 1)
    ROLLBACK TRANSACTION
  END
  ELSE
  BEGIN
    -- Update the sale items in the SaleItems table
    UPDATE SALEITEMS
    SET Quantity = i.Quantity, ITEM_VALUE = i.ITEM_VALUE, ITEM_COST = i.ITEM_COST,
        DISCOUNT_CASH = i.DISCOUNT_CASH, DISCOUNT_PERC = i.DISCOUNT_PERC,
        TOTAL_VALUE = i.TOTAL_VALUE, DATE_CREATION = i.DATE_CREATION,
        DATE_LAST_UPDATE = i.DATE_LAST_UPDATE
    FROM inserted i
    WHERE SALEITEMS.SALE_ID = i.SALE_ID AND SALEITEMS.PRODUCT_ID = i.PRODUCT_ID
    
    -- Check if there are any canceled items and update the stock accordingly
    UPDATE PRODUCTS
    SET Stock = Stock + d.Quantity
    FROM deleted d
    JOIN SALEITEMS si ON d.SALE_ID = si.SALE_ID AND d.PRODUCT_ID = si.PRODUCT_ID
    JOIN PRODUCTS p ON si.PRODUCT_ID = p.id_product
  END
END;

--------------------------------------
ALTER TABLE SALEITEMS
ADD CONSTRAINT FK_SALEITEMS_SALES
FOREIGN KEY (SALE_ID) REFERENCES SALES(id_sale)
ON DELETE CASCADE;
------------------------------
CREATE TRIGGER DeleteSale
ON SALES
INSTEAD OF DELETE
AS
BEGIN
  -- Recolocar o estoque dos produtos da venda excluída
  UPDATE PRODUCTS
  SET Stock = Stock + si.Quantity
  FROM deleted s
  JOIN SALEITEMS si ON s.id_sale = si.SALE_ID
  WHERE PRODUCTS.id_product = si.PRODUCT_ID;

  -- Não é necessário excluir a venda, pois o DELETE CASCADE fará isso automaticamente junto com os itens da venda
END;
