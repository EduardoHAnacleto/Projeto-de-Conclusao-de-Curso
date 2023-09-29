namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Create_BillsToReceive
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.Instalment_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_billInstalment = new System.Windows.Forms.GroupBox();
            this.edt_instalmentValue = new System.Windows.Forms.NumericUpDown();
            this.edt_instalmentId = new System.Windows.Forms.NumericUpDown();
            this.btn_AddInstalments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_instalment = new System.Windows.Forms.Label();
            this.cbox_paymentMethod = new System.Windows.Forms.ComboBox();
            this.gbox_client = new System.Windows.Forms.GroupBox();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            this.btn_search = new System.Windows.Forms.Button();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.gbox_billDates = new System.Windows.Forms.GroupBox();
            this.lbl_paidDate = new System.Windows.Forms.Label();
            this.datePicker_PaidDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.lbl_EmissionDate = new System.Windows.Forms.Label();
            this.datePicker_due = new System.Windows.Forms.DateTimePicker();
            this.datePicker_emission = new System.Windows.Forms.DateTimePicker();
            this.gbox_isPaid = new System.Windows.Forms.GroupBox();
            this.check_Cancelled = new System.Windows.Forms.CheckBox();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.check_Paid = new System.Windows.Forms.CheckBox();
            this.lbl_PaymentForm = new System.Windows.Forms.Label();
            this.lbl_saleId = new System.Windows.Forms.Label();
            this.edt_saleNumber = new System.Windows.Forms.NumericUpDown();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            this.gbox_billInstalment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).BeginInit();
            this.gbox_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            this.gbox_billDates.SuspendLayout();
            this.gbox_isPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Instalments
            // 
            this.DGV_Instalments.AllowUserToAddRows = false;
            this.DGV_Instalments.AllowUserToDeleteRows = false;
            this.DGV_Instalments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Instalments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instalment_Number,
            this.DueDate,
            this.Value,
            this.PaymentMethod_Name});
            this.DGV_Instalments.Location = new System.Drawing.Point(13, 153);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.RowHeadersVisible = false;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Instalments.Size = new System.Drawing.Size(471, 167);
            this.DGV_Instalments.TabIndex = 33;
            // 
            // Instalment_Number
            // 
            this.Instalment_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Instalment_Number.HeaderText = "Parcela";
            this.Instalment_Number.MinimumWidth = 6;
            this.Instalment_Number.Name = "Instalment_Number";
            this.Instalment_Number.ReadOnly = true;
            this.Instalment_Number.Width = 60;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Data de Vencimento";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Valor";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 65;
            // 
            // PaymentMethod_Name
            // 
            this.PaymentMethod_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentMethod_Name.HeaderText = "Método de Pagamento";
            this.PaymentMethod_Name.MinimumWidth = 6;
            this.PaymentMethod_Name.Name = "PaymentMethod_Name";
            this.PaymentMethod_Name.ReadOnly = true;
            // 
            // gbox_billInstalment
            // 
            this.gbox_billInstalment.Controls.Add(this.edt_instalmentValue);
            this.gbox_billInstalment.Controls.Add(this.edt_instalmentId);
            this.gbox_billInstalment.Controls.Add(this.btn_AddInstalments);
            this.gbox_billInstalment.Controls.Add(this.label1);
            this.gbox_billInstalment.Controls.Add(this.lbl_instalment);
            this.gbox_billInstalment.Location = new System.Drawing.Point(12, 80);
            this.gbox_billInstalment.Name = "gbox_billInstalment";
            this.gbox_billInstalment.Size = new System.Drawing.Size(230, 66);
            this.gbox_billInstalment.TabIndex = 32;
            this.gbox_billInstalment.TabStop = false;
            this.gbox_billInstalment.Text = "* Parcelas";
            // 
            // edt_instalmentValue
            // 
            this.edt_instalmentValue.DecimalPlaces = 2;
            this.edt_instalmentValue.Location = new System.Drawing.Point(59, 34);
            this.edt_instalmentValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_instalmentValue.Name = "edt_instalmentValue";
            this.edt_instalmentValue.Size = new System.Drawing.Size(66, 20);
            this.edt_instalmentValue.TabIndex = 27;
            // 
            // edt_instalmentId
            // 
            this.edt_instalmentId.Enabled = false;
            this.edt_instalmentId.Location = new System.Drawing.Point(6, 35);
            this.edt_instalmentId.Name = "edt_instalmentId";
            this.edt_instalmentId.Size = new System.Drawing.Size(39, 20);
            this.edt_instalmentId.TabIndex = 26;
            this.edt_instalmentId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_AddInstalments
            // 
            this.btn_AddInstalments.Location = new System.Drawing.Point(131, 35);
            this.btn_AddInstalments.Name = "btn_AddInstalments";
            this.btn_AddInstalments.Size = new System.Drawing.Size(63, 20);
            this.btn_AddInstalments.TabIndex = 25;
            this.btn_AddInstalments.Text = "Adicionar";
            this.btn_AddInstalments.UseVisualStyleBackColor = true;
            this.btn_AddInstalments.Click += new System.EventHandler(this.btn_AddInstalments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Número";
            // 
            // lbl_instalment
            // 
            this.lbl_instalment.AutoSize = true;
            this.lbl_instalment.Location = new System.Drawing.Point(56, 19);
            this.lbl_instalment.Name = "lbl_instalment";
            this.lbl_instalment.Size = new System.Drawing.Size(31, 13);
            this.lbl_instalment.TabIndex = 15;
            this.lbl_instalment.Text = "Valor";
            // 
            // cbox_paymentMethod
            // 
            this.cbox_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_paymentMethod.FormattingEnabled = true;
            this.cbox_paymentMethod.Location = new System.Drawing.Point(360, 114);
            this.cbox_paymentMethod.MaxDropDownItems = 20;
            this.cbox_paymentMethod.Name = "cbox_paymentMethod";
            this.cbox_paymentMethod.Size = new System.Drawing.Size(106, 21);
            this.cbox_paymentMethod.TabIndex = 31;
            // 
            // gbox_client
            // 
            this.gbox_client.Controls.Add(this.edt_clientId);
            this.gbox_client.Controls.Add(this.btn_search);
            this.gbox_client.Controls.Add(this.edt_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientId);
            this.gbox_client.Location = new System.Drawing.Point(79, 8);
            this.gbox_client.Name = "gbox_client";
            this.gbox_client.Size = new System.Drawing.Size(332, 66);
            this.gbox_client.TabIndex = 30;
            this.gbox_client.TabStop = false;
            this.gbox_client.Text = "* Cliente";
            // 
            // edt_clientId
            // 
            this.edt_clientId.Enabled = false;
            this.edt_clientId.Location = new System.Drawing.Point(5, 32);
            this.edt_clientId.Name = "edt_clientId";
            this.edt_clientId.Size = new System.Drawing.Size(42, 20);
            this.edt_clientId.TabIndex = 25;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(255, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 21);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Bu&scar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_clientName
            // 
            this.edt_clientName.Location = new System.Drawing.Point(53, 32);
            this.edt_clientName.MaxLength = 30;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(196, 20);
            this.edt_clientName.TabIndex = 18;
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(50, 16);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(35, 13);
            this.lbl_clientName.TabIndex = 19;
            this.lbl_clientName.Text = "Nome";
            // 
            // lbl_clientId
            // 
            this.lbl_clientId.AutoSize = true;
            this.lbl_clientId.Location = new System.Drawing.Point(2, 16);
            this.lbl_clientId.Name = "lbl_clientId";
            this.lbl_clientId.Size = new System.Drawing.Size(18, 13);
            this.lbl_clientId.TabIndex = 8;
            this.lbl_clientId.Text = "ID";
            // 
            // gbox_billDates
            // 
            this.gbox_billDates.Controls.Add(this.lbl_paidDate);
            this.gbox_billDates.Controls.Add(this.datePicker_PaidDate);
            this.gbox_billDates.Controls.Add(this.lbl_DueDate);
            this.gbox_billDates.Controls.Add(this.lbl_EmissionDate);
            this.gbox_billDates.Controls.Add(this.datePicker_due);
            this.gbox_billDates.Controls.Add(this.datePicker_emission);
            this.gbox_billDates.Location = new System.Drawing.Point(487, 153);
            this.gbox_billDates.Name = "gbox_billDates";
            this.gbox_billDates.Size = new System.Drawing.Size(107, 167);
            this.gbox_billDates.TabIndex = 28;
            this.gbox_billDates.TabStop = false;
            this.gbox_billDates.Text = "* Data de Movimento";
            // 
            // lbl_paidDate
            // 
            this.lbl_paidDate.AutoSize = true;
            this.lbl_paidDate.Location = new System.Drawing.Point(2, 121);
            this.lbl_paidDate.Name = "lbl_paidDate";
            this.lbl_paidDate.Size = new System.Drawing.Size(61, 13);
            this.lbl_paidDate.TabIndex = 5;
            this.lbl_paidDate.Text = "Pagamento";
            // 
            // datePicker_PaidDate
            // 
            this.datePicker_PaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_PaidDate.Location = new System.Drawing.Point(5, 137);
            this.datePicker_PaidDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker_PaidDate.Name = "datePicker_PaidDate";
            this.datePicker_PaidDate.Size = new System.Drawing.Size(96, 20);
            this.datePicker_PaidDate.TabIndex = 4;
            this.datePicker_PaidDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker_PaidDate.ValueChanged += new System.EventHandler(this.datePicker_PaidDate_ValueChanged);
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Location = new System.Drawing.Point(3, 78);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(63, 13);
            this.lbl_DueDate.TabIndex = 3;
            this.lbl_DueDate.Text = "Vencimento";
            // 
            // lbl_EmissionDate
            // 
            this.lbl_EmissionDate.AutoSize = true;
            this.lbl_EmissionDate.Location = new System.Drawing.Point(2, 36);
            this.lbl_EmissionDate.Name = "lbl_EmissionDate";
            this.lbl_EmissionDate.Size = new System.Drawing.Size(46, 13);
            this.lbl_EmissionDate.TabIndex = 2;
            this.lbl_EmissionDate.Text = "Emissão";
            // 
            // datePicker_due
            // 
            this.datePicker_due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_due.Location = new System.Drawing.Point(6, 94);
            this.datePicker_due.Name = "datePicker_due";
            this.datePicker_due.Size = new System.Drawing.Size(96, 20);
            this.datePicker_due.TabIndex = 1;
            // 
            // datePicker_emission
            // 
            this.datePicker_emission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_emission.Location = new System.Drawing.Point(5, 52);
            this.datePicker_emission.MinDate = new System.DateTime(2000, 1, 5, 0, 0, 0, 0);
            this.datePicker_emission.Name = "datePicker_emission";
            this.datePicker_emission.Size = new System.Drawing.Size(96, 20);
            this.datePicker_emission.TabIndex = 0;
            this.datePicker_emission.Value = new System.DateTime(2023, 3, 15, 22, 38, 56, 0);
            // 
            // gbox_isPaid
            // 
            this.gbox_isPaid.Controls.Add(this.check_Cancelled);
            this.gbox_isPaid.Controls.Add(this.check_Active);
            this.gbox_isPaid.Controls.Add(this.check_Paid);
            this.gbox_isPaid.Location = new System.Drawing.Point(576, 8);
            this.gbox_isPaid.Name = "gbox_isPaid";
            this.gbox_isPaid.Size = new System.Drawing.Size(84, 79);
            this.gbox_isPaid.TabIndex = 27;
            this.gbox_isPaid.TabStop = false;
            this.gbox_isPaid.Text = "* Status";
            // 
            // check_Cancelled
            // 
            this.check_Cancelled.AutoSize = true;
            this.check_Cancelled.Location = new System.Drawing.Point(6, 60);
            this.check_Cancelled.Name = "check_Cancelled";
            this.check_Cancelled.Size = new System.Drawing.Size(77, 17);
            this.check_Cancelled.TabIndex = 13;
            this.check_Cancelled.Text = "Cancelado";
            this.check_Cancelled.UseVisualStyleBackColor = true;
            this.check_Cancelled.CheckedChanged += new System.EventHandler(this.check_Cancelled_CheckedChanged);
            // 
            // check_Active
            // 
            this.check_Active.AutoSize = true;
            this.check_Active.Checked = true;
            this.check_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Active.Location = new System.Drawing.Point(6, 14);
            this.check_Active.Name = "check_Active";
            this.check_Active.Size = new System.Drawing.Size(50, 17);
            this.check_Active.TabIndex = 11;
            this.check_Active.Text = "Ativo";
            this.check_Active.UseVisualStyleBackColor = true;
            this.check_Active.CheckedChanged += new System.EventHandler(this.check_Active_CheckedChanged);
            // 
            // check_Paid
            // 
            this.check_Paid.AutoSize = true;
            this.check_Paid.Location = new System.Drawing.Point(6, 37);
            this.check_Paid.Name = "check_Paid";
            this.check_Paid.Size = new System.Drawing.Size(51, 17);
            this.check_Paid.TabIndex = 12;
            this.check_Paid.Text = "Pago";
            this.check_Paid.UseVisualStyleBackColor = true;
            this.check_Paid.CheckedChanged += new System.EventHandler(this.check_Paid_CheckedChanged);
            // 
            // lbl_PaymentForm
            // 
            this.lbl_PaymentForm.AutoSize = true;
            this.lbl_PaymentForm.Location = new System.Drawing.Point(352, 98);
            this.lbl_PaymentForm.Name = "lbl_PaymentForm";
            this.lbl_PaymentForm.Size = new System.Drawing.Size(122, 13);
            this.lbl_PaymentForm.TabIndex = 26;
            this.lbl_PaymentForm.Text = "* Método de Pagamento";
            // 
            // lbl_saleId
            // 
            this.lbl_saleId.AutoSize = true;
            this.lbl_saleId.Location = new System.Drawing.Point(253, 97);
            this.lbl_saleId.Name = "lbl_saleId";
            this.lbl_saleId.Size = new System.Drawing.Size(96, 13);
            this.lbl_saleId.TabIndex = 25;
            this.lbl_saleId.Text = "* Código da Venda";
            // 
            // edt_saleNumber
            // 
            this.edt_saleNumber.Enabled = false;
            this.edt_saleNumber.Location = new System.Drawing.Point(263, 113);
            this.edt_saleNumber.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_saleNumber.Name = "edt_saleNumber";
            this.edt_saleNumber.Size = new System.Drawing.Size(65, 20);
            this.edt_saleNumber.TabIndex = 34;
            // 
            // Frm_Create_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.edt_saleNumber);
            this.Controls.Add(this.DGV_Instalments);
            this.Controls.Add(this.gbox_billInstalment);
            this.Controls.Add(this.cbox_paymentMethod);
            this.Controls.Add(this.gbox_client);
            this.Controls.Add(this.gbox_billDates);
            this.Controls.Add(this.gbox_isPaid);
            this.Controls.Add(this.lbl_PaymentForm);
            this.Controls.Add(this.lbl_saleId);
            this.Name = "Frm_Create_BillsToReceive";
            this.Text = "Criar Contas à Receber";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.lbl_saleId, 0);
            this.Controls.SetChildIndex(this.lbl_PaymentForm, 0);
            this.Controls.SetChildIndex(this.gbox_isPaid, 0);
            this.Controls.SetChildIndex(this.gbox_billDates, 0);
            this.Controls.SetChildIndex(this.gbox_client, 0);
            this.Controls.SetChildIndex(this.cbox_paymentMethod, 0);
            this.Controls.SetChildIndex(this.gbox_billInstalment, 0);
            this.Controls.SetChildIndex(this.DGV_Instalments, 0);
            this.Controls.SetChildIndex(this.edt_saleNumber, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            this.gbox_billInstalment.ResumeLayout(false);
            this.gbox_billInstalment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).EndInit();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            this.gbox_billDates.ResumeLayout(false);
            this.gbox_billDates.PerformLayout();
            this.gbox_isPaid.ResumeLayout(false);
            this.gbox_isPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_saleNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbox_billInstalment;
        private System.Windows.Forms.NumericUpDown edt_instalmentId;
        private System.Windows.Forms.Button btn_AddInstalments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_instalment;
        private System.Windows.Forms.ComboBox cbox_paymentMethod;
        private System.Windows.Forms.GroupBox gbox_client;
        private System.Windows.Forms.NumericUpDown edt_clientId;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.GroupBox gbox_billDates;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.Label lbl_EmissionDate;
        private System.Windows.Forms.DateTimePicker datePicker_due;
        private System.Windows.Forms.DateTimePicker datePicker_emission;
        private System.Windows.Forms.GroupBox gbox_isPaid;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.CheckBox check_Paid;
        private System.Windows.Forms.Label lbl_PaymentForm;
        private System.Windows.Forms.Label lbl_saleId;
        private System.Windows.Forms.NumericUpDown edt_instalmentValue;
        private System.Windows.Forms.NumericUpDown edt_saleNumber;
        private System.Windows.Forms.Label lbl_paidDate;
        private System.Windows.Forms.DateTimePicker datePicker_PaidDate;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instalment_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod_Name;
        private System.Windows.Forms.CheckBox check_Cancelled;
    }
}
