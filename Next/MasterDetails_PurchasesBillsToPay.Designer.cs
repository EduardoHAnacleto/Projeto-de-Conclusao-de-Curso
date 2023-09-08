namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class MasterDetails_PurchasesBillsToPay
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
            this.gbox_purchase = new System.Windows.Forms.GroupBox();
            this.btn_SelectPurchase = new System.Windows.Forms.Button();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.rbtn_cancelled = new System.Windows.Forms.RadioButton();
            this.rbtn_active = new System.Windows.Forms.RadioButton();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.dateTime_filter = new System.Windows.Forms.DateTimePicker();
            this.rbtn_cancelDate = new System.Windows.Forms.RadioButton();
            this.rbtn_DateCreation = new System.Windows.Forms.RadioButton();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.DGV_Purchases = new System.Windows.Forms.DataGridView();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gbox_BillsToPay = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gbox_dueStatus = new System.Windows.Forms.GroupBox();
            this.rbtn_overdue = new System.Windows.Forms.RadioButton();
            this.rbtn_onDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_paidBills = new System.Windows.Forms.RadioButton();
            this.rbtn_cancelledBills = new System.Windows.Forms.RadioButton();
            this.rbtn_activeBill = new System.Windows.Forms.RadioButton();
            this.btn_SelectBill = new System.Windows.Forms.Button();
            this.DGV_BillsToPay = new System.Windows.Forms.DataGridView();
            this.InstalmentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_purchase.SuspendLayout();
            this.gbox_status.SuspendLayout();
            this.gbox_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).BeginInit();
            this.gbox_BillsToPay.SuspendLayout();
            this.gbox_dueStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_purchase
            // 
            this.gbox_purchase.Controls.Add(this.btn_SelectPurchase);
            this.gbox_purchase.Controls.Add(this.gbox_status);
            this.gbox_purchase.Controls.Add(this.gbox_date);
            this.gbox_purchase.Controls.Add(this.lbl_Supplier);
            this.gbox_purchase.Controls.Add(this.btn_Clear);
            this.gbox_purchase.Controls.Add(this.edt_supplierName);
            this.gbox_purchase.Controls.Add(this.DGV_Purchases);
            this.gbox_purchase.Controls.Add(this.btn_Search);
            this.gbox_purchase.Location = new System.Drawing.Point(12, 21);
            this.gbox_purchase.Name = "gbox_purchase";
            this.gbox_purchase.Size = new System.Drawing.Size(1006, 249);
            this.gbox_purchase.TabIndex = 15;
            this.gbox_purchase.TabStop = false;
            this.gbox_purchase.Text = "Compras";
            // 
            // btn_SelectPurchase
            // 
            this.btn_SelectPurchase.Location = new System.Drawing.Point(745, 220);
            this.btn_SelectPurchase.Name = "btn_SelectPurchase";
            this.btn_SelectPurchase.Size = new System.Drawing.Size(104, 23);
            this.btn_SelectPurchase.TabIndex = 18;
            this.btn_SelectPurchase.Text = "Selecionar Compra";
            this.btn_SelectPurchase.UseVisualStyleBackColor = true;
            this.btn_SelectPurchase.Click += new System.EventHandler(this.btn_SelectPurchase_Click);
            // 
            // gbox_status
            // 
            this.gbox_status.Controls.Add(this.rbtn_cancelled);
            this.gbox_status.Controls.Add(this.rbtn_active);
            this.gbox_status.Location = new System.Drawing.Point(908, 10);
            this.gbox_status.Name = "gbox_status";
            this.gbox_status.Size = new System.Drawing.Size(92, 93);
            this.gbox_status.TabIndex = 17;
            this.gbox_status.TabStop = false;
            this.gbox_status.Text = "Status da Compra";
            // 
            // rbtn_cancelled
            // 
            this.rbtn_cancelled.AutoSize = true;
            this.rbtn_cancelled.Location = new System.Drawing.Point(6, 61);
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
            this.rbtn_active.Location = new System.Drawing.Point(6, 38);
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
            this.gbox_date.Location = new System.Drawing.Point(855, 124);
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
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Location = new System.Drawing.Point(6, 20);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(61, 13);
            this.lbl_Supplier.TabIndex = 12;
            this.lbl_Supplier.Text = "Fornecedor";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(911, 220);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(89, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Limpar Filtros";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Enabled = false;
            this.edt_supplierName.Location = new System.Drawing.Point(6, 36);
            this.edt_supplierName.Name = "edt_supplierName";
            this.edt_supplierName.Size = new System.Drawing.Size(236, 20);
            this.edt_supplierName.TabIndex = 11;
            // 
            // DGV_Purchases
            // 
            this.DGV_Purchases.AllowUserToAddRows = false;
            this.DGV_Purchases.AllowUserToDeleteRows = false;
            this.DGV_Purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Purchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillNumber,
            this.BillModel,
            this.BillSeries,
            this.PurchaseSupplierName,
            this.UserId,
            this.PurchaseTotalValue,
            this.PurchaseDateCreation,
            this.PurchaseCancelDate});
            this.DGV_Purchases.Location = new System.Drawing.Point(6, 64);
            this.DGV_Purchases.MultiSelect = false;
            this.DGV_Purchases.Name = "DGV_Purchases";
            this.DGV_Purchases.ReadOnly = true;
            this.DGV_Purchases.RowHeadersVisible = false;
            this.DGV_Purchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Purchases.Size = new System.Drawing.Size(843, 150);
            this.DGV_Purchases.TabIndex = 0;
            this.DGV_Purchases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Purchases_CellClick);
            this.DGV_Purchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Purchases_CellContentClick);
            // 
            // BillNumber
            // 
            this.BillNumber.HeaderText = "Número";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            this.BillNumber.Width = 65;
            // 
            // BillModel
            // 
            this.BillModel.HeaderText = "Modelo";
            this.BillModel.Name = "BillModel";
            this.BillModel.ReadOnly = true;
            this.BillModel.Width = 65;
            // 
            // BillSeries
            // 
            this.BillSeries.HeaderText = "Série";
            this.BillSeries.Name = "BillSeries";
            this.BillSeries.ReadOnly = true;
            this.BillSeries.Width = 65;
            // 
            // PurchaseSupplierName
            // 
            this.PurchaseSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseSupplierName.HeaderText = "Fornecedor";
            this.PurchaseSupplierName.Name = "PurchaseSupplierName";
            this.PurchaseSupplierName.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID Usuário";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 70;
            // 
            // PurchaseTotalValue
            // 
            this.PurchaseTotalValue.HeaderText = "Valor Total";
            this.PurchaseTotalValue.Name = "PurchaseTotalValue";
            this.PurchaseTotalValue.ReadOnly = true;
            // 
            // PurchaseDateCreation
            // 
            this.PurchaseDateCreation.HeaderText = "Data de Emissão";
            this.PurchaseDateCreation.Name = "PurchaseDateCreation";
            this.PurchaseDateCreation.ReadOnly = true;
            this.PurchaseDateCreation.Width = 85;
            // 
            // PurchaseCancelDate
            // 
            this.PurchaseCancelDate.HeaderText = "Cancelamento";
            this.PurchaseCancelDate.Name = "PurchaseCancelDate";
            this.PurchaseCancelDate.ReadOnly = true;
            this.PurchaseCancelDate.Width = 90;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(248, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gbox_BillsToPay
            // 
            this.gbox_BillsToPay.Controls.Add(this.btn_Close);
            this.gbox_BillsToPay.Controls.Add(this.gbox_dueStatus);
            this.gbox_BillsToPay.Controls.Add(this.groupBox1);
            this.gbox_BillsToPay.Controls.Add(this.btn_SelectBill);
            this.gbox_BillsToPay.Controls.Add(this.DGV_BillsToPay);
            this.gbox_BillsToPay.Location = new System.Drawing.Point(12, 291);
            this.gbox_BillsToPay.Name = "gbox_BillsToPay";
            this.gbox_BillsToPay.Size = new System.Drawing.Size(1118, 296);
            this.gbox_BillsToPay.TabIndex = 16;
            this.gbox_BillsToPay.TabStop = false;
            this.gbox_BillsToPay.Text = "Contas a Pagar";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1032, 246);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 22;
            this.btn_Close.Text = "Sair";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gbox_dueStatus
            // 
            this.gbox_dueStatus.Controls.Add(this.rbtn_overdue);
            this.gbox_dueStatus.Controls.Add(this.rbtn_onDate);
            this.gbox_dueStatus.Location = new System.Drawing.Point(1020, 143);
            this.gbox_dueStatus.Name = "gbox_dueStatus";
            this.gbox_dueStatus.Size = new System.Drawing.Size(92, 89);
            this.gbox_dueStatus.TabIndex = 21;
            this.gbox_dueStatus.TabStop = false;
            this.gbox_dueStatus.Text = "Movimento";
            // 
            // rbtn_overdue
            // 
            this.rbtn_overdue.AutoSize = true;
            this.rbtn_overdue.Location = new System.Drawing.Point(5, 61);
            this.rbtn_overdue.Name = "rbtn_overdue";
            this.rbtn_overdue.Size = new System.Drawing.Size(69, 17);
            this.rbtn_overdue.TabIndex = 2;
            this.rbtn_overdue.TabStop = true;
            this.rbtn_overdue.Text = "Vencidos";
            this.rbtn_overdue.UseVisualStyleBackColor = true;
            this.rbtn_overdue.CheckedChanged += new System.EventHandler(this.rbtn_overdue_CheckedChanged);
            // 
            // rbtn_onDate
            // 
            this.rbtn_onDate.AutoSize = true;
            this.rbtn_onDate.Location = new System.Drawing.Point(6, 38);
            this.rbtn_onDate.Name = "rbtn_onDate";
            this.rbtn_onDate.Size = new System.Drawing.Size(57, 17);
            this.rbtn_onDate.TabIndex = 0;
            this.rbtn_onDate.TabStop = true;
            this.rbtn_onDate.Text = "Em dia";
            this.rbtn_onDate.UseVisualStyleBackColor = true;
            this.rbtn_onDate.CheckedChanged += new System.EventHandler(this.rbtn_onDate_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_paidBills);
            this.groupBox1.Controls.Add(this.rbtn_cancelledBills);
            this.groupBox1.Controls.Add(this.rbtn_activeBill);
            this.groupBox1.Location = new System.Drawing.Point(1020, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 118);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status da Conta";
            // 
            // rbtn_paidBills
            // 
            this.rbtn_paidBills.AutoSize = true;
            this.rbtn_paidBills.Location = new System.Drawing.Point(5, 61);
            this.rbtn_paidBills.Name = "rbtn_paidBills";
            this.rbtn_paidBills.Size = new System.Drawing.Size(55, 17);
            this.rbtn_paidBills.TabIndex = 2;
            this.rbtn_paidBills.TabStop = true;
            this.rbtn_paidBills.Text = "Pagos";
            this.rbtn_paidBills.UseVisualStyleBackColor = true;
            this.rbtn_paidBills.CheckedChanged += new System.EventHandler(this.rbtn_paidBills_CheckedChanged);
            // 
            // rbtn_cancelledBills
            // 
            this.rbtn_cancelledBills.AutoSize = true;
            this.rbtn_cancelledBills.Location = new System.Drawing.Point(6, 83);
            this.rbtn_cancelledBills.Name = "rbtn_cancelledBills";
            this.rbtn_cancelledBills.Size = new System.Drawing.Size(81, 17);
            this.rbtn_cancelledBills.TabIndex = 1;
            this.rbtn_cancelledBills.TabStop = true;
            this.rbtn_cancelledBills.Text = "Cancelados";
            this.rbtn_cancelledBills.UseVisualStyleBackColor = true;
            this.rbtn_cancelledBills.CheckedChanged += new System.EventHandler(this.rbtn_cancelledBills_CheckedChanged);
            // 
            // rbtn_activeBill
            // 
            this.rbtn_activeBill.AutoSize = true;
            this.rbtn_activeBill.Location = new System.Drawing.Point(6, 38);
            this.rbtn_activeBill.Name = "rbtn_activeBill";
            this.rbtn_activeBill.Size = new System.Drawing.Size(54, 17);
            this.rbtn_activeBill.TabIndex = 0;
            this.rbtn_activeBill.TabStop = true;
            this.rbtn_activeBill.Text = "Ativos";
            this.rbtn_activeBill.UseVisualStyleBackColor = true;
            this.rbtn_activeBill.CheckedChanged += new System.EventHandler(this.rbtn_activeBill_CheckedChanged);
            // 
            // btn_SelectBill
            // 
            this.btn_SelectBill.Location = new System.Drawing.Point(896, 246);
            this.btn_SelectBill.Name = "btn_SelectBill";
            this.btn_SelectBill.Size = new System.Drawing.Size(104, 23);
            this.btn_SelectBill.TabIndex = 19;
            this.btn_SelectBill.Text = "Selecionar Conta";
            this.btn_SelectBill.UseVisualStyleBackColor = true;
            // 
            // DGV_BillsToPay
            // 
            this.DGV_BillsToPay.AllowUserToAddRows = false;
            this.DGV_BillsToPay.AllowUserToResizeColumns = false;
            this.DGV_BillsToPay.AllowUserToResizeRows = false;
            this.DGV_BillsToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BillsToPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstalmentNum,
            this.PaymentCondition,
            this.PaymentMethod,
            this.DueDate,
            this.TotalValue,
            this.BillStatus});
            this.DGV_BillsToPay.Location = new System.Drawing.Point(9, 19);
            this.DGV_BillsToPay.MultiSelect = false;
            this.DGV_BillsToPay.Name = "DGV_BillsToPay";
            this.DGV_BillsToPay.RowHeadersVisible = false;
            this.DGV_BillsToPay.RowHeadersWidth = 51;
            this.DGV_BillsToPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToPay.Size = new System.Drawing.Size(991, 221);
            this.DGV_BillsToPay.TabIndex = 6;
            // 
            // InstalmentNum
            // 
            this.InstalmentNum.HeaderText = "Número da Parcela";
            this.InstalmentNum.MinimumWidth = 6;
            this.InstalmentNum.Name = "InstalmentNum";
            this.InstalmentNum.ReadOnly = true;
            this.InstalmentNum.Width = 95;
            // 
            // PaymentCondition
            // 
            this.PaymentCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentCondition.HeaderText = "Condição de Pagamento";
            this.PaymentCondition.Name = "PaymentCondition";
            this.PaymentCondition.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Método de Pagamento";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Data de Vencimento";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "Valor Total";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            // 
            // BillStatus
            // 
            this.BillStatus.HeaderText = "Status";
            this.BillStatus.Name = "BillStatus";
            this.BillStatus.ReadOnly = true;
            // 
            // MasterDetails_PurchasesBillsToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 596);
            this.Controls.Add(this.gbox_BillsToPay);
            this.Controls.Add(this.gbox_purchase);
            this.Name = "MasterDetails_PurchasesBillsToPay";
            this.Text = "Compras - Contas a Pagar";
            this.gbox_purchase.ResumeLayout(false);
            this.gbox_purchase.PerformLayout();
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).EndInit();
            this.gbox_BillsToPay.ResumeLayout(false);
            this.gbox_dueStatus.ResumeLayout(false);
            this.gbox_dueStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_purchase;
        private System.Windows.Forms.Button btn_SelectPurchase;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.RadioButton rbtn_cancelled;
        private System.Windows.Forms.RadioButton rbtn_active;
        private System.Windows.Forms.GroupBox gbox_date;
        private System.Windows.Forms.DateTimePicker dateTime_filter;
        private System.Windows.Forms.RadioButton rbtn_cancelDate;
        private System.Windows.Forms.RadioButton rbtn_DateCreation;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox edt_supplierName;
        private System.Windows.Forms.DataGridView DGV_Purchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCancelDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gbox_BillsToPay;
        private System.Windows.Forms.Button btn_SelectBill;
        private System.Windows.Forms.DataGridView DGV_BillsToPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_cancelledBills;
        private System.Windows.Forms.RadioButton rbtn_activeBill;
        private System.Windows.Forms.RadioButton rbtn_paidBills;
        private System.Windows.Forms.GroupBox gbox_dueStatus;
        private System.Windows.Forms.RadioButton rbtn_overdue;
        private System.Windows.Forms.RadioButton rbtn_onDate;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillStatus;
    }
}