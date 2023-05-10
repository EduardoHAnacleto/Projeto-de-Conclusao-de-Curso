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
            this.SaleNumberBillReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayConditionBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValueBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            this.gbox_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).BeginInit();
            this.gbox_billsToReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).BeginInit();
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
            this.DGV_Clients.Size = new System.Drawing.Size(725, 171);
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
            this.lbl_clientName.Text = "Name";
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
            this.gbox_client.Text = "Client";
            // 
            // btn_resetClients
            // 
            this.btn_resetClients.Location = new System.Drawing.Point(337, 29);
            this.btn_resetClients.Name = "btn_resetClients";
            this.btn_resetClients.Size = new System.Drawing.Size(44, 20);
            this.btn_resetClients.TabIndex = 15;
            this.btn_resetClients.Text = "Reset";
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
            this.ClientName,
            this.SaleNumberBillReceive,
            this.PayConditionBillsReceive,
            this.InstalmentNumber,
            this.TotalValueBillsReceive,
            this.PaymentMethod,
            this.EmissionDateBillsReceive,
            this.DueDateBillsReceive,
            this.StatusBillsReceive});
            this.DGV_BillsToReceive.Location = new System.Drawing.Point(9, 66);
            this.DGV_BillsToReceive.MultiSelect = false;
            this.DGV_BillsToReceive.Name = "DGV_BillsToReceive";
            this.DGV_BillsToReceive.ReadOnly = true;
            this.DGV_BillsToReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToReceive.Size = new System.Drawing.Size(1126, 276);
            this.DGV_BillsToReceive.TabIndex = 7;
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
            this.SaleNumberBillReceive.HeaderText = "Sale ID";
            this.SaleNumberBillReceive.Name = "SaleNumberBillReceive";
            this.SaleNumberBillReceive.ReadOnly = true;
            this.SaleNumberBillReceive.Width = 55;
            // 
            // PayConditionBillsReceive
            // 
            this.PayConditionBillsReceive.HeaderText = "Payment Condition";
            this.PayConditionBillsReceive.Name = "PayConditionBillsReceive";
            this.PayConditionBillsReceive.ReadOnly = true;
            this.PayConditionBillsReceive.Width = 125;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Instalment Number";
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 60;
            // 
            // TotalValueBillsReceive
            // 
            this.TotalValueBillsReceive.HeaderText = "Instalment Value";
            this.TotalValueBillsReceive.Name = "TotalValueBillsReceive";
            this.TotalValueBillsReceive.ReadOnly = true;
            this.TotalValueBillsReceive.Width = 70;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "PaymentMethod";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Width = 120;
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
            this.gbox_billsToReceive.Text = "Bills To Receive";
            // 
            // btn_ClearDateSort
            // 
            this.btn_ClearDateSort.Location = new System.Drawing.Point(338, 40);
            this.btn_ClearDateSort.Name = "btn_ClearDateSort";
            this.btn_ClearDateSort.Size = new System.Drawing.Size(44, 20);
            this.btn_ClearDateSort.TabIndex = 14;
            this.btn_ClearDateSort.Text = "Reset";
            this.btn_ClearDateSort.UseVisualStyleBackColor = true;
            this.btn_ClearDateSort.Click += new System.EventHandler(this.btn_ClearDateSort_Click);
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
            this.dueDate_bills.Value = new System.DateTime(2000, 1, 1, 19, 6, 0, 0);
            this.dueDate_bills.ValueChanged += new System.EventHandler(this.dueDate_bills_ValueChanged);
            // 
            // emissionDate_bills
            // 
            this.emissionDate_bills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissionDate_bills.Location = new System.Drawing.Point(131, 40);
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
            this.btn_exit.Location = new System.Drawing.Point(1078, 605);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // MasterDetails_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 640);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gbox_billsToReceive);
            this.Controls.Add(this.gbox_client);
            this.Name = "MasterDetails_BillsToReceive";
            this.Text = "Bills to Receive";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).EndInit();
            this.gbox_billsToReceive.ResumeLayout(false);
            this.gbox_billsToReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumberBillReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayConditionBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValueBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmissionDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNumberClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeClient;
        private System.Windows.Forms.Button btn_ClearDateSort;
        private System.Windows.Forms.Button btn_resetClients;
    }
}