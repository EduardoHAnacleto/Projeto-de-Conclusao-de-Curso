namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    partial class Frm_Create_BillsToPay
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
            this.cbox_payMethod = new System.Windows.Forms.ComboBox();
            this.gbox_danfe = new System.Windows.Forms.GroupBox();
            this.edt_serieDanfe = new System.Windows.Forms.NumericUpDown();
            this.edt_numDanfe = new System.Windows.Forms.NumericUpDown();
            this.edt_pagDanfe = new System.Windows.Forms.NumericUpDown();
            this.edt_tipoDanfe = new System.Windows.Forms.TextBox();
            this.lbl_pagDanfe = new System.Windows.Forms.Label();
            this.lbl_serieDanfe = new System.Windows.Forms.Label();
            this.lbl_tipoDanfe = new System.Windows.Forms.Label();
            this.lbl_numDanfe = new System.Windows.Forms.Label();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.edt_supplierId = new System.Windows.Forms.NumericUpDown();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.lbl_supplierId = new System.Windows.Forms.Label();
            this.lbl_instalmentNumber = new System.Windows.Forms.Label();
            this.lbl_totalValue = new System.Windows.Forms.Label();
            this.gbox_billDates = new System.Windows.Forms.GroupBox();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.datePicker_due = new System.Windows.Forms.DateTimePicker();
            this.gbox_isPaid = new System.Windows.Forms.GroupBox();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.check_Paid = new System.Windows.Forms.CheckBox();
            this.edt_totalValue = new System.Windows.Forms.TextBox();
            this.lbl_paymentMethod = new System.Windows.Forms.Label();
            this.gbox_billInfo = new System.Windows.Forms.GroupBox();
            this.edt_instalmentNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_SearchSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_danfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_serieDanfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_numDanfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_pagDanfe)).BeginInit();
            this.gbox_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).BeginInit();
            this.gbox_billDates.SuspendLayout();
            this.gbox_isPaid.SuspendLayout();
            this.gbox_billInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // cbox_payMethod
            // 
            this.cbox_payMethod.FormattingEnabled = true;
            this.cbox_payMethod.Location = new System.Drawing.Point(6, 91);
            this.cbox_payMethod.Name = "cbox_payMethod";
            this.cbox_payMethod.Size = new System.Drawing.Size(121, 21);
            this.cbox_payMethod.TabIndex = 33;
            // 
            // gbox_danfe
            // 
            this.gbox_danfe.Controls.Add(this.edt_serieDanfe);
            this.gbox_danfe.Controls.Add(this.edt_numDanfe);
            this.gbox_danfe.Controls.Add(this.edt_pagDanfe);
            this.gbox_danfe.Controls.Add(this.edt_tipoDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_pagDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_serieDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_tipoDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_numDanfe);
            this.gbox_danfe.Location = new System.Drawing.Point(9, 86);
            this.gbox_danfe.Name = "gbox_danfe";
            this.gbox_danfe.Size = new System.Drawing.Size(274, 72);
            this.gbox_danfe.TabIndex = 32;
            this.gbox_danfe.TabStop = false;
            this.gbox_danfe.Text = "DANFe";
            // 
            // edt_serieDanfe
            // 
            this.edt_serieDanfe.Location = new System.Drawing.Point(161, 40);
            this.edt_serieDanfe.Name = "edt_serieDanfe";
            this.edt_serieDanfe.Size = new System.Drawing.Size(60, 20);
            this.edt_serieDanfe.TabIndex = 36;
            // 
            // edt_numDanfe
            // 
            this.edt_numDanfe.Location = new System.Drawing.Point(11, 39);
            this.edt_numDanfe.Name = "edt_numDanfe";
            this.edt_numDanfe.Size = new System.Drawing.Size(73, 20);
            this.edt_numDanfe.TabIndex = 36;
            // 
            // edt_pagDanfe
            // 
            this.edt_pagDanfe.Location = new System.Drawing.Point(226, 40);
            this.edt_pagDanfe.Name = "edt_pagDanfe";
            this.edt_pagDanfe.Size = new System.Drawing.Size(45, 20);
            this.edt_pagDanfe.TabIndex = 36;
            // 
            // edt_tipoDanfe
            // 
            this.edt_tipoDanfe.Location = new System.Drawing.Point(90, 39);
            this.edt_tipoDanfe.Name = "edt_tipoDanfe";
            this.edt_tipoDanfe.Size = new System.Drawing.Size(65, 20);
            this.edt_tipoDanfe.TabIndex = 5;
            // 
            // lbl_pagDanfe
            // 
            this.lbl_pagDanfe.AutoSize = true;
            this.lbl_pagDanfe.Location = new System.Drawing.Point(223, 23);
            this.lbl_pagDanfe.Name = "lbl_pagDanfe";
            this.lbl_pagDanfe.Size = new System.Drawing.Size(40, 13);
            this.lbl_pagDanfe.TabIndex = 3;
            this.lbl_pagDanfe.Text = "Página";
            // 
            // lbl_serieDanfe
            // 
            this.lbl_serieDanfe.AutoSize = true;
            this.lbl_serieDanfe.Location = new System.Drawing.Point(158, 23);
            this.lbl_serieDanfe.Name = "lbl_serieDanfe";
            this.lbl_serieDanfe.Size = new System.Drawing.Size(31, 13);
            this.lbl_serieDanfe.TabIndex = 2;
            this.lbl_serieDanfe.Text = "Série";
            // 
            // lbl_tipoDanfe
            // 
            this.lbl_tipoDanfe.AutoSize = true;
            this.lbl_tipoDanfe.Location = new System.Drawing.Point(87, 23);
            this.lbl_tipoDanfe.Name = "lbl_tipoDanfe";
            this.lbl_tipoDanfe.Size = new System.Drawing.Size(68, 13);
            this.lbl_tipoDanfe.TabIndex = 1;
            this.lbl_tipoDanfe.Text = "Tipo/Modelo";
            // 
            // lbl_numDanfe
            // 
            this.lbl_numDanfe.AutoSize = true;
            this.lbl_numDanfe.Location = new System.Drawing.Point(8, 23);
            this.lbl_numDanfe.Name = "lbl_numDanfe";
            this.lbl_numDanfe.Size = new System.Drawing.Size(44, 13);
            this.lbl_numDanfe.TabIndex = 0;
            this.lbl_numDanfe.Text = "Número";
            // 
            // gbox_supplier
            // 
            this.gbox_supplier.Controls.Add(this.btn_SearchSupplier);
            this.gbox_supplier.Controls.Add(this.edt_supplierId);
            this.gbox_supplier.Controls.Add(this.edt_supplierName);
            this.gbox_supplier.Controls.Add(this.lbl_supplierName);
            this.gbox_supplier.Controls.Add(this.lbl_supplierId);
            this.gbox_supplier.Location = new System.Drawing.Point(54, 12);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(358, 68);
            this.gbox_supplier.TabIndex = 30;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "Supplier";
            // 
            // edt_supplierId
            // 
            this.edt_supplierId.Location = new System.Drawing.Point(6, 38);
            this.edt_supplierId.Name = "edt_supplierId";
            this.edt_supplierId.Size = new System.Drawing.Size(48, 20);
            this.edt_supplierId.TabIndex = 36;
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Location = new System.Drawing.Point(60, 38);
            this.edt_supplierName.Name = "edt_supplierName";
            this.edt_supplierName.Size = new System.Drawing.Size(210, 20);
            this.edt_supplierName.TabIndex = 20;
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(57, 23);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(35, 13);
            this.lbl_supplierName.TabIndex = 19;
            this.lbl_supplierName.Text = "Name";
            // 
            // lbl_supplierId
            // 
            this.lbl_supplierId.AutoSize = true;
            this.lbl_supplierId.Location = new System.Drawing.Point(3, 23);
            this.lbl_supplierId.Name = "lbl_supplierId";
            this.lbl_supplierId.Size = new System.Drawing.Size(18, 13);
            this.lbl_supplierId.TabIndex = 18;
            this.lbl_supplierId.Text = "ID";
            // 
            // lbl_instalmentNumber
            // 
            this.lbl_instalmentNumber.AutoSize = true;
            this.lbl_instalmentNumber.Location = new System.Drawing.Point(3, 20);
            this.lbl_instalmentNumber.Name = "lbl_instalmentNumber";
            this.lbl_instalmentNumber.Size = new System.Drawing.Size(95, 13);
            this.lbl_instalmentNumber.TabIndex = 29;
            this.lbl_instalmentNumber.Text = "Instalment Number";
            // 
            // lbl_totalValue
            // 
            this.lbl_totalValue.AutoSize = true;
            this.lbl_totalValue.Location = new System.Drawing.Point(107, 21);
            this.lbl_totalValue.Name = "lbl_totalValue";
            this.lbl_totalValue.Size = new System.Drawing.Size(61, 13);
            this.lbl_totalValue.TabIndex = 28;
            this.lbl_totalValue.Text = "Total Value";
            // 
            // gbox_billDates
            // 
            this.gbox_billDates.Controls.Add(this.lbl_DueDate);
            this.gbox_billDates.Controls.Add(this.datePicker_due);
            this.gbox_billDates.Location = new System.Drawing.Point(305, 86);
            this.gbox_billDates.Name = "gbox_billDates";
            this.gbox_billDates.Size = new System.Drawing.Size(107, 72);
            this.gbox_billDates.TabIndex = 27;
            this.gbox_billDates.TabStop = false;
            this.gbox_billDates.Text = "Movement Date";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Location = new System.Drawing.Point(6, 25);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(53, 13);
            this.lbl_DueDate.TabIndex = 3;
            this.lbl_DueDate.Text = "Due Date";
            // 
            // datePicker_due
            // 
            this.datePicker_due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_due.Location = new System.Drawing.Point(6, 41);
            this.datePicker_due.Name = "datePicker_due";
            this.datePicker_due.Size = new System.Drawing.Size(96, 20);
            this.datePicker_due.TabIndex = 1;
            // 
            // gbox_isPaid
            // 
            this.gbox_isPaid.Controls.Add(this.check_Active);
            this.gbox_isPaid.Controls.Add(this.check_Paid);
            this.gbox_isPaid.Location = new System.Drawing.Point(494, 12);
            this.gbox_isPaid.Name = "gbox_isPaid";
            this.gbox_isPaid.Size = new System.Drawing.Size(69, 59);
            this.gbox_isPaid.TabIndex = 26;
            this.gbox_isPaid.TabStop = false;
            this.gbox_isPaid.Text = "Status";
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
            this.check_Paid.CheckedChanged += new System.EventHandler(this.check_Paid_CheckedChanged);
            // 
            // edt_totalValue
            // 
            this.edt_totalValue.Location = new System.Drawing.Point(110, 37);
            this.edt_totalValue.Name = "edt_totalValue";
            this.edt_totalValue.Size = new System.Drawing.Size(100, 20);
            this.edt_totalValue.TabIndex = 25;
            // 
            // lbl_paymentMethod
            // 
            this.lbl_paymentMethod.AutoSize = true;
            this.lbl_paymentMethod.Location = new System.Drawing.Point(3, 75);
            this.lbl_paymentMethod.Name = "lbl_paymentMethod";
            this.lbl_paymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lbl_paymentMethod.TabIndex = 34;
            this.lbl_paymentMethod.Text = "Payment Method";
            // 
            // gbox_billInfo
            // 
            this.gbox_billInfo.Controls.Add(this.edt_instalmentNumber);
            this.gbox_billInfo.Controls.Add(this.lbl_paymentMethod);
            this.gbox_billInfo.Controls.Add(this.cbox_payMethod);
            this.gbox_billInfo.Controls.Add(this.lbl_instalmentNumber);
            this.gbox_billInfo.Controls.Add(this.lbl_totalValue);
            this.gbox_billInfo.Controls.Add(this.edt_totalValue);
            this.gbox_billInfo.Location = new System.Drawing.Point(10, 164);
            this.gbox_billInfo.Name = "gbox_billInfo";
            this.gbox_billInfo.Size = new System.Drawing.Size(220, 128);
            this.gbox_billInfo.TabIndex = 35;
            this.gbox_billInfo.TabStop = false;
            this.gbox_billInfo.Text = "Bill Information";
            // 
            // edt_instalmentNumber
            // 
            this.edt_instalmentNumber.Location = new System.Drawing.Point(6, 37);
            this.edt_instalmentNumber.Name = "edt_instalmentNumber";
            this.edt_instalmentNumber.Size = new System.Drawing.Size(52, 20);
            this.edt_instalmentNumber.TabIndex = 35;
            // 
            // btn_SearchSupplier
            // 
            this.btn_SearchSupplier.Location = new System.Drawing.Point(275, 37);
            this.btn_SearchSupplier.Name = "btn_SearchSupplier";
            this.btn_SearchSupplier.Size = new System.Drawing.Size(75, 21);
            this.btn_SearchSupplier.TabIndex = 37;
            this.btn_SearchSupplier.Text = "&Search";
            this.btn_SearchSupplier.UseVisualStyleBackColor = true;
            // 
            // Frm_Create_BillsToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbox_billInfo);
            this.Controls.Add(this.gbox_danfe);
            this.Controls.Add(this.gbox_supplier);
            this.Controls.Add(this.gbox_billDates);
            this.Controls.Add(this.gbox_isPaid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Create_BillsToPay";
            this.Text = "Bills To Pay";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.gbox_isPaid, 0);
            this.Controls.SetChildIndex(this.gbox_billDates, 0);
            this.Controls.SetChildIndex(this.gbox_supplier, 0);
            this.Controls.SetChildIndex(this.gbox_danfe, 0);
            this.Controls.SetChildIndex(this.gbox_billInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_danfe.ResumeLayout(false);
            this.gbox_danfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_serieDanfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_numDanfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_pagDanfe)).EndInit();
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).EndInit();
            this.gbox_billDates.ResumeLayout(false);
            this.gbox_billDates.PerformLayout();
            this.gbox_isPaid.ResumeLayout(false);
            this.gbox_isPaid.PerformLayout();
            this.gbox_billInfo.ResumeLayout(false);
            this.gbox_billInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_payMethod;
        private System.Windows.Forms.GroupBox gbox_danfe;
        private System.Windows.Forms.TextBox edt_tipoDanfe;
        private System.Windows.Forms.Label lbl_pagDanfe;
        private System.Windows.Forms.Label lbl_serieDanfe;
        private System.Windows.Forms.Label lbl_tipoDanfe;
        private System.Windows.Forms.Label lbl_numDanfe;
        private System.Windows.Forms.GroupBox gbox_supplier;
        private System.Windows.Forms.TextBox edt_supplierName;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.Label lbl_supplierId;
        private System.Windows.Forms.Label lbl_instalmentNumber;
        private System.Windows.Forms.Label lbl_totalValue;
        private System.Windows.Forms.GroupBox gbox_billDates;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.DateTimePicker datePicker_due;
        private System.Windows.Forms.GroupBox gbox_isPaid;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.CheckBox check_Paid;
        private System.Windows.Forms.TextBox edt_totalValue;
        private System.Windows.Forms.Label lbl_paymentMethod;
        private System.Windows.Forms.GroupBox gbox_billInfo;
        private System.Windows.Forms.NumericUpDown edt_instalmentNumber;
        private System.Windows.Forms.NumericUpDown edt_supplierId;
        private System.Windows.Forms.NumericUpDown edt_pagDanfe;
        private System.Windows.Forms.NumericUpDown edt_numDanfe;
        private System.Windows.Forms.NumericUpDown edt_serieDanfe;
        private System.Windows.Forms.Button btn_SearchSupplier;
    }
}
