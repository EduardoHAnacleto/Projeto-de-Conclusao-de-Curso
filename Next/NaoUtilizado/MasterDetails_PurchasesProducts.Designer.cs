namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class MasterDetails_PurchasesProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Close = new System.Windows.Forms.Button();
            this.gbox_products = new System.Windows.Forms.GroupBox();
            this.DGV_PurchaseProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscoutCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnValueProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductWeightedAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_purchase = new System.Windows.Forms.GroupBox();
            this.btn_SelectPurchase = new System.Windows.Forms.Button();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.rbtn_cancelled = new System.Windows.Forms.RadioButton();
            this.rbtn_active = new System.Windows.Forms.RadioButton();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.dateTime_filter = new System.Windows.Forms.DateTimePicker();
            this.rbtn_cancelDate = new System.Windows.Forms.RadioButton();
            this.rbtn_DateCreation = new System.Windows.Forms.RadioButton();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.DGV_Purchases = new System.Windows.Forms.DataGridView();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gbox_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchaseProducts)).BeginInit();
            this.gbox_purchase.SuspendLayout();
            this.gbox_status.SuspendLayout();
            this.gbox_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(927, 537);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Sair";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gbox_products
            // 
            this.gbox_products.Controls.Add(this.DGV_PurchaseProducts);
            this.gbox_products.Location = new System.Drawing.Point(12, 267);
            this.gbox_products.Name = "gbox_products";
            this.gbox_products.Size = new System.Drawing.Size(1006, 264);
            this.gbox_products.TabIndex = 15;
            this.gbox_products.TabStop = false;
            this.gbox_products.Text = "Produtos";
            // 
            // DGV_PurchaseProducts
            // 
            this.DGV_PurchaseProducts.AllowUserToAddRows = false;
            this.DGV_PurchaseProducts.AllowUserToResizeColumns = false;
            this.DGV_PurchaseProducts.AllowUserToResizeRows = false;
            this.DGV_PurchaseProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PurchaseProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.QuantityProduct,
            this.ProductDiscoutCash,
            this.UnValueProduct,
            this.ProductWeightedAvg,
            this.ProductTotalValue});
            this.DGV_PurchaseProducts.Location = new System.Drawing.Point(9, 19);
            this.DGV_PurchaseProducts.MultiSelect = false;
            this.DGV_PurchaseProducts.Name = "DGV_PurchaseProducts";
            this.DGV_PurchaseProducts.RowHeadersVisible = false;
            this.DGV_PurchaseProducts.RowHeadersWidth = 51;
            this.DGV_PurchaseProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PurchaseProducts.Size = new System.Drawing.Size(984, 221);
            this.DGV_PurchaseProducts.TabIndex = 6;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "ID";
            this.IdProduct.MinimumWidth = 6;
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Width = 45;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.HeaderText = "Produto";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // QuantityProduct
            // 
            this.QuantityProduct.HeaderText = "Quantidade";
            this.QuantityProduct.MinimumWidth = 6;
            this.QuantityProduct.Name = "QuantityProduct";
            this.QuantityProduct.ReadOnly = true;
            this.QuantityProduct.Width = 70;
            // 
            // ProductDiscoutCash
            // 
            this.ProductDiscoutCash.HeaderText = "Desconto $";
            this.ProductDiscoutCash.MinimumWidth = 6;
            this.ProductDiscoutCash.Name = "ProductDiscoutCash";
            this.ProductDiscoutCash.ReadOnly = true;
            this.ProductDiscoutCash.Width = 70;
            // 
            // UnValueProduct
            // 
            this.UnValueProduct.HeaderText = "Valor UN";
            this.UnValueProduct.MinimumWidth = 6;
            this.UnValueProduct.Name = "UnValueProduct";
            this.UnValueProduct.ReadOnly = true;
            this.UnValueProduct.Width = 70;
            // 
            // ProductWeightedAvg
            // 
            this.ProductWeightedAvg.HeaderText = "Média Ponderada";
            this.ProductWeightedAvg.Name = "ProductWeightedAvg";
            this.ProductWeightedAvg.ReadOnly = true;
            // 
            // ProductTotalValue
            // 
            this.ProductTotalValue.HeaderText = "Valor Total";
            this.ProductTotalValue.MinimumWidth = 6;
            this.ProductTotalValue.Name = "ProductTotalValue";
            this.ProductTotalValue.ReadOnly = true;
            this.ProductTotalValue.Width = 90;
            // 
            // gbox_purchase
            // 
            this.gbox_purchase.Controls.Add(this.btn_SelectPurchase);
            this.gbox_purchase.Controls.Add(this.gbox_status);
            this.gbox_purchase.Controls.Add(this.gbox_date);
            this.gbox_purchase.Controls.Add(this.lbl_Supplier);
            this.gbox_purchase.Controls.Add(this.btn_Clear);
            this.gbox_purchase.Controls.Add(this.edt_supplierName);
            this.gbox_purchase.Controls.Add(this.DGV_Purchases);
            this.gbox_purchase.Controls.Add(this.btn_Search);
            this.gbox_purchase.Location = new System.Drawing.Point(12, 12);
            this.gbox_purchase.Name = "gbox_purchase";
            this.gbox_purchase.Size = new System.Drawing.Size(1006, 249);
            this.gbox_purchase.TabIndex = 14;
            this.gbox_purchase.TabStop = false;
            this.gbox_purchase.Text = "Compras";
            // 
            // btn_SelectPurchase
            // 
            this.btn_SelectPurchase.Location = new System.Drawing.Point(745, 220);
            this.btn_SelectPurchase.Name = "btn_SelectPurchase";
            this.btn_SelectPurchase.Size = new System.Drawing.Size(104, 23);
            this.btn_SelectPurchase.TabIndex = 18;
            this.btn_SelectPurchase.Text = "Selecionar Compra";
            this.btn_SelectPurchase.UseVisualStyleBackColor = true;
            this.btn_SelectPurchase.Click += new System.EventHandler(this.btn_SelectPurchase_Click);
            // 
            // gbox_status
            // 
            this.gbox_status.Controls.Add(this.rbtn_cancelled);
            this.gbox_status.Controls.Add(this.rbtn_active);
            this.gbox_status.Location = new System.Drawing.Point(908, 10);
            this.gbox_status.Name = "gbox_status";
            this.gbox_status.Size = new System.Drawing.Size(92, 69);
            this.gbox_status.TabIndex = 17;
            this.gbox_status.TabStop = false;
            this.gbox_status.Text = "Status";
            // 
            // rbtn_cancelled
            // 
            this.rbtn_cancelled.AutoSize = true;
            this.rbtn_cancelled.Location = new System.Drawing.Point(6, 42);
            this.rbtn_cancelled.Name = "rbtn_cancelled";
            this.rbtn_cancelled.Size = new System.Drawing.Size(81, 17);
            this.rbtn_cancelled.TabIndex = 1;
            this.rbtn_cancelled.TabStop = true;
            this.rbtn_cancelled.Text = "Cancelados";
            this.rbtn_cancelled.UseVisualStyleBackColor = true;
            this.rbtn_cancelled.CheckedChanged += new System.EventHandler(this.rbtn_cancelled_CheckedChanged);
            // 
            // rbtn_active
            // 
            this.rbtn_active.AutoSize = true;
            this.rbtn_active.Location = new System.Drawing.Point(6, 19);
            this.rbtn_active.Name = "rbtn_active";
            this.rbtn_active.Size = new System.Drawing.Size(54, 17);
            this.rbtn_active.TabIndex = 0;
            this.rbtn_active.TabStop = true;
            this.rbtn_active.Text = "Ativos";
            this.rbtn_active.UseVisualStyleBackColor = true;
            this.rbtn_active.CheckedChanged += new System.EventHandler(this.rbtn_active_CheckedChanged);
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.dateTime_filter);
            this.gbox_date.Controls.Add(this.rbtn_cancelDate);
            this.gbox_date.Controls.Add(this.rbtn_DateCreation);
            this.gbox_date.Location = new System.Drawing.Point(855, 124);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(145, 90);
            this.gbox_date.TabIndex = 16;
            this.gbox_date.TabStop = false;
            this.gbox_date.Text = "Data";
            // 
            // dateTime_filter
            // 
            this.dateTime_filter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_filter.Location = new System.Drawing.Point(6, 19);
            this.dateTime_filter.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_filter.Name = "dateTime_filter";
            this.dateTime_filter.Size = new System.Drawing.Size(96, 20);
            this.dateTime_filter.TabIndex = 13;
            // 
            // rbtn_cancelDate
            // 
            this.rbtn_cancelDate.AutoSize = true;
            this.rbtn_cancelDate.Location = new System.Drawing.Point(6, 68);
            this.rbtn_cancelDate.Name = "rbtn_cancelDate";
            this.rbtn_cancelDate.Size = new System.Drawing.Size(134, 17);
            this.rbtn_cancelDate.TabIndex = 15;
            this.rbtn_cancelDate.TabStop = true;
            this.rbtn_cancelDate.Text = "Data de Cancelamento";
            this.rbtn_cancelDate.UseVisualStyleBackColor = true;
            this.rbtn_cancelDate.CheckedChanged += new System.EventHandler(this.rbtn_cancelDate_CheckedChanged);
            // 
            // rbtn_DateCreation
            // 
            this.rbtn_DateCreation.AutoSize = true;
            this.rbtn_DateCreation.Location = new System.Drawing.Point(6, 45);
            this.rbtn_DateCreation.Name = "rbtn_DateCreation";
            this.rbtn_DateCreation.Size = new System.Drawing.Size(103, 17);
            this.rbtn_DateCreation.TabIndex = 14;
            this.rbtn_DateCreation.TabStop = true;
            this.rbtn_DateCreation.Text = "Data de Entrada";
            this.rbtn_DateCreation.UseVisualStyleBackColor = true;
            this.rbtn_DateCreation.CheckedChanged += new System.EventHandler(this.rbtn_DateCreation_CheckedChanged);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Location = new System.Drawing.Point(6, 20);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(61, 13);
            this.lbl_Supplier.TabIndex = 12;
            this.lbl_Supplier.Text = "Fornecedor";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(911, 220);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(89, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Limpar Filtros";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Enabled = false;
            this.edt_supplierName.Location = new System.Drawing.Point(6, 36);
            this.edt_supplierName.Name = "edt_supplierName";
            this.edt_supplierName.Size = new System.Drawing.Size(236, 20);
            this.edt_supplierName.TabIndex = 11;
            // 
            // DGV_Purchases
            // 
            this.DGV_Purchases.AllowUserToAddRows = false;
            this.DGV_Purchases.AllowUserToDeleteRows = false;
            this.DGV_Purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Purchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillNumber,
            this.BillModel,
            this.BillSeries,
            this.PurchaseSupplierName,
            this.UserId,
            this.PurchaseTotalValue,
            this.PurchaseDateCreation,
            this.PurchaseCancelDate});
            this.DGV_Purchases.Location = new System.Drawing.Point(6, 64);
            this.DGV_Purchases.MultiSelect = false;
            this.DGV_Purchases.Name = "DGV_Purchases";
            this.DGV_Purchases.ReadOnly = true;
            this.DGV_Purchases.RowHeadersVisible = false;
            this.DGV_Purchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Purchases.Size = new System.Drawing.Size(843, 150);
            this.DGV_Purchases.TabIndex = 0;
            this.DGV_Purchases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Purchases_CellClick);
            this.DGV_Purchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Purchases_CellContentClick);
            this.DGV_Purchases.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Purchases_CellMouseClick);
            // 
            // BillNumber
            // 
            this.BillNumber.HeaderText = "Número";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            this.BillNumber.Width = 65;
            // 
            // BillModel
            // 
            this.BillModel.HeaderText = "Modelo";
            this.BillModel.Name = "BillModel";
            this.BillModel.ReadOnly = true;
            this.BillModel.Width = 65;
            // 
            // BillSeries
            // 
            this.BillSeries.HeaderText = "Série";
            this.BillSeries.Name = "BillSeries";
            this.BillSeries.ReadOnly = true;
            this.BillSeries.Width = 65;
            // 
            // PurchaseSupplierName
            // 
            this.PurchaseSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseSupplierName.HeaderText = "Fornecedor";
            this.PurchaseSupplierName.Name = "PurchaseSupplierName";
            this.PurchaseSupplierName.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID Usuário";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 70;
            // 
            // PurchaseTotalValue
            // 
            this.PurchaseTotalValue.HeaderText = "Valor Total";
            this.PurchaseTotalValue.Name = "PurchaseTotalValue";
            this.PurchaseTotalValue.ReadOnly = true;
            // 
            // PurchaseDateCreation
            // 
            this.PurchaseDateCreation.HeaderText = "Data de Emissão";
            this.PurchaseDateCreation.Name = "PurchaseDateCreation";
            this.PurchaseDateCreation.ReadOnly = true;
            this.PurchaseDateCreation.Width = 85;
            // 
            // PurchaseCancelDate
            // 
            this.PurchaseCancelDate.HeaderText = "Cancelamento";
            this.PurchaseCancelDate.Name = "PurchaseCancelDate";
            this.PurchaseCancelDate.ReadOnly = true;
            this.PurchaseCancelDate.Width = 90;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(248, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // MasterDetails_PurchasesProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 578);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gbox_products);
            this.Controls.Add(this.gbox_purchase);
            this.Name = "MasterDetails_PurchasesProducts";
            this.Text = "MasterDetails_PurchasesProducts";
            this.gbox_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchaseProducts)).EndInit();
            this.gbox_purchase.ResumeLayout(false);
            this.gbox_purchase.PerformLayout();
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gbox_products;
        private System.Windows.Forms.DataGridView DGV_PurchaseProducts;
        private System.Windows.Forms.GroupBox gbox_purchase;
        private System.Windows.Forms.Button btn_SelectPurchase;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.RadioButton rbtn_cancelled;
        private System.Windows.Forms.RadioButton rbtn_active;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.DateTimePicker dateTime_filter;
        private System.Windows.Forms.RadioButton rbtn_cancelDate;
        private System.Windows.Forms.RadioButton rbtn_DateCreation;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox edt_supplierName;
        private System.Windows.Forms.DataGridView DGV_Purchases;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscoutCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnValueProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductWeightedAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCancelDate;
    }
}