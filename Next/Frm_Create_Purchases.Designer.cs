namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Create_Purchases
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
            this.DGV_PurchasesProducts = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDiscountCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdNewBaseUnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPurchPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdWeightedAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_products = new System.Windows.Forms.GroupBox();
            this.lbl_totalProduct = new System.Windows.Forms.Label();
            this.lbl_und = new System.Windows.Forms.Label();
            this.edt_prodUnd = new System.Windows.Forms.TextBox();
            this.edt_prodTotal = new System.Windows.Forms.NumericUpDown();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.lbl_prodDiscCash = new System.Windows.Forms.Label();
            this.edt_prodDiscCash = new System.Windows.Forms.NumericUpDown();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_FindProduct = new System.Windows.Forms.Button();
            this.lbl_prodUnCost = new System.Windows.Forms.Label();
            this.lbl_prodqtd = new System.Windows.Forms.Label();
            this.lbl_prodBarCode = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.edt_prodUnCost = new System.Windows.Forms.NumericUpDown();
            this.edt_prodQtd = new System.Windows.Forms.NumericUpDown();
            this.edt_prodBarCode = new System.Windows.Forms.NumericUpDown();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.lbl_prodId = new System.Windows.Forms.Label();
            this.edt_prodId = new System.Windows.Forms.NumericUpDown();
            this.gbox_User = new System.Windows.Forms.GroupBox();
            this.edt_userId = new System.Windows.Forms.NumericUpDown();
            this.edt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userSalesman = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.lbl_requiredCamps = new System.Windows.Forms.Label();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.lbl_CancelDate = new System.Windows.Forms.Label();
            this.medt_CancelDate = new System.Windows.Forms.MaskedTextBox();
            this.medt_date = new System.Windows.Forms.MaskedTextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.gbox_options = new System.Windows.Forms.GroupBox();
            this.lbl_findsupplier = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.lbl_Save = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_FindSup = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.edt_transportFee = new System.Windows.Forms.NumericUpDown();
            this.lbl_transportFee = new System.Windows.Forms.Label();
            this.edt_supplierId = new System.Windows.Forms.NumericUpDown();
            this.lbl_supplierId = new System.Windows.Forms.Label();
            this.lbl_extraExpenses = new System.Windows.Forms.Label();
            this.edt_extraExpenses = new System.Windows.Forms.NumericUpDown();
            this.edt_insurance = new System.Windows.Forms.NumericUpDown();
            this.lbl_insurance = new System.Windows.Forms.Label();
            this.btn_findSupplier = new System.Windows.Forms.Button();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.gbox_billInfo = new System.Windows.Forms.GroupBox();
            this.edt_billSeries = new System.Windows.Forms.NumericUpDown();
            this.edt_billModel = new System.Windows.Forms.NumericUpDown();
            this.edt_billNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_billNumber = new System.Windows.Forms.Label();
            this.lbl_billSeries = new System.Windows.Forms.Label();
            this.lbl_billModel = new System.Windows.Forms.Label();
            this.gbox_info = new System.Windows.Forms.GroupBox();
            this.lbl_emissionDate = new System.Windows.Forms.Label();
            this.dateTime_emissionDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_arrivalDate = new System.Windows.Forms.Label();
            this.dateTime_ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.gbox_payCond = new System.Windows.Forms.GroupBox();
            this.btn_FindPayCond = new System.Windows.Forms.Button();
            this.edt_payCondId = new System.Windows.Forms.NumericUpDown();
            this.edt_payCondName = new System.Windows.Forms.TextBox();
            this.lbl_payCondId = new System.Windows.Forms.Label();
            this.lbl_payCondName = new System.Windows.Forms.Label();
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_PurchSummary = new System.Windows.Forms.DataGridView();
            this.PurchSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.check_Cancelled = new System.Windows.Forms.CheckBox();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.gbox_cancelReason = new System.Windows.Forms.GroupBox();
            this.txt_cancelMot = new System.Windows.Forms.RichTextBox();
            this.btn_checkBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).BeginInit();
            this.gbox_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodDiscCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodUnCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodId)).BeginInit();
            this.gbox_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).BeginInit();
            this.gbox_date.SuspendLayout();
            this.gbox_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_transportFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_extraExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_insurance)).BeginInit();
            this.gbox_supplier.SuspendLayout();
            this.gbox_billInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).BeginInit();
            this.gbox_info.SuspendLayout();
            this.gbox_payCond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payCondId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchSummary)).BeginInit();
            this.gbox_status.SuspendLayout();
            this.gbox_cancelReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_PurchasesProducts
            // 
            this.DGV_PurchasesProducts.AllowUserToAddRows = false;
            this.DGV_PurchasesProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_PurchasesProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PurchasesProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdUND,
            this.ProdQtd,
            this.ProdDiscountCash,
            this.ProdNewBaseUnCost,
            this.ProdTotalValue,
            this.ProdPurchPerc,
            this.ProdWeightedAvg});
            this.DGV_PurchasesProducts.Location = new System.Drawing.Point(8, 64);
            this.DGV_PurchasesProducts.MultiSelect = false;
            this.DGV_PurchasesProducts.Name = "DGV_PurchasesProducts";
            this.DGV_PurchasesProducts.RowHeadersVisible = false;
            this.DGV_PurchasesProducts.RowHeadersWidth = 51;
            this.DGV_PurchasesProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PurchasesProducts.Size = new System.Drawing.Size(1122, 228);
            this.DGV_PurchasesProducts.TabIndex = 0;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ID";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Width = 50;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Produto";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdUND
            // 
            this.ProdUND.HeaderText = "UND";
            this.ProdUND.Name = "ProdUND";
            this.ProdUND.ReadOnly = true;
            this.ProdUND.Width = 75;
            // 
            // ProdQtd
            // 
            this.ProdQtd.HeaderText = "Quantidade";
            this.ProdQtd.MinimumWidth = 6;
            this.ProdQtd.Name = "ProdQtd";
            this.ProdQtd.ReadOnly = true;
            this.ProdQtd.Width = 75;
            // 
            // ProdDiscountCash
            // 
            this.ProdDiscountCash.HeaderText = "Desconto";
            this.ProdDiscountCash.MinimumWidth = 6;
            this.ProdDiscountCash.Name = "ProdDiscountCash";
            this.ProdDiscountCash.ReadOnly = true;
            this.ProdDiscountCash.Width = 70;
            // 
            // ProdNewBaseUnCost
            // 
            this.ProdNewBaseUnCost.HeaderText = "Preço Unitário Sugerido";
            this.ProdNewBaseUnCost.MinimumWidth = 6;
            this.ProdNewBaseUnCost.Name = "ProdNewBaseUnCost";
            this.ProdNewBaseUnCost.Width = 125;
            // 
            // ProdTotalValue
            // 
            this.ProdTotalValue.HeaderText = "Preço Total";
            this.ProdTotalValue.Name = "ProdTotalValue";
            this.ProdTotalValue.ReadOnly = true;
            // 
            // ProdPurchPerc
            // 
            this.ProdPurchPerc.HeaderText = "Porcentagem da Compra";
            this.ProdPurchPerc.MinimumWidth = 6;
            this.ProdPurchPerc.Name = "ProdPurchPerc";
            this.ProdPurchPerc.ReadOnly = true;
            this.ProdPurchPerc.Width = 125;
            // 
            // ProdWeightedAvg
            // 
            this.ProdWeightedAvg.HeaderText = "Média Ponderada";
            this.ProdWeightedAvg.MinimumWidth = 6;
            this.ProdWeightedAvg.Name = "ProdWeightedAvg";
            this.ProdWeightedAvg.ReadOnly = true;
            this.ProdWeightedAvg.Width = 125;
            // 
            // gbox_products
            // 
            this.gbox_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_products.Controls.Add(this.lbl_totalProduct);
            this.gbox_products.Controls.Add(this.lbl_und);
            this.gbox_products.Controls.Add(this.edt_prodUnd);
            this.gbox_products.Controls.Add(this.edt_prodTotal);
            this.gbox_products.Controls.Add(this.btn_removeItem);
            this.gbox_products.Controls.Add(this.lbl_prodDiscCash);
            this.gbox_products.Controls.Add(this.edt_prodDiscCash);
            this.gbox_products.Controls.Add(this.btn_AddProduct);
            this.gbox_products.Controls.Add(this.btn_FindProduct);
            this.gbox_products.Controls.Add(this.lbl_prodUnCost);
            this.gbox_products.Controls.Add(this.lbl_prodqtd);
            this.gbox_products.Controls.Add(this.lbl_prodBarCode);
            this.gbox_products.Controls.Add(this.lbl_productName);
            this.gbox_products.Controls.Add(this.edt_prodUnCost);
            this.gbox_products.Controls.Add(this.edt_prodQtd);
            this.gbox_products.Controls.Add(this.edt_prodBarCode);
            this.gbox_products.Controls.Add(this.edt_productName);
            this.gbox_products.Controls.Add(this.lbl_prodId);
            this.gbox_products.Controls.Add(this.edt_prodId);
            this.gbox_products.Controls.Add(this.DGV_PurchasesProducts);
            this.gbox_products.Enabled = false;
            this.gbox_products.Location = new System.Drawing.Point(12, 181);
            this.gbox_products.Name = "gbox_products";
            this.gbox_products.Size = new System.Drawing.Size(1136, 298);
            this.gbox_products.TabIndex = 1;
            this.gbox_products.TabStop = false;
            this.gbox_products.Text = "Produtos";
            // 
            // lbl_totalProduct
            // 
            this.lbl_totalProduct.AutoSize = true;
            this.lbl_totalProduct.Location = new System.Drawing.Point(977, 22);
            this.lbl_totalProduct.Name = "lbl_totalProduct";
            this.lbl_totalProduct.Size = new System.Drawing.Size(31, 13);
            this.lbl_totalProduct.TabIndex = 20;
            this.lbl_totalProduct.Text = "Total";
            // 
            // lbl_und
            // 
            this.lbl_und.AutoSize = true;
            this.lbl_und.Location = new System.Drawing.Point(508, 21);
            this.lbl_und.Name = "lbl_und";
            this.lbl_und.Size = new System.Drawing.Size(31, 13);
            this.lbl_und.TabIndex = 19;
            this.lbl_und.Text = "UND";
            // 
            // edt_prodUnd
            // 
            this.edt_prodUnd.Enabled = false;
            this.edt_prodUnd.Location = new System.Drawing.Point(508, 36);
            this.edt_prodUnd.Name = "edt_prodUnd";
            this.edt_prodUnd.Size = new System.Drawing.Size(51, 20);
            this.edt_prodUnd.TabIndex = 18;
            // 
            // edt_prodTotal
            // 
            this.edt_prodTotal.DecimalPlaces = 2;
            this.edt_prodTotal.Enabled = false;
            this.edt_prodTotal.Location = new System.Drawing.Point(980, 38);
            this.edt_prodTotal.Name = "edt_prodTotal";
            this.edt_prodTotal.Size = new System.Drawing.Size(69, 20);
            this.edt_prodTotal.TabIndex = 17;
            this.edt_prodTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Location = new System.Drawing.Point(1065, 13);
            this.btn_removeItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(65, 19);
            this.btn_removeItem.TabIndex = 16;
            this.btn_removeItem.Text = "Remover";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // lbl_prodDiscCash
            // 
            this.lbl_prodDiscCash.AutoSize = true;
            this.lbl_prodDiscCash.Location = new System.Drawing.Point(704, 21);
            this.lbl_prodDiscCash.Name = "lbl_prodDiscCash";
            this.lbl_prodDiscCash.Size = new System.Drawing.Size(62, 13);
            this.lbl_prodDiscCash.TabIndex = 15;
            this.lbl_prodDiscCash.Text = "Desconto $";
            // 
            // edt_prodDiscCash
            // 
            this.edt_prodDiscCash.DecimalPlaces = 2;
            this.edt_prodDiscCash.Location = new System.Drawing.Point(707, 36);
            this.edt_prodDiscCash.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edt_prodDiscCash.Name = "edt_prodDiscCash";
            this.edt_prodDiscCash.Size = new System.Drawing.Size(73, 20);
            this.edt_prodDiscCash.TabIndex = 14;
            this.edt_prodDiscCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(1055, 37);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(75, 20);
            this.btn_AddProduct.TabIndex = 12;
            this.btn_AddProduct.Text = "Adicionar";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_FindProduct
            // 
            this.btn_FindProduct.Location = new System.Drawing.Point(432, 36);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(72, 21);
            this.btn_FindProduct.TabIndex = 11;
            this.btn_FindProduct.Text = "Bu&scar";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            this.btn_FindProduct.Click += new System.EventHandler(this.btn_FindProduct_Click);
            // 
            // lbl_prodUnCost
            // 
            this.lbl_prodUnCost.AutoSize = true;
            this.lbl_prodUnCost.Location = new System.Drawing.Point(632, 21);
            this.lbl_prodUnCost.Name = "lbl_prodUnCost";
            this.lbl_prodUnCost.Size = new System.Drawing.Size(54, 13);
            this.lbl_prodUnCost.TabIndex = 10;
            this.lbl_prodUnCost.Text = "Preço UN";
            // 
            // lbl_prodqtd
            // 
            this.lbl_prodqtd.AutoSize = true;
            this.lbl_prodqtd.Location = new System.Drawing.Point(564, 21);
            this.lbl_prodqtd.Name = "lbl_prodqtd";
            this.lbl_prodqtd.Size = new System.Drawing.Size(62, 13);
            this.lbl_prodqtd.TabIndex = 9;
            this.lbl_prodqtd.Text = "Quantidade";
            // 
            // lbl_prodBarCode
            // 
            this.lbl_prodBarCode.AutoSize = true;
            this.lbl_prodBarCode.Location = new System.Drawing.Point(318, 22);
            this.lbl_prodBarCode.Name = "lbl_prodBarCode";
            this.lbl_prodBarCode.Size = new System.Drawing.Size(88, 13);
            this.lbl_prodBarCode.TabIndex = 8;
            this.lbl_prodBarCode.Text = "Código de Barras";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(74, 22);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(44, 13);
            this.lbl_productName.TabIndex = 7;
            this.lbl_productName.Text = "Produto";
            // 
            // edt_prodUnCost
            // 
            this.edt_prodUnCost.DecimalPlaces = 2;
            this.edt_prodUnCost.Location = new System.Drawing.Point(632, 36);
            this.edt_prodUnCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodUnCost.Name = "edt_prodUnCost";
            this.edt_prodUnCost.Size = new System.Drawing.Size(69, 20);
            this.edt_prodUnCost.TabIndex = 6;
            this.edt_prodUnCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_prodUnCost.Leave += new System.EventHandler(this.edt_prodUnCost_Leave);
            // 
            // edt_prodQtd
            // 
            this.edt_prodQtd.Location = new System.Drawing.Point(563, 36);
            this.edt_prodQtd.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_prodQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edt_prodQtd.Name = "edt_prodQtd";
            this.edt_prodQtd.Size = new System.Drawing.Size(63, 20);
            this.edt_prodQtd.TabIndex = 5;
            this.edt_prodQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_prodQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edt_prodQtd.Leave += new System.EventHandler(this.edt_prodQtd_Leave);
            // 
            // edt_prodBarCode
            // 
            this.edt_prodBarCode.Location = new System.Drawing.Point(321, 37);
            this.edt_prodBarCode.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.edt_prodBarCode.Name = "edt_prodBarCode";
            this.edt_prodBarCode.Size = new System.Drawing.Size(105, 20);
            this.edt_prodBarCode.TabIndex = 4;
            this.edt_prodBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(74, 37);
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(241, 20);
            this.edt_productName.TabIndex = 3;
            // 
            // lbl_prodId
            // 
            this.lbl_prodId.AutoSize = true;
            this.lbl_prodId.Location = new System.Drawing.Point(5, 22);
            this.lbl_prodId.Name = "lbl_prodId";
            this.lbl_prodId.Size = new System.Drawing.Size(18, 13);
            this.lbl_prodId.TabIndex = 2;
            this.lbl_prodId.Text = "ID";
            // 
            // edt_prodId
            // 
            this.edt_prodId.Location = new System.Drawing.Point(8, 37);
            this.edt_prodId.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodId.Name = "edt_prodId";
            this.edt_prodId.Size = new System.Drawing.Size(60, 20);
            this.edt_prodId.TabIndex = 1;
            this.edt_prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbox_User
            // 
            this.gbox_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbox_User.Controls.Add(this.edt_userId);
            this.gbox_User.Controls.Add(this.edt_userName);
            this.gbox_User.Controls.Add(this.lbl_userSalesman);
            this.gbox_User.Controls.Add(this.lbl_userId);
            this.gbox_User.Location = new System.Drawing.Point(17, 487);
            this.gbox_User.Name = "gbox_User";
            this.gbox_User.Size = new System.Drawing.Size(131, 100);
            this.gbox_User.TabIndex = 8;
            this.gbox_User.TabStop = false;
            this.gbox_User.Text = "* Usuário";
            // 
            // edt_userId
            // 
            this.edt_userId.Enabled = false;
            this.edt_userId.Location = new System.Drawing.Point(9, 32);
            this.edt_userId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_userId.Name = "edt_userId";
            this.edt_userId.Size = new System.Drawing.Size(46, 20);
            this.edt_userId.TabIndex = 3;
            this.edt_userId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_userName
            // 
            this.edt_userName.Enabled = false;
            this.edt_userName.Location = new System.Drawing.Point(9, 74);
            this.edt_userName.MaxLength = 30;
            this.edt_userName.Name = "edt_userName";
            this.edt_userName.Size = new System.Drawing.Size(105, 20);
            this.edt_userName.TabIndex = 2;
            // 
            // lbl_userSalesman
            // 
            this.lbl_userSalesman.AutoSize = true;
            this.lbl_userSalesman.Location = new System.Drawing.Point(6, 55);
            this.lbl_userSalesman.Name = "lbl_userSalesman";
            this.lbl_userSalesman.Size = new System.Drawing.Size(43, 13);
            this.lbl_userSalesman.TabIndex = 1;
            this.lbl_userSalesman.Text = "Usuário";
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Location = new System.Drawing.Point(6, 16);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(18, 13);
            this.lbl_userId.TabIndex = 0;
            this.lbl_userId.Text = "ID";
            // 
            // lbl_requiredCamps
            // 
            this.lbl_requiredCamps.AutoSize = true;
            this.lbl_requiredCamps.Location = new System.Drawing.Point(6, 76);
            this.lbl_requiredCamps.Name = "lbl_requiredCamps";
            this.lbl_requiredCamps.Size = new System.Drawing.Size(114, 13);
            this.lbl_requiredCamps.TabIndex = 30;
            this.lbl_requiredCamps.Text = "* Campos Obrigatórios.";
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.lbl_CancelDate);
            this.gbox_date.Controls.Add(this.medt_CancelDate);
            this.gbox_date.Controls.Add(this.medt_date);
            this.gbox_date.Controls.Add(this.lbl_date);
            this.gbox_date.Controls.Add(this.lbl_requiredCamps);
            this.gbox_date.Location = new System.Drawing.Point(11, 12);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(201, 92);
            this.gbox_date.TabIndex = 29;
            this.gbox_date.TabStop = false;
            this.gbox_date.Text = "Datas";
            // 
            // lbl_CancelDate
            // 
            this.lbl_CancelDate.AutoSize = true;
            this.lbl_CancelDate.Location = new System.Drawing.Point(11, 45);
            this.lbl_CancelDate.Name = "lbl_CancelDate";
            this.lbl_CancelDate.Size = new System.Drawing.Size(81, 13);
            this.lbl_CancelDate.TabIndex = 3;
            this.lbl_CancelDate.Text = "Cancelado em :";
            this.lbl_CancelDate.Visible = false;
            // 
            // medt_CancelDate
            // 
            this.medt_CancelDate.Enabled = false;
            this.medt_CancelDate.Location = new System.Drawing.Point(95, 42);
            this.medt_CancelDate.Mask = "00/00/0000 90:00";
            this.medt_CancelDate.Name = "medt_CancelDate";
            this.medt_CancelDate.Size = new System.Drawing.Size(100, 20);
            this.medt_CancelDate.TabIndex = 2;
            this.medt_CancelDate.ValidatingType = typeof(System.DateTime);
            this.medt_CancelDate.Visible = false;
            // 
            // medt_date
            // 
            this.medt_date.Enabled = false;
            this.medt_date.Location = new System.Drawing.Point(54, 16);
            this.medt_date.Mask = "00/00/0000 90:00";
            this.medt_date.Name = "medt_date";
            this.medt_date.Size = new System.Drawing.Size(100, 20);
            this.medt_date.TabIndex = 1;
            this.medt_date.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(43, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Criado :";
            // 
            // gbox_options
            // 
            this.gbox_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_options.Controls.Add(this.lbl_findsupplier);
            this.gbox_options.Controls.Add(this.lbl_new);
            this.gbox_options.Controls.Add(this.lbl_Save);
            this.gbox_options.Controls.Add(this.btn_Close);
            this.gbox_options.Controls.Add(this.btn_Save);
            this.gbox_options.Controls.Add(this.btn_FindSup);
            this.gbox_options.Controls.Add(this.btn_new);
            this.gbox_options.Location = new System.Drawing.Point(885, 11);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(254, 100);
            this.gbox_options.TabIndex = 31;
            this.gbox_options.TabStop = false;
            this.gbox_options.Text = "Atalhos";
            // 
            // lbl_findsupplier
            // 
            this.lbl_findsupplier.AutoSize = true;
            this.lbl_findsupplier.Location = new System.Drawing.Point(63, 74);
            this.lbl_findsupplier.Name = "lbl_findsupplier";
            this.lbl_findsupplier.Size = new System.Drawing.Size(61, 13);
            this.lbl_findsupplier.TabIndex = 6;
            this.lbl_findsupplier.Text = "Fornecedor";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Location = new System.Drawing.Point(18, 73);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(33, 13);
            this.lbl_new.TabIndex = 5;
            this.lbl_new.Text = "Novo";
            // 
            // lbl_Save
            // 
            this.lbl_Save.AutoSize = true;
            this.lbl_Save.Location = new System.Drawing.Point(139, 73);
            this.lbl_Save.Name = "lbl_Save";
            this.lbl_Save.Size = new System.Drawing.Size(37, 13);
            this.lbl_Save.TabIndex = 4;
            this.lbl_Save.Text = "Salvar";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(192, 19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 51);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Sair";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(129, 19);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(57, 51);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "F10";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_FindSup
            // 
            this.btn_FindSup.Location = new System.Drawing.Point(66, 19);
            this.btn_FindSup.Name = "btn_FindSup";
            this.btn_FindSup.Size = new System.Drawing.Size(57, 51);
            this.btn_FindSup.TabIndex = 1;
            this.btn_FindSup.Text = "F7";
            this.btn_FindSup.UseVisualStyleBackColor = true;
            this.btn_FindSup.Click += new System.EventHandler(this.btn_FindSup_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(3, 19);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(57, 51);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "F5";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // edt_transportFee
            // 
            this.edt_transportFee.DecimalPlaces = 2;
            this.edt_transportFee.Location = new System.Drawing.Point(124, 41);
            this.edt_transportFee.Name = "edt_transportFee";
            this.edt_transportFee.Size = new System.Drawing.Size(84, 20);
            this.edt_transportFee.TabIndex = 32;
            this.edt_transportFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_transportFee.ValueChanged += new System.EventHandler(this.edt_transportFee_ValueChanged);
            // 
            // lbl_transportFee
            // 
            this.lbl_transportFee.AutoSize = true;
            this.lbl_transportFee.Location = new System.Drawing.Point(121, 25);
            this.lbl_transportFee.Name = "lbl_transportFee";
            this.lbl_transportFee.Size = new System.Drawing.Size(31, 13);
            this.lbl_transportFee.TabIndex = 33;
            this.lbl_transportFee.Text = "Frete";
            // 
            // edt_supplierId
            // 
            this.edt_supplierId.Enabled = false;
            this.edt_supplierId.Location = new System.Drawing.Point(6, 36);
            this.edt_supplierId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_supplierId.Name = "edt_supplierId";
            this.edt_supplierId.Size = new System.Drawing.Size(38, 20);
            this.edt_supplierId.TabIndex = 34;
            this.edt_supplierId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_supplierId.ValueChanged += new System.EventHandler(this.edt_supplierId_ValueChanged);
            // 
            // lbl_supplierId
            // 
            this.lbl_supplierId.AutoSize = true;
            this.lbl_supplierId.Location = new System.Drawing.Point(3, 20);
            this.lbl_supplierId.Name = "lbl_supplierId";
            this.lbl_supplierId.Size = new System.Drawing.Size(18, 13);
            this.lbl_supplierId.TabIndex = 35;
            this.lbl_supplierId.Text = "ID";
            // 
            // lbl_extraExpenses
            // 
            this.lbl_extraExpenses.AutoSize = true;
            this.lbl_extraExpenses.Location = new System.Drawing.Point(213, 25);
            this.lbl_extraExpenses.Name = "lbl_extraExpenses";
            this.lbl_extraExpenses.Size = new System.Drawing.Size(90, 13);
            this.lbl_extraExpenses.TabIndex = 38;
            this.lbl_extraExpenses.Text = "Custos Adicionais";
            // 
            // edt_extraExpenses
            // 
            this.edt_extraExpenses.DecimalPlaces = 2;
            this.edt_extraExpenses.Location = new System.Drawing.Point(216, 41);
            this.edt_extraExpenses.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edt_extraExpenses.Name = "edt_extraExpenses";
            this.edt_extraExpenses.Size = new System.Drawing.Size(77, 20);
            this.edt_extraExpenses.TabIndex = 39;
            this.edt_extraExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_extraExpenses.ValueChanged += new System.EventHandler(this.edt_extraExpenses_ValueChanged);
            // 
            // edt_insurance
            // 
            this.edt_insurance.DecimalPlaces = 2;
            this.edt_insurance.Location = new System.Drawing.Point(124, 93);
            this.edt_insurance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_insurance.Name = "edt_insurance";
            this.edt_insurance.Size = new System.Drawing.Size(77, 20);
            this.edt_insurance.TabIndex = 40;
            this.edt_insurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_insurance.ValueChanged += new System.EventHandler(this.edt_insurance_ValueChanged);
            // 
            // lbl_insurance
            // 
            this.lbl_insurance.AutoSize = true;
            this.lbl_insurance.Location = new System.Drawing.Point(121, 77);
            this.lbl_insurance.Name = "lbl_insurance";
            this.lbl_insurance.Size = new System.Drawing.Size(41, 13);
            this.lbl_insurance.TabIndex = 41;
            this.lbl_insurance.Text = "Seguro";
            // 
            // btn_findSupplier
            // 
            this.btn_findSupplier.Location = new System.Drawing.Point(302, 35);
            this.btn_findSupplier.Name = "btn_findSupplier";
            this.btn_findSupplier.Size = new System.Drawing.Size(51, 21);
            this.btn_findSupplier.TabIndex = 43;
            this.btn_findSupplier.Text = "Bu&scar";
            this.btn_findSupplier.UseVisualStyleBackColor = true;
            this.btn_findSupplier.Click += new System.EventHandler(this.btn_findSupplier_Click);
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(47, 19);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(35, 13);
            this.lbl_supplierName.TabIndex = 44;
            this.lbl_supplierName.Text = "Nome";
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Enabled = false;
            this.edt_supplierName.Location = new System.Drawing.Point(50, 35);
            this.edt_supplierName.Name = "edt_supplierName";
            this.edt_supplierName.Size = new System.Drawing.Size(245, 20);
            this.edt_supplierName.TabIndex = 45;
            // 
            // gbox_supplier
            // 
            this.gbox_supplier.Controls.Add(this.btn_checkBill);
            this.gbox_supplier.Controls.Add(this.edt_supplierName);
            this.gbox_supplier.Controls.Add(this.gbox_billInfo);
            this.gbox_supplier.Controls.Add(this.btn_findSupplier);
            this.gbox_supplier.Controls.Add(this.edt_supplierId);
            this.gbox_supplier.Controls.Add(this.lbl_supplierName);
            this.gbox_supplier.Controls.Add(this.lbl_supplierId);
            this.gbox_supplier.Location = new System.Drawing.Point(218, 11);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(360, 139);
            this.gbox_supplier.TabIndex = 46;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "* Fornecedor";
            this.gbox_supplier.Leave += new System.EventHandler(this.gbox_supplier_Leave);
            // 
            // gbox_billInfo
            // 
            this.gbox_billInfo.Controls.Add(this.edt_billSeries);
            this.gbox_billInfo.Controls.Add(this.edt_billModel);
            this.gbox_billInfo.Controls.Add(this.edt_billNumber);
            this.gbox_billInfo.Controls.Add(this.lbl_billNumber);
            this.gbox_billInfo.Controls.Add(this.lbl_billSeries);
            this.gbox_billInfo.Controls.Add(this.lbl_billModel);
            this.gbox_billInfo.Location = new System.Drawing.Point(5, 63);
            this.gbox_billInfo.Name = "gbox_billInfo";
            this.gbox_billInfo.Size = new System.Drawing.Size(215, 70);
            this.gbox_billInfo.TabIndex = 49;
            this.gbox_billInfo.TabStop = false;
            this.gbox_billInfo.Text = "Informação da NFe";
            // 
            // edt_billSeries
            // 
            this.edt_billSeries.Location = new System.Drawing.Point(11, 39);
            this.edt_billSeries.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edt_billSeries.Name = "edt_billSeries";
            this.edt_billSeries.Size = new System.Drawing.Size(58, 20);
            this.edt_billSeries.TabIndex = 52;
            this.edt_billSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_billSeries.ValueChanged += new System.EventHandler(this.edt_billSeries_ValueChanged);
            // 
            // edt_billModel
            // 
            this.edt_billModel.Location = new System.Drawing.Point(74, 39);
            this.edt_billModel.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billModel.Name = "edt_billModel";
            this.edt_billModel.Size = new System.Drawing.Size(58, 20);
            this.edt_billModel.TabIndex = 51;
            this.edt_billModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_billModel.ValueChanged += new System.EventHandler(this.edt_billModel_ValueChanged);
            // 
            // edt_billNumber
            // 
            this.edt_billNumber.Location = new System.Drawing.Point(139, 39);
            this.edt_billNumber.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billNumber.Name = "edt_billNumber";
            this.edt_billNumber.Size = new System.Drawing.Size(58, 20);
            this.edt_billNumber.TabIndex = 50;
            this.edt_billNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_billNumber.ValueChanged += new System.EventHandler(this.edt_billNumber_ValueChanged);
            // 
            // lbl_billNumber
            // 
            this.lbl_billNumber.AutoSize = true;
            this.lbl_billNumber.Location = new System.Drawing.Point(136, 24);
            this.lbl_billNumber.Name = "lbl_billNumber";
            this.lbl_billNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_billNumber.TabIndex = 49;
            this.lbl_billNumber.Text = "Número";
            // 
            // lbl_billSeries
            // 
            this.lbl_billSeries.AutoSize = true;
            this.lbl_billSeries.Location = new System.Drawing.Point(8, 22);
            this.lbl_billSeries.Name = "lbl_billSeries";
            this.lbl_billSeries.Size = new System.Drawing.Size(31, 13);
            this.lbl_billSeries.TabIndex = 48;
            this.lbl_billSeries.Text = "Série";
            // 
            // lbl_billModel
            // 
            this.lbl_billModel.AutoSize = true;
            this.lbl_billModel.Location = new System.Drawing.Point(74, 24);
            this.lbl_billModel.Name = "lbl_billModel";
            this.lbl_billModel.Size = new System.Drawing.Size(42, 13);
            this.lbl_billModel.TabIndex = 47;
            this.lbl_billModel.Text = "Modelo";
            // 
            // gbox_info
            // 
            this.gbox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbox_info.Controls.Add(this.lbl_emissionDate);
            this.gbox_info.Controls.Add(this.dateTime_emissionDate);
            this.gbox_info.Controls.Add(this.lbl_arrivalDate);
            this.gbox_info.Controls.Add(this.dateTime_ArrivalDate);
            this.gbox_info.Controls.Add(this.edt_transportFee);
            this.gbox_info.Controls.Add(this.lbl_transportFee);
            this.gbox_info.Controls.Add(this.lbl_insurance);
            this.gbox_info.Controls.Add(this.edt_insurance);
            this.gbox_info.Controls.Add(this.lbl_extraExpenses);
            this.gbox_info.Controls.Add(this.edt_extraExpenses);
            this.gbox_info.Enabled = false;
            this.gbox_info.Location = new System.Drawing.Point(154, 487);
            this.gbox_info.Name = "gbox_info";
            this.gbox_info.Size = new System.Drawing.Size(311, 124);
            this.gbox_info.TabIndex = 47;
            this.gbox_info.TabStop = false;
            this.gbox_info.Text = "Informações da Compra";
            // 
            // lbl_emissionDate
            // 
            this.lbl_emissionDate.AutoSize = true;
            this.lbl_emissionDate.Location = new System.Drawing.Point(6, 77);
            this.lbl_emissionDate.Name = "lbl_emissionDate";
            this.lbl_emissionDate.Size = new System.Drawing.Size(87, 13);
            this.lbl_emissionDate.TabIndex = 46;
            this.lbl_emissionDate.Text = "Data de Emissão";
            // 
            // dateTime_emissionDate
            // 
            this.dateTime_emissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_emissionDate.Location = new System.Drawing.Point(9, 93);
            this.dateTime_emissionDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_emissionDate.Name = "dateTime_emissionDate";
            this.dateTime_emissionDate.Size = new System.Drawing.Size(95, 20);
            this.dateTime_emissionDate.TabIndex = 45;
            this.dateTime_emissionDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_arrivalDate
            // 
            this.lbl_arrivalDate.AutoSize = true;
            this.lbl_arrivalDate.Location = new System.Drawing.Point(6, 25);
            this.lbl_arrivalDate.Name = "lbl_arrivalDate";
            this.lbl_arrivalDate.Size = new System.Drawing.Size(85, 13);
            this.lbl_arrivalDate.TabIndex = 44;
            this.lbl_arrivalDate.Text = "Data de Entrada";
            // 
            // dateTime_ArrivalDate
            // 
            this.dateTime_ArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_ArrivalDate.Location = new System.Drawing.Point(9, 41);
            this.dateTime_ArrivalDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_ArrivalDate.Name = "dateTime_ArrivalDate";
            this.dateTime_ArrivalDate.Size = new System.Drawing.Size(95, 20);
            this.dateTime_ArrivalDate.TabIndex = 43;
            this.dateTime_ArrivalDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // gbox_payCond
            // 
            this.gbox_payCond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_payCond.Controls.Add(this.btn_FindPayCond);
            this.gbox_payCond.Controls.Add(this.edt_payCondId);
            this.gbox_payCond.Controls.Add(this.edt_payCondName);
            this.gbox_payCond.Controls.Add(this.lbl_payCondId);
            this.gbox_payCond.Controls.Add(this.lbl_payCondName);
            this.gbox_payCond.Enabled = false;
            this.gbox_payCond.Location = new System.Drawing.Point(520, 487);
            this.gbox_payCond.Name = "gbox_payCond";
            this.gbox_payCond.Size = new System.Drawing.Size(241, 100);
            this.gbox_payCond.TabIndex = 50;
            this.gbox_payCond.TabStop = false;
            this.gbox_payCond.Text = "Condição de Pagamento";
            // 
            // btn_FindPayCond
            // 
            this.btn_FindPayCond.Location = new System.Drawing.Point(51, 33);
            this.btn_FindPayCond.Name = "btn_FindPayCond";
            this.btn_FindPayCond.Size = new System.Drawing.Size(52, 23);
            this.btn_FindPayCond.TabIndex = 57;
            this.btn_FindPayCond.Text = "Bu&scar";
            this.btn_FindPayCond.UseVisualStyleBackColor = true;
            this.btn_FindPayCond.Click += new System.EventHandler(this.btn_FindPayCond_Click);
            // 
            // edt_payCondId
            // 
            this.edt_payCondId.Enabled = false;
            this.edt_payCondId.Location = new System.Drawing.Point(6, 33);
            this.edt_payCondId.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_payCondId.Name = "edt_payCondId";
            this.edt_payCondId.Size = new System.Drawing.Size(39, 20);
            this.edt_payCondId.TabIndex = 55;
            this.edt_payCondId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_payCondName
            // 
            this.edt_payCondName.Enabled = false;
            this.edt_payCondName.Location = new System.Drawing.Point(6, 70);
            this.edt_payCondName.Name = "edt_payCondName";
            this.edt_payCondName.Size = new System.Drawing.Size(229, 20);
            this.edt_payCondName.TabIndex = 56;
            // 
            // lbl_payCondId
            // 
            this.lbl_payCondId.AutoSize = true;
            this.lbl_payCondId.Location = new System.Drawing.Point(4, 17);
            this.lbl_payCondId.Name = "lbl_payCondId";
            this.lbl_payCondId.Size = new System.Drawing.Size(18, 13);
            this.lbl_payCondId.TabIndex = 53;
            this.lbl_payCondId.Text = "ID";
            // 
            // lbl_payCondName
            // 
            this.lbl_payCondName.AutoSize = true;
            this.lbl_payCondName.Location = new System.Drawing.Point(3, 55);
            this.lbl_payCondName.Name = "lbl_payCondName";
            this.lbl_payCondName.Size = new System.Drawing.Size(52, 13);
            this.lbl_payCondName.TabIndex = 54;
            this.lbl_payCondName.Text = "Condição";
            // 
            // DGV_Instalments
            // 
            this.DGV_Instalments.AllowUserToAddRows = false;
            this.DGV_Instalments.AllowUserToDeleteRows = false;
            this.DGV_Instalments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Instalments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Instalments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstalmentNumber,
            this.InstalmentDays,
            this.InstalmentPercentage,
            this.InstalmentMethod,
            this.InstalmentValue});
            this.DGV_Instalments.Enabled = false;
            this.DGV_Instalments.Location = new System.Drawing.Point(767, 487);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.RowHeadersVisible = false;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.Size = new System.Drawing.Size(372, 150);
            this.DGV_Instalments.TabIndex = 51;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Nº";
            this.InstalmentNumber.MinimumWidth = 6;
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 45;
            // 
            // InstalmentDays
            // 
            this.InstalmentDays.HeaderText = "Dias";
            this.InstalmentDays.MinimumWidth = 6;
            this.InstalmentDays.Name = "InstalmentDays";
            this.InstalmentDays.ReadOnly = true;
            this.InstalmentDays.Width = 45;
            // 
            // InstalmentPercentage
            // 
            this.InstalmentPercentage.HeaderText = "%";
            this.InstalmentPercentage.MinimumWidth = 6;
            this.InstalmentPercentage.Name = "InstalmentPercentage";
            this.InstalmentPercentage.ReadOnly = true;
            this.InstalmentPercentage.Width = 45;
            // 
            // InstalmentMethod
            // 
            this.InstalmentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstalmentMethod.HeaderText = "Método";
            this.InstalmentMethod.MinimumWidth = 6;
            this.InstalmentMethod.Name = "InstalmentMethod";
            this.InstalmentMethod.ReadOnly = true;
            // 
            // InstalmentValue
            // 
            this.InstalmentValue.HeaderText = "Valor da Parcela";
            this.InstalmentValue.MinimumWidth = 6;
            this.InstalmentValue.Name = "InstalmentValue";
            this.InstalmentValue.ReadOnly = true;
            this.InstalmentValue.Width = 125;
            // 
            // DGV_PurchSummary
            // 
            this.DGV_PurchSummary.AllowUserToDeleteRows = false;
            this.DGV_PurchSummary.AllowUserToResizeColumns = false;
            this.DGV_PurchSummary.AllowUserToResizeRows = false;
            this.DGV_PurchSummary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DGV_PurchSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_PurchSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PurchSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchSubTotal,
            this.PurchTotal});
            this.DGV_PurchSummary.Enabled = false;
            this.DGV_PurchSummary.Location = new System.Drawing.Point(938, 117);
            this.DGV_PurchSummary.MultiSelect = false;
            this.DGV_PurchSummary.Name = "DGV_PurchSummary";
            this.DGV_PurchSummary.ReadOnly = true;
            this.DGV_PurchSummary.RowHeadersVisible = false;
            this.DGV_PurchSummary.RowHeadersWidth = 51;
            this.DGV_PurchSummary.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DGV_PurchSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PurchSummary.Size = new System.Drawing.Size(201, 54);
            this.DGV_PurchSummary.TabIndex = 52;
            // 
            // PurchSubTotal
            // 
            this.PurchSubTotal.HeaderText = "Valor Total dos Produtos";
            this.PurchSubTotal.MinimumWidth = 6;
            this.PurchSubTotal.Name = "PurchSubTotal";
            this.PurchSubTotal.ReadOnly = true;
            this.PurchSubTotal.Width = 120;
            // 
            // PurchTotal
            // 
            this.PurchTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchTotal.HeaderText = "Total";
            this.PurchTotal.MinimumWidth = 6;
            this.PurchTotal.Name = "PurchTotal";
            this.PurchTotal.ReadOnly = true;
            // 
            // gbox_status
            // 
            this.gbox_status.Controls.Add(this.check_Cancelled);
            this.gbox_status.Controls.Add(this.check_Active);
            this.gbox_status.Enabled = false;
            this.gbox_status.Location = new System.Drawing.Point(11, 110);
            this.gbox_status.Name = "gbox_status";
            this.gbox_status.Size = new System.Drawing.Size(118, 65);
            this.gbox_status.TabIndex = 53;
            this.gbox_status.TabStop = false;
            this.gbox_status.Text = "Status da Compra";
            // 
            // check_Cancelled
            // 
            this.check_Cancelled.AutoSize = true;
            this.check_Cancelled.Location = new System.Drawing.Point(6, 43);
            this.check_Cancelled.Name = "check_Cancelled";
            this.check_Cancelled.Size = new System.Drawing.Size(77, 17);
            this.check_Cancelled.TabIndex = 1;
            this.check_Cancelled.Text = "Cancelado";
            this.check_Cancelled.UseVisualStyleBackColor = true;
            this.check_Cancelled.CheckedChanged += new System.EventHandler(this.check_Cancelled_CheckedChanged);
            // 
            // check_Active
            // 
            this.check_Active.AutoSize = true;
            this.check_Active.Checked = true;
            this.check_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Active.Location = new System.Drawing.Point(6, 20);
            this.check_Active.Name = "check_Active";
            this.check_Active.Size = new System.Drawing.Size(50, 17);
            this.check_Active.TabIndex = 0;
            this.check_Active.Text = "Ativo";
            this.check_Active.UseVisualStyleBackColor = true;
            this.check_Active.CheckedChanged += new System.EventHandler(this.check_Active_CheckedChanged);
            // 
            // gbox_cancelReason
            // 
            this.gbox_cancelReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_cancelReason.Controls.Add(this.txt_cancelMot);
            this.gbox_cancelReason.Location = new System.Drawing.Point(584, 12);
            this.gbox_cancelReason.Name = "gbox_cancelReason";
            this.gbox_cancelReason.Size = new System.Drawing.Size(243, 143);
            this.gbox_cancelReason.TabIndex = 54;
            this.gbox_cancelReason.TabStop = false;
            this.gbox_cancelReason.Text = "* Motivo de Cancelamento";
            this.gbox_cancelReason.Visible = false;
            this.gbox_cancelReason.Leave += new System.EventHandler(this.gbox_cancelReason_Leave);
            // 
            // txt_cancelMot
            // 
            this.txt_cancelMot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cancelMot.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cancelMot.Location = new System.Drawing.Point(6, 16);
            this.txt_cancelMot.MaxLength = 150;
            this.txt_cancelMot.Name = "txt_cancelMot";
            this.txt_cancelMot.Size = new System.Drawing.Size(231, 121);
            this.txt_cancelMot.TabIndex = 0;
            this.txt_cancelMot.Text = "";
            // 
            // btn_checkBill
            // 
            this.btn_checkBill.Location = new System.Drawing.Point(256, 102);
            this.btn_checkBill.Name = "btn_checkBill";
            this.btn_checkBill.Size = new System.Drawing.Size(98, 23);
            this.btn_checkBill.TabIndex = 50;
            this.btn_checkBill.Text = "Autenticar Nota";
            this.btn_checkBill.UseVisualStyleBackColor = true;
            this.btn_checkBill.Click += new System.EventHandler(this.btn_checkBill_Click);
            // 
            // Frm_Create_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 648);
            this.Controls.Add(this.gbox_cancelReason);
            this.Controls.Add(this.gbox_status);
            this.Controls.Add(this.DGV_PurchSummary);
            this.Controls.Add(this.DGV_Instalments);
            this.Controls.Add(this.gbox_payCond);
            this.Controls.Add(this.gbox_info);
            this.Controls.Add(this.gbox_supplier);
            this.Controls.Add(this.gbox_options);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.gbox_User);
            this.Controls.Add(this.gbox_products);
            this.Name = "Frm_Create_Purchases";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).EndInit();
            this.gbox_products.ResumeLayout(false);
            this.gbox_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodDiscCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodUnCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodId)).EndInit();
            this.gbox_User.ResumeLayout(false);
            this.gbox_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).EndInit();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.gbox_options.ResumeLayout(false);
            this.gbox_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_transportFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_extraExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_insurance)).EndInit();
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            this.gbox_billInfo.ResumeLayout(false);
            this.gbox_billInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).EndInit();
            this.gbox_info.ResumeLayout(false);
            this.gbox_info.PerformLayout();
            this.gbox_payCond.ResumeLayout(false);
            this.gbox_payCond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payCondId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchSummary)).EndInit();
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            this.gbox_cancelReason.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PurchasesProducts;
        private System.Windows.Forms.GroupBox gbox_products;
        private System.Windows.Forms.NumericUpDown edt_prodBarCode;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Label lbl_prodId;
        private System.Windows.Forms.NumericUpDown edt_prodId;
        private System.Windows.Forms.NumericUpDown edt_prodUnCost;
        private System.Windows.Forms.NumericUpDown edt_prodQtd;
        private System.Windows.Forms.Label lbl_prodUnCost;
        private System.Windows.Forms.Label lbl_prodqtd;
        private System.Windows.Forms.Label lbl_prodBarCode;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.GroupBox gbox_User;
        private System.Windows.Forms.NumericUpDown edt_userId;
        private System.Windows.Forms.TextBox edt_userName;
        private System.Windows.Forms.Label lbl_userSalesman;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.Label lbl_requiredCamps;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.Label lbl_CancelDate;
        private System.Windows.Forms.MaskedTextBox medt_CancelDate;
        private System.Windows.Forms.MaskedTextBox medt_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_FindProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.GroupBox gbox_options;
        private System.Windows.Forms.Label lbl_findsupplier;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.Label lbl_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_FindSup;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.NumericUpDown edt_transportFee;
        private System.Windows.Forms.Label lbl_transportFee;
        private System.Windows.Forms.NumericUpDown edt_supplierId;
        private System.Windows.Forms.Label lbl_supplierId;
        private System.Windows.Forms.Label lbl_extraExpenses;
        private System.Windows.Forms.NumericUpDown edt_extraExpenses;
        private System.Windows.Forms.NumericUpDown edt_insurance;
        private System.Windows.Forms.Label lbl_insurance;
        private System.Windows.Forms.Button btn_findSupplier;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox edt_supplierName;
        private System.Windows.Forms.GroupBox gbox_supplier;
        private System.Windows.Forms.GroupBox gbox_info;
        private System.Windows.Forms.Label lbl_arrivalDate;
        private System.Windows.Forms.DateTimePicker dateTime_ArrivalDate;
        private System.Windows.Forms.Label lbl_billModel;
        private System.Windows.Forms.GroupBox gbox_billInfo;
        private System.Windows.Forms.NumericUpDown edt_payCondId;
        private System.Windows.Forms.Label lbl_payCondName;
        private System.Windows.Forms.Label lbl_payCondId;
        private System.Windows.Forms.NumericUpDown edt_billSeries;
        private System.Windows.Forms.NumericUpDown edt_billModel;
        private System.Windows.Forms.NumericUpDown edt_billNumber;
        private System.Windows.Forms.Label lbl_billNumber;
        private System.Windows.Forms.Label lbl_billSeries;
        private System.Windows.Forms.GroupBox gbox_payCond;
        private System.Windows.Forms.Button btn_FindPayCond;
        private System.Windows.Forms.TextBox edt_payCondName;
        private System.Windows.Forms.Label lbl_emissionDate;
        private System.Windows.Forms.DateTimePicker dateTime_emissionDate;
        private System.Windows.Forms.Label lbl_prodDiscCash;
        private System.Windows.Forms.NumericUpDown edt_prodDiscCash;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentValue;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.DataGridView DGV_PurchSummary;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.CheckBox check_Cancelled;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.Label lbl_totalProduct;
        private System.Windows.Forms.Label lbl_und;
        private System.Windows.Forms.TextBox edt_prodUnd;
        private System.Windows.Forms.NumericUpDown edt_prodTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDiscountCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNewBaseUnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPurchPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdWeightedAvg;
        private System.Windows.Forms.GroupBox gbox_cancelReason;
        private System.Windows.Forms.RichTextBox txt_cancelMot;
        private System.Windows.Forms.Button btn_checkBill;
    }
}