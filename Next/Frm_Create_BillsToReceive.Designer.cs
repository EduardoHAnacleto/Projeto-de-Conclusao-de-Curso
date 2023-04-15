namespace ProjetoEduardoAnacletoWindowsForm1.Forms
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
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.lbl_saleId = new System.Windows.Forms.Label();
            this.lbl_PaymentForm = new System.Windows.Forms.Label();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.check_Paid = new System.Windows.Forms.CheckBox();
            this.gbox_isPaid = new System.Windows.Forms.GroupBox();
            this.gbox_billDates = new System.Windows.Forms.GroupBox();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.lbl_EmissionDate = new System.Windows.Forms.Label();
            this.datePicker_due = new System.Windows.Forms.DateTimePicker();
            this.datePicker_emission = new System.Windows.Forms.DateTimePicker();
            this.lbl_instalment = new System.Windows.Forms.Label();
            this.edt_saleNumber = new System.Windows.Forms.TextBox();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.gbox_client = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbox_paymentMethod = new System.Windows.Forms.ComboBox();
            this.medt_instalmentValue = new System.Windows.Forms.MaskedTextBox();
            this.gbox_billInstalment = new System.Windows.Forms.GroupBox();
            this.btn_AddInstalments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.Instalment_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edt_clientId = new System.Windows.Forms.NumericUpDown();
            this.edt_instalmentId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_isPaid.SuspendLayout();
            this.gbox_billDates.SuspendLayout();
            this.gbox_client.SuspendLayout();
            this.gbox_billInstalment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            // lbl_saleId
            // 
            this.lbl_saleId.AutoSize = true;
            this.lbl_saleId.Location = new System.Drawing.Point(257, 96);
            this.lbl_saleId.Name = "lbl_saleId";
            this.lbl_saleId.Size = new System.Drawing.Size(68, 13);
            this.lbl_saleId.TabIndex = 9;
            this.lbl_saleId.Text = "Sale Number";
            // 
            // lbl_PaymentForm
            // 
            this.lbl_PaymentForm.AutoSize = true;
            this.lbl_PaymentForm.Location = new System.Drawing.Point(333, 98);
            this.lbl_PaymentForm.Name = "lbl_PaymentForm";
            this.lbl_PaymentForm.Size = new System.Drawing.Size(87, 13);
            this.lbl_PaymentForm.TabIndex = 10;
            this.lbl_PaymentForm.Text = "Payment Method";
            // 
            // check_Active
            // 
            this.check_Active.AutoSize = true;
            this.check_Active.Location = new System.Drawing.Point(6, 14);
            this.check_Active.Name = "check_Active";
            this.check_Active.Size = new System.Drawing.Size(56, 17);
            this.check_Active.TabIndex = 11;
            this.check_Active.Text = "Active";
            this.check_Active.UseVisualStyleBackColor = true;
            this.check_Active.CheckedChanged += new System.EventHandler(this.check_Active_CheckedChanged);
            // 
            // check_Paid
            // 
            this.check_Paid.AutoSize = true;
            this.check_Paid.Location = new System.Drawing.Point(6, 37);
            this.check_Paid.Name = "check_Paid";
            this.check_Paid.Size = new System.Drawing.Size(62, 17);
            this.check_Paid.TabIndex = 12;
            this.check_Paid.Text = "Paid off";
            this.check_Paid.UseVisualStyleBackColor = true;
            // 
            // gbox_isPaid
            // 
            this.gbox_isPaid.Controls.Add(this.check_Active);
            this.gbox_isPaid.Controls.Add(this.check_Paid);
            this.gbox_isPaid.Location = new System.Drawing.Point(522, 23);
            this.gbox_isPaid.Name = "gbox_isPaid";
            this.gbox_isPaid.Size = new System.Drawing.Size(69, 59);
            this.gbox_isPaid.TabIndex = 13;
            this.gbox_isPaid.TabStop = false;
            this.gbox_isPaid.Text = "Status";
            // 
            // gbox_billDates
            // 
            this.gbox_billDates.Controls.Add(this.lbl_DueDate);
            this.gbox_billDates.Controls.Add(this.lbl_EmissionDate);
            this.gbox_billDates.Controls.Add(this.datePicker_due);
            this.gbox_billDates.Controls.Add(this.datePicker_emission);
            this.gbox_billDates.Location = new System.Drawing.Point(484, 152);
            this.gbox_billDates.Name = "gbox_billDates";
            this.gbox_billDates.Size = new System.Drawing.Size(107, 136);
            this.gbox_billDates.TabIndex = 14;
            this.gbox_billDates.TabStop = false;
            this.gbox_billDates.Text = "Movement Date";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Location = new System.Drawing.Point(3, 90);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(53, 13);
            this.lbl_DueDate.TabIndex = 3;
            this.lbl_DueDate.Text = "Due Date";
            // 
            // lbl_EmissionDate
            // 
            this.lbl_EmissionDate.AutoSize = true;
            this.lbl_EmissionDate.Location = new System.Drawing.Point(3, 33);
            this.lbl_EmissionDate.Name = "lbl_EmissionDate";
            this.lbl_EmissionDate.Size = new System.Drawing.Size(74, 13);
            this.lbl_EmissionDate.TabIndex = 2;
            this.lbl_EmissionDate.Text = "Emission Date";
            // 
            // datePicker_due
            // 
            this.datePicker_due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_due.Location = new System.Drawing.Point(6, 106);
            this.datePicker_due.Name = "datePicker_due";
            this.datePicker_due.Size = new System.Drawing.Size(96, 20);
            this.datePicker_due.TabIndex = 1;
            // 
            // datePicker_emission
            // 
            this.datePicker_emission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_emission.Location = new System.Drawing.Point(6, 49);
            this.datePicker_emission.MinDate = new System.DateTime(2000, 1, 5, 0, 0, 0, 0);
            this.datePicker_emission.Name = "datePicker_emission";
            this.datePicker_emission.Size = new System.Drawing.Size(96, 20);
            this.datePicker_emission.TabIndex = 0;
            this.datePicker_emission.Value = new System.DateTime(2023, 3, 15, 22, 38, 56, 0);
            // 
            // lbl_instalment
            // 
            this.lbl_instalment.AutoSize = true;
            this.lbl_instalment.Location = new System.Drawing.Point(45, 19);
            this.lbl_instalment.Name = "lbl_instalment";
            this.lbl_instalment.Size = new System.Drawing.Size(85, 13);
            this.lbl_instalment.TabIndex = 15;
            this.lbl_instalment.Text = "Instalment Value";
            // 
            // edt_saleNumber
            // 
            this.edt_saleNumber.Location = new System.Drawing.Point(260, 112);
            this.edt_saleNumber.Name = "edt_saleNumber";
            this.edt_saleNumber.Size = new System.Drawing.Size(65, 20);
            this.edt_saleNumber.TabIndex = 16;
            // 
            // edt_clientName
            // 
            this.edt_clientName.Location = new System.Drawing.Point(53, 32);
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
            this.lbl_clientName.Text = "Name";
            // 
            // gbox_client
            // 
            this.gbox_client.Controls.Add(this.edt_clientId);
            this.gbox_client.Controls.Add(this.btn_search);
            this.gbox_client.Controls.Add(this.edt_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientName);
            this.gbox_client.Controls.Add(this.lbl_clientId);
            this.gbox_client.Location = new System.Drawing.Point(76, 7);
            this.gbox_client.Name = "gbox_client";
            this.gbox_client.Size = new System.Drawing.Size(332, 66);
            this.gbox_client.TabIndex = 20;
            this.gbox_client.TabStop = false;
            this.gbox_client.Text = "Client";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(255, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 21);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbox_paymentMethod
            // 
            this.cbox_paymentMethod.FormattingEnabled = true;
            this.cbox_paymentMethod.Location = new System.Drawing.Point(336, 112);
            this.cbox_paymentMethod.Name = "cbox_paymentMethod";
            this.cbox_paymentMethod.Size = new System.Drawing.Size(106, 21);
            this.cbox_paymentMethod.TabIndex = 21;
            // 
            // medt_instalmentValue
            // 
            this.medt_instalmentValue.Location = new System.Drawing.Point(48, 35);
            this.medt_instalmentValue.Mask = "000000.00";
            this.medt_instalmentValue.Name = "medt_instalmentValue";
            this.medt_instalmentValue.Size = new System.Drawing.Size(66, 20);
            this.medt_instalmentValue.TabIndex = 22;
            // 
            // gbox_billInstalment
            // 
            this.gbox_billInstalment.Controls.Add(this.edt_instalmentId);
            this.gbox_billInstalment.Controls.Add(this.btn_AddInstalments);
            this.gbox_billInstalment.Controls.Add(this.label1);
            this.gbox_billInstalment.Controls.Add(this.medt_instalmentValue);
            this.gbox_billInstalment.Controls.Add(this.lbl_instalment);
            this.gbox_billInstalment.Location = new System.Drawing.Point(9, 79);
            this.gbox_billInstalment.Name = "gbox_billInstalment";
            this.gbox_billInstalment.Size = new System.Drawing.Size(230, 66);
            this.gbox_billInstalment.TabIndex = 23;
            this.gbox_billInstalment.TabStop = false;
            this.gbox_billInstalment.Text = "Instalment";
            // 
            // btn_AddInstalments
            // 
            this.btn_AddInstalments.Location = new System.Drawing.Point(120, 35);
            this.btn_AddInstalments.Name = "btn_AddInstalments";
            this.btn_AddInstalments.Size = new System.Drawing.Size(93, 20);
            this.btn_AddInstalments.TabIndex = 25;
            this.btn_AddInstalments.Text = "Add Instalments";
            this.btn_AddInstalments.UseVisualStyleBackColor = true;
            this.btn_AddInstalments.Click += new System.EventHandler(this.btn_AddInstalments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // DGV_Instalments
            // 
            this.DGV_Instalments.AllowUserToDeleteRows = false;
            this.DGV_Instalments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Instalments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instalment_Number,
            this.Total_Days,
            this.Value_Percentage,
            this.PaymentMethod_Name,
            this.Payment_Condition});
            this.DGV_Instalments.Location = new System.Drawing.Point(10, 152);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Instalments.Size = new System.Drawing.Size(471, 167);
            this.DGV_Instalments.TabIndex = 24;
            // 
            // Instalment_Number
            // 
            this.Instalment_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Instalment_Number.HeaderText = "Instalment";
            this.Instalment_Number.MinimumWidth = 6;
            this.Instalment_Number.Name = "Instalment_Number";
            this.Instalment_Number.ReadOnly = true;
            this.Instalment_Number.Width = 60;
            // 
            // Total_Days
            // 
            this.Total_Days.HeaderText = "Total Days";
            this.Total_Days.MinimumWidth = 6;
            this.Total_Days.Name = "Total_Days";
            this.Total_Days.ReadOnly = true;
            this.Total_Days.Width = 35;
            // 
            // Value_Percentage
            // 
            this.Value_Percentage.HeaderText = "Percentage Value";
            this.Value_Percentage.MinimumWidth = 6;
            this.Value_Percentage.Name = "Value_Percentage";
            this.Value_Percentage.ReadOnly = true;
            this.Value_Percentage.Width = 65;
            // 
            // PaymentMethod_Name
            // 
            this.PaymentMethod_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentMethod_Name.HeaderText = "Payment Method";
            this.PaymentMethod_Name.MinimumWidth = 6;
            this.PaymentMethod_Name.Name = "PaymentMethod_Name";
            this.PaymentMethod_Name.ReadOnly = true;
            // 
            // Payment_Condition
            // 
            this.Payment_Condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payment_Condition.HeaderText = "Condition";
            this.Payment_Condition.MinimumWidth = 6;
            this.Payment_Condition.Name = "Payment_Condition";
            this.Payment_Condition.ReadOnly = true;
            // 
            // edt_clientId
            // 
            this.edt_clientId.Location = new System.Drawing.Point(5, 32);
            this.edt_clientId.Name = "edt_clientId";
            this.edt_clientId.Size = new System.Drawing.Size(42, 20);
            this.edt_clientId.TabIndex = 25;
            // 
            // edt_instalmentId
            // 
            this.edt_instalmentId.Location = new System.Drawing.Point(6, 35);
            this.edt_instalmentId.Name = "edt_instalmentId";
            this.edt_instalmentId.Size = new System.Drawing.Size(39, 20);
            this.edt_instalmentId.TabIndex = 26;
            // 
            // Frm_Create_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGV_Instalments);
            this.Controls.Add(this.gbox_billInstalment);
            this.Controls.Add(this.cbox_paymentMethod);
            this.Controls.Add(this.gbox_client);
            this.Controls.Add(this.edt_saleNumber);
            this.Controls.Add(this.gbox_billDates);
            this.Controls.Add(this.gbox_isPaid);
            this.Controls.Add(this.lbl_PaymentForm);
            this.Controls.Add(this.lbl_saleId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Create_BillsToReceive";
            this.Text = "Create Bills To Receive";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.lbl_saleId, 0);
            this.Controls.SetChildIndex(this.lbl_PaymentForm, 0);
            this.Controls.SetChildIndex(this.gbox_isPaid, 0);
            this.Controls.SetChildIndex(this.gbox_billDates, 0);
            this.Controls.SetChildIndex(this.edt_saleNumber, 0);
            this.Controls.SetChildIndex(this.gbox_client, 0);
            this.Controls.SetChildIndex(this.cbox_paymentMethod, 0);
            this.Controls.SetChildIndex(this.gbox_billInstalment, 0);
            this.Controls.SetChildIndex(this.DGV_Instalments, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_isPaid.ResumeLayout(false);
            this.gbox_isPaid.PerformLayout();
            this.gbox_billDates.ResumeLayout(false);
            this.gbox_billDates.PerformLayout();
            this.gbox_client.ResumeLayout(false);
            this.gbox_client.PerformLayout();
            this.gbox_billInstalment.ResumeLayout(false);
            this.gbox_billInstalment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_clientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.Label lbl_saleId;
        private System.Windows.Forms.Label lbl_PaymentForm;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.CheckBox check_Paid;
        private System.Windows.Forms.GroupBox gbox_isPaid;
        private System.Windows.Forms.GroupBox gbox_billDates;
        private System.Windows.Forms.DateTimePicker datePicker_emission;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.Label lbl_EmissionDate;
        private System.Windows.Forms.DateTimePicker datePicker_due;
        private System.Windows.Forms.Label lbl_instalment;
        private System.Windows.Forms.TextBox edt_saleNumber;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.GroupBox gbox_client;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbox_paymentMethod;
        private System.Windows.Forms.MaskedTextBox medt_instalmentValue;
        private System.Windows.Forms.GroupBox gbox_billInstalment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddInstalments;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instalment_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Condition;
        private System.Windows.Forms.NumericUpDown edt_clientId;
        private System.Windows.Forms.NumericUpDown edt_instalmentId;
    }
}
