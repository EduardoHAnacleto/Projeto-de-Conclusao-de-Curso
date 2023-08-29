﻿namespace ProjetoEduardoAnacletoWindowsForm1.Forms
{
    partial class Frm_Sale
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
            this.DGV_SaleProducts = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscoutCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnValueProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_Salesman = new System.Windows.Forms.GroupBox();
            this.edt_userId = new System.Windows.Forms.NumericUpDown();
            this.edt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userSalesman = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.gbox_client = new System.Windows.Forms.GroupBox();
            this.medt_registrationNumber = new System.Windows.Forms.MaskedTextBox();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            this.btn_find = new System.Windows.Forms.Button();
            this.lbl_registrationNumber = new System.Windows.Forms.Label();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.gbox_options = new System.Windows.Forms.GroupBox();
            this.btn_CancelSale = new System.Windows.Forms.Button();
            this.lbl_findClient = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.lbl_Save = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_FindClient = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.lbl_barCode = new System.Windows.Forms.Label();
            this.lbl_productId = new System.Windows.Forms.Label();
            this.lbl_qntdAmount = new System.Windows.Forms.Label();
            this.btn_FindProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.gbox_Product = new System.Windows.Forms.GroupBox();
            this.lbl_prodUnValue = new System.Windows.Forms.Label();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.lbl_ProdDiscCash = new System.Windows.Forms.Label();
            this.edt_ProdUnValue = new System.Windows.Forms.NumericUpDown();
            this.edt_ProdDiscCash = new System.Windows.Forms.NumericUpDown();
            this.edt_barCode = new System.Windows.Forms.NumericUpDown();
            this.edt_amount = new System.Windows.Forms.NumericUpDown();
            this.edt_totalPValue = new System.Windows.Forms.NumericUpDown();
            this.edt_productId = new System.Windows.Forms.NumericUpDown();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.lbl_CancelDate = new System.Windows.Forms.Label();
            this.medt_CancelDate = new System.Windows.Forms.MaskedTextBox();
            this.medt_date = new System.Windows.Forms.MaskedTextBox();
            this.lbl_date = new System.Windows.Forms.Label();
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
            this.DGV_SaleSummary = new System.Windows.Forms.DataGridView();
            this.SaleSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).BeginInit();
            this.gbox_Salesman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).BeginInit();
            this.gbox_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            this.gbox_options.SuspendLayout();
            this.gbox_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProdUnValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProdDiscCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_barCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productId)).BeginInit();
            this.gbox_date.SuspendLayout();
            this.gbox_paymentCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleSummary)).BeginInit();
            this.SuspendLayout();
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
            this.DGV_SaleProducts.Location = new System.Drawing.Point(15, 225);
            this.DGV_SaleProducts.MultiSelect = false;
            this.DGV_SaleProducts.Name = "DGV_SaleProducts";
            this.DGV_SaleProducts.RowHeadersVisible = false;
            this.DGV_SaleProducts.RowHeadersWidth = 51;
            this.DGV_SaleProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleProducts.Size = new System.Drawing.Size(1116, 221);
            this.DGV_SaleProducts.TabIndex = 5;
            this.DGV_SaleProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SaleProducts_CellValueChanged);
            this.DGV_SaleProducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_SaleProducts_RowsRemoved);
            this.DGV_SaleProducts.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGV_SaleProducts_UserDeletedRow);
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
            // gbox_Salesman
            // 
            this.gbox_Salesman.Controls.Add(this.edt_userId);
            this.gbox_Salesman.Controls.Add(this.edt_userName);
            this.gbox_Salesman.Controls.Add(this.lbl_userSalesman);
            this.gbox_Salesman.Controls.Add(this.lbl_userId);
            this.gbox_Salesman.Location = new System.Drawing.Point(19, 563);
            this.gbox_Salesman.Name = "gbox_Salesman";
            this.gbox_Salesman.Size = new System.Drawing.Size(259, 100);
            this.gbox_Salesman.TabIndex = 7;
            this.gbox_Salesman.TabStop = false;
            this.gbox_Salesman.Text = "* Vendedor";
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
            // gbox_client
            // 
            this.gbox_client.Controls.Add(this.medt_registrationNumber);
            this.gbox_client.Controls.Add(this.edt_clientId);
            this.gbox_client.Controls.Add(this.btn_find);
            this.gbox_client.Controls.Add(this.lbl_registrationNumber);
            this.gbox_client.Controls.Add(this.lbl_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientId);
            this.gbox_client.Controls.Add(this.edt_clientName);
            this.gbox_client.Location = new System.Drawing.Point(228, 8);
            this.gbox_client.Name = "gbox_client";
            this.gbox_client.Size = new System.Drawing.Size(386, 100);
            this.gbox_client.TabIndex = 8;
            this.gbox_client.TabStop = false;
            this.gbox_client.Text = "* Clientes";
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
            // edt_clientId
            // 
            this.edt_clientId.Enabled = false;
            this.edt_clientId.Location = new System.Drawing.Point(9, 32);
            this.edt_clientId.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_clientId.Name = "edt_clientId";
            this.edt_clientId.Size = new System.Drawing.Size(41, 20);
            this.edt_clientId.TabIndex = 12;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(115, 75);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(64, 20);
            this.btn_find.TabIndex = 11;
            this.btn_find.Text = "Bu&scar";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // lbl_registrationNumber
            // 
            this.lbl_registrationNumber.AutoSize = true;
            this.lbl_registrationNumber.Location = new System.Drawing.Point(6, 58);
            this.lbl_registrationNumber.Name = "lbl_registrationNumber";
            this.lbl_registrationNumber.Size = new System.Drawing.Size(46, 13);
            this.lbl_registrationNumber.TabIndex = 4;
            this.lbl_registrationNumber.Text = "Registro";
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(53, 16);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(35, 13);
            this.lbl_clientName.TabIndex = 3;
            this.lbl_clientName.Text = "Nome";
            // 
            // lbl_clientId
            // 
            this.lbl_clientId.AutoSize = true;
            this.lbl_clientId.Location = new System.Drawing.Point(6, 16);
            this.lbl_clientId.Name = "lbl_clientId";
            this.lbl_clientId.Size = new System.Drawing.Size(18, 13);
            this.lbl_clientId.TabIndex = 2;
            this.lbl_clientId.Text = "ID";
            // 
            // edt_clientName
            // 
            this.edt_clientName.Enabled = false;
            this.edt_clientName.Location = new System.Drawing.Point(56, 32);
            this.edt_clientName.MaxLength = 60;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(284, 20);
            this.edt_clientName.TabIndex = 0;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(45, 25);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(44, 13);
            this.lbl_productName.TabIndex = 9;
            this.lbl_productName.Text = "Produto";
            // 
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(48, 41);
            this.edt_productName.MaxLength = 50;
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(336, 20);
            this.edt_productName.TabIndex = 1;
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
            this.gbox_options.Location = new System.Drawing.Point(19, 457);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(318, 88);
            this.gbox_options.TabIndex = 11;
            this.gbox_options.TabStop = false;
            this.gbox_options.Text = "Atalhos";
            // 
            // btn_CancelSale
            // 
            this.btn_CancelSale.Location = new System.Drawing.Point(252, 20);
            this.btn_CancelSale.Name = "btn_CancelSale";
            this.btn_CancelSale.Size = new System.Drawing.Size(60, 48);
            this.btn_CancelSale.TabIndex = 7;
            this.btn_CancelSale.Text = "Cancelar\r\nCompra";
            this.btn_CancelSale.UseVisualStyleBackColor = true;
            this.btn_CancelSale.Visible = false;
            // 
            // lbl_findClient
            // 
            this.lbl_findClient.AutoSize = true;
            this.lbl_findClient.Location = new System.Drawing.Point(77, 72);
            this.lbl_findClient.Name = "lbl_findClient";
            this.lbl_findClient.Size = new System.Drawing.Size(39, 13);
            this.lbl_findClient.TabIndex = 6;
            this.lbl_findClient.Text = "Cliente";
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
            // btn_FindClient
            // 
            this.btn_FindClient.Location = new System.Drawing.Point(66, 19);
            this.btn_FindClient.Name = "btn_FindClient";
            this.btn_FindClient.Size = new System.Drawing.Size(57, 51);
            this.btn_FindClient.TabIndex = 1;
            this.btn_FindClient.Text = "F7";
            this.btn_FindClient.UseVisualStyleBackColor = true;
            this.btn_FindClient.Click += new System.EventHandler(this.btn_FindClient_Click);
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
            // lbl_barCode
            // 
            this.lbl_barCode.AutoSize = true;
            this.lbl_barCode.Location = new System.Drawing.Point(387, 25);
            this.lbl_barCode.Name = "lbl_barCode";
            this.lbl_barCode.Size = new System.Drawing.Size(88, 13);
            this.lbl_barCode.TabIndex = 13;
            this.lbl_barCode.Text = "Código de Barras";
            // 
            // lbl_productId
            // 
            this.lbl_productId.AutoSize = true;
            this.lbl_productId.Location = new System.Drawing.Point(3, 24);
            this.lbl_productId.Name = "lbl_productId";
            this.lbl_productId.Size = new System.Drawing.Size(18, 13);
            this.lbl_productId.TabIndex = 16;
            this.lbl_productId.Text = "ID";
            // 
            // lbl_qntdAmount
            // 
            this.lbl_qntdAmount.AutoSize = true;
            this.lbl_qntdAmount.Location = new System.Drawing.Point(694, 24);
            this.lbl_qntdAmount.Name = "lbl_qntdAmount";
            this.lbl_qntdAmount.Size = new System.Drawing.Size(62, 13);
            this.lbl_qntdAmount.TabIndex = 18;
            this.lbl_qntdAmount.Text = "Quantidade\r\n";
            // 
            // btn_FindProduct
            // 
            this.btn_FindProduct.Location = new System.Drawing.Point(622, 41);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(58, 20);
            this.btn_FindProduct.TabIndex = 3;
            this.btn_FindProduct.Text = "Bu&scar";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            this.btn_FindProduct.Click += new System.EventHandler(this.btn_FindProduct_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(1109, 41);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(59, 20);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "Adicionar";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.Location = new System.Drawing.Point(1030, 25);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(58, 13);
            this.lbl_TotalCost.TabIndex = 24;
            this.lbl_TotalCost.Text = "Valor Total";
            // 
            // gbox_Product
            // 
            this.gbox_Product.Controls.Add(this.lbl_prodUnValue);
            this.gbox_Product.Controls.Add(this.btn_DeleteItem);
            this.gbox_Product.Controls.Add(this.lbl_ProdDiscCash);
            this.gbox_Product.Controls.Add(this.edt_ProdUnValue);
            this.gbox_Product.Controls.Add(this.edt_ProdDiscCash);
            this.gbox_Product.Controls.Add(this.edt_barCode);
            this.gbox_Product.Controls.Add(this.edt_amount);
            this.gbox_Product.Controls.Add(this.edt_totalPValue);
            this.gbox_Product.Controls.Add(this.edt_productId);
            this.gbox_Product.Controls.Add(this.btn_FindProduct);
            this.gbox_Product.Controls.Add(this.lbl_TotalCost);
            this.gbox_Product.Controls.Add(this.lbl_productName);
            this.gbox_Product.Controls.Add(this.edt_productName);
            this.gbox_Product.Controls.Add(this.lbl_barCode);
            this.gbox_Product.Controls.Add(this.btn_AddProduct);
            this.gbox_Product.Controls.Add(this.lbl_productId);
            this.gbox_Product.Controls.Add(this.lbl_qntdAmount);
            this.gbox_Product.Location = new System.Drawing.Point(15, 153);
            this.gbox_Product.Name = "gbox_Product";
            this.gbox_Product.Size = new System.Drawing.Size(1168, 66);
            this.gbox_Product.TabIndex = 25;
            this.gbox_Product.TabStop = false;
            this.gbox_Product.Text = "Produtos";
            // 
            // lbl_prodUnValue
            // 
            this.lbl_prodUnValue.AutoSize = true;
            this.lbl_prodUnValue.Location = new System.Drawing.Point(951, 24);
            this.lbl_prodUnValue.Name = "lbl_prodUnValue";
            this.lbl_prodUnValue.Size = new System.Drawing.Size(50, 13);
            this.lbl_prodUnValue.TabIndex = 35;
            this.lbl_prodUnValue.Text = "Valor UN";
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Location = new System.Drawing.Point(1093, 6);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteItem.TabIndex = 30;
            this.btn_DeleteItem.Text = "Excluir Item";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // lbl_ProdDiscCash
            // 
            this.lbl_ProdDiscCash.AutoSize = true;
            this.lbl_ProdDiscCash.Location = new System.Drawing.Point(756, 25);
            this.lbl_ProdDiscCash.Name = "lbl_ProdDiscCash";
            this.lbl_ProdDiscCash.Size = new System.Drawing.Size(62, 13);
            this.lbl_ProdDiscCash.TabIndex = 33;
            this.lbl_ProdDiscCash.Text = "Desconto $";
            // 
            // edt_ProdUnValue
            // 
            this.edt_ProdUnValue.DecimalPlaces = 2;
            this.edt_ProdUnValue.Enabled = false;
            this.edt_ProdUnValue.Location = new System.Drawing.Point(954, 41);
            this.edt_ProdUnValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_ProdUnValue.Name = "edt_ProdUnValue";
            this.edt_ProdUnValue.Size = new System.Drawing.Size(73, 20);
            this.edt_ProdUnValue.TabIndex = 32;
            // 
            // edt_ProdDiscCash
            // 
            this.edt_ProdDiscCash.DecimalPlaces = 2;
            this.edt_ProdDiscCash.Location = new System.Drawing.Point(759, 41);
            this.edt_ProdDiscCash.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_ProdDiscCash.Name = "edt_ProdDiscCash";
            this.edt_ProdDiscCash.Size = new System.Drawing.Size(59, 20);
            this.edt_ProdDiscCash.TabIndex = 5;
            // 
            // edt_barCode
            // 
            this.edt_barCode.Location = new System.Drawing.Point(390, 41);
            this.edt_barCode.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.edt_barCode.Name = "edt_barCode";
            this.edt_barCode.Size = new System.Drawing.Size(226, 20);
            this.edt_barCode.TabIndex = 2;
            this.edt_barCode.ValueChanged += new System.EventHandler(this.edt_barCode_ValueChanged);
            this.edt_barCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_barCode_KeyPress);
            // 
            // edt_amount
            // 
            this.edt_amount.Location = new System.Drawing.Point(697, 41);
            this.edt_amount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edt_amount.Name = "edt_amount";
            this.edt_amount.Size = new System.Drawing.Size(44, 20);
            this.edt_amount.TabIndex = 4;
            this.edt_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edt_amount.ValueChanged += new System.EventHandler(this.edt_amount_ValueChanged);
            // 
            // edt_totalPValue
            // 
            this.edt_totalPValue.DecimalPlaces = 2;
            this.edt_totalPValue.Enabled = false;
            this.edt_totalPValue.Location = new System.Drawing.Point(1033, 41);
            this.edt_totalPValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_totalPValue.Name = "edt_totalPValue";
            this.edt_totalPValue.Size = new System.Drawing.Size(70, 20);
            this.edt_totalPValue.TabIndex = 26;
            // 
            // edt_productId
            // 
            this.edt_productId.Location = new System.Drawing.Point(6, 40);
            this.edt_productId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_productId.Name = "edt_productId";
            this.edt_productId.Size = new System.Drawing.Size(36, 20);
            this.edt_productId.TabIndex = 25;
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.lbl_CancelDate);
            this.gbox_date.Controls.Add(this.medt_CancelDate);
            this.gbox_date.Controls.Add(this.medt_date);
            this.gbox_date.Controls.Add(this.lbl_date);
            this.gbox_date.Controls.Add(this.lbl_requiredCamps);
            this.gbox_date.Location = new System.Drawing.Point(15, 8);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(196, 83);
            this.gbox_date.TabIndex = 26;
            this.gbox_date.TabStop = false;
            this.gbox_date.Text = "Datas";
            // 
            // lbl_CancelDate
            // 
            this.lbl_CancelDate.AutoSize = true;
            this.lbl_CancelDate.Location = new System.Drawing.Point(6, 45);
            this.lbl_CancelDate.Name = "lbl_CancelDate";
            this.lbl_CancelDate.Size = new System.Drawing.Size(64, 13);
            this.lbl_CancelDate.TabIndex = 3;
            this.lbl_CancelDate.Text = "Cancelado :";
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
            this.lbl_date.Location = new System.Drawing.Point(6, 19);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Emissão :";
            // 
            // lbl_requiredCamps
            // 
            this.lbl_requiredCamps.AutoSize = true;
            this.lbl_requiredCamps.Location = new System.Drawing.Point(6, 65);
            this.lbl_requiredCamps.Name = "lbl_requiredCamps";
            this.lbl_requiredCamps.Size = new System.Drawing.Size(114, 13);
            this.lbl_requiredCamps.TabIndex = 28;
            this.lbl_requiredCamps.Text = "* Campos Obrigatórios.";
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
            this.gbox_paymentCondition.Location = new System.Drawing.Point(344, 513);
            this.gbox_paymentCondition.Name = "gbox_paymentCondition";
            this.gbox_paymentCondition.Size = new System.Drawing.Size(817, 166);
            this.gbox_paymentCondition.TabIndex = 27;
            this.gbox_paymentCondition.TabStop = false;
            this.gbox_paymentCondition.Text = "* Condição de Pagamento";
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
            this.DGV_Instalments.RowHeadersVisible = false;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.Size = new System.Drawing.Size(408, 150);
            this.DGV_Instalments.TabIndex = 13;
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
            // lbl_payConditionInstalments
            // 
            this.lbl_payConditionInstalments.AutoSize = true;
            this.lbl_payConditionInstalments.Location = new System.Drawing.Point(172, 66);
            this.lbl_payConditionInstalments.Name = "lbl_payConditionInstalments";
            this.lbl_payConditionInstalments.Size = new System.Drawing.Size(48, 13);
            this.lbl_payConditionInstalments.TabIndex = 12;
            this.lbl_payConditionInstalments.Text = "Parcelas";
            // 
            // lbl_payConditionDiscount
            // 
            this.lbl_payConditionDiscount.AutoSize = true;
            this.lbl_payConditionDiscount.Location = new System.Drawing.Point(111, 66);
            this.lbl_payConditionDiscount.Name = "lbl_payConditionDiscount";
            this.lbl_payConditionDiscount.Size = new System.Drawing.Size(64, 13);
            this.lbl_payConditionDiscount.TabIndex = 11;
            this.lbl_payConditionDiscount.Text = "Desconto %";
            // 
            // lbl_payConditionFine
            // 
            this.lbl_payConditionFine.AutoSize = true;
            this.lbl_payConditionFine.Location = new System.Drawing.Point(60, 66);
            this.lbl_payConditionFine.Name = "lbl_payConditionFine";
            this.lbl_payConditionFine.Size = new System.Drawing.Size(33, 13);
            this.lbl_payConditionFine.TabIndex = 10;
            this.lbl_payConditionFine.Text = "Multa";
            // 
            // lbl_payConditionFees
            // 
            this.lbl_payConditionFees.AutoSize = true;
            this.lbl_payConditionFees.Location = new System.Drawing.Point(11, 66);
            this.lbl_payConditionFees.Name = "lbl_payConditionFees";
            this.lbl_payConditionFees.Size = new System.Drawing.Size(31, 13);
            this.lbl_payConditionFees.TabIndex = 9;
            this.lbl_payConditionFees.Text = "Taxa";
            // 
            // btn_SearchPayCondition
            // 
            this.btn_SearchPayCondition.Location = new System.Drawing.Point(337, 35);
            this.btn_SearchPayCondition.Name = "btn_SearchPayCondition";
            this.btn_SearchPayCondition.Size = new System.Drawing.Size(57, 20);
            this.btn_SearchPayCondition.TabIndex = 8;
            this.btn_SearchPayCondition.Text = "Search";
            this.btn_SearchPayCondition.UseVisualStyleBackColor = true;
            this.btn_SearchPayCondition.Click += new System.EventHandler(this.btn_SearchPayCondition_Click);
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
            this.lbl_payCondition.Size = new System.Drawing.Size(52, 13);
            this.lbl_payCondition.TabIndex = 3;
            this.lbl_payCondition.Text = "Condição";
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
            // DGV_SaleSummary
            // 
            this.DGV_SaleSummary.AllowUserToDeleteRows = false;
            this.DGV_SaleSummary.AllowUserToResizeColumns = false;
            this.DGV_SaleSummary.AllowUserToResizeRows = false;
            this.DGV_SaleSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SaleSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SaleSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleSubTotal,
            this.SaleTotal});
            this.DGV_SaleSummary.Enabled = false;
            this.DGV_SaleSummary.Location = new System.Drawing.Point(978, 16);
            this.DGV_SaleSummary.MultiSelect = false;
            this.DGV_SaleSummary.Name = "DGV_SaleSummary";
            this.DGV_SaleSummary.ReadOnly = true;
            this.DGV_SaleSummary.RowHeadersVisible = false;
            this.DGV_SaleSummary.RowHeadersWidth = 51;
            this.DGV_SaleSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleSummary.Size = new System.Drawing.Size(153, 41);
            this.DGV_SaleSummary.TabIndex = 29;
            // 
            // SaleSubTotal
            // 
            this.SaleSubTotal.HeaderText = "Sub-Total";
            this.SaleSubTotal.MinimumWidth = 6;
            this.SaleSubTotal.Name = "SaleSubTotal";
            this.SaleSubTotal.ReadOnly = true;
            this.SaleSubTotal.Width = 70;
            // 
            // SaleTotal
            // 
            this.SaleTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleTotal.HeaderText = "Total";
            this.SaleTotal.MinimumWidth = 6;
            this.SaleTotal.Name = "SaleTotal";
            this.SaleTotal.ReadOnly = true;
            // 
            // Frm_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 684);
            this.Controls.Add(this.DGV_SaleSummary);
            this.Controls.Add(this.gbox_paymentCondition);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.gbox_Product);
            this.Controls.Add(this.gbox_options);
            this.Controls.Add(this.gbox_client);
            this.Controls.Add(this.gbox_Salesman);
            this.Controls.Add(this.DGV_SaleProducts);
            this.Name = "Frm_Sale";
            this.Text = "Vendas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Sale_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleProducts)).EndInit();
            this.gbox_Salesman.ResumeLayout(false);
            this.gbox_Salesman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_userId)).EndInit();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            this.gbox_options.ResumeLayout(false);
            this.gbox_options.PerformLayout();
            this.gbox_Product.ResumeLayout(false);
            this.gbox_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProdUnValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProdDiscCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_barCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productId)).EndInit();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.gbox_paymentCondition.ResumeLayout(false);
            this.gbox_paymentCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_SaleProducts;
        private System.Windows.Forms.GroupBox gbox_Salesman;
        private System.Windows.Forms.TextBox edt_userName;
        private System.Windows.Forms.Label lbl_userSalesman;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.GroupBox gbox_client;
        private System.Windows.Forms.Label lbl_registrationNumber;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.GroupBox gbox_options;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.Label lbl_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_FindClient;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_barCode;
        private System.Windows.Forms.Label lbl_productId;
        private System.Windows.Forms.Label lbl_qntdAmount;
        private System.Windows.Forms.Button btn_FindProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.GroupBox gbox_Product;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.MaskedTextBox medt_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.NumericUpDown edt_userId;
        private System.Windows.Forms.NumericUpDown edt_clientId;
        private System.Windows.Forms.NumericUpDown edt_totalPValue;
        private System.Windows.Forms.NumericUpDown edt_productId;
        private System.Windows.Forms.NumericUpDown edt_amount;
        private System.Windows.Forms.NumericUpDown edt_barCode;
        private System.Windows.Forms.MaskedTextBox medt_registrationNumber;
        private System.Windows.Forms.Label lbl_findClient;
        private System.Windows.Forms.GroupBox gbox_paymentCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionId;
        private System.Windows.Forms.Label lbl_payConditionID;
        private System.Windows.Forms.Label lbl_payCondition;
        private System.Windows.Forms.TextBox edt_payCondition;
        private System.Windows.Forms.Button btn_SearchPayCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionQnt;
        private System.Windows.Forms.NumericUpDown edt_payConditionDiscount;
        private System.Windows.Forms.NumericUpDown edt_payConditionFine;
        private System.Windows.Forms.NumericUpDown edt_payConditionFees;
        private System.Windows.Forms.Label lbl_payConditionInstalments;
        private System.Windows.Forms.Label lbl_payConditionDiscount;
        private System.Windows.Forms.Label lbl_payConditionFine;
        private System.Windows.Forms.Label lbl_payConditionFees;
        private System.Windows.Forms.Label lbl_CancelDate;
        private System.Windows.Forms.MaskedTextBox medt_CancelDate;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.Label lbl_requiredCamps;
        private System.Windows.Forms.NumericUpDown edt_ProdDiscCash;
        private System.Windows.Forms.NumericUpDown edt_ProdUnValue;
        private System.Windows.Forms.Label lbl_prodUnValue;
        private System.Windows.Forms.Label lbl_ProdDiscCash;
        private System.Windows.Forms.DataGridView DGV_SaleSummary;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Button btn_CancelSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDiscoutCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnValueProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalValue;
    }
}