namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_PaymentConditions
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
            this.gbox_Instalments = new System.Windows.Forms.GroupBox();
            this.edt_valuePercentage = new System.Windows.Forms.NumericUpDown();
            this.lbl_totalPercentage = new System.Windows.Forms.Label();
            this.edt_totalPercentage = new System.Windows.Forms.TextBox();
            this.edt_daysCount = new System.Windows.Forms.NumericUpDown();
            this.edt_instalmentNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_valuePercentage = new System.Windows.Forms.Label();
            this.btn_SearchMethod = new System.Windows.Forms.Button();
            this.lbl_method = new System.Windows.Forms.Label();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.btn_AddInstalment = new System.Windows.Forms.Button();
            this.cbox_payMethods = new System.Windows.Forms.ComboBox();
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntalmentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentPayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_paymentDiscount = new System.Windows.Forms.Label();
            this.lbl_paymentFee = new System.Windows.Forms.Label();
            this.lbl_paymentFine = new System.Windows.Forms.Label();
            this.lbl_paymentCondition = new System.Windows.Forms.Label();
            this.edt_paymentCondition = new System.Windows.Forms.TextBox();
            this.edt_paymentFine = new System.Windows.Forms.NumericUpDown();
            this.edt_paymentFee = new System.Windows.Forms.NumericUpDown();
            this.edt_discount = new System.Windows.Forms.NumericUpDown();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_Instalments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_valuePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_daysCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_paymentFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_paymentFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LastUpdate
            // 
            this.lbl_LastUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // gbox_Instalments
            // 
            this.gbox_Instalments.Controls.Add(this.edt_valuePercentage);
            this.gbox_Instalments.Controls.Add(this.lbl_totalPercentage);
            this.gbox_Instalments.Controls.Add(this.edt_totalPercentage);
            this.gbox_Instalments.Controls.Add(this.edt_daysCount);
            this.gbox_Instalments.Controls.Add(this.edt_instalmentNumber);
            this.gbox_Instalments.Controls.Add(this.lbl_valuePercentage);
            this.gbox_Instalments.Controls.Add(this.btn_SearchMethod);
            this.gbox_Instalments.Controls.Add(this.lbl_method);
            this.gbox_Instalments.Controls.Add(this.lbl_Days);
            this.gbox_Instalments.Controls.Add(this.lbl_Number);
            this.gbox_Instalments.Controls.Add(this.btn_AddInstalment);
            this.gbox_Instalments.Controls.Add(this.cbox_payMethods);
            this.gbox_Instalments.Location = new System.Drawing.Point(66, 104);
            this.gbox_Instalments.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_Instalments.Name = "gbox_Instalments";
            this.gbox_Instalments.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_Instalments.Size = new System.Drawing.Size(529, 62);
            this.gbox_Instalments.TabIndex = 29;
            this.gbox_Instalments.TabStop = false;
            this.gbox_Instalments.Text = "*Instalments";
            // 
            // edt_valuePercentage
            // 
            this.edt_valuePercentage.DecimalPlaces = 2;
            this.edt_valuePercentage.Location = new System.Drawing.Point(106, 37);
            this.edt_valuePercentage.Name = "edt_valuePercentage";
            this.edt_valuePercentage.Size = new System.Drawing.Size(62, 20);
            this.edt_valuePercentage.TabIndex = 33;
            // 
            // lbl_totalPercentage
            // 
            this.lbl_totalPercentage.AutoSize = true;
            this.lbl_totalPercentage.Location = new System.Drawing.Point(475, 23);
            this.lbl_totalPercentage.Name = "lbl_totalPercentage";
            this.lbl_totalPercentage.Size = new System.Drawing.Size(42, 13);
            this.lbl_totalPercentage.TabIndex = 32;
            this.lbl_totalPercentage.Text = "Total %";
            // 
            // edt_totalPercentage
            // 
            this.edt_totalPercentage.Enabled = false;
            this.edt_totalPercentage.Location = new System.Drawing.Point(478, 37);
            this.edt_totalPercentage.Name = "edt_totalPercentage";
            this.edt_totalPercentage.Size = new System.Drawing.Size(39, 20);
            this.edt_totalPercentage.TabIndex = 31;
            this.edt_totalPercentage.Text = "0";
            // 
            // edt_daysCount
            // 
            this.edt_daysCount.Location = new System.Drawing.Point(48, 37);
            this.edt_daysCount.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.edt_daysCount.Name = "edt_daysCount";
            this.edt_daysCount.Size = new System.Drawing.Size(52, 20);
            this.edt_daysCount.TabIndex = 30;
            // 
            // edt_instalmentNumber
            // 
            this.edt_instalmentNumber.Enabled = false;
            this.edt_instalmentNumber.Location = new System.Drawing.Point(3, 37);
            this.edt_instalmentNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.edt_instalmentNumber.Name = "edt_instalmentNumber";
            this.edt_instalmentNumber.Size = new System.Drawing.Size(39, 20);
            this.edt_instalmentNumber.TabIndex = 30;
            this.edt_instalmentNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_valuePercentage
            // 
            this.lbl_valuePercentage.AutoSize = true;
            this.lbl_valuePercentage.Location = new System.Drawing.Point(95, 23);
            this.lbl_valuePercentage.Name = "lbl_valuePercentage";
            this.lbl_valuePercentage.Size = new System.Drawing.Size(62, 13);
            this.lbl_valuePercentage.TabIndex = 25;
            this.lbl_valuePercentage.Text = "Percentage";
            // 
            // btn_SearchMethod
            // 
            this.btn_SearchMethod.Location = new System.Drawing.Point(363, 37);
            this.btn_SearchMethod.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchMethod.Name = "btn_SearchMethod";
            this.btn_SearchMethod.Size = new System.Drawing.Size(50, 21);
            this.btn_SearchMethod.TabIndex = 23;
            this.btn_SearchMethod.Text = "&Search";
            this.btn_SearchMethod.UseVisualStyleBackColor = true;
            this.btn_SearchMethod.Click += new System.EventHandler(this.btn_SearchMethod_Click);
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Location = new System.Drawing.Point(173, 23);
            this.lbl_method.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(43, 13);
            this.lbl_method.TabIndex = 22;
            this.lbl_method.Text = "Method";
            // 
            // lbl_Days
            // 
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.Location = new System.Drawing.Point(47, 23);
            this.lbl_Days.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(31, 13);
            this.lbl_Days.TabIndex = 21;
            this.lbl_Days.Text = "Days";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(0, 23);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(44, 13);
            this.lbl_Number.TabIndex = 20;
            this.lbl_Number.Text = "Number";
            // 
            // btn_AddInstalment
            // 
            this.btn_AddInstalment.Location = new System.Drawing.Point(417, 37);
            this.btn_AddInstalment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddInstalment.Name = "btn_AddInstalment";
            this.btn_AddInstalment.Size = new System.Drawing.Size(56, 21);
            this.btn_AddInstalment.TabIndex = 19;
            this.btn_AddInstalment.Text = "&Add";
            this.btn_AddInstalment.UseVisualStyleBackColor = true;
            this.btn_AddInstalment.Click += new System.EventHandler(this.btn_AddInstalment_Click);
            // 
            // cbox_payMethods
            // 
            this.cbox_payMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_payMethods.FormattingEnabled = true;
            this.cbox_payMethods.Location = new System.Drawing.Point(173, 37);
            this.cbox_payMethods.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_payMethods.Name = "cbox_payMethods";
            this.cbox_payMethods.Size = new System.Drawing.Size(186, 21);
            this.cbox_payMethods.TabIndex = 18;
            // 
            // DGV_Instalments
            // 
            this.DGV_Instalments.AllowUserToAddRows = false;
            this.DGV_Instalments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Instalments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstalmentNumber,
            this.IntalmentDays,
            this.InstalmentPercentage,
            this.InstalmentPayMethod});
            this.DGV_Instalments.Location = new System.Drawing.Point(66, 170);
            this.DGV_Instalments.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.RowTemplate.Height = 24;
            this.DGV_Instalments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Instalments.Size = new System.Drawing.Size(529, 147);
            this.DGV_Instalments.TabIndex = 28;
            this.DGV_Instalments.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_Instalments_RowsRemoved);
            this.DGV_Instalments.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGV_Instalments_UserDeletedRow);
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Num";
            this.InstalmentNumber.MinimumWidth = 6;
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 50;
            // 
            // IntalmentDays
            // 
            this.IntalmentDays.HeaderText = "Dias";
            this.IntalmentDays.MinimumWidth = 6;
            this.IntalmentDays.Name = "IntalmentDays";
            this.IntalmentDays.ReadOnly = true;
            this.IntalmentDays.Width = 65;
            // 
            // InstalmentPercentage
            // 
            this.InstalmentPercentage.HeaderText = "%";
            this.InstalmentPercentage.MinimumWidth = 6;
            this.InstalmentPercentage.Name = "InstalmentPercentage";
            this.InstalmentPercentage.ReadOnly = true;
            this.InstalmentPercentage.Width = 65;
            // 
            // InstalmentPayMethod
            // 
            this.InstalmentPayMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstalmentPayMethod.HeaderText = "Method";
            this.InstalmentPayMethod.MinimumWidth = 6;
            this.InstalmentPayMethod.Name = "InstalmentPayMethod";
            this.InstalmentPayMethod.ReadOnly = true;
            // 
            // lbl_paymentDiscount
            // 
            this.lbl_paymentDiscount.AutoSize = true;
            this.lbl_paymentDiscount.Location = new System.Drawing.Point(173, 51);
            this.lbl_paymentDiscount.Name = "lbl_paymentDiscount";
            this.lbl_paymentDiscount.Size = new System.Drawing.Size(64, 13);
            this.lbl_paymentDiscount.TabIndex = 27;
            this.lbl_paymentDiscount.Text = "*Discount %";
            // 
            // lbl_paymentFee
            // 
            this.lbl_paymentFee.AutoSize = true;
            this.lbl_paymentFee.Location = new System.Drawing.Point(118, 51);
            this.lbl_paymentFee.Name = "lbl_paymentFee";
            this.lbl_paymentFee.Size = new System.Drawing.Size(29, 13);
            this.lbl_paymentFee.TabIndex = 26;
            this.lbl_paymentFee.Text = "*Fee";
            // 
            // lbl_paymentFine
            // 
            this.lbl_paymentFine.AutoSize = true;
            this.lbl_paymentFine.Location = new System.Drawing.Point(63, 51);
            this.lbl_paymentFine.Name = "lbl_paymentFine";
            this.lbl_paymentFine.Size = new System.Drawing.Size(31, 13);
            this.lbl_paymentFine.TabIndex = 25;
            this.lbl_paymentFine.Text = "*Fine";
            // 
            // lbl_paymentCondition
            // 
            this.lbl_paymentCondition.AutoSize = true;
            this.lbl_paymentCondition.Location = new System.Drawing.Point(63, 8);
            this.lbl_paymentCondition.Name = "lbl_paymentCondition";
            this.lbl_paymentCondition.Size = new System.Drawing.Size(99, 13);
            this.lbl_paymentCondition.TabIndex = 24;
            this.lbl_paymentCondition.Text = "*Payment Condition";
            // 
            // edt_paymentCondition
            // 
            this.edt_paymentCondition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_paymentCondition.Location = new System.Drawing.Point(66, 24);
            this.edt_paymentCondition.MaxLength = 30;
            this.edt_paymentCondition.Name = "edt_paymentCondition";
            this.edt_paymentCondition.Size = new System.Drawing.Size(312, 20);
            this.edt_paymentCondition.TabIndex = 20;
            // 
            // edt_paymentFine
            // 
            this.edt_paymentFine.DecimalPlaces = 2;
            this.edt_paymentFine.Location = new System.Drawing.Point(66, 67);
            this.edt_paymentFine.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edt_paymentFine.Name = "edt_paymentFine";
            this.edt_paymentFine.Size = new System.Drawing.Size(49, 20);
            this.edt_paymentFine.TabIndex = 30;
            // 
            // edt_paymentFee
            // 
            this.edt_paymentFee.DecimalPlaces = 2;
            this.edt_paymentFee.Location = new System.Drawing.Point(121, 67);
            this.edt_paymentFee.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_paymentFee.Name = "edt_paymentFee";
            this.edt_paymentFee.Size = new System.Drawing.Size(49, 20);
            this.edt_paymentFee.TabIndex = 31;
            // 
            // edt_discount
            // 
            this.edt_discount.DecimalPlaces = 2;
            this.edt_discount.Location = new System.Drawing.Point(176, 67);
            this.edt_discount.Name = "edt_discount";
            this.edt_discount.Size = new System.Drawing.Size(61, 20);
            this.edt_discount.TabIndex = 32;
            // 
            // Frm_Create_PaymentConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.edt_discount);
            this.Controls.Add(this.edt_paymentFee);
            this.Controls.Add(this.edt_paymentFine);
            this.Controls.Add(this.gbox_Instalments);
            this.Controls.Add(this.DGV_Instalments);
            this.Controls.Add(this.lbl_paymentDiscount);
            this.Controls.Add(this.lbl_paymentFee);
            this.Controls.Add(this.lbl_paymentFine);
            this.Controls.Add(this.lbl_paymentCondition);
            this.Controls.Add(this.edt_paymentCondition);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_PaymentConditions";
            this.Text = "Payment Conditions";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_paymentCondition, 0);
            this.Controls.SetChildIndex(this.lbl_paymentCondition, 0);
            this.Controls.SetChildIndex(this.lbl_paymentFine, 0);
            this.Controls.SetChildIndex(this.lbl_paymentFee, 0);
            this.Controls.SetChildIndex(this.lbl_paymentDiscount, 0);
            this.Controls.SetChildIndex(this.DGV_Instalments, 0);
            this.Controls.SetChildIndex(this.gbox_Instalments, 0);
            this.Controls.SetChildIndex(this.edt_paymentFine, 0);
            this.Controls.SetChildIndex(this.edt_paymentFee, 0);
            this.Controls.SetChildIndex(this.edt_discount, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_Instalments.ResumeLayout(false);
            this.gbox_Instalments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_valuePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_daysCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_paymentFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_paymentFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Instalments;
        private System.Windows.Forms.Button btn_SearchMethod;
        private System.Windows.Forms.Label lbl_method;
        private System.Windows.Forms.Label lbl_Days;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Button btn_AddInstalment;
        private System.Windows.Forms.ComboBox cbox_payMethods;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.Label lbl_paymentDiscount;
        private System.Windows.Forms.Label lbl_paymentFee;
        private System.Windows.Forms.Label lbl_paymentFine;
        private System.Windows.Forms.Label lbl_paymentCondition;
        private System.Windows.Forms.TextBox edt_paymentCondition;
        private System.Windows.Forms.Label lbl_valuePercentage;
        private System.Windows.Forms.NumericUpDown edt_instalmentNumber;
        private System.Windows.Forms.NumericUpDown edt_daysCount;
        private System.Windows.Forms.Label lbl_totalPercentage;
        private System.Windows.Forms.TextBox edt_totalPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntalmentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPayMethod;
        private System.Windows.Forms.NumericUpDown edt_paymentFine;
        private System.Windows.Forms.NumericUpDown edt_paymentFee;
        private System.Windows.Forms.NumericUpDown edt_discount;
        private System.Windows.Forms.NumericUpDown edt_valuePercentage;
    }
}
