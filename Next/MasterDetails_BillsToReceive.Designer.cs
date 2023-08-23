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
            this.btn_resetClients = new System.Windows.Forms.Button();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            this.btn_searchClient = new System.Windows.Forms.Button();
            this.DGV_BillsToReceive = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNumberBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethodBillsToReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValueBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmissionDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_billsToReceive = new System.Windows.Forms.GroupBox();
            this.btn_ClearDateSort = new System.Windows.Forms.Button();
            this.lbl_dueDate = new System.Windows.Forms.Label();
            this.lbl_emissionDate = new System.Windows.Forms.Label();
            this.dueDate_bills = new System.Windows.Forms.DateTimePicker();
            this.emissionDate_bills = new System.Windows.Forms.DateTimePicker();
            this.lbl_saleNumber = new System.Windows.Forms.Label();
            this.edt_saleNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbox_clientFilters = new System.Windows.Forms.GroupBox();
            this.rbtn_Natural = new System.Windows.Forms.RadioButton();
            this.rbtn_LegalClients = new System.Windows.Forms.RadioButton();
            this.btn_ClearClientFilters = new System.Windows.Forms.Button();
            this.gbox_SaleFilters = new System.Windows.Forms.GroupBox();
            this.rbtn_onHold = new System.Windows.Forms.RadioButton();
            this.btn_ClearSaleFilters = new System.Windows.Forms.Button();
            this.rbtn_PaidStatus = new System.Windows.Forms.RadioButton();
            this.rbtn_ActiveStatus = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            this.gbox_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).BeginInit();
            this.gbox_billsToReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).BeginInit();
            this.gbox_clientFilters.SuspendLayout();
            this.gbox_SaleFilters.SuspendLayout();
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
            this.DGV_Clients.RowHeadersVisible = false;
            this.DGV_Clients.RowHeadersWidth = 51;
            this.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Clients.Size = new System.Drawing.Size(725, 171);
            this.DGV_Clients.TabIndex = 0;
            this.DGV_Clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Clients_CellContentClick);
            this.DGV_Clients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Clients_CellContentDoubleClick);
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "ID";
            this.IdClient.MinimumWidth = 6;
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            this.IdClient.Width = 55;
            // 
            // NameClient
            // 
            this.NameClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameClient.HeaderText = "Cliente";
            this.NameClient.MinimumWidth = 6;
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            // 
            // RegNumberClient
            // 
            this.RegNumberClient.HeaderText = "Registro";
            this.RegNumberClient.MinimumWidth = 6;
            this.RegNumberClient.Name = "RegNumberClient";
            this.RegNumberClient.ReadOnly = true;
            this.RegNumberClient.Width = 125;
            // 
            // TypeClient
            // 
            this.TypeClient.HeaderText = "Tipo";
            this.TypeClient.MinimumWidth = 6;
            this.TypeClient.Name = "TypeClient";
            this.TypeClient.ReadOnly = true;
            this.TypeClient.Width = 80;
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
            this.lbl_clientName.Text = "Nome";
            // 
            // gbox_client
            // 
            this.gbox_client.Controls.Add(this.btn_resetClients);
            this.gbox_client.Controls.Add(this.edt_clientId);
            this.gbox_client.Controls.Add(this.btn_searchClient);
            this.gbox_client.Controls.Add(this.edt_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientId);
            this.gbox_client.Controls.Add(this.DGV_Clients);
            this.gbox_client.Controls.Add(this.lbl_clientName);
            this.gbox_client.Location = new System.Drawing.Point(12, 12);
            this.gbox_client.Name = "gbox_client";
            this.gbox_client.Size = new System.Drawing.Size(740, 233);
            this.gbox_client.TabIndex = 5;
            this.gbox_client.TabStop = false;
            this.gbox_client.Text = "Clientes";
            // 
            // btn_resetClients
            // 
            this.btn_resetClients.Location = new System.Drawing.Point(337, 29);
            this.btn_resetClients.Name = "btn_resetClients";
            this.btn_resetClients.Size = new System.Drawing.Size(56, 21);
            this.btn_resetClients.TabIndex = 15;
            this.btn_resetClients.Text = "Limpar";
            this.btn_resetClients.UseVisualStyleBackColor = true;
            this.btn_resetClients.Click += new System.EventHandler(this.btn_resetClients_Click);
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
            this.btn_searchClient.Text = "Bu&scar";
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
            this.ClientName,
            this.SaleNumberBillsReceive,
            this.PaymentMethodBillsToReceive,
            this.InstalmentNumber,
            this.TotalValueBillsReceive,
            this.EmissionDateBillsReceive,
            this.DueDateBillsReceive,
            this.StatusBillsReceive});
            this.DGV_BillsToReceive.Location = new System.Drawing.Point(9, 66);
            this.DGV_BillsToReceive.MultiSelect = false;
            this.DGV_BillsToReceive.Name = "DGV_BillsToReceive";
            this.DGV_BillsToReceive.ReadOnly = true;
            this.DGV_BillsToReceive.RowHeadersVisible = false;
            this.DGV_BillsToReceive.RowHeadersWidth = 51;
            this.DGV_BillsToReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToReceive.Size = new System.Drawing.Size(1126, 276);
            this.DGV_BillsToReceive.TabIndex = 7;
            this.DGV_BillsToReceive.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_BillsToReceive_CellContentDoubleClick);
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Cliente";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // SaleNumberBillsReceive
            // 
            this.SaleNumberBillsReceive.HeaderText = "ID Venda";
            this.SaleNumberBillsReceive.MinimumWidth = 6;
            this.SaleNumberBillsReceive.Name = "SaleNumberBillsReceive";
            this.SaleNumberBillsReceive.ReadOnly = true;
            this.SaleNumberBillsReceive.Width = 55;
            // 
            // PaymentMethodBillsToReceive
            // 
            this.PaymentMethodBillsToReceive.HeaderText = "Método de Pagamento";
            this.PaymentMethodBillsToReceive.MinimumWidth = 6;
            this.PaymentMethodBillsToReceive.Name = "PaymentMethodBillsToReceive";
            this.PaymentMethodBillsToReceive.ReadOnly = true;
            this.PaymentMethodBillsToReceive.Width = 200;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Nº Parcela";
            this.InstalmentNumber.MinimumWidth = 6;
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 75;
            // 
            // TotalValueBillsReceive
            // 
            this.TotalValueBillsReceive.HeaderText = "Valor da Parcela";
            this.TotalValueBillsReceive.MinimumWidth = 6;
            this.TotalValueBillsReceive.Name = "TotalValueBillsReceive";
            this.TotalValueBillsReceive.ReadOnly = true;
            this.TotalValueBillsReceive.Width = 80;
            // 
            // EmissionDateBillsReceive
            // 
            this.EmissionDateBillsReceive.HeaderText = "Data de Emissão";
            this.EmissionDateBillsReceive.MinimumWidth = 6;
            this.EmissionDateBillsReceive.Name = "EmissionDateBillsReceive";
            this.EmissionDateBillsReceive.ReadOnly = true;
            // 
            // DueDateBillsReceive
            // 
            this.DueDateBillsReceive.HeaderText = "Data de Vencimento";
            this.DueDateBillsReceive.MinimumWidth = 6;
            this.DueDateBillsReceive.Name = "DueDateBillsReceive";
            this.DueDateBillsReceive.ReadOnly = true;
            // 
            // StatusBillsReceive
            // 
            this.StatusBillsReceive.HeaderText = "Status";
            this.StatusBillsReceive.MinimumWidth = 6;
            this.StatusBillsReceive.Name = "StatusBillsReceive";
            this.StatusBillsReceive.ReadOnly = true;
            // 
            // gbox_billsToReceive
            // 
            this.gbox_billsToReceive.Controls.Add(this.btn_ClearDateSort);
            this.gbox_billsToReceive.Controls.Add(this.lbl_dueDate);
            this.gbox_billsToReceive.Controls.Add(this.lbl_emissionDate);
            this.gbox_billsToReceive.Controls.Add(this.dueDate_bills);
            this.gbox_billsToReceive.Controls.Add(this.emissionDate_bills);
            this.gbox_billsToReceive.Controls.Add(this.lbl_saleNumber);
            this.gbox_billsToReceive.Controls.Add(this.edt_saleNumber);
            this.gbox_billsToReceive.Controls.Add(this.DGV_BillsToReceive);
            this.gbox_billsToReceive.Location = new System.Drawing.Point(12, 251);
            this.gbox_billsToReceive.Name = "gbox_billsToReceive";
            this.gbox_billsToReceive.Size = new System.Drawing.Size(1141, 348);
            this.gbox_billsToReceive.TabIndex = 9;
            this.gbox_billsToReceive.TabStop = false;
            this.gbox_billsToReceive.Text = "Contas à Receber";
            // 
            // btn_ClearDateSort
            // 
            this.btn_ClearDateSort.Location = new System.Drawing.Point(338, 40);
            this.btn_ClearDateSort.Name = "btn_ClearDateSort";
            this.btn_ClearDateSort.Size = new System.Drawing.Size(44, 20);
            this.btn_ClearDateSort.TabIndex = 14;
            this.btn_ClearDateSort.Text = "Limpar";
            this.btn_ClearDateSort.UseVisualStyleBackColor = true;
            this.btn_ClearDateSort.Click += new System.EventHandler(this.btn_ClearDateSort_Click);
            // 
            // lbl_dueDate
            // 
            this.lbl_dueDate.AutoSize = true;
            this.lbl_dueDate.Location = new System.Drawing.Point(230, 24);
            this.lbl_dueDate.Name = "lbl_dueDate";
            this.lbl_dueDate.Size = new System.Drawing.Size(104, 13);
            this.lbl_dueDate.TabIndex = 13;
            this.lbl_dueDate.Text = "Data de Vencimento";
            // 
            // lbl_emissionDate
            // 
            this.lbl_emissionDate.AutoSize = true;
            this.lbl_emissionDate.Location = new System.Drawing.Point(128, 24);
            this.lbl_emissionDate.Name = "lbl_emissionDate";
            this.lbl_emissionDate.Size = new System.Drawing.Size(87, 13);
            this.lbl_emissionDate.TabIndex = 12;
            this.lbl_emissionDate.Text = "Data de Emissão";
            // 
            // dueDate_bills
            // 
            this.dueDate_bills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDate_bills.Location = new System.Drawing.Point(233, 40);
            this.dueDate_bills.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dueDate_bills.Name = "dueDate_bills";
            this.dueDate_bills.Size = new System.Drawing.Size(99, 20);
            this.dueDate_bills.TabIndex = 11;
            this.dueDate_bills.Value = new System.DateTime(2000, 1, 1, 19, 6, 0, 0);
            this.dueDate_bills.ValueChanged += new System.EventHandler(this.dueDate_bills_ValueChanged);
            // 
            // emissionDate_bills
            // 
            this.emissionDate_bills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissionDate_bills.Location = new System.Drawing.Point(131, 40);
            this.emissionDate_bills.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.emissionDate_bills.Name = "emissionDate_bills";
            this.emissionDate_bills.Size = new System.Drawing.Size(96, 20);
            this.emissionDate_bills.TabIndex = 10;
            this.emissionDate_bills.Value = new System.DateTime(2000, 1, 1, 19, 6, 0, 0);
            this.emissionDate_bills.ValueChanged += new System.EventHandler(this.emissionDate_bills_ValueChanged);
            // 
            // lbl_saleNumber
            // 
            this.lbl_saleNumber.AutoSize = true;
            this.lbl_saleNumber.Location = new System.Drawing.Point(6, 24);
            this.lbl_saleNumber.Name = "lbl_saleNumber";
            this.lbl_saleNumber.Size = new System.Drawing.Size(67, 13);
            this.lbl_saleNumber.TabIndex = 9;
            this.lbl_saleNumber.Text = "ID da Venda";
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
            this.edt_saleNumber.ValueChanged += new System.EventHandler(this.edt_saleNumber_ValueChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1078, 605);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gbox_clientFilters
            // 
            this.gbox_clientFilters.Controls.Add(this.rbtn_Natural);
            this.gbox_clientFilters.Controls.Add(this.rbtn_LegalClients);
            this.gbox_clientFilters.Controls.Add(this.btn_ClearClientFilters);
            this.gbox_clientFilters.Location = new System.Drawing.Point(758, 40);
            this.gbox_clientFilters.Name = "gbox_clientFilters";
            this.gbox_clientFilters.Size = new System.Drawing.Size(136, 74);
            this.gbox_clientFilters.TabIndex = 13;
            this.gbox_clientFilters.TabStop = false;
            this.gbox_clientFilters.Text = "Filtro de Clientes";
            // 
            // rbtn_Natural
            // 
            this.rbtn_Natural.AutoSize = true;
            this.rbtn_Natural.Location = new System.Drawing.Point(6, 45);
            this.rbtn_Natural.Name = "rbtn_Natural";
            this.rbtn_Natural.Size = new System.Drawing.Size(54, 17);
            this.rbtn_Natural.TabIndex = 9;
            this.rbtn_Natural.TabStop = true;
            this.rbtn_Natural.Text = "Físico";
            this.rbtn_Natural.UseVisualStyleBackColor = true;
            this.rbtn_Natural.CheckedChanged += new System.EventHandler(this.rbtn_Natural_CheckedChanged);
            // 
            // rbtn_LegalClients
            // 
            this.rbtn_LegalClients.AutoSize = true;
            this.rbtn_LegalClients.Location = new System.Drawing.Point(6, 22);
            this.rbtn_LegalClients.Name = "rbtn_LegalClients";
            this.rbtn_LegalClients.Size = new System.Drawing.Size(63, 17);
            this.rbtn_LegalClients.TabIndex = 8;
            this.rbtn_LegalClients.TabStop = true;
            this.rbtn_LegalClients.Text = "Jurídico";
            this.rbtn_LegalClients.UseVisualStyleBackColor = true;
            this.rbtn_LegalClients.CheckedChanged += new System.EventHandler(this.rbtn_LegalClients_CheckedChanged);
            // 
            // btn_ClearClientFilters
            // 
            this.btn_ClearClientFilters.Location = new System.Drawing.Point(73, 45);
            this.btn_ClearClientFilters.Name = "btn_ClearClientFilters";
            this.btn_ClearClientFilters.Size = new System.Drawing.Size(57, 23);
            this.btn_ClearClientFilters.TabIndex = 7;
            this.btn_ClearClientFilters.Text = "Limpar";
            this.btn_ClearClientFilters.UseVisualStyleBackColor = true;
            this.btn_ClearClientFilters.Click += new System.EventHandler(this.btn_ClearClientFilters_Click);
            // 
            // gbox_SaleFilters
            // 
            this.gbox_SaleFilters.Controls.Add(this.rbtn_onHold);
            this.gbox_SaleFilters.Controls.Add(this.btn_ClearSaleFilters);
            this.gbox_SaleFilters.Controls.Add(this.rbtn_PaidStatus);
            this.gbox_SaleFilters.Controls.Add(this.rbtn_ActiveStatus);
            this.gbox_SaleFilters.Location = new System.Drawing.Point(758, 177);
            this.gbox_SaleFilters.Name = "gbox_SaleFilters";
            this.gbox_SaleFilters.Size = new System.Drawing.Size(214, 68);
            this.gbox_SaleFilters.TabIndex = 14;
            this.gbox_SaleFilters.TabStop = false;
            this.gbox_SaleFilters.Text = "Filtro de Contas à Receber";
            // 
            // rbtn_onHold
            // 
            this.rbtn_onHold.AutoSize = true;
            this.rbtn_onHold.Location = new System.Drawing.Point(67, 45);
            this.rbtn_onHold.Name = "rbtn_onHold";
            this.rbtn_onHold.Size = new System.Drawing.Size(76, 17);
            this.rbtn_onHold.TabIndex = 7;
            this.rbtn_onHold.TabStop = true;
            this.rbtn_onHold.Text = "Em Espera";
            this.rbtn_onHold.UseVisualStyleBackColor = true;
            this.rbtn_onHold.CheckedChanged += new System.EventHandler(this.rbtn_onHold_CheckedChanged);
            // 
            // btn_ClearSaleFilters
            // 
            this.btn_ClearSaleFilters.Location = new System.Drawing.Point(151, 16);
            this.btn_ClearSaleFilters.Name = "btn_ClearSaleFilters";
            this.btn_ClearSaleFilters.Size = new System.Drawing.Size(57, 23);
            this.btn_ClearSaleFilters.TabIndex = 6;
            this.btn_ClearSaleFilters.Text = "Limpar";
            this.btn_ClearSaleFilters.UseVisualStyleBackColor = true;
            this.btn_ClearSaleFilters.Click += new System.EventHandler(this.btn_ClearSaleFilters_Click);
            // 
            // rbtn_PaidStatus
            // 
            this.rbtn_PaidStatus.AutoSize = true;
            this.rbtn_PaidStatus.Location = new System.Drawing.Point(6, 45);
            this.rbtn_PaidStatus.Name = "rbtn_PaidStatus";
            this.rbtn_PaidStatus.Size = new System.Drawing.Size(50, 17);
            this.rbtn_PaidStatus.TabIndex = 2;
            this.rbtn_PaidStatus.TabStop = true;
            this.rbtn_PaidStatus.Text = "Pago";
            this.rbtn_PaidStatus.UseVisualStyleBackColor = true;
            this.rbtn_PaidStatus.CheckedChanged += new System.EventHandler(this.rbtn_PaidStatus_CheckedChanged);
            // 
            // rbtn_ActiveStatus
            // 
            this.rbtn_ActiveStatus.AutoSize = true;
            this.rbtn_ActiveStatus.Location = new System.Drawing.Point(6, 22);
            this.rbtn_ActiveStatus.Name = "rbtn_ActiveStatus";
            this.rbtn_ActiveStatus.Size = new System.Drawing.Size(49, 17);
            this.rbtn_ActiveStatus.TabIndex = 1;
            this.rbtn_ActiveStatus.TabStop = true;
            this.rbtn_ActiveStatus.Text = "Ativo";
            this.rbtn_ActiveStatus.UseVisualStyleBackColor = true;
            this.rbtn_ActiveStatus.CheckedChanged += new System.EventHandler(this.rbtn_ActiveStatus_CheckedChanged);
            // 
            // MasterDetails_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 640);
            this.Controls.Add(this.gbox_SaleFilters);
            this.Controls.Add(this.gbox_clientFilters);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gbox_billsToReceive);
            this.Controls.Add(this.gbox_client);
            this.Name = "MasterDetails_BillsToReceive";
            this.Text = "Clientes - Contas à Receber";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).EndInit();
            this.gbox_billsToReceive.ResumeLayout(false);
            this.gbox_billsToReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).EndInit();
            this.gbox_clientFilters.ResumeLayout(false);
            this.gbox_clientFilters.PerformLayout();
            this.gbox_SaleFilters.ResumeLayout(false);
            this.gbox_SaleFilters.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbox_billsToReceive;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NumericUpDown edt_clientId;
        private System.Windows.Forms.NumericUpDown edt_saleNumber;
        private System.Windows.Forms.Label lbl_saleNumber;
        private System.Windows.Forms.Label lbl_dueDate;
        private System.Windows.Forms.Label lbl_emissionDate;
        private System.Windows.Forms.DateTimePicker dueDate_bills;
        private System.Windows.Forms.DateTimePicker emissionDate_bills;
        private System.Windows.Forms.Button btn_ClearDateSort;
        private System.Windows.Forms.Button btn_resetClients;
        private System.Windows.Forms.GroupBox gbox_clientFilters;
        private System.Windows.Forms.RadioButton rbtn_Natural;
        private System.Windows.Forms.RadioButton rbtn_LegalClients;
        private System.Windows.Forms.Button btn_ClearClientFilters;
        private System.Windows.Forms.GroupBox gbox_SaleFilters;
        private System.Windows.Forms.Button btn_ClearSaleFilters;
        private System.Windows.Forms.RadioButton rbtn_PaidStatus;
        private System.Windows.Forms.RadioButton rbtn_ActiveStatus;
        private System.Windows.Forms.RadioButton rbtn_onHold;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNumberClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumberBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethodBillsToReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValueBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmissionDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusBillsReceive;
    }
}