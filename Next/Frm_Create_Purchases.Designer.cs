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
            this.ProdQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCurrentUnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdNewBaseUnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCurrentSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPurchPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdWeightedAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdNewSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_products = new System.Windows.Forms.GroupBox();
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
            this.dateTime_EstArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EstArrivalDate = new System.Windows.Forms.Label();
            this.lbl_extraExpenses = new System.Windows.Forms.Label();
            this.edt_extraExpenses = new System.Windows.Forms.NumericUpDown();
            this.edt_insurance = new System.Windows.Forms.NumericUpDown();
            this.lbl_insurance = new System.Windows.Forms.Label();
            this.btn_findSupplier = new System.Windows.Forms.Button();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.gbox_info = new System.Windows.Forms.GroupBox();
            this.lbl_arrivalDate = new System.Windows.Forms.Label();
            this.dateTime_ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.gbox_purchStatus = new System.Windows.Forms.GroupBox();
            this.rbtn_Active = new System.Windows.Forms.RadioButton();
            this.rbtn_Paid = new System.Windows.Forms.RadioButton();
            this.rbtn_OnHold = new System.Windows.Forms.RadioButton();
            this.rbtn_Cancelled = new System.Windows.Forms.RadioButton();
            this.rbtn_Completed = new System.Windows.Forms.RadioButton();
            this.lbl_paidDate = new System.Windows.Forms.Label();
            this.dateTime_PaidDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).BeginInit();
            this.gbox_products.SuspendLayout();
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
            this.gbox_info.SuspendLayout();
            this.gbox_purchStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_PurchasesProducts
            // 
            this.DGV_PurchasesProducts.AllowUserToAddRows = false;
            this.DGV_PurchasesProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PurchasesProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdQtd,
            this.ProdCurrentUnCost,
            this.ProdNewBaseUnCost,
            this.ProdCurrentSalePrice,
            this.ProdCurrentStock,
            this.ProdPurchPerc,
            this.ProdWeightedAvg,
            this.ProdNewSalePrice});
            this.DGV_PurchasesProducts.Location = new System.Drawing.Point(22, 64);
            this.DGV_PurchasesProducts.MultiSelect = false;
            this.DGV_PurchasesProducts.Name = "DGV_PurchasesProducts";
            this.DGV_PurchasesProducts.RowHeadersVisible = false;
            this.DGV_PurchasesProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PurchasesProducts.Size = new System.Drawing.Size(1087, 228);
            this.DGV_PurchasesProducts.TabIndex = 0;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ID";
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Width = 50;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Product";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdQtd
            // 
            this.ProdQtd.HeaderText = "Quantity";
            this.ProdQtd.Name = "ProdQtd";
            this.ProdQtd.ReadOnly = true;
            this.ProdQtd.Width = 60;
            // 
            // ProdCurrentUnCost
            // 
            this.ProdCurrentUnCost.HeaderText = "Current UN Cost";
            this.ProdCurrentUnCost.Name = "ProdCurrentUnCost";
            // 
            // ProdNewBaseUnCost
            // 
            this.ProdNewBaseUnCost.HeaderText = "New Base UN Cost";
            this.ProdNewBaseUnCost.Name = "ProdNewBaseUnCost";
            // 
            // ProdCurrentSalePrice
            // 
            this.ProdCurrentSalePrice.HeaderText = "Current Sale Price";
            this.ProdCurrentSalePrice.Name = "ProdCurrentSalePrice";
            this.ProdCurrentSalePrice.ReadOnly = true;
            // 
            // ProdCurrentStock
            // 
            this.ProdCurrentStock.HeaderText = "Current Stock";
            this.ProdCurrentStock.Name = "ProdCurrentStock";
            this.ProdCurrentStock.ReadOnly = true;
            this.ProdCurrentStock.Width = 60;
            // 
            // ProdPurchPerc
            // 
            this.ProdPurchPerc.HeaderText = "Purchase Percentage";
            this.ProdPurchPerc.Name = "ProdPurchPerc";
            this.ProdPurchPerc.ReadOnly = true;
            // 
            // ProdWeightedAvg
            // 
            this.ProdWeightedAvg.HeaderText = "Weighted Cost Average";
            this.ProdWeightedAvg.Name = "ProdWeightedAvg";
            this.ProdWeightedAvg.ReadOnly = true;
            // 
            // ProdNewSalePrice
            // 
            this.ProdNewSalePrice.HeaderText = "New Sale Price";
            this.ProdNewSalePrice.Name = "ProdNewSalePrice";
            this.ProdNewSalePrice.ReadOnly = true;
            // 
            // gbox_products
            // 
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
            this.gbox_products.Location = new System.Drawing.Point(12, 216);
            this.gbox_products.Name = "gbox_products";
            this.gbox_products.Size = new System.Drawing.Size(1129, 298);
            this.gbox_products.TabIndex = 1;
            this.gbox_products.TabStop = false;
            this.gbox_products.Text = "Products";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(823, 36);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(51, 20);
            this.btn_AddProduct.TabIndex = 12;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_FindProduct
            // 
            this.btn_FindProduct.Location = new System.Drawing.Point(606, 37);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(58, 20);
            this.btn_FindProduct.TabIndex = 11;
            this.btn_FindProduct.Text = "Find";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            this.btn_FindProduct.Click += new System.EventHandler(this.btn_FindProduct_Click);
            // 
            // lbl_prodUnCost
            // 
            this.lbl_prodUnCost.AutoSize = true;
            this.lbl_prodUnCost.Location = new System.Drawing.Point(762, 22);
            this.lbl_prodUnCost.Name = "lbl_prodUnCost";
            this.lbl_prodUnCost.Size = new System.Drawing.Size(47, 13);
            this.lbl_prodUnCost.TabIndex = 10;
            this.lbl_prodUnCost.Text = "UN Cost";
            // 
            // lbl_prodqtd
            // 
            this.lbl_prodqtd.AutoSize = true;
            this.lbl_prodqtd.Location = new System.Drawing.Point(699, 22);
            this.lbl_prodqtd.Name = "lbl_prodqtd";
            this.lbl_prodqtd.Size = new System.Drawing.Size(46, 13);
            this.lbl_prodqtd.TabIndex = 9;
            this.lbl_prodqtd.Text = "Quantity";
            // 
            // lbl_prodBarCode
            // 
            this.lbl_prodBarCode.AutoSize = true;
            this.lbl_prodBarCode.Location = new System.Drawing.Point(418, 22);
            this.lbl_prodBarCode.Name = "lbl_prodBarCode";
            this.lbl_prodBarCode.Size = new System.Drawing.Size(51, 13);
            this.lbl_prodBarCode.TabIndex = 8;
            this.lbl_prodBarCode.Text = "Bar Code";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(88, 22);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(44, 13);
            this.lbl_productName.TabIndex = 7;
            this.lbl_productName.Text = "Product";
            // 
            // edt_prodUnCost
            // 
            this.edt_prodUnCost.Location = new System.Drawing.Point(762, 37);
            this.edt_prodUnCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodUnCost.Name = "edt_prodUnCost";
            this.edt_prodUnCost.Size = new System.Drawing.Size(56, 20);
            this.edt_prodUnCost.TabIndex = 6;
            // 
            // edt_prodQtd
            // 
            this.edt_prodQtd.Location = new System.Drawing.Point(693, 37);
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
            this.edt_prodQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edt_prodBarCode
            // 
            this.edt_prodBarCode.Location = new System.Drawing.Point(421, 37);
            this.edt_prodBarCode.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.edt_prodBarCode.Name = "edt_prodBarCode";
            this.edt_prodBarCode.Size = new System.Drawing.Size(179, 20);
            this.edt_prodBarCode.TabIndex = 4;
            // 
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(88, 37);
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(327, 20);
            this.edt_productName.TabIndex = 3;
            // 
            // lbl_prodId
            // 
            this.lbl_prodId.AutoSize = true;
            this.lbl_prodId.Location = new System.Drawing.Point(19, 22);
            this.lbl_prodId.Name = "lbl_prodId";
            this.lbl_prodId.Size = new System.Drawing.Size(18, 13);
            this.lbl_prodId.TabIndex = 2;
            this.lbl_prodId.Text = "ID";
            // 
            // edt_prodId
            // 
            this.edt_prodId.Location = new System.Drawing.Point(22, 37);
            this.edt_prodId.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodId.Name = "edt_prodId";
            this.edt_prodId.Size = new System.Drawing.Size(60, 20);
            this.edt_prodId.TabIndex = 1;
            // 
            // gbox_User
            // 
            this.gbox_User.Controls.Add(this.edt_userId);
            this.gbox_User.Controls.Add(this.edt_userName);
            this.gbox_User.Controls.Add(this.lbl_userSalesman);
            this.gbox_User.Controls.Add(this.lbl_userId);
            this.gbox_User.Location = new System.Drawing.Point(12, 12);
            this.gbox_User.Name = "gbox_User";
            this.gbox_User.Size = new System.Drawing.Size(282, 100);
            this.gbox_User.TabIndex = 8;
            this.gbox_User.TabStop = false;
            this.gbox_User.Text = "* User";
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
            // 
            // edt_userName
            // 
            this.edt_userName.Enabled = false;
            this.edt_userName.Location = new System.Drawing.Point(9, 74);
            this.edt_userName.MaxLength = 30;
            this.edt_userName.Name = "edt_userName";
            this.edt_userName.Size = new System.Drawing.Size(228, 20);
            this.edt_userName.TabIndex = 2;
            // 
            // lbl_userSalesman
            // 
            this.lbl_userSalesman.AutoSize = true;
            this.lbl_userSalesman.Location = new System.Drawing.Point(6, 55);
            this.lbl_userSalesman.Name = "lbl_userSalesman";
            this.lbl_userSalesman.Size = new System.Drawing.Size(29, 13);
            this.lbl_userSalesman.TabIndex = 1;
            this.lbl_userSalesman.Text = "User";
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
            this.lbl_requiredCamps.Location = new System.Drawing.Point(12, 565);
            this.lbl_requiredCamps.Name = "lbl_requiredCamps";
            this.lbl_requiredCamps.Size = new System.Drawing.Size(108, 13);
            this.lbl_requiredCamps.TabIndex = 30;
            this.lbl_requiredCamps.Text = "* Camps are required.";
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.lbl_CancelDate);
            this.gbox_date.Controls.Add(this.medt_CancelDate);
            this.gbox_date.Controls.Add(this.medt_date);
            this.gbox_date.Controls.Add(this.lbl_date);
            this.gbox_date.Location = new System.Drawing.Point(12, 581);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(196, 63);
            this.gbox_date.TabIndex = 29;
            this.gbox_date.TabStop = false;
            this.gbox_date.Text = "Date";
            // 
            // lbl_CancelDate
            // 
            this.lbl_CancelDate.AutoSize = true;
            this.lbl_CancelDate.Location = new System.Drawing.Point(11, 45);
            this.lbl_CancelDate.Name = "lbl_CancelDate";
            this.lbl_CancelDate.Size = new System.Drawing.Size(60, 13);
            this.lbl_CancelDate.TabIndex = 3;
            this.lbl_CancelDate.Text = "Cancelled :";
            this.lbl_CancelDate.Visible = false;
            // 
            // medt_CancelDate
            // 
            this.medt_CancelDate.Enabled = false;
            this.medt_CancelDate.Location = new System.Drawing.Point(71, 42);
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
            this.medt_date.Location = new System.Drawing.Point(71, 16);
            this.medt_date.Mask = "00/00/0000 90:00";
            this.medt_date.Name = "medt_date";
            this.medt_date.Size = new System.Drawing.Size(100, 20);
            this.medt_date.TabIndex = 1;
            this.medt_date.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(11, 19);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(54, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Emission :";
            // 
            // gbox_options
            // 
            this.gbox_options.Controls.Add(this.lbl_findsupplier);
            this.gbox_options.Controls.Add(this.lbl_new);
            this.gbox_options.Controls.Add(this.lbl_Save);
            this.gbox_options.Controls.Add(this.btn_Close);
            this.gbox_options.Controls.Add(this.btn_Save);
            this.gbox_options.Controls.Add(this.btn_FindSup);
            this.gbox_options.Controls.Add(this.btn_new);
            this.gbox_options.Location = new System.Drawing.Point(874, 12);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(267, 100);
            this.gbox_options.TabIndex = 31;
            this.gbox_options.TabStop = false;
            this.gbox_options.Text = "Options";
            // 
            // lbl_findsupplier
            // 
            this.lbl_findsupplier.AutoSize = true;
            this.lbl_findsupplier.Location = new System.Drawing.Point(55, 73);
            this.lbl_findsupplier.Name = "lbl_findsupplier";
            this.lbl_findsupplier.Size = new System.Drawing.Size(78, 13);
            this.lbl_findsupplier.TabIndex = 6;
            this.lbl_findsupplier.Text = "Select Supplier";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Location = new System.Drawing.Point(18, 73);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(29, 13);
            this.lbl_new.TabIndex = 5;
            this.lbl_new.Text = "New";
            // 
            // lbl_Save
            // 
            this.lbl_Save.AutoSize = true;
            this.lbl_Save.Location = new System.Drawing.Point(139, 73);
            this.lbl_Save.Name = "lbl_Save";
            this.lbl_Save.Size = new System.Drawing.Size(32, 13);
            this.lbl_Save.TabIndex = 4;
            this.lbl_Save.Text = "Save";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(192, 19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 51);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
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
            this.edt_transportFee.Size = new System.Drawing.Size(120, 20);
            this.edt_transportFee.TabIndex = 32;
            // 
            // lbl_transportFee
            // 
            this.lbl_transportFee.AutoSize = true;
            this.lbl_transportFee.Location = new System.Drawing.Point(131, 25);
            this.lbl_transportFee.Name = "lbl_transportFee";
            this.lbl_transportFee.Size = new System.Drawing.Size(73, 13);
            this.lbl_transportFee.TabIndex = 33;
            this.lbl_transportFee.Text = "Transport Fee";
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
            // dateTime_EstArrivalDate
            // 
            this.dateTime_EstArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_EstArrivalDate.Location = new System.Drawing.Point(13, 41);
            this.dateTime_EstArrivalDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_EstArrivalDate.Name = "dateTime_EstArrivalDate";
            this.dateTime_EstArrivalDate.Size = new System.Drawing.Size(92, 20);
            this.dateTime_EstArrivalDate.TabIndex = 36;
            // 
            // lbl_EstArrivalDate
            // 
            this.lbl_EstArrivalDate.AutoSize = true;
            this.lbl_EstArrivalDate.Location = new System.Drawing.Point(10, 25);
            this.lbl_EstArrivalDate.Name = "lbl_EstArrivalDate";
            this.lbl_EstArrivalDate.Size = new System.Drawing.Size(95, 13);
            this.lbl_EstArrivalDate.TabIndex = 37;
            this.lbl_EstArrivalDate.Text = "Est. Date of Arrival";
            // 
            // lbl_extraExpenses
            // 
            this.lbl_extraExpenses.AutoSize = true;
            this.lbl_extraExpenses.Location = new System.Drawing.Point(257, 25);
            this.lbl_extraExpenses.Name = "lbl_extraExpenses";
            this.lbl_extraExpenses.Size = new System.Drawing.Size(80, 13);
            this.lbl_extraExpenses.TabIndex = 38;
            this.lbl_extraExpenses.Text = "Extra Expenses";
            // 
            // edt_extraExpenses
            // 
            this.edt_extraExpenses.DecimalPlaces = 2;
            this.edt_extraExpenses.Location = new System.Drawing.Point(260, 41);
            this.edt_extraExpenses.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edt_extraExpenses.Name = "edt_extraExpenses";
            this.edt_extraExpenses.Size = new System.Drawing.Size(77, 20);
            this.edt_extraExpenses.TabIndex = 39;
            // 
            // edt_insurance
            // 
            this.edt_insurance.DecimalPlaces = 2;
            this.edt_insurance.Location = new System.Drawing.Point(352, 41);
            this.edt_insurance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_insurance.Name = "edt_insurance";
            this.edt_insurance.Size = new System.Drawing.Size(77, 20);
            this.edt_insurance.TabIndex = 40;
            // 
            // lbl_insurance
            // 
            this.lbl_insurance.AutoSize = true;
            this.lbl_insurance.Location = new System.Drawing.Point(349, 25);
            this.lbl_insurance.Name = "lbl_insurance";
            this.lbl_insurance.Size = new System.Drawing.Size(54, 13);
            this.lbl_insurance.TabIndex = 41;
            this.lbl_insurance.Text = "Insurance";
            // 
            // btn_findSupplier
            // 
            this.btn_findSupplier.Location = new System.Drawing.Point(302, 35);
            this.btn_findSupplier.Name = "btn_findSupplier";
            this.btn_findSupplier.Size = new System.Drawing.Size(51, 21);
            this.btn_findSupplier.TabIndex = 43;
            this.btn_findSupplier.Text = "Find";
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
            this.lbl_supplierName.Text = "Name";
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Location = new System.Drawing.Point(50, 35);
            this.edt_supplierName.Name = "edt_supplierName";
            this.edt_supplierName.Size = new System.Drawing.Size(245, 20);
            this.edt_supplierName.TabIndex = 45;
            // 
            // gbox_supplier
            // 
            this.gbox_supplier.Controls.Add(this.edt_supplierName);
            this.gbox_supplier.Controls.Add(this.btn_findSupplier);
            this.gbox_supplier.Controls.Add(this.edt_supplierId);
            this.gbox_supplier.Controls.Add(this.lbl_supplierName);
            this.gbox_supplier.Controls.Add(this.lbl_supplierId);
            this.gbox_supplier.Location = new System.Drawing.Point(300, 12);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(359, 79);
            this.gbox_supplier.TabIndex = 46;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "Supplier";
            // 
            // gbox_info
            // 
            this.gbox_info.Controls.Add(this.dateTime_PaidDate);
            this.gbox_info.Controls.Add(this.lbl_paidDate);
            this.gbox_info.Controls.Add(this.lbl_arrivalDate);
            this.gbox_info.Controls.Add(this.dateTime_ArrivalDate);
            this.gbox_info.Controls.Add(this.dateTime_EstArrivalDate);
            this.gbox_info.Controls.Add(this.edt_transportFee);
            this.gbox_info.Controls.Add(this.lbl_transportFee);
            this.gbox_info.Controls.Add(this.lbl_insurance);
            this.gbox_info.Controls.Add(this.lbl_EstArrivalDate);
            this.gbox_info.Controls.Add(this.edt_insurance);
            this.gbox_info.Controls.Add(this.lbl_extraExpenses);
            this.gbox_info.Controls.Add(this.edt_extraExpenses);
            this.gbox_info.Location = new System.Drawing.Point(300, 97);
            this.gbox_info.Name = "gbox_info";
            this.gbox_info.Size = new System.Drawing.Size(523, 113);
            this.gbox_info.TabIndex = 47;
            this.gbox_info.TabStop = false;
            this.gbox_info.Text = "Purchase Information";
            // 
            // lbl_arrivalDate
            // 
            this.lbl_arrivalDate.AutoSize = true;
            this.lbl_arrivalDate.Location = new System.Drawing.Point(10, 71);
            this.lbl_arrivalDate.Name = "lbl_arrivalDate";
            this.lbl_arrivalDate.Size = new System.Drawing.Size(74, 13);
            this.lbl_arrivalDate.TabIndex = 44;
            this.lbl_arrivalDate.Text = "Date of Arrival";
            this.lbl_arrivalDate.Visible = false;
            // 
            // dateTime_ArrivalDate
            // 
            this.dateTime_ArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_ArrivalDate.Location = new System.Drawing.Point(13, 87);
            this.dateTime_ArrivalDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_ArrivalDate.Name = "dateTime_ArrivalDate";
            this.dateTime_ArrivalDate.Size = new System.Drawing.Size(92, 20);
            this.dateTime_ArrivalDate.TabIndex = 43;
            this.dateTime_ArrivalDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_ArrivalDate.Visible = false;
            // 
            // gbox_purchStatus
            // 
            this.gbox_purchStatus.Controls.Add(this.rbtn_Completed);
            this.gbox_purchStatus.Controls.Add(this.rbtn_Cancelled);
            this.gbox_purchStatus.Controls.Add(this.rbtn_OnHold);
            this.gbox_purchStatus.Controls.Add(this.rbtn_Paid);
            this.gbox_purchStatus.Controls.Add(this.rbtn_Active);
            this.gbox_purchStatus.Location = new System.Drawing.Point(955, 122);
            this.gbox_purchStatus.Name = "gbox_purchStatus";
            this.gbox_purchStatus.Size = new System.Drawing.Size(186, 84);
            this.gbox_purchStatus.TabIndex = 48;
            this.gbox_purchStatus.TabStop = false;
            this.gbox_purchStatus.Text = "Purchase Status";
            // 
            // rbtn_Active
            // 
            this.rbtn_Active.AutoSize = true;
            this.rbtn_Active.Checked = true;
            this.rbtn_Active.Location = new System.Drawing.Point(6, 19);
            this.rbtn_Active.Name = "rbtn_Active";
            this.rbtn_Active.Size = new System.Drawing.Size(55, 17);
            this.rbtn_Active.TabIndex = 0;
            this.rbtn_Active.TabStop = true;
            this.rbtn_Active.Text = "Active";
            this.rbtn_Active.UseVisualStyleBackColor = true;
            this.rbtn_Active.CheckedChanged += new System.EventHandler(this.rbtn_Active_CheckedChanged);
            // 
            // rbtn_Paid
            // 
            this.rbtn_Paid.AutoSize = true;
            this.rbtn_Paid.Location = new System.Drawing.Point(6, 38);
            this.rbtn_Paid.Name = "rbtn_Paid";
            this.rbtn_Paid.Size = new System.Drawing.Size(46, 17);
            this.rbtn_Paid.TabIndex = 1;
            this.rbtn_Paid.TabStop = true;
            this.rbtn_Paid.Text = "Paid";
            this.rbtn_Paid.UseVisualStyleBackColor = true;
            this.rbtn_Paid.CheckedChanged += new System.EventHandler(this.rbtn_Paid_CheckedChanged);
            // 
            // rbtn_OnHold
            // 
            this.rbtn_OnHold.AutoSize = true;
            this.rbtn_OnHold.Location = new System.Drawing.Point(101, 19);
            this.rbtn_OnHold.Name = "rbtn_OnHold";
            this.rbtn_OnHold.Size = new System.Drawing.Size(64, 17);
            this.rbtn_OnHold.TabIndex = 2;
            this.rbtn_OnHold.TabStop = true;
            this.rbtn_OnHold.Text = "On Hold";
            this.rbtn_OnHold.UseVisualStyleBackColor = true;
            this.rbtn_OnHold.CheckedChanged += new System.EventHandler(this.rbtn_OnHold_CheckedChanged);
            // 
            // rbtn_Cancelled
            // 
            this.rbtn_Cancelled.AutoSize = true;
            this.rbtn_Cancelled.Location = new System.Drawing.Point(101, 38);
            this.rbtn_Cancelled.Name = "rbtn_Cancelled";
            this.rbtn_Cancelled.Size = new System.Drawing.Size(72, 17);
            this.rbtn_Cancelled.TabIndex = 3;
            this.rbtn_Cancelled.TabStop = true;
            this.rbtn_Cancelled.Text = "Cancelled";
            this.rbtn_Cancelled.UseVisualStyleBackColor = true;
            this.rbtn_Cancelled.CheckedChanged += new System.EventHandler(this.rbtn_Cancelled_CheckedChanged);
            // 
            // rbtn_Completed
            // 
            this.rbtn_Completed.AutoSize = true;
            this.rbtn_Completed.Location = new System.Drawing.Point(6, 58);
            this.rbtn_Completed.Name = "rbtn_Completed";
            this.rbtn_Completed.Size = new System.Drawing.Size(75, 17);
            this.rbtn_Completed.TabIndex = 4;
            this.rbtn_Completed.TabStop = true;
            this.rbtn_Completed.Text = "Completed";
            this.rbtn_Completed.UseVisualStyleBackColor = true;
            this.rbtn_Completed.CheckedChanged += new System.EventHandler(this.rbtn_Completed_CheckedChanged);
            // 
            // lbl_paidDate
            // 
            this.lbl_paidDate.AutoSize = true;
            this.lbl_paidDate.Location = new System.Drawing.Point(121, 71);
            this.lbl_paidDate.Name = "lbl_paidDate";
            this.lbl_paidDate.Size = new System.Drawing.Size(54, 13);
            this.lbl_paidDate.TabIndex = 45;
            this.lbl_paidDate.Text = "Paid Date";
            this.lbl_paidDate.Visible = false;
            // 
            // dateTime_PaidDate
            // 
            this.dateTime_PaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_PaidDate.Location = new System.Drawing.Point(124, 87);
            this.dateTime_PaidDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_PaidDate.Name = "dateTime_PaidDate";
            this.dateTime_PaidDate.Size = new System.Drawing.Size(96, 20);
            this.dateTime_PaidDate.TabIndex = 46;
            this.dateTime_PaidDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_PaidDate.Visible = false;
            // 
            // Frm_Create_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 656);
            this.Controls.Add(this.gbox_purchStatus);
            this.Controls.Add(this.gbox_info);
            this.Controls.Add(this.gbox_supplier);
            this.Controls.Add(this.gbox_options);
            this.Controls.Add(this.lbl_requiredCamps);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.gbox_User);
            this.Controls.Add(this.gbox_products);
            this.Name = "Frm_Create_Purchases";
            this.Text = "Frm_Create_Purchases";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).EndInit();
            this.gbox_products.ResumeLayout(false);
            this.gbox_products.PerformLayout();
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
            this.gbox_info.ResumeLayout(false);
            this.gbox_info.PerformLayout();
            this.gbox_purchStatus.ResumeLayout(false);
            this.gbox_purchStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCurrentUnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNewBaseUnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCurrentSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPurchPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdWeightedAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNewSalePrice;
        private System.Windows.Forms.NumericUpDown edt_supplierId;
        private System.Windows.Forms.Label lbl_supplierId;
        private System.Windows.Forms.DateTimePicker dateTime_EstArrivalDate;
        private System.Windows.Forms.Label lbl_EstArrivalDate;
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
        private System.Windows.Forms.GroupBox gbox_purchStatus;
        private System.Windows.Forms.RadioButton rbtn_Completed;
        private System.Windows.Forms.RadioButton rbtn_Cancelled;
        private System.Windows.Forms.RadioButton rbtn_OnHold;
        private System.Windows.Forms.RadioButton rbtn_Paid;
        private System.Windows.Forms.RadioButton rbtn_Active;
        private System.Windows.Forms.DateTimePicker dateTime_PaidDate;
        private System.Windows.Forms.Label lbl_paidDate;
    }
}