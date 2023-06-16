namespace ProjetoEduardoAnacletoWindowsForm1.MasterDetails
{
    partial class MasterDetails_Sales
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
            this.DGV_Clients = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientRegNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_client = new System.Windows.Forms.Label();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.btn_FindClient = new System.Windows.Forms.Button();
            this.lbl_SaleId = new System.Windows.Forms.Label();
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePayCond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleProdQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SelectSale = new System.Windows.Forms.Button();
            this.edt_saleId = new System.Windows.Forms.NumericUpDown();
            this.btn_findSale = new System.Windows.Forms.Button();
            this.gbox_sale = new System.Windows.Forms.GroupBox();
            this.btn_SearchUser = new System.Windows.Forms.Button();
            this.gbox_SaleFilters = new System.Windows.Forms.GroupBox();
            this.btn_ClearSaleFilters = new System.Windows.Forms.Button();
            this.lbl_payCondition = new System.Windows.Forms.Label();
            this.btn_SearchPayCond = new System.Windows.Forms.Button();
            this.edt_payCondition = new System.Windows.Forms.TextBox();
            this.rbtn_CancelledStatus = new System.Windows.Forms.RadioButton();
            this.rbtn_ActiveStatus = new System.Windows.Forms.RadioButton();
            this.dateTime_DateFilter = new System.Windows.Forms.DateTimePicker();
            this.gbox_clientFilters = new System.Windows.Forms.GroupBox();
            this.rbtn_Natural = new System.Windows.Forms.RadioButton();
            this.rbtn_LegalClients = new System.Windows.Forms.RadioButton();
            this.btn_ClearClientFilters = new System.Windows.Forms.Button();
            this.btn_SelectClient = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.edt_UserId = new System.Windows.Forms.NumericUpDown();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.lbl_ClientId = new System.Windows.Forms.Label();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleId)).BeginInit();
            this.gbox_sale.SuspendLayout();
            this.gbox_SaleFilters.SuspendLayout();
            this.gbox_clientFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_UserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Clients
            // 
            this.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.ClientRegNumber,
            this.ClientType});
            this.DGV_Clients.Location = new System.Drawing.Point(16, 44);
            this.DGV_Clients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Clients.Name = "DGV_Clients";
            this.DGV_Clients.RowHeadersWidth = 51;
            this.DGV_Clients.Size = new System.Drawing.Size(849, 207);
            this.DGV_Clients.TabIndex = 0;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "ID";
            this.ClientId.MinimumWidth = 6;
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Width = 45;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientRegNumber
            // 
            this.ClientRegNumber.HeaderText = "Registration Number";
            this.ClientRegNumber.MinimumWidth = 6;
            this.ClientRegNumber.Name = "ClientRegNumber";
            this.ClientRegNumber.ReadOnly = true;
            this.ClientRegNumber.Width = 125;
            // 
            // ClientType
            // 
            this.ClientType.HeaderText = "Type";
            this.ClientType.MinimumWidth = 6;
            this.ClientType.Name = "ClientType";
            this.ClientType.ReadOnly = true;
            this.ClientType.Width = 125;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(167, 17);
            this.lbl_client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(46, 16);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client :";
            // 
            // edt_clientName
            // 
            this.edt_clientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_clientName.Location = new System.Drawing.Point(212, 14);
            this.edt_clientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_clientName.MaxLength = 30;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(317, 22);
            this.edt_clientName.TabIndex = 2;
            // 
            // btn_FindClient
            // 
            this.btn_FindClient.Location = new System.Drawing.Point(537, 14);
            this.btn_FindClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FindClient.Name = "btn_FindClient";
            this.btn_FindClient.Size = new System.Drawing.Size(100, 23);
            this.btn_FindClient.TabIndex = 3;
            this.btn_FindClient.Text = "&Search";
            this.btn_FindClient.UseVisualStyleBackColor = true;
            this.btn_FindClient.Click += new System.EventHandler(this.btn_FindClient_Click);
            // 
            // lbl_SaleId
            // 
            this.lbl_SaleId.AutoSize = true;
            this.lbl_SaleId.Location = new System.Drawing.Point(6, 26);
            this.lbl_SaleId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SaleId.Name = "lbl_SaleId";
            this.lbl_SaleId.Size = new System.Drawing.Size(57, 16);
            this.lbl_SaleId.TabIndex = 5;
            this.lbl_SaleId.Text = "Sale ID :";
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.SaleClientName,
            this.SaleSubTotal,
            this.SaleTotalValue,
            this.SalePayCond,
            this.SaleProdQtd,
            this.SaleDate,
            this.SaleUserId,
            this.SaleStatus});
            this.DGV_Sales.Location = new System.Drawing.Point(8, 96);
            this.DGV_Sales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.RowHeadersWidth = 51;
            this.DGV_Sales.Size = new System.Drawing.Size(1399, 363);
            this.DGV_Sales.TabIndex = 6;
            // 
            // SaleId
            // 
            this.SaleId.HeaderText = "ID";
            this.SaleId.MinimumWidth = 6;
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            this.SaleId.Width = 45;
            // 
            // SaleClientName
            // 
            this.SaleClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleClientName.HeaderText = "Client Name";
            this.SaleClientName.MinimumWidth = 6;
            this.SaleClientName.Name = "SaleClientName";
            this.SaleClientName.ReadOnly = true;
            // 
            // SaleSubTotal
            // 
            this.SaleSubTotal.HeaderText = "Sub-Total";
            this.SaleSubTotal.MinimumWidth = 6;
            this.SaleSubTotal.Name = "SaleSubTotal";
            this.SaleSubTotal.ReadOnly = true;
            this.SaleSubTotal.Width = 65;
            // 
            // SaleTotalValue
            // 
            this.SaleTotalValue.HeaderText = "Total Value";
            this.SaleTotalValue.MinimumWidth = 6;
            this.SaleTotalValue.Name = "SaleTotalValue";
            this.SaleTotalValue.ReadOnly = true;
            this.SaleTotalValue.Width = 75;
            // 
            // SalePayCond
            // 
            this.SalePayCond.HeaderText = "Payment Condition";
            this.SalePayCond.MinimumWidth = 6;
            this.SalePayCond.Name = "SalePayCond";
            this.SalePayCond.ReadOnly = true;
            this.SalePayCond.Width = 125;
            // 
            // SaleProdQtd
            // 
            this.SaleProdQtd.HeaderText = "Product Quantity";
            this.SaleProdQtd.MinimumWidth = 6;
            this.SaleProdQtd.Name = "SaleProdQtd";
            this.SaleProdQtd.ReadOnly = true;
            this.SaleProdQtd.Width = 60;
            // 
            // SaleDate
            // 
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            this.SaleDate.Width = 70;
            // 
            // SaleUserId
            // 
            this.SaleUserId.HeaderText = "User ID";
            this.SaleUserId.MinimumWidth = 6;
            this.SaleUserId.Name = "SaleUserId";
            this.SaleUserId.ReadOnly = true;
            this.SaleUserId.Width = 60;
            // 
            // SaleStatus
            // 
            this.SaleStatus.HeaderText = "Status";
            this.SaleStatus.MinimumWidth = 6;
            this.SaleStatus.Name = "SaleStatus";
            this.SaleStatus.ReadOnly = true;
            this.SaleStatus.Width = 65;
            // 
            // btn_SelectSale
            // 
            this.btn_SelectSale.Location = new System.Drawing.Point(1189, 732);
            this.btn_SelectSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SelectSale.Name = "btn_SelectSale";
            this.btn_SelectSale.Size = new System.Drawing.Size(100, 28);
            this.btn_SelectSale.TabIndex = 7;
            this.btn_SelectSale.Text = "Select &Sale";
            this.btn_SelectSale.UseVisualStyleBackColor = true;
            // 
            // edt_saleId
            // 
            this.edt_saleId.Location = new System.Drawing.Point(71, 23);
            this.edt_saleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_saleId.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.edt_saleId.Name = "edt_saleId";
            this.edt_saleId.Size = new System.Drawing.Size(81, 22);
            this.edt_saleId.TabIndex = 8;
            // 
            // btn_findSale
            // 
            this.btn_findSale.Location = new System.Drawing.Point(160, 23);
            this.btn_findSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_findSale.Name = "btn_findSale";
            this.btn_findSale.Size = new System.Drawing.Size(100, 25);
            this.btn_findSale.TabIndex = 9;
            this.btn_findSale.Text = "&Search ID";
            this.btn_findSale.UseVisualStyleBackColor = true;
            this.btn_findSale.Click += new System.EventHandler(this.btn_findSale_Click);
            // 
            // gbox_sale
            // 
            this.gbox_sale.Controls.Add(this.lbl_UserId);
            this.gbox_sale.Controls.Add(this.edt_UserId);
            this.gbox_sale.Controls.Add(this.btn_SearchUser);
            this.gbox_sale.Controls.Add(this.DGV_Sales);
            this.gbox_sale.Controls.Add(this.btn_findSale);
            this.gbox_sale.Controls.Add(this.lbl_SaleId);
            this.gbox_sale.Controls.Add(this.edt_saleId);
            this.gbox_sale.Location = new System.Drawing.Point(16, 258);
            this.gbox_sale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_sale.Name = "gbox_sale";
            this.gbox_sale.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_sale.Size = new System.Drawing.Size(1419, 466);
            this.gbox_sale.TabIndex = 10;
            this.gbox_sale.TabStop = false;
            this.gbox_sale.Text = "Sale";
            // 
            // btn_SearchUser
            // 
            this.btn_SearchUser.Location = new System.Drawing.Point(160, 67);
            this.btn_SearchUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SearchUser.Name = "btn_SearchUser";
            this.btn_SearchUser.Size = new System.Drawing.Size(109, 22);
            this.btn_SearchUser.TabIndex = 12;
            this.btn_SearchUser.Text = "Search User";
            this.btn_SearchUser.UseVisualStyleBackColor = true;
            this.btn_SearchUser.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // gbox_SaleFilters
            // 
            this.gbox_SaleFilters.Controls.Add(this.btn_ClearSaleFilters);
            this.gbox_SaleFilters.Controls.Add(this.lbl_payCondition);
            this.gbox_SaleFilters.Controls.Add(this.btn_SearchPayCond);
            this.gbox_SaleFilters.Controls.Add(this.edt_payCondition);
            this.gbox_SaleFilters.Controls.Add(this.rbtn_CancelledStatus);
            this.gbox_SaleFilters.Controls.Add(this.rbtn_ActiveStatus);
            this.gbox_SaleFilters.Controls.Add(this.dateTime_DateFilter);
            this.gbox_SaleFilters.Location = new System.Drawing.Point(1085, 28);
            this.gbox_SaleFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_SaleFilters.Name = "gbox_SaleFilters";
            this.gbox_SaleFilters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_SaleFilters.Size = new System.Drawing.Size(349, 192);
            this.gbox_SaleFilters.TabIndex = 11;
            this.gbox_SaleFilters.TabStop = false;
            this.gbox_SaleFilters.Text = "Sale Filters";
            // 
            // btn_ClearSaleFilters
            // 
            this.btn_ClearSaleFilters.Location = new System.Drawing.Point(261, 20);
            this.btn_ClearSaleFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ClearSaleFilters.Name = "btn_ClearSaleFilters";
            this.btn_ClearSaleFilters.Size = new System.Drawing.Size(76, 28);
            this.btn_ClearSaleFilters.TabIndex = 6;
            this.btn_ClearSaleFilters.Text = "Reset";
            this.btn_ClearSaleFilters.UseVisualStyleBackColor = true;
            this.btn_ClearSaleFilters.Click += new System.EventHandler(this.btn_ClearSaleFilters_Click);
            // 
            // lbl_payCondition
            // 
            this.lbl_payCondition.AutoSize = true;
            this.lbl_payCondition.Location = new System.Drawing.Point(8, 121);
            this.lbl_payCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_payCondition.Name = "lbl_payCondition";
            this.lbl_payCondition.Size = new System.Drawing.Size(119, 16);
            this.lbl_payCondition.TabIndex = 5;
            this.lbl_payCondition.Text = "Payment Condition";
            // 
            // btn_SearchPayCond
            // 
            this.btn_SearchPayCond.Location = new System.Drawing.Point(261, 137);
            this.btn_SearchPayCond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SearchPayCond.Name = "btn_SearchPayCond";
            this.btn_SearchPayCond.Size = new System.Drawing.Size(76, 28);
            this.btn_SearchPayCond.TabIndex = 4;
            this.btn_SearchPayCond.Text = "Search";
            this.btn_SearchPayCond.UseVisualStyleBackColor = true;
            this.btn_SearchPayCond.Click += new System.EventHandler(this.btn_SearchPayCond_Click);
            // 
            // edt_payCondition
            // 
            this.edt_payCondition.Enabled = false;
            this.edt_payCondition.Location = new System.Drawing.Point(8, 140);
            this.edt_payCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_payCondition.MaxLength = 50;
            this.edt_payCondition.Name = "edt_payCondition";
            this.edt_payCondition.Size = new System.Drawing.Size(244, 22);
            this.edt_payCondition.TabIndex = 3;
            // 
            // rbtn_CancelledStatus
            // 
            this.rbtn_CancelledStatus.AutoSize = true;
            this.rbtn_CancelledStatus.Location = new System.Drawing.Point(8, 84);
            this.rbtn_CancelledStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_CancelledStatus.Name = "rbtn_CancelledStatus";
            this.rbtn_CancelledStatus.Size = new System.Drawing.Size(89, 20);
            this.rbtn_CancelledStatus.TabIndex = 2;
            this.rbtn_CancelledStatus.TabStop = true;
            this.rbtn_CancelledStatus.Text = "Cancelled";
            this.rbtn_CancelledStatus.UseVisualStyleBackColor = true;
            this.rbtn_CancelledStatus.CheckedChanged += new System.EventHandler(this.rbtn_CancelledStatus_CheckedChanged);
            // 
            // rbtn_ActiveStatus
            // 
            this.rbtn_ActiveStatus.AutoSize = true;
            this.rbtn_ActiveStatus.Location = new System.Drawing.Point(8, 55);
            this.rbtn_ActiveStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_ActiveStatus.Name = "rbtn_ActiveStatus";
            this.rbtn_ActiveStatus.Size = new System.Drawing.Size(65, 20);
            this.rbtn_ActiveStatus.TabIndex = 1;
            this.rbtn_ActiveStatus.TabStop = true;
            this.rbtn_ActiveStatus.Text = "Active";
            this.rbtn_ActiveStatus.UseVisualStyleBackColor = true;
            this.rbtn_ActiveStatus.CheckedChanged += new System.EventHandler(this.rbtn_ActiveStatus_CheckedChanged);
            // 
            // dateTime_DateFilter
            // 
            this.dateTime_DateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_DateFilter.Location = new System.Drawing.Point(8, 23);
            this.dateTime_DateFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime_DateFilter.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_DateFilter.Name = "dateTime_DateFilter";
            this.dateTime_DateFilter.Size = new System.Drawing.Size(125, 22);
            this.dateTime_DateFilter.TabIndex = 0;
            this.dateTime_DateFilter.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_DateFilter.ValueChanged += new System.EventHandler(this.dateTime_DateFilter_ValueChanged);
            // 
            // gbox_clientFilters
            // 
            this.gbox_clientFilters.Controls.Add(this.rbtn_Natural);
            this.gbox_clientFilters.Controls.Add(this.rbtn_LegalClients);
            this.gbox_clientFilters.Controls.Add(this.btn_ClearClientFilters);
            this.gbox_clientFilters.Location = new System.Drawing.Point(873, 44);
            this.gbox_clientFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_clientFilters.Name = "gbox_clientFilters";
            this.gbox_clientFilters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_clientFilters.Size = new System.Drawing.Size(204, 91);
            this.gbox_clientFilters.TabIndex = 12;
            this.gbox_clientFilters.TabStop = false;
            this.gbox_clientFilters.Text = "Client Filters";
            // 
            // rbtn_Natural
            // 
            this.rbtn_Natural.AutoSize = true;
            this.rbtn_Natural.Location = new System.Drawing.Point(8, 55);
            this.rbtn_Natural.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_Natural.Name = "rbtn_Natural";
            this.rbtn_Natural.Size = new System.Drawing.Size(71, 20);
            this.rbtn_Natural.TabIndex = 9;
            this.rbtn_Natural.TabStop = true;
            this.rbtn_Natural.Text = "Natural";
            this.rbtn_Natural.UseVisualStyleBackColor = true;
            this.rbtn_Natural.CheckedChanged += new System.EventHandler(this.rbtn_Natural_CheckedChanged);
            // 
            // rbtn_LegalClients
            // 
            this.rbtn_LegalClients.AutoSize = true;
            this.rbtn_LegalClients.Location = new System.Drawing.Point(8, 27);
            this.rbtn_LegalClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_LegalClients.Name = "rbtn_LegalClients";
            this.rbtn_LegalClients.Size = new System.Drawing.Size(62, 20);
            this.rbtn_LegalClients.TabIndex = 8;
            this.rbtn_LegalClients.TabStop = true;
            this.rbtn_LegalClients.Text = "Legal";
            this.rbtn_LegalClients.UseVisualStyleBackColor = true;
            this.rbtn_LegalClients.CheckedChanged += new System.EventHandler(this.rbtn_LegalClients_CheckedChanged);
            // 
            // btn_ClearClientFilters
            // 
            this.btn_ClearClientFilters.Location = new System.Drawing.Point(121, 20);
            this.btn_ClearClientFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ClearClientFilters.Name = "btn_ClearClientFilters";
            this.btn_ClearClientFilters.Size = new System.Drawing.Size(76, 28);
            this.btn_ClearClientFilters.TabIndex = 7;
            this.btn_ClearClientFilters.Text = "Reset";
            this.btn_ClearClientFilters.UseVisualStyleBackColor = true;
            this.btn_ClearClientFilters.Click += new System.EventHandler(this.btn_ClearClientFilters_Click);
            // 
            // btn_SelectClient
            // 
            this.btn_SelectClient.Location = new System.Drawing.Point(873, 223);
            this.btn_SelectClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SelectClient.Name = "btn_SelectClient";
            this.btn_SelectClient.Size = new System.Drawing.Size(100, 28);
            this.btn_SelectClient.TabIndex = 13;
            this.btn_SelectClient.Text = "Select &Client";
            this.btn_SelectClient.UseVisualStyleBackColor = true;
            this.btn_SelectClient.Click += new System.EventHandler(this.btn_SelectClient_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1312, 732);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 28);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // edt_UserId
            // 
            this.edt_UserId.Location = new System.Drawing.Point(71, 67);
            this.edt_UserId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edt_UserId.Name = "edt_UserId";
            this.edt_UserId.Size = new System.Drawing.Size(81, 22);
            this.edt_UserId.TabIndex = 13;
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(5, 69);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(58, 16);
            this.lbl_UserId.TabIndex = 14;
            this.lbl_UserId.Text = "User ID :";
            // 
            // lbl_ClientId
            // 
            this.lbl_ClientId.AutoSize = true;
            this.lbl_ClientId.Location = new System.Drawing.Point(13, 17);
            this.lbl_ClientId.Name = "lbl_ClientId";
            this.lbl_ClientId.Size = new System.Drawing.Size(62, 16);
            this.lbl_ClientId.TabIndex = 15;
            this.lbl_ClientId.Text = "Client ID :";
            // 
            // edt_clientId
            // 
            this.edt_clientId.Location = new System.Drawing.Point(75, 14);
            this.edt_clientId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edt_clientId.Name = "edt_clientId";
            this.edt_clientId.Size = new System.Drawing.Size(80, 22);
            this.edt_clientId.TabIndex = 16;
            // 
            // MasterDetails_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 769);
            this.Controls.Add(this.edt_clientId);
            this.Controls.Add(this.lbl_ClientId);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SelectClient);
            this.Controls.Add(this.gbox_clientFilters);
            this.Controls.Add(this.gbox_SaleFilters);
            this.Controls.Add(this.gbox_sale);
            this.Controls.Add(this.btn_SelectSale);
            this.Controls.Add(this.btn_FindClient);
            this.Controls.Add(this.edt_clientName);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.DGV_Clients);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasterDetails_Sales";
            this.Text = "Clients - Sales";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleId)).EndInit();
            this.gbox_sale.ResumeLayout(false);
            this.gbox_sale.PerformLayout();
            this.gbox_SaleFilters.ResumeLayout(false);
            this.gbox_SaleFilters.PerformLayout();
            this.gbox_clientFilters.ResumeLayout(false);
            this.gbox_clientFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_UserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Clients;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Button btn_FindClient;
        private System.Windows.Forms.Label lbl_SaleId;
        private System.Windows.Forms.DataGridView DGV_Sales;
        private System.Windows.Forms.Button btn_SelectSale;
        private System.Windows.Forms.NumericUpDown edt_saleId;
        private System.Windows.Forms.Button btn_findSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientRegNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientType;
        private System.Windows.Forms.GroupBox gbox_sale;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.GroupBox gbox_SaleFilters;
        private System.Windows.Forms.Button btn_SearchPayCond;
        private System.Windows.Forms.TextBox edt_payCondition;
        private System.Windows.Forms.RadioButton rbtn_CancelledStatus;
        private System.Windows.Forms.RadioButton rbtn_ActiveStatus;
        private System.Windows.Forms.DateTimePicker dateTime_DateFilter;
        private System.Windows.Forms.Button btn_ClearSaleFilters;
        private System.Windows.Forms.Label lbl_payCondition;
        private System.Windows.Forms.GroupBox gbox_clientFilters;
        private System.Windows.Forms.Button btn_ClearClientFilters;
        private System.Windows.Forms.RadioButton rbtn_Natural;
        private System.Windows.Forms.RadioButton rbtn_LegalClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePayCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleProdQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleStatus;
        private System.Windows.Forms.Button btn_SelectClient;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.NumericUpDown edt_UserId;
        private System.Windows.Forms.Label lbl_ClientId;
        private System.Windows.Forms.NumericUpDown edt_clientId;
    }
}