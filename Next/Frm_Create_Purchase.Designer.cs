namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Create_Purchase
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
            this.lbl_requiredCamps = new System.Windows.Forms.Label();
            this.gbox_paymentCondition = new System.Windows.Forms.GroupBox();
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_payConditionInstalments = new System.Windows.Forms.Label();
            this.lbl_payConditionDiscount = new System.Windows.Forms.Label();
            this.lbl_payConditionFine = new System.Windows.Forms.Label();
            this.lbl_payConditionFees = new System.Windows.Forms.Label();
            this.btn_SearchPayCondition = new System.Windows.Forms.Button();
            this.edt_payConditionQnt = new System.Windows.Forms.NumericUpDown();
            this.edt_payConditionDiscount = new System.Windows.Forms.NumericUpDown();
            this.edt_payConditionFine = new System.Windows.Forms.NumericUpDown();
            this.edt_payConditionFees = new System.Windows.Forms.NumericUpDown();
            this.lbl_payCondition = new System.Windows.Forms.Label();
            this.edt_payCondition = new System.Windows.Forms.TextBox();
            this.edt_payConditionId = new System.Windows.Forms.NumericUpDown();
            this.lbl_payConditionID = new System.Windows.Forms.Label();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.lbl_CancelDate = new System.Windows.Forms.Label();
            this.medt_CancelDate = new System.Windows.Forms.MaskedTextBox();
            this.medt_date = new System.Windows.Forms.MaskedTextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.gbox_Product = new System.Windows.Forms.GroupBox();
            this.edt_barCode = new System.Windows.Forms.NumericUpDown();
            this.edt_amount = new System.Windows.Forms.NumericUpDown();
            this.edt_UNCost = new System.Windows.Forms.NumericUpDown();
            this.edt_totalPValue = new System.Windows.Forms.NumericUpDown();
            this.edt_productId = new System.Windows.Forms.NumericUpDown();
            this.btn_FindProduct = new System.Windows.Forms.Button();
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.lbl_barCode = new System.Windows.Forms.Label();
            this.lbl_UNPrice = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_summary = new System.Windows.Forms.GroupBox();
            this.edt_discountCash = new System.Windows.Forms.NumericUpDown();
            this.lbl_discountCash = new System.Windows.Forms.Label();
            this.edt_total = new System.Windows.Forms.NumericUpDown();
            this.edt_discountPerc = new System.Windows.Forms.NumericUpDown();
            this.edt_subtotal = new System.Windows.Forms.NumericUpDown();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.gbox_options = new System.Windows.Forms.GroupBox();
            this.lbl_findSupp = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.lbl_Save = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_FindSuppliers = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.medt_registrationNumber = new System.Windows.Forms.MaskedTextBox();
            this.edt_SupplierId = new System.Windows.Forms.NumericUpDown();
            this.btn_findSupplier = new System.Windows.Forms.Button();
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.lbl_SupplierName = new System.Windows.Forms.Label();
            this.lbl_SupplierId = new System.Windows.Forms.Label();
            this.edt_SupplierName = new System.Windows.Forms.TextBox();
            this.gbox_User = new System.Windows.Forms.GroupBox();
            this.edt_userId = new System.Windows.Forms.NumericUpDown();
            this.edt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userSalesman = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.DGV_SaleProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDiscountCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnValueProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_paymentCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).BeginInit();
            this.gbox_date.SuspendLayout();
            this.gbox_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_barCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_UNCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productId)).BeginInit();
            this.gbox_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discountCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discountPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_subtotal)).BeginInit();
            this.gbox_options.SuspendLayout();
            this.gbox_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_SupplierId)).BeginInit();
            this.gbox_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_requiredCamps
            // 
            this.lbl_requiredCamps.AutoSize = true;
            this.lbl_requiredCamps.Location = new System.Drawing.Point(12, 575);
            this.lbl_requiredCamps.Name = "lbl_requiredCamps";
            this.lbl_requiredCamps.Size = new System.Drawing.Size(108, 13);
            this.lbl_requiredCamps.TabIndex = 37;
            this.lbl_requiredCamps.Text = "* Camps are required.";
            // 
            // gbox_paymentCondition
            // 
            this.gbox_paymentCondition.Controls.Add(this.DGV_Instalments);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payConditionInstalments);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payConditionDiscount);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payConditionFine);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payConditionFees);
            this.gbox_paymentCondition.Controls.Add(this.btn_SearchPayCondition);
            this.gbox_paymentCondition.Controls.Add(this.edt_payConditionQnt);
            this.gbox_paymentCondition.Controls.Add(this.edt_payConditionDiscount);
            this.gbox_paymentCondition.Controls.Add(this.edt_payConditionFine);
            this.gbox_paymentCondition.Controls.Add(this.edt_payConditionFees);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payCondition);
            this.gbox_paymentCondition.Controls.Add(this.edt_payCondition);
            this.gbox_paymentCondition.Controls.Add(this.edt_payConditionId);
            this.gbox_paymentCondition.Controls.Add(this.lbl_payConditionID);
            this.gbox_paymentCondition.Location = new System.Drawing.Point(214, 496);
            this.gbox_paymentCondition.Name = "gbox_paymentCondition";
            this.gbox_paymentCondition.Size = new System.Drawing.Size(787, 166);
            this.gbox_paymentCondition.TabIndex = 36;
            this.gbox_paymentCondition.TabStop = false;
            this.gbox_paymentCondition.Text = "* Payment Condition";
            // 
            // DGV_Instalments
            // 
            this.DGV_Instalments.AllowUserToAddRows = false;
            this.DGV_Instalments.AllowUserToDeleteRows = false;
            this.DGV_Instalments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Instalments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstalmentNumber,
            this.InstalmentDays,
            this.InstalmentPercentage,
            this.InstalmentMethod});
            this.DGV_Instalments.Enabled = false;
            this.DGV_Instalments.Location = new System.Drawing.Point(400, 8);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.Size = new System.Drawing.Size(381, 150);
            this.DGV_Instalments.TabIndex = 13;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Num";
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 45;
            // 
            // InstalmentDays
            // 
            this.InstalmentDays.HeaderText = "Days";
            this.InstalmentDays.Name = "InstalmentDays";
            this.InstalmentDays.ReadOnly = true;
            this.InstalmentDays.Width = 45;
            // 
            // InstalmentPercentage
            // 
            this.InstalmentPercentage.HeaderText = "%";
            this.InstalmentPercentage.Name = "InstalmentPercentage";
            this.InstalmentPercentage.ReadOnly = true;
            this.InstalmentPercentage.Width = 45;
            // 
            // InstalmentMethod
            // 
            this.InstalmentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstalmentMethod.HeaderText = "Method";
            this.InstalmentMethod.Name = "InstalmentMethod";
            this.InstalmentMethod.ReadOnly = true;
            // 
            // lbl_payConditionInstalments
            // 
            this.lbl_payConditionInstalments.AutoSize = true;
            this.lbl_payConditionInstalments.Location = new System.Drawing.Point(172, 66);
            this.lbl_payConditionInstalments.Name = "lbl_payConditionInstalments";
            this.lbl_payConditionInstalments.Size = new System.Drawing.Size(102, 13);
            this.lbl_payConditionInstalments.TabIndex = 12;
            this.lbl_payConditionInstalments.Text = "Instalments Quantity";
            // 
            // lbl_payConditionDiscount
            // 
            this.lbl_payConditionDiscount.AutoSize = true;
            this.lbl_payConditionDiscount.Location = new System.Drawing.Point(111, 66);
            this.lbl_payConditionDiscount.Name = "lbl_payConditionDiscount";
            this.lbl_payConditionDiscount.Size = new System.Drawing.Size(60, 13);
            this.lbl_payConditionDiscount.TabIndex = 11;
            this.lbl_payConditionDiscount.Text = "Discount %";
            // 
            // lbl_payConditionFine
            // 
            this.lbl_payConditionFine.AutoSize = true;
            this.lbl_payConditionFine.Location = new System.Drawing.Point(60, 66);
            this.lbl_payConditionFine.Name = "lbl_payConditionFine";
            this.lbl_payConditionFine.Size = new System.Drawing.Size(27, 13);
            this.lbl_payConditionFine.TabIndex = 10;
            this.lbl_payConditionFine.Text = "Fine";
            // 
            // lbl_payConditionFees
            // 
            this.lbl_payConditionFees.AutoSize = true;
            this.lbl_payConditionFees.Location = new System.Drawing.Point(11, 66);
            this.lbl_payConditionFees.Name = "lbl_payConditionFees";
            this.lbl_payConditionFees.Size = new System.Drawing.Size(30, 13);
            this.lbl_payConditionFees.TabIndex = 9;
            this.lbl_payConditionFees.Text = "Fees";
            // 
            // btn_SearchPayCondition
            // 
            this.btn_SearchPayCondition.Location = new System.Drawing.Point(337, 35);
            this.btn_SearchPayCondition.Name = "btn_SearchPayCondition";
            this.btn_SearchPayCondition.Size = new System.Drawing.Size(57, 20);
            this.btn_SearchPayCondition.TabIndex = 8;
            this.btn_SearchPayCondition.Text = "Search";
            this.btn_SearchPayCondition.UseVisualStyleBackColor = true;
            // 
            // edt_payConditionQnt
            // 
            this.edt_payConditionQnt.Enabled = false;
            this.edt_payConditionQnt.Location = new System.Drawing.Point(175, 82);
            this.edt_payConditionQnt.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.edt_payConditionQnt.Name = "edt_payConditionQnt";
            this.edt_payConditionQnt.Size = new System.Drawing.Size(43, 20);
            this.edt_payConditionQnt.TabIndex = 7;
            // 
            // edt_payConditionDiscount
            // 
            this.edt_payConditionDiscount.DecimalPlaces = 2;
            this.edt_payConditionDiscount.Enabled = false;
            this.edt_payConditionDiscount.Location = new System.Drawing.Point(114, 82);
            this.edt_payConditionDiscount.Name = "edt_payConditionDiscount";
            this.edt_payConditionDiscount.Size = new System.Drawing.Size(44, 20);
            this.edt_payConditionDiscount.TabIndex = 6;
            // 
            // edt_payConditionFine
            // 
            this.edt_payConditionFine.DecimalPlaces = 2;
            this.edt_payConditionFine.Enabled = false;
            this.edt_payConditionFine.Location = new System.Drawing.Point(63, 82);
            this.edt_payConditionFine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edt_payConditionFine.Name = "edt_payConditionFine";
            this.edt_payConditionFine.Size = new System.Drawing.Size(45, 20);
            this.edt_payConditionFine.TabIndex = 5;
            // 
            // edt_payConditionFees
            // 
            this.edt_payConditionFees.Enabled = false;
            this.edt_payConditionFees.Location = new System.Drawing.Point(14, 82);
            this.edt_payConditionFees.Name = "edt_payConditionFees";
            this.edt_payConditionFees.Size = new System.Drawing.Size(43, 20);
            this.edt_payConditionFees.TabIndex = 4;
            // 
            // lbl_payCondition
            // 
            this.lbl_payCondition.AutoSize = true;
            this.lbl_payCondition.Location = new System.Drawing.Point(61, 19);
            this.lbl_payCondition.Name = "lbl_payCondition";
            this.lbl_payCondition.Size = new System.Drawing.Size(95, 13);
            this.lbl_payCondition.TabIndex = 3;
            this.lbl_payCondition.Text = "Payment Condition";
            // 
            // edt_payCondition
            // 
            this.edt_payCondition.Enabled = false;
            this.edt_payCondition.Location = new System.Drawing.Point(63, 35);
            this.edt_payCondition.MaxLength = 30;
            this.edt_payCondition.Name = "edt_payCondition";
            this.edt_payCondition.Size = new System.Drawing.Size(271, 20);
            this.edt_payCondition.TabIndex = 2;
            // 
            // edt_payConditionId
            // 
            this.edt_payConditionId.Enabled = false;
            this.edt_payConditionId.Location = new System.Drawing.Point(13, 35);
            this.edt_payConditionId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_payConditionId.Name = "edt_payConditionId";
            this.edt_payConditionId.Size = new System.Drawing.Size(44, 20);
            this.edt_payConditionId.TabIndex = 1;
            // 
            // lbl_payConditionID
            // 
            this.lbl_payConditionID.AutoSize = true;
            this.lbl_payConditionID.Location = new System.Drawing.Point(11, 19);
            this.lbl_payConditionID.Name = "lbl_payConditionID";
            this.lbl_payConditionID.Size = new System.Drawing.Size(18, 13);
            this.lbl_payConditionID.TabIndex = 0;
            this.lbl_payConditionID.Text = "ID";
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.lbl_CancelDate);
            this.gbox_date.Controls.Add(this.medt_CancelDate);
            this.gbox_date.Controls.Add(this.medt_date);
            this.gbox_date.Controls.Add(this.lbl_date);
            this.gbox_date.Location = new System.Drawing.Point(12, 591);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(196, 63);
            this.gbox_date.TabIndex = 35;
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
            // gbox_Product
            // 
            this.gbox_Product.Controls.Add(this.edt_barCode);
            this.gbox_Product.Controls.Add(this.edt_amount);
            this.gbox_Product.Controls.Add(this.edt_UNCost);
            this.gbox_Product.Controls.Add(this.edt_totalPValue);
            this.gbox_Product.Controls.Add(this.edt_productId);
            this.gbox_Product.Controls.Add(this.btn_FindProduct);
            this.gbox_Product.Controls.Add(this.lbl_TotalCost);
            this.gbox_Product.Controls.Add(this.lbl_productName);
            this.gbox_Product.Controls.Add(this.edt_productName);
            this.gbox_Product.Controls.Add(this.lbl_barCode);
            this.gbox_Product.Controls.Add(this.lbl_UNPrice);
            this.gbox_Product.Controls.Add(this.btn_AddProduct);
            this.gbox_Product.Controls.Add(this.lbl_productId);
            this.gbox_Product.Controls.Add(this.label1);
            this.gbox_Product.Location = new System.Drawing.Point(12, 113);
            this.gbox_Product.Name = "gbox_Product";
            this.gbox_Product.Size = new System.Drawing.Size(376, 150);
            this.gbox_Product.TabIndex = 34;
            this.gbox_Product.TabStop = false;
            this.gbox_Product.Text = "Product";
            // 
            // edt_barCode
            // 
            this.edt_barCode.Location = new System.Drawing.Point(54, 35);
            this.edt_barCode.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.edt_barCode.Name = "edt_barCode";
            this.edt_barCode.Size = new System.Drawing.Size(258, 20);
            this.edt_barCode.TabIndex = 29;
            // 
            // edt_amount
            // 
            this.edt_amount.Location = new System.Drawing.Point(11, 120);
            this.edt_amount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edt_amount.Name = "edt_amount";
            this.edt_amount.Size = new System.Drawing.Size(44, 20);
            this.edt_amount.TabIndex = 28;
            this.edt_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edt_UNCost
            // 
            this.edt_UNCost.DecimalPlaces = 2;
            this.edt_UNCost.Enabled = false;
            this.edt_UNCost.Location = new System.Drawing.Point(61, 120);
            this.edt_UNCost.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_UNCost.Name = "edt_UNCost";
            this.edt_UNCost.Size = new System.Drawing.Size(55, 20);
            this.edt_UNCost.TabIndex = 27;
            // 
            // edt_totalPValue
            // 
            this.edt_totalPValue.DecimalPlaces = 2;
            this.edt_totalPValue.Enabled = false;
            this.edt_totalPValue.Location = new System.Drawing.Point(122, 120);
            this.edt_totalPValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_totalPValue.Name = "edt_totalPValue";
            this.edt_totalPValue.Size = new System.Drawing.Size(61, 20);
            this.edt_totalPValue.TabIndex = 26;
            // 
            // edt_productId
            // 
            this.edt_productId.Location = new System.Drawing.Point(11, 35);
            this.edt_productId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_productId.Name = "edt_productId";
            this.edt_productId.Size = new System.Drawing.Size(36, 20);
            this.edt_productId.TabIndex = 25;
            // 
            // btn_FindProduct
            // 
            this.btn_FindProduct.Location = new System.Drawing.Point(299, 77);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(58, 20);
            this.btn_FindProduct.TabIndex = 19;
            this.btn_FindProduct.Text = "Find";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.Location = new System.Drawing.Point(119, 106);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(55, 13);
            this.lbl_TotalCost.TabIndex = 24;
            this.lbl_TotalCost.Text = "Total Cost";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(8, 61);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(44, 13);
            this.lbl_productName.TabIndex = 9;
            this.lbl_productName.Text = "Product";
            // 
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(11, 77);
            this.edt_productName.MaxLength = 50;
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(282, 20);
            this.edt_productName.TabIndex = 10;
            // 
            // lbl_barCode
            // 
            this.lbl_barCode.AutoSize = true;
            this.lbl_barCode.Location = new System.Drawing.Point(50, 19);
            this.lbl_barCode.Name = "lbl_barCode";
            this.lbl_barCode.Size = new System.Drawing.Size(51, 13);
            this.lbl_barCode.TabIndex = 13;
            this.lbl_barCode.Text = "Bar Code";
            // 
            // lbl_UNPrice
            // 
            this.lbl_UNPrice.AutoSize = true;
            this.lbl_UNPrice.Location = new System.Drawing.Point(58, 107);
            this.lbl_UNPrice.Name = "lbl_UNPrice";
            this.lbl_UNPrice.Size = new System.Drawing.Size(47, 13);
            this.lbl_UNPrice.TabIndex = 21;
            this.lbl_UNPrice.Text = "UN Cost";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(189, 120);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(75, 20);
            this.btn_AddProduct.TabIndex = 20;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(8, 19);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(18, 13);
            this.lbl_productId.TabIndex = 16;
            this.lbl_productId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amount";
            // 
            // gbox_summary
            // 
            this.gbox_summary.Controls.Add(this.edt_discountCash);
            this.gbox_summary.Controls.Add(this.lbl_discountCash);
            this.gbox_summary.Controls.Add(this.edt_total);
            this.gbox_summary.Controls.Add(this.edt_discountPerc);
            this.gbox_summary.Controls.Add(this.edt_subtotal);
            this.gbox_summary.Controls.Add(this.lbl_totalAmount);
            this.gbox_summary.Controls.Add(this.lbl_Discount);
            this.gbox_summary.Controls.Add(this.lbl_subTotal);
            this.gbox_summary.Location = new System.Drawing.Point(686, 118);
            this.gbox_summary.Name = "gbox_summary";
            this.gbox_summary.Size = new System.Drawing.Size(309, 125);
            this.gbox_summary.TabIndex = 33;
            this.gbox_summary.TabStop = false;
            this.gbox_summary.Text = "Summary";
            // 
            // edt_discountCash
            // 
            this.edt_discountCash.DecimalPlaces = 2;
            this.edt_discountCash.Location = new System.Drawing.Point(71, 88);
            this.edt_discountCash.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edt_discountCash.Name = "edt_discountCash";
            this.edt_discountCash.Size = new System.Drawing.Size(54, 20);
            this.edt_discountCash.TabIndex = 12;
            // 
            // lbl_discountCash
            // 
            this.lbl_discountCash.AutoSize = true;
            this.lbl_discountCash.Location = new System.Drawing.Point(6, 90);
            this.lbl_discountCash.Name = "lbl_discountCash";
            this.lbl_discountCash.Size = new System.Drawing.Size(64, 13);
            this.lbl_discountCash.TabIndex = 11;
            this.lbl_discountCash.Text = "Discount $ :";
            // 
            // edt_total
            // 
            this.edt_total.DecimalPlaces = 2;
            this.edt_total.Enabled = false;
            this.edt_total.Location = new System.Drawing.Point(222, 88);
            this.edt_total.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_total.Name = "edt_total";
            this.edt_total.Size = new System.Drawing.Size(75, 20);
            this.edt_total.TabIndex = 10;
            // 
            // edt_discountPerc
            // 
            this.edt_discountPerc.DecimalPlaces = 2;
            this.edt_discountPerc.Location = new System.Drawing.Point(71, 55);
            this.edt_discountPerc.Name = "edt_discountPerc";
            this.edt_discountPerc.Size = new System.Drawing.Size(54, 20);
            this.edt_discountPerc.TabIndex = 9;
            // 
            // edt_subtotal
            // 
            this.edt_subtotal.DecimalPlaces = 2;
            this.edt_subtotal.Enabled = false;
            this.edt_subtotal.Location = new System.Drawing.Point(71, 26);
            this.edt_subtotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_subtotal.Name = "edt_subtotal";
            this.edt_subtotal.Size = new System.Drawing.Size(72, 20);
            this.edt_subtotal.TabIndex = 8;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Location = new System.Drawing.Point(155, 90);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(61, 13);
            this.lbl_totalAmount.TabIndex = 2;
            this.lbl_totalAmount.Text = "Total Cost :";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Location = new System.Drawing.Point(4, 57);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(66, 13);
            this.lbl_Discount.TabIndex = 1;
            this.lbl_Discount.Text = "Discount % :";
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Location = new System.Drawing.Point(11, 28);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(59, 13);
            this.lbl_subTotal.TabIndex = 0;
            this.lbl_subTotal.Text = "Sub-Total :";
            // 
            // gbox_options
            // 
            this.gbox_options.Controls.Add(this.lbl_findSupp);
            this.gbox_options.Controls.Add(this.lbl_new);
            this.gbox_options.Controls.Add(this.lbl_Save);
            this.gbox_options.Controls.Add(this.btn_Close);
            this.gbox_options.Controls.Add(this.btn_Save);
            this.gbox_options.Controls.Add(this.btn_FindSuppliers);
            this.gbox_options.Controls.Add(this.btn_new);
            this.gbox_options.Location = new System.Drawing.Point(692, 12);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(309, 100);
            this.gbox_options.TabIndex = 32;
            this.gbox_options.TabStop = false;
            this.gbox_options.Text = "Options";
            // 
            // lbl_findSupp
            // 
            this.lbl_findSupp.AutoSize = true;
            this.lbl_findSupp.Location = new System.Drawing.Point(73, 74);
            this.lbl_findSupp.Name = "lbl_findSupp";
            this.lbl_findSupp.Size = new System.Drawing.Size(68, 13);
            this.lbl_findSupp.TabIndex = 6;
            this.lbl_findSupp.Text = "Find Supplier";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Location = new System.Drawing.Point(28, 74);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(29, 13);
            this.lbl_new.TabIndex = 5;
            this.lbl_new.Text = "New";
            // 
            // lbl_Save
            // 
            this.lbl_Save.AutoSize = true;
            this.lbl_Save.Location = new System.Drawing.Point(148, 74);
            this.lbl_Save.Name = "lbl_Save";
            this.lbl_Save.Size = new System.Drawing.Size(32, 13);
            this.lbl_Save.TabIndex = 4;
            this.lbl_Save.Text = "Save";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(202, 20);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(57, 51);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(139, 20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(57, 51);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "F10";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_FindSuppliers
            // 
            this.btn_FindSuppliers.Location = new System.Drawing.Point(76, 20);
            this.btn_FindSuppliers.Name = "btn_FindSuppliers";
            this.btn_FindSuppliers.Size = new System.Drawing.Size(57, 51);
            this.btn_FindSuppliers.TabIndex = 1;
            this.btn_FindSuppliers.Text = "F7";
            this.btn_FindSuppliers.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(13, 20);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(57, 51);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "F5";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // gbox_supplier
            // 
            this.gbox_supplier.Controls.Add(this.medt_registrationNumber);
            this.gbox_supplier.Controls.Add(this.edt_SupplierId);
            this.gbox_supplier.Controls.Add(this.btn_findSupplier);
            this.gbox_supplier.Controls.Add(this.lbl_registrationNumber);
            this.gbox_supplier.Controls.Add(this.lbl_SupplierName);
            this.gbox_supplier.Controls.Add(this.lbl_SupplierId);
            this.gbox_supplier.Controls.Add(this.edt_SupplierName);
            this.gbox_supplier.Location = new System.Drawing.Point(300, 12);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(386, 100);
            this.gbox_supplier.TabIndex = 31;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "* Supplier";
            // 
            // medt_registrationNumber
            // 
            this.medt_registrationNumber.Enabled = false;
            this.medt_registrationNumber.Location = new System.Drawing.Point(9, 75);
            this.medt_registrationNumber.Mask = "000.000.000-00";
            this.medt_registrationNumber.Name = "medt_registrationNumber";
            this.medt_registrationNumber.Size = new System.Drawing.Size(100, 20);
            this.medt_registrationNumber.TabIndex = 13;
            // 
            // edt_SupplierId
            // 
            this.edt_SupplierId.Enabled = false;
            this.edt_SupplierId.Location = new System.Drawing.Point(9, 32);
            this.edt_SupplierId.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_SupplierId.Name = "edt_SupplierId";
            this.edt_SupplierId.Size = new System.Drawing.Size(41, 20);
            this.edt_SupplierId.TabIndex = 12;
            // 
            // btn_findSupplier
            // 
            this.btn_findSupplier.Location = new System.Drawing.Point(115, 75);
            this.btn_findSupplier.Name = "btn_findSupplier";
            this.btn_findSupplier.Size = new System.Drawing.Size(64, 20);
            this.btn_findSupplier.TabIndex = 11;
            this.btn_findSupplier.Text = "Search";
            this.btn_findSupplier.UseVisualStyleBackColor = true;
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Location = new System.Drawing.Point(6, 58);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(103, 13);
            this.lbl_registrationNumber.TabIndex = 4;
            this.lbl_registrationNumber.Text = "Registration Number";
            // 
            // lbl_SupplierName
            // 
            this.lbl_SupplierName.AutoSize = true;
            this.lbl_SupplierName.Location = new System.Drawing.Point(53, 16);
            this.lbl_SupplierName.Name = "lbl_SupplierName";
            this.lbl_SupplierName.Size = new System.Drawing.Size(35, 13);
            this.lbl_SupplierName.TabIndex = 3;
            this.lbl_SupplierName.Text = "Name";
            // 
            // lbl_SupplierId
            // 
            this.lbl_SupplierId.AutoSize = true;
            this.lbl_SupplierId.Location = new System.Drawing.Point(6, 16);
            this.lbl_SupplierId.Name = "lbl_SupplierId";
            this.lbl_SupplierId.Size = new System.Drawing.Size(18, 13);
            this.lbl_SupplierId.TabIndex = 2;
            this.lbl_SupplierId.Text = "ID";
            // 
            // edt_SupplierName
            // 
            this.edt_SupplierName.Enabled = false;
            this.edt_SupplierName.Location = new System.Drawing.Point(56, 32);
            this.edt_SupplierName.MaxLength = 60;
            this.edt_SupplierName.Name = "edt_SupplierName";
            this.edt_SupplierName.Size = new System.Drawing.Size(284, 20);
            this.edt_SupplierName.TabIndex = 0;
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
            this.gbox_User.TabIndex = 30;
            this.gbox_User.TabStop = false;
            this.gbox_User.Text = "* User";
            // 
            // edt_userId
            // 
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
            // DGV_SaleProducts
            // 
            this.DGV_SaleProducts.AllowUserToAddRows = false;
            this.DGV_SaleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SaleProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.ProductCost,
            this.QuantityProduct,
            this.ItemDiscountCash,
            this.ItemDiscountPerc,
            this.UnValueProduct,
            this.ProductTotalValue});
            this.DGV_SaleProducts.Location = new System.Drawing.Point(12, 269);
            this.DGV_SaleProducts.MultiSelect = false;
            this.DGV_SaleProducts.Name = "DGV_SaleProducts";
            this.DGV_SaleProducts.ReadOnly = true;
            this.DGV_SaleProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleProducts.Size = new System.Drawing.Size(983, 221);
            this.DGV_SaleProducts.TabIndex = 29;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "ID";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Width = 45;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.HeaderText = "Product";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // ProductCost
            // 
            this.ProductCost.HeaderText = "Product Cost";
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.ReadOnly = true;
            this.ProductCost.Width = 55;
            // 
            // QuantityProduct
            // 
            this.QuantityProduct.HeaderText = "Quantity";
            this.QuantityProduct.Name = "QuantityProduct";
            this.QuantityProduct.ReadOnly = true;
            this.QuantityProduct.Width = 50;
            // 
            // ItemDiscountCash
            // 
            this.ItemDiscountCash.HeaderText = "Discount Cash";
            this.ItemDiscountCash.Name = "ItemDiscountCash";
            this.ItemDiscountCash.ReadOnly = true;
            this.ItemDiscountCash.Width = 55;
            // 
            // ItemDiscountPerc
            // 
            this.ItemDiscountPerc.HeaderText = "Discount %";
            this.ItemDiscountPerc.Name = "ItemDiscountPerc";
            this.ItemDiscountPerc.ReadOnly = true;
            this.ItemDiscountPerc.Width = 55;
            // 
            // UnValueProduct
            // 
            this.UnValueProduct.HeaderText = "UN Value";
            this.UnValueProduct.Name = "UnValueProduct";
            this.UnValueProduct.ReadOnly = true;
            this.UnValueProduct.Width = 55;
            // 
            // ProductTotalValue
            // 
            this.ProductTotalValue.HeaderText = "Total Value";
            this.ProductTotalValue.Name = "ProductTotalValue";
            this.ProductTotalValue.ReadOnly = true;
            this.ProductTotalValue.Width = 75;
            // 
            // Frm_Create_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 657);
            this.Controls.Add(this.lbl_requiredCamps);
            this.Controls.Add(this.gbox_paymentCondition);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.gbox_Product);
            this.Controls.Add(this.gbox_summary);
            this.Controls.Add(this.gbox_options);
            this.Controls.Add(this.gbox_supplier);
            this.Controls.Add(this.gbox_User);
            this.Controls.Add(this.DGV_SaleProducts);
            this.Name = "Frm_Create_Purchase";
            this.Text = "Frm_Create_Purchase";
            this.gbox_paymentCondition.ResumeLayout(false);
            this.gbox_paymentCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).EndInit();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.gbox_Product.ResumeLayout(false);
            this.gbox_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_barCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_UNCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productId)).EndInit();
            this.gbox_summary.ResumeLayout(false);
            this.gbox_summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discountCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discountPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_subtotal)).EndInit();
            this.gbox_options.ResumeLayout(false);
            this.gbox_options.PerformLayout();
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_SupplierId)).EndInit();
            this.gbox_User.ResumeLayout(false);
            this.gbox_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_requiredCamps;
        private System.Windows.Forms.GroupBox gbox_paymentCondition;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentMethod;
        private System.Windows.Forms.Label lbl_payConditionInstalments;
        private System.Windows.Forms.Label lbl_payConditionDiscount;
        private System.Windows.Forms.Label lbl_payConditionFine;
        private System.Windows.Forms.Label lbl_payConditionFees;
        private System.Windows.Forms.Button btn_SearchPayCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionQnt;
        private System.Windows.Forms.NumericUpDown edt_payConditionDiscount;
        private System.Windows.Forms.NumericUpDown edt_payConditionFine;
        private System.Windows.Forms.NumericUpDown edt_payConditionFees;
        private System.Windows.Forms.Label lbl_payCondition;
        private System.Windows.Forms.TextBox edt_payCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionId;
        private System.Windows.Forms.Label lbl_payConditionID;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.Label lbl_CancelDate;
        private System.Windows.Forms.MaskedTextBox medt_CancelDate;
        private System.Windows.Forms.MaskedTextBox medt_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.GroupBox gbox_Product;
        private System.Windows.Forms.NumericUpDown edt_barCode;
        private System.Windows.Forms.NumericUpDown edt_amount;
        private System.Windows.Forms.NumericUpDown edt_UNCost;
        private System.Windows.Forms.NumericUpDown edt_totalPValue;
        private System.Windows.Forms.NumericUpDown edt_productId;
        private System.Windows.Forms.Button btn_FindProduct;
        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Label lbl_barCode;
        private System.Windows.Forms.Label lbl_UNPrice;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_summary;
        private System.Windows.Forms.NumericUpDown edt_discountCash;
        private System.Windows.Forms.Label lbl_discountCash;
        private System.Windows.Forms.NumericUpDown edt_total;
        private System.Windows.Forms.NumericUpDown edt_discountPerc;
        private System.Windows.Forms.NumericUpDown edt_subtotal;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.GroupBox gbox_options;
        private System.Windows.Forms.Label lbl_findSupp;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.Label lbl_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_FindSuppliers;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox gbox_supplier;
        private System.Windows.Forms.MaskedTextBox medt_registrationNumber;
        private System.Windows.Forms.NumericUpDown edt_SupplierId;
        private System.Windows.Forms.Button btn_findSupplier;
        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.Label lbl_SupplierName;
        private System.Windows.Forms.Label lbl_SupplierId;
        private System.Windows.Forms.TextBox edt_SupplierName;
        private System.Windows.Forms.GroupBox gbox_User;
        private System.Windows.Forms.NumericUpDown edt_userId;
        private System.Windows.Forms.TextBox edt_userName;
        private System.Windows.Forms.Label lbl_userSalesman;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.DataGridView DGV_SaleProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDiscountCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnValueProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalValue;
    }
}