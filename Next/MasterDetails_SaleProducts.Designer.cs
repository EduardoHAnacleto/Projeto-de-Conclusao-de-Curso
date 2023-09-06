namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class MasterDetails_SaleProducts
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
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_SaleProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscoutCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnValueProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gbox_sale = new System.Windows.Forms.GroupBox();
            this.btn_SelectSale = new System.Windows.Forms.Button();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.rbtn_cancelled = new System.Windows.Forms.RadioButton();
            this.rbtn_active = new System.Windows.Forms.RadioButton();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.dateTime_filter = new System.Windows.Forms.DateTimePicker();
            this.rbtn_cancelDate = new System.Windows.Forms.RadioButton();
            this.rbtn_DateCreation = new System.Windows.Forms.RadioButton();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.gbox_products = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).BeginInit();
            this.gbox_sale.SuspendLayout();
            this.gbox_status.SuspendLayout();
            this.gbox_date.SuspendLayout();
            this.gbox_products.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.AllowUserToAddRows = false;
            this.DGV_Sales.AllowUserToDeleteRows = false;
            this.DGV_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.SaleClientName,
            this.UserId,
            this.SaleTotalValue,
            this.SaleDateCreation,
            this.SaleCancelDate});
            this.DGV_Sales.Location = new System.Drawing.Point(6, 62);
            this.DGV_Sales.MultiSelect = false;
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.ReadOnly = true;
            this.DGV_Sales.RowHeadersVisible = false;
            this.DGV_Sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Sales.Size = new System.Drawing.Size(715, 150);
            this.DGV_Sales.TabIndex = 0;
            this.DGV_Sales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Sales_CellContentClick);
            // 
            // SaleId
            // 
            this.SaleId.HeaderText = "ID Venda";
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            this.SaleId.Width = 70;
            // 
            // SaleClientName
            // 
            this.SaleClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleClientName.HeaderText = "Cliente";
            this.SaleClientName.Name = "SaleClientName";
            this.SaleClientName.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID Usuário";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 70;
            // 
            // SaleTotalValue
            // 
            this.SaleTotalValue.HeaderText = "Valor Total";
            this.SaleTotalValue.Name = "SaleTotalValue";
            this.SaleTotalValue.ReadOnly = true;
            // 
            // SaleDateCreation
            // 
            this.SaleDateCreation.HeaderText = "Data";
            this.SaleDateCreation.Name = "SaleDateCreation";
            this.SaleDateCreation.ReadOnly = true;
            this.SaleDateCreation.Width = 85;
            // 
            // SaleCancelDate
            // 
            this.SaleCancelDate.HeaderText = "Cancelamento";
            this.SaleCancelDate.Name = "SaleCancelDate";
            this.SaleCancelDate.ReadOnly = true;
            this.SaleCancelDate.Width = 85;
            // 
            // DGV_SaleProducts
            // 
            this.DGV_SaleProducts.AllowUserToAddRows = false;
            this.DGV_SaleProducts.AllowUserToResizeColumns = false;
            this.DGV_SaleProducts.AllowUserToResizeRows = false;
            this.DGV_SaleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SaleProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.QuantityProduct,
            this.ProductDiscoutCash,
            this.UnValueProduct,
            this.ProductTotalValue});
            this.DGV_SaleProducts.Location = new System.Drawing.Point(6, 19);
            this.DGV_SaleProducts.MultiSelect = false;
            this.DGV_SaleProducts.Name = "DGV_SaleProducts";
            this.DGV_SaleProducts.RowHeadersVisible = false;
            this.DGV_SaleProducts.RowHeadersWidth = 51;
            this.DGV_SaleProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleProducts.Size = new System.Drawing.Size(984, 221);
            this.DGV_SaleProducts.TabIndex = 6;
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
            // ProductTotalValue
            // 
            this.ProductTotalValue.HeaderText = "Valor Total";
            this.ProductTotalValue.MinimumWidth = 6;
            this.ProductTotalValue.Name = "ProductTotalValue";
            this.ProductTotalValue.ReadOnly = true;
            this.ProductTotalValue.Width = 90;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(213, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gbox_sale
            // 
            this.gbox_sale.Controls.Add(this.btn_SelectSale);
            this.gbox_sale.Controls.Add(this.gbox_status);
            this.gbox_sale.Controls.Add(this.gbox_date);
            this.gbox_sale.Controls.Add(this.lbl_clientName);
            this.gbox_sale.Controls.Add(this.btn_Clear);
            this.gbox_sale.Controls.Add(this.edt_clientName);
            this.gbox_sale.Controls.Add(this.DGV_Sales);
            this.gbox_sale.Controls.Add(this.btn_Search);
            this.gbox_sale.Location = new System.Drawing.Point(12, 12);
            this.gbox_sale.Name = "gbox_sale";
            this.gbox_sale.Size = new System.Drawing.Size(1006, 249);
            this.gbox_sale.TabIndex = 10;
            this.gbox_sale.TabStop = false;
            this.gbox_sale.Text = "Vendas";
            // 
            // btn_SelectSale
            // 
            this.btn_SelectSale.Location = new System.Drawing.Point(621, 220);
            this.btn_SelectSale.Name = "btn_SelectSale";
            this.btn_SelectSale.Size = new System.Drawing.Size(100, 23);
            this.btn_SelectSale.TabIndex = 18;
            this.btn_SelectSale.Text = "Selecionar Venda";
            this.btn_SelectSale.UseVisualStyleBackColor = true;
            this.btn_SelectSale.Click += new System.EventHandler(this.btn_SelectSale_Click);
            // 
            // gbox_status
            // 
            this.gbox_status.Controls.Add(this.rbtn_cancelled);
            this.gbox_status.Controls.Add(this.rbtn_active);
            this.gbox_status.Location = new System.Drawing.Point(898, 19);
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
            this.gbox_date.Location = new System.Drawing.Point(855, 94);
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
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(6, 20);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(39, 13);
            this.lbl_clientName.TabIndex = 12;
            this.lbl_clientName.Text = "Cliente";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(911, 206);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(89, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Limpar Filtros";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // edt_clientName
            // 
            this.edt_clientName.Location = new System.Drawing.Point(6, 36);
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(201, 20);
            this.edt_clientName.TabIndex = 11;
            // 
            // gbox_products
            // 
            this.gbox_products.Controls.Add(this.DGV_SaleProducts);
            this.gbox_products.Location = new System.Drawing.Point(12, 267);
            this.gbox_products.Name = "gbox_products";
            this.gbox_products.Size = new System.Drawing.Size(1006, 264);
            this.gbox_products.TabIndex = 11;
            this.gbox_products.TabStop = false;
            this.gbox_products.Text = "Produtos";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(927, 537);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Sair";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // MasterDetails_SaleProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gbox_products);
            this.Controls.Add(this.gbox_sale);
            this.Name = "MasterDetails_SaleProducts";
            this.Text = "MasterDetails_SaleProducts";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).EndInit();
            this.gbox_sale.ResumeLayout(false);
            this.gbox_sale.PerformLayout();
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.gbox_products.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Sales;
        private System.Windows.Forms.DataGridView DGV_SaleProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscoutCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnValueProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalValue;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gbox_sale;
        private System.Windows.Forms.GroupBox gbox_products;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCancelDate;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.DateTimePicker dateTime_filter;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.RadioButton rbtn_cancelled;
        private System.Windows.Forms.RadioButton rbtn_active;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.RadioButton rbtn_cancelDate;
        private System.Windows.Forms.RadioButton rbtn_DateCreation;
        private System.Windows.Forms.Button btn_SelectSale;
    }
}