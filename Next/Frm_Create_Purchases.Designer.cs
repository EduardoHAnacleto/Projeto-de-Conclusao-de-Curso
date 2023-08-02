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
            this.gbox_products = new System.Windows.Forms.GroupBox();
            this.edt_prodId = new System.Windows.Forms.NumericUpDown();
            this.lbl_prodId = new System.Windows.Forms.Label();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.edt_prodBarCode = new System.Windows.Forms.NumericUpDown();
            this.edt_prodQtd = new System.Windows.Forms.NumericUpDown();
            this.edt_prodUnCost = new System.Windows.Forms.NumericUpDown();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_prodBarCode = new System.Windows.Forms.Label();
            this.lbl_prodqtd = new System.Windows.Forms.Label();
            this.lbl_prodUnCost = new System.Windows.Forms.Label();
            this.gbox_Salesman = new System.Windows.Forms.GroupBox();
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
            this.btn_FindProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.gbox_options = new System.Windows.Forms.GroupBox();
            this.btn_CancelSale = new System.Windows.Forms.Button();
            this.lbl_findClient = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.lbl_Save = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_FindClient = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.edt_transportFee = new System.Windows.Forms.NumericUpDown();
            this.lbl_transportFee = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).BeginInit();
            this.gbox_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodUnCost)).BeginInit();
            this.gbox_Salesman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).BeginInit();
            this.gbox_date.SuspendLayout();
            this.gbox_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_transportFee)).BeginInit();
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
            this.DGV_PurchasesProducts.Size = new System.Drawing.Size(1087, 150);
            this.DGV_PurchasesProducts.TabIndex = 0;
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
            this.gbox_products.Location = new System.Drawing.Point(12, 214);
            this.gbox_products.Name = "gbox_products";
            this.gbox_products.Size = new System.Drawing.Size(1129, 220);
            this.gbox_products.TabIndex = 1;
            this.gbox_products.TabStop = false;
            this.gbox_products.Text = "Products";
            // 
            // edt_prodId
            // 
            this.edt_prodId.Location = new System.Drawing.Point(22, 38);
            this.edt_prodId.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodId.Name = "edt_prodId";
            this.edt_prodId.Size = new System.Drawing.Size(60, 20);
            this.edt_prodId.TabIndex = 1;
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
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(88, 37);
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(289, 20);
            this.edt_productName.TabIndex = 3;
            // 
            // edt_prodBarCode
            // 
            this.edt_prodBarCode.Location = new System.Drawing.Point(383, 37);
            this.edt_prodBarCode.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.edt_prodBarCode.Name = "edt_prodBarCode";
            this.edt_prodBarCode.Size = new System.Drawing.Size(120, 20);
            this.edt_prodBarCode.TabIndex = 4;
            // 
            // edt_prodQtd
            // 
            this.edt_prodQtd.Location = new System.Drawing.Point(509, 37);
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
            // edt_prodUnCost
            // 
            this.edt_prodUnCost.Location = new System.Drawing.Point(578, 37);
            this.edt_prodUnCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_prodUnCost.Name = "edt_prodUnCost";
            this.edt_prodUnCost.Size = new System.Drawing.Size(56, 20);
            this.edt_prodUnCost.TabIndex = 6;
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
            // lbl_prodBarCode
            // 
            this.lbl_prodBarCode.AutoSize = true;
            this.lbl_prodBarCode.Location = new System.Drawing.Point(380, 22);
            this.lbl_prodBarCode.Name = "lbl_prodBarCode";
            this.lbl_prodBarCode.Size = new System.Drawing.Size(51, 13);
            this.lbl_prodBarCode.TabIndex = 8;
            this.lbl_prodBarCode.Text = "Bar Code";
            // 
            // lbl_prodqtd
            // 
            this.lbl_prodqtd.AutoSize = true;
            this.lbl_prodqtd.Location = new System.Drawing.Point(506, 22);
            this.lbl_prodqtd.Name = "lbl_prodqtd";
            this.lbl_prodqtd.Size = new System.Drawing.Size(46, 13);
            this.lbl_prodqtd.TabIndex = 9;
            this.lbl_prodqtd.Text = "Quantity";
            // 
            // lbl_prodUnCost
            // 
            this.lbl_prodUnCost.AutoSize = true;
            this.lbl_prodUnCost.Location = new System.Drawing.Point(578, 22);
            this.lbl_prodUnCost.Name = "lbl_prodUnCost";
            this.lbl_prodUnCost.Size = new System.Drawing.Size(47, 13);
            this.lbl_prodUnCost.TabIndex = 10;
            this.lbl_prodUnCost.Text = "UN Cost";
            // 
            // gbox_Salesman
            // 
            this.gbox_Salesman.Controls.Add(this.edt_userId);
            this.gbox_Salesman.Controls.Add(this.edt_userName);
            this.gbox_Salesman.Controls.Add(this.lbl_userSalesman);
            this.gbox_Salesman.Controls.Add(this.lbl_userId);
            this.gbox_Salesman.Location = new System.Drawing.Point(12, 12);
            this.gbox_Salesman.Name = "gbox_Salesman";
            this.gbox_Salesman.Size = new System.Drawing.Size(282, 100);
            this.gbox_Salesman.TabIndex = 8;
            this.gbox_Salesman.TabStop = false;
            this.gbox_Salesman.Text = "* User";
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
            // btn_FindProduct
            // 
            this.btn_FindProduct.Location = new System.Drawing.Point(640, 35);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(58, 20);
            this.btn_FindProduct.TabIndex = 11;
            this.btn_FindProduct.Text = "Find";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            this.btn_FindProduct.Click += new System.EventHandler(this.btn_FindProduct_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(719, 35);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(51, 20);
            this.btn_AddProduct.TabIndex = 12;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // gbox_options
            // 
            this.gbox_options.Controls.Add(this.btn_CancelSale);
            this.gbox_options.Controls.Add(this.lbl_findClient);
            this.gbox_options.Controls.Add(this.lbl_new);
            this.gbox_options.Controls.Add(this.lbl_Save);
            this.gbox_options.Controls.Add(this.btn_Close);
            this.gbox_options.Controls.Add(this.btn_Save);
            this.gbox_options.Controls.Add(this.btn_FindClient);
            this.gbox_options.Controls.Add(this.btn_new);
            this.gbox_options.Location = new System.Drawing.Point(665, 12);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(309, 100);
            this.gbox_options.TabIndex = 31;
            this.gbox_options.TabStop = false;
            this.gbox_options.Text = "Options";
            // 
            // btn_CancelSale
            // 
            this.btn_CancelSale.Location = new System.Drawing.Point(252, 20);
            this.btn_CancelSale.Name = "btn_CancelSale";
            this.btn_CancelSale.Size = new System.Drawing.Size(57, 48);
            this.btn_CancelSale.TabIndex = 7;
            this.btn_CancelSale.Text = "Cancel\r\n Sale";
            this.btn_CancelSale.UseVisualStyleBackColor = true;
            this.btn_CancelSale.Visible = false;
            // 
            // lbl_findClient
            // 
            this.lbl_findClient.AutoSize = true;
            this.lbl_findClient.Location = new System.Drawing.Point(63, 73);
            this.lbl_findClient.Name = "lbl_findClient";
            this.lbl_findClient.Size = new System.Drawing.Size(66, 13);
            this.lbl_findClient.TabIndex = 6;
            this.lbl_findClient.Text = "Select Client";
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
            // 
            // btn_FindClient
            // 
            this.btn_FindClient.Location = new System.Drawing.Point(66, 19);
            this.btn_FindClient.Name = "btn_FindClient";
            this.btn_FindClient.Size = new System.Drawing.Size(57, 51);
            this.btn_FindClient.TabIndex = 1;
            this.btn_FindClient.Text = "F7";
            this.btn_FindClient.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(3, 19);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(57, 51);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "F5";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // edt_transportFee
            // 
            this.edt_transportFee.Location = new System.Drawing.Point(323, 31);
            this.edt_transportFee.Name = "edt_transportFee";
            this.edt_transportFee.Size = new System.Drawing.Size(120, 20);
            this.edt_transportFee.TabIndex = 32;
            // 
            // lbl_transportFee
            // 
            this.lbl_transportFee.AutoSize = true;
            this.lbl_transportFee.Location = new System.Drawing.Point(320, 15);
            this.lbl_transportFee.Name = "lbl_transportFee";
            this.lbl_transportFee.Size = new System.Drawing.Size(73, 13);
            this.lbl_transportFee.TabIndex = 33;
            this.lbl_transportFee.Text = "Transport Fee";
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
            // Frm_Create_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 656);
            this.Controls.Add(this.lbl_transportFee);
            this.Controls.Add(this.edt_transportFee);
            this.Controls.Add(this.gbox_options);
            this.Controls.Add(this.lbl_requiredCamps);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.gbox_Salesman);
            this.Controls.Add(this.gbox_products);
            this.Name = "Frm_Create_Purchases";
            this.Text = "Frm_Create_Purchases";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PurchasesProducts)).EndInit();
            this.gbox_products.ResumeLayout(false);
            this.gbox_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_prodUnCost)).EndInit();
            this.gbox_Salesman.ResumeLayout(false);
            this.gbox_Salesman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).EndInit();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.gbox_options.ResumeLayout(false);
            this.gbox_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_transportFee)).EndInit();
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
        private System.Windows.Forms.GroupBox gbox_Salesman;
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
        private System.Windows.Forms.Button btn_CancelSale;
        private System.Windows.Forms.Label lbl_findClient;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.Label lbl_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_FindClient;
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
    }
}