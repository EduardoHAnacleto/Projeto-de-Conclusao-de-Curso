namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    partial class MasterDetails_BillsToReceive
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
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNumberClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.gbox_client = new System.Windows.Forms.GroupBox();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            this.btn_searchClient = new System.Windows.Forms.Button();
            this.DGV_BillsToReceive = new System.Windows.Forms.DataGridView();
            this.IDBillReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNumberBillReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValueBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayConditionBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmissionDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_orderBy = new System.Windows.Forms.GroupBox();
            this.rbtn_billsDescending = new System.Windows.Forms.RadioButton();
            this.rbtn_billsAscending = new System.Windows.Forms.RadioButton();
            this.check_paidOff = new System.Windows.Forms.CheckBox();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.check_dueDate = new System.Windows.Forms.CheckBox();
            this.btn_ClearOrder = new System.Windows.Forms.Button();
            this.check_value = new System.Windows.Forms.CheckBox();
            this.check_emissionDate = new System.Windows.Forms.CheckBox();
            this.gbox_billsToReceive = new System.Windows.Forms.GroupBox();
            this.lbl_dueDate = new System.Windows.Forms.Label();
            this.lbl_emissionDate = new System.Windows.Forms.Label();
            this.dueDate_bills = new System.Windows.Forms.DateTimePicker();
            this.emissionDate_bills = new System.Windows.Forms.DateTimePicker();
            this.lbl_saleNumber = new System.Windows.Forms.Label();
            this.edt_saleNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbox_orderClientsBy = new System.Windows.Forms.GroupBox();
            this.rbtn_clientDescending = new System.Windows.Forms.RadioButton();
            this.rbtn_clientAscending = new System.Windows.Forms.RadioButton();
            this.check_clientType = new System.Windows.Forms.CheckBox();
            this.check_clientName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            this.gbox_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).BeginInit();
            this.gbox_orderBy.SuspendLayout();
            this.gbox_billsToReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).BeginInit();
            this.gbox_orderClientsBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Clients
            // 
            this.DGV_Clients.AllowUserToAddRows = false;
            this.DGV_Clients.AllowUserToDeleteRows = false;
            this.DGV_Clients.AllowUserToResizeColumns = false;
            this.DGV_Clients.AllowUserToResizeRows = false;
            this.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClient,
            this.NameClient,
            this.RegNumberClient,
            this.TypeClient});
            this.DGV_Clients.Location = new System.Drawing.Point(9, 56);
            this.DGV_Clients.MultiSelect = false;
            this.DGV_Clients.Name = "DGV_Clients";
            this.DGV_Clients.ReadOnly = true;
            this.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Clients.Size = new System.Drawing.Size(540, 143);
            this.DGV_Clients.TabIndex = 0;
            this.DGV_Clients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Clients_CellContentDoubleClick);
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "ID";
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            this.IdClient.Width = 55;
            // 
            // NameClient
            // 
            this.NameClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameClient.HeaderText = "Client";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            // 
            // RegNumberClient
            // 
            this.RegNumberClient.HeaderText = "Registration Number";
            this.RegNumberClient.Name = "RegNumberClient";
            this.RegNumberClient.ReadOnly = true;
            // 
            // TypeClient
            // 
            this.TypeClient.HeaderText = "Type";
            this.TypeClient.Name = "TypeClient";
            this.TypeClient.ReadOnly = true;
            this.TypeClient.Width = 75;
            // 
            // edt_clientName
            // 
            this.edt_clientName.Location = new System.Drawing.Point(56, 29);
            this.edt_clientName.MaxLength = 30;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(194, 20);
            this.edt_clientName.TabIndex = 2;
            this.edt_clientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_clientName_KeyPress);
            // 
            // lbl_clientId
            // 
            this.lbl_clientId.AutoSize = true;
            this.lbl_clientId.Location = new System.Drawing.Point(6, 14);
            this.lbl_clientId.Name = "lbl_clientId";
            this.lbl_clientId.Size = new System.Drawing.Size(18, 13);
            this.lbl_clientId.TabIndex = 1;
            this.lbl_clientId.Text = "ID";
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(53, 13);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(35, 13);
            this.lbl_clientName.TabIndex = 4;
            this.lbl_clientName.Text = "Name";
            // 
            // gbox_client
            // 
            this.gbox_client.Controls.Add(this.edt_clientId);
            this.gbox_client.Controls.Add(this.btn_searchClient);
            this.gbox_client.Controls.Add(this.edt_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientId);
            this.gbox_client.Controls.Add(this.DGV_Clients);
            this.gbox_client.Controls.Add(this.lbl_clientName);
            this.gbox_client.Location = new System.Drawing.Point(12, 12);
            this.gbox_client.Name = "gbox_client";
            this.gbox_client.Size = new System.Drawing.Size(561, 208);
            this.gbox_client.TabIndex = 5;
            this.gbox_client.TabStop = false;
            this.gbox_client.Text = "Client";
            // 
            // edt_clientId
            // 
            this.edt_clientId.Location = new System.Drawing.Point(9, 29);
            this.edt_clientId.Name = "edt_clientId";
            this.edt_clientId.Size = new System.Drawing.Size(44, 20);
            this.edt_clientId.TabIndex = 6;
            // 
            // btn_searchClient
            // 
            this.btn_searchClient.Location = new System.Drawing.Point(256, 28);
            this.btn_searchClient.Name = "btn_searchClient";
            this.btn_searchClient.Size = new System.Drawing.Size(75, 21);
            this.btn_searchClient.TabIndex = 5;
            this.btn_searchClient.Text = "Search";
            this.btn_searchClient.UseVisualStyleBackColor = true;
            this.btn_searchClient.Click += new System.EventHandler(this.btn_searchClient_Click);
            // 
            // DGV_BillsToReceive
            // 
            this.DGV_BillsToReceive.AllowUserToAddRows = false;
            this.DGV_BillsToReceive.AllowUserToDeleteRows = false;
            this.DGV_BillsToReceive.AllowUserToResizeRows = false;
            this.DGV_BillsToReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BillsToReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBillReceive,
            this.ClientName,
            this.SaleNumberBillReceive,
            this.TotalValueBillsReceive,
            this.PayConditionBillsReceive,
            this.EmissionDateBillsReceive,
            this.DueDateBillsReceive,
            this.StatusBillsReceive});
            this.DGV_BillsToReceive.Location = new System.Drawing.Point(9, 66);
            this.DGV_BillsToReceive.MultiSelect = false;
            this.DGV_BillsToReceive.Name = "DGV_BillsToReceive";
            this.DGV_BillsToReceive.ReadOnly = true;
            this.DGV_BillsToReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToReceive.Size = new System.Drawing.Size(796, 251);
            this.DGV_BillsToReceive.TabIndex = 7;
            // 
            // IDBillReceive
            // 
            this.IDBillReceive.HeaderText = "ID";
            this.IDBillReceive.Name = "IDBillReceive";
            this.IDBillReceive.ReadOnly = true;
            this.IDBillReceive.Width = 55;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Client";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // SaleNumberBillReceive
            // 
            this.SaleNumberBillReceive.HeaderText = "Sale Number";
            this.SaleNumberBillReceive.Name = "SaleNumberBillReceive";
            this.SaleNumberBillReceive.ReadOnly = true;
            this.SaleNumberBillReceive.Width = 65;
            // 
            // TotalValueBillsReceive
            // 
            this.TotalValueBillsReceive.HeaderText = "Value";
            this.TotalValueBillsReceive.Name = "TotalValueBillsReceive";
            this.TotalValueBillsReceive.ReadOnly = true;
            this.TotalValueBillsReceive.Width = 50;
            // 
            // PayConditionBillsReceive
            // 
            this.PayConditionBillsReceive.HeaderText = "Payment Condition";
            this.PayConditionBillsReceive.Name = "PayConditionBillsReceive";
            this.PayConditionBillsReceive.ReadOnly = true;
            this.PayConditionBillsReceive.Width = 125;
            // 
            // EmissionDateBillsReceive
            // 
            this.EmissionDateBillsReceive.HeaderText = "Emission Date";
            this.EmissionDateBillsReceive.Name = "EmissionDateBillsReceive";
            this.EmissionDateBillsReceive.ReadOnly = true;
            this.EmissionDateBillsReceive.Width = 65;
            // 
            // DueDateBillsReceive
            // 
            this.DueDateBillsReceive.HeaderText = "Due Date";
            this.DueDateBillsReceive.Name = "DueDateBillsReceive";
            this.DueDateBillsReceive.ReadOnly = true;
            this.DueDateBillsReceive.Width = 65;
            // 
            // StatusBillsReceive
            // 
            this.StatusBillsReceive.HeaderText = "Status";
            this.StatusBillsReceive.Name = "StatusBillsReceive";
            this.StatusBillsReceive.ReadOnly = true;
            this.StatusBillsReceive.Width = 60;
            // 
            // gbox_orderBy
            // 
            this.gbox_orderBy.Controls.Add(this.rbtn_billsDescending);
            this.gbox_orderBy.Controls.Add(this.rbtn_billsAscending);
            this.gbox_orderBy.Controls.Add(this.check_paidOff);
            this.gbox_orderBy.Controls.Add(this.check_Active);
            this.gbox_orderBy.Controls.Add(this.check_dueDate);
            this.gbox_orderBy.Controls.Add(this.btn_ClearOrder);
            this.gbox_orderBy.Controls.Add(this.check_value);
            this.gbox_orderBy.Controls.Add(this.check_emissionDate);
            this.gbox_orderBy.Location = new System.Drawing.Point(579, 87);
            this.gbox_orderBy.Name = "gbox_orderBy";
            this.gbox_orderBy.Size = new System.Drawing.Size(205, 132);
            this.gbox_orderBy.TabIndex = 8;
            this.gbox_orderBy.TabStop = false;
            this.gbox_orderBy.Text = "Select Bills by";
            // 
            // rbtn_billsDescending
            // 
            this.rbtn_billsDescending.AutoSize = true;
            this.rbtn_billsDescending.Location = new System.Drawing.Point(121, 41);
            this.rbtn_billsDescending.Name = "rbtn_billsDescending";
            this.rbtn_billsDescending.Size = new System.Drawing.Size(82, 17);
            this.rbtn_billsDescending.TabIndex = 7;
            this.rbtn_billsDescending.TabStop = true;
            this.rbtn_billsDescending.Text = "Descending";
            this.rbtn_billsDescending.UseVisualStyleBackColor = true;
            // 
            // rbtn_billsAscending
            // 
            this.rbtn_billsAscending.AutoSize = true;
            this.rbtn_billsAscending.Location = new System.Drawing.Point(121, 18);
            this.rbtn_billsAscending.Name = "rbtn_billsAscending";
            this.rbtn_billsAscending.Size = new System.Drawing.Size(75, 17);
            this.rbtn_billsAscending.TabIndex = 6;
            this.rbtn_billsAscending.TabStop = true;
            this.rbtn_billsAscending.Text = "Ascending";
            this.rbtn_billsAscending.UseVisualStyleBackColor = true;
            // 
            // check_paidOff
            // 
            this.check_paidOff.AutoSize = true;
            this.check_paidOff.Location = new System.Drawing.Point(6, 111);
            this.check_paidOff.Name = "check_paidOff";
            this.check_paidOff.Size = new System.Drawing.Size(64, 17);
            this.check_paidOff.TabIndex = 5;
            this.check_paidOff.Text = "Paid Off";
            this.check_paidOff.UseVisualStyleBackColor = true;
            this.check_paidOff.CheckedChanged += new System.EventHandler(this.check_paidOff_CheckedChanged);
            // 
            // check_Active
            // 
            this.check_Active.AutoSize = true;
            this.check_Active.Location = new System.Drawing.Point(6, 88);
            this.check_Active.Name = "check_Active";
            this.check_Active.Size = new System.Drawing.Size(56, 17);
            this.check_Active.TabIndex = 4;
            this.check_Active.Text = "Active";
            this.check_Active.UseVisualStyleBackColor = true;
            this.check_Active.CheckedChanged += new System.EventHandler(this.check_Active_CheckedChanged);
            // 
            // check_dueDate
            // 
            this.check_dueDate.AutoSize = true;
            this.check_dueDate.Location = new System.Drawing.Point(6, 65);
            this.check_dueDate.Name = "check_dueDate";
            this.check_dueDate.Size = new System.Drawing.Size(72, 17);
            this.check_dueDate.TabIndex = 3;
            this.check_dueDate.Text = "Due Date";
            this.check_dueDate.UseVisualStyleBackColor = true;
            this.check_dueDate.CheckedChanged += new System.EventHandler(this.check_dueDate_CheckedChanged);
            // 
            // btn_ClearOrder
            // 
            this.btn_ClearOrder.Location = new System.Drawing.Point(141, 103);
            this.btn_ClearOrder.Name = "btn_ClearOrder";
            this.btn_ClearOrder.Size = new System.Drawing.Size(48, 23);
            this.btn_ClearOrder.TabIndex = 2;
            this.btn_ClearOrder.Text = "Clear";
            this.btn_ClearOrder.UseVisualStyleBackColor = true;
            this.btn_ClearOrder.Click += new System.EventHandler(this.btn_ClearOrder_Click);
            // 
            // check_value
            // 
            this.check_value.AutoSize = true;
            this.check_value.Location = new System.Drawing.Point(6, 42);
            this.check_value.Name = "check_value";
            this.check_value.Size = new System.Drawing.Size(53, 17);
            this.check_value.TabIndex = 1;
            this.check_value.Text = "Value";
            this.check_value.UseVisualStyleBackColor = true;
            this.check_value.CheckedChanged += new System.EventHandler(this.check_value_CheckedChanged);
            // 
            // check_emissionDate
            // 
            this.check_emissionDate.AutoSize = true;
            this.check_emissionDate.Location = new System.Drawing.Point(6, 19);
            this.check_emissionDate.Name = "check_emissionDate";
            this.check_emissionDate.Size = new System.Drawing.Size(93, 17);
            this.check_emissionDate.TabIndex = 0;
            this.check_emissionDate.Text = "Emission Date";
            this.check_emissionDate.UseVisualStyleBackColor = true;
            this.check_emissionDate.CheckedChanged += new System.EventHandler(this.check_emissionDate_CheckedChanged);
            // 
            // gbox_billsToReceive
            // 
            this.gbox_billsToReceive.Controls.Add(this.lbl_dueDate);
            this.gbox_billsToReceive.Controls.Add(this.lbl_emissionDate);
            this.gbox_billsToReceive.Controls.Add(this.dueDate_bills);
            this.gbox_billsToReceive.Controls.Add(this.emissionDate_bills);
            this.gbox_billsToReceive.Controls.Add(this.lbl_saleNumber);
            this.gbox_billsToReceive.Controls.Add(this.edt_saleNumber);
            this.gbox_billsToReceive.Controls.Add(this.DGV_BillsToReceive);
            this.gbox_billsToReceive.Location = new System.Drawing.Point(12, 226);
            this.gbox_billsToReceive.Name = "gbox_billsToReceive";
            this.gbox_billsToReceive.Size = new System.Drawing.Size(811, 323);
            this.gbox_billsToReceive.TabIndex = 9;
            this.gbox_billsToReceive.TabStop = false;
            this.gbox_billsToReceive.Text = "Bills To Receive";
            // 
            // lbl_dueDate
            // 
            this.lbl_dueDate.AutoSize = true;
            this.lbl_dueDate.Location = new System.Drawing.Point(230, 24);
            this.lbl_dueDate.Name = "lbl_dueDate";
            this.lbl_dueDate.Size = new System.Drawing.Size(53, 13);
            this.lbl_dueDate.TabIndex = 13;
            this.lbl_dueDate.Text = "Due Date";
            // 
            // lbl_emissionDate
            // 
            this.lbl_emissionDate.AutoSize = true;
            this.lbl_emissionDate.Location = new System.Drawing.Point(128, 24);
            this.lbl_emissionDate.Name = "lbl_emissionDate";
            this.lbl_emissionDate.Size = new System.Drawing.Size(74, 13);
            this.lbl_emissionDate.TabIndex = 12;
            this.lbl_emissionDate.Text = "Emission Date";
            // 
            // dueDate_bills
            // 
            this.dueDate_bills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDate_bills.Location = new System.Drawing.Point(233, 40);
            this.dueDate_bills.Name = "dueDate_bills";
            this.dueDate_bills.Size = new System.Drawing.Size(99, 20);
            this.dueDate_bills.TabIndex = 11;
            this.dueDate_bills.ValueChanged += new System.EventHandler(this.dueDate_bills_ValueChanged);
            // 
            // emissionDate_bills
            // 
            this.emissionDate_bills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissionDate_bills.Location = new System.Drawing.Point(131, 40);
            this.emissionDate_bills.Name = "emissionDate_bills";
            this.emissionDate_bills.Size = new System.Drawing.Size(96, 20);
            this.emissionDate_bills.TabIndex = 10;
            // 
            // lbl_saleNumber
            // 
            this.lbl_saleNumber.AutoSize = true;
            this.lbl_saleNumber.Location = new System.Drawing.Point(6, 24);
            this.lbl_saleNumber.Name = "lbl_saleNumber";
            this.lbl_saleNumber.Size = new System.Drawing.Size(68, 13);
            this.lbl_saleNumber.TabIndex = 9;
            this.lbl_saleNumber.Text = "Sale Number";
            // 
            // edt_saleNumber
            // 
            this.edt_saleNumber.Location = new System.Drawing.Point(9, 40);
            this.edt_saleNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_saleNumber.Name = "edt_saleNumber";
            this.edt_saleNumber.Size = new System.Drawing.Size(99, 20);
            this.edt_saleNumber.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(748, 555);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // gbox_orderClientsBy
            // 
            this.gbox_orderClientsBy.Controls.Add(this.rbtn_clientDescending);
            this.gbox_orderClientsBy.Controls.Add(this.rbtn_clientAscending);
            this.gbox_orderClientsBy.Controls.Add(this.check_clientType);
            this.gbox_orderClientsBy.Controls.Add(this.check_clientName);
            this.gbox_orderClientsBy.Location = new System.Drawing.Point(579, 12);
            this.gbox_orderClientsBy.Name = "gbox_orderClientsBy";
            this.gbox_orderClientsBy.Size = new System.Drawing.Size(172, 69);
            this.gbox_orderClientsBy.TabIndex = 11;
            this.gbox_orderClientsBy.TabStop = false;
            this.gbox_orderClientsBy.Text = "Select Clients by";
            // 
            // rbtn_clientDescending
            // 
            this.rbtn_clientDescending.AutoSize = true;
            this.rbtn_clientDescending.Location = new System.Drawing.Point(81, 43);
            this.rbtn_clientDescending.Name = "rbtn_clientDescending";
            this.rbtn_clientDescending.Size = new System.Drawing.Size(82, 17);
            this.rbtn_clientDescending.TabIndex = 3;
            this.rbtn_clientDescending.Text = "Descending";
            this.rbtn_clientDescending.UseVisualStyleBackColor = true;
            // 
            // rbtn_clientAscending
            // 
            this.rbtn_clientAscending.AutoSize = true;
            this.rbtn_clientAscending.Checked = true;
            this.rbtn_clientAscending.Location = new System.Drawing.Point(81, 20);
            this.rbtn_clientAscending.Name = "rbtn_clientAscending";
            this.rbtn_clientAscending.Size = new System.Drawing.Size(75, 17);
            this.rbtn_clientAscending.TabIndex = 2;
            this.rbtn_clientAscending.TabStop = true;
            this.rbtn_clientAscending.Text = "Ascending";
            this.rbtn_clientAscending.UseVisualStyleBackColor = true;
            // 
            // check_clientType
            // 
            this.check_clientType.AutoSize = true;
            this.check_clientType.Location = new System.Drawing.Point(6, 44);
            this.check_clientType.Name = "check_clientType";
            this.check_clientType.Size = new System.Drawing.Size(50, 17);
            this.check_clientType.TabIndex = 1;
            this.check_clientType.Text = "Type";
            this.check_clientType.UseVisualStyleBackColor = true;
            // 
            // check_clientName
            // 
            this.check_clientName.AutoSize = true;
            this.check_clientName.Location = new System.Drawing.Point(6, 20);
            this.check_clientName.Name = "check_clientName";
            this.check_clientName.Size = new System.Drawing.Size(54, 17);
            this.check_clientName.TabIndex = 0;
            this.check_clientName.Text = "Name";
            this.check_clientName.UseVisualStyleBackColor = true;
            // 
            // MasterDetails_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 601);
            this.Controls.Add(this.gbox_orderClientsBy);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gbox_billsToReceive);
            this.Controls.Add(this.gbox_orderBy);
            this.Controls.Add(this.gbox_client);
            this.Name = "MasterDetails_BillsToReceive";
            this.Text = "Bills to Receive";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).EndInit();
            this.gbox_orderBy.ResumeLayout(false);
            this.gbox_orderBy.PerformLayout();
            this.gbox_billsToReceive.ResumeLayout(false);
            this.gbox_billsToReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).EndInit();
            this.gbox_orderClientsBy.ResumeLayout(false);
            this.gbox_orderClientsBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Clients;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.GroupBox gbox_client;
        private System.Windows.Forms.Button btn_searchClient;
        private System.Windows.Forms.DataGridView DGV_BillsToReceive;
        private System.Windows.Forms.GroupBox gbox_orderBy;
        private System.Windows.Forms.CheckBox check_value;
        private System.Windows.Forms.CheckBox check_emissionDate;
        private System.Windows.Forms.GroupBox gbox_billsToReceive;
        private System.Windows.Forms.Button btn_ClearOrder;
        private System.Windows.Forms.CheckBox check_dueDate;
        private System.Windows.Forms.CheckBox check_paidOff;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNumberClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeClient;
        private System.Windows.Forms.NumericUpDown edt_clientId;
        private System.Windows.Forms.NumericUpDown edt_saleNumber;
        private System.Windows.Forms.Label lbl_saleNumber;
        private System.Windows.Forms.GroupBox gbox_orderClientsBy;
        private System.Windows.Forms.CheckBox check_clientType;
        private System.Windows.Forms.CheckBox check_clientName;
        private System.Windows.Forms.RadioButton rbtn_billsDescending;
        private System.Windows.Forms.RadioButton rbtn_billsAscending;
        private System.Windows.Forms.RadioButton rbtn_clientDescending;
        private System.Windows.Forms.RadioButton rbtn_clientAscending;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBillReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumberBillReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValueBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayConditionBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmissionDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusBillsReceive;
        private System.Windows.Forms.Label lbl_dueDate;
        private System.Windows.Forms.Label lbl_emissionDate;
        private System.Windows.Forms.DateTimePicker dueDate_bills;
        private System.Windows.Forms.DateTimePicker emissionDate_bills;
    }
}