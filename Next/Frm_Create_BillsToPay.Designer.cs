﻿namespace ProjetoEduardoAnacletoWindowsForm1.Next
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
            this.gbox_danfe = new System.Windows.Forms.GroupBox();
            this.edt_BillModel = new System.Windows.Forms.NumericUpDown();
            this.edt_BillSeries = new System.Windows.Forms.NumericUpDown();
            this.edt_BillNum = new System.Windows.Forms.NumericUpDown();
            this.lbl_serieDanfe = new System.Windows.Forms.Label();
            this.lbl_tipoDanfe = new System.Windows.Forms.Label();
            this.lbl_numDanfe = new System.Windows.Forms.Label();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.btn_SearchSupplier = new System.Windows.Forms.Button();
            this.edt_supplierId = new System.Windows.Forms.NumericUpDown();
            this.edt_supplierName = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.lbl_supplierId = new System.Windows.Forms.Label();
            this.gbox_isPaid = new System.Windows.Forms.GroupBox();
            this.check_Cancelled = new System.Windows.Forms.CheckBox();
            this.check_Active = new System.Windows.Forms.CheckBox();
            this.check_Paid = new System.Windows.Forms.CheckBox();
            this.gbox_cancelReason = new System.Windows.Forms.GroupBox();
            this.txt_cancelMot = new System.Windows.Forms.RichTextBox();
            this.gbox_newBill = new System.Windows.Forms.GroupBox();
            this.edt_instalmentValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_instalment = new System.Windows.Forms.Label();
            this.gbox_billDates = new System.Windows.Forms.GroupBox();
            this.lbl_cancelDate = new System.Windows.Forms.Label();
            this.date_cancelled = new System.Windows.Forms.DateTimePicker();
            this.lbl_paidDate = new System.Windows.Forms.Label();
            this.datePicker_PaidDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.lbl_EmissionDate = new System.Windows.Forms.Label();
            this.datePicker_due = new System.Windows.Forms.DateTimePicker();
            this.datePicker_emission = new System.Windows.Forms.DateTimePicker();
            this.gbox_paymentCondition = new System.Windows.Forms.GroupBox();
            this.DGV_Instalments = new System.Windows.Forms.DataGridView();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbox_billInstalment = new System.Windows.Forms.GroupBox();
            this.lbl_finalValue = new System.Windows.Forms.Label();
            this.edt_finalValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_instFirstValue = new System.Windows.Forms.Label();
            this.edt_instValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_instDisc = new System.Windows.Forms.NumericUpDown();
            this.edt_instFine = new System.Windows.Forms.NumericUpDown();
            this.edt_instFee = new System.Windows.Forms.NumericUpDown();
            this.edt_instalmentId = new System.Windows.Forms.NumericUpDown();
            this.lbl_instalmentNumber = new System.Windows.Forms.Label();
            this.cbox_paymentMethod = new System.Windows.Forms.ComboBox();
            this.lbl_PaymentForm = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_danfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillNum)).BeginInit();
            this.gbox_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).BeginInit();
            this.gbox_isPaid.SuspendLayout();
            this.gbox_cancelReason.SuspendLayout();
            this.gbox_newBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentValue)).BeginInit();
            this.gbox_billDates.SuspendLayout();
            this.gbox_paymentCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).BeginInit();
            this.gbox_billInstalment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_finalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_dates
            // 
            this.gbox_dates.Location = new System.Drawing.Point(12, 417);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(714, 446);
            // 
            // btn_SelectDelete
            // 
            this.btn_SelectDelete.Location = new System.Drawing.Point(774, 446);
            // 
            // btn_NewSave
            // 
            this.btn_NewSave.Location = new System.Drawing.Point(654, 446);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(834, 446);
            // 
            // lbl_id
            // 
            this.lbl_id.Visible = false;
            // 
            // edt_id
            // 
            this.edt_id.Visible = false;
            // 
            // lbl_requiredSymbol
            // 
            this.lbl_requiredSymbol.Location = new System.Drawing.Point(192, 452);
            // 
            // gbox_danfe
            // 
            this.gbox_danfe.Controls.Add(this.edt_BillModel);
            this.gbox_danfe.Controls.Add(this.edt_BillSeries);
            this.gbox_danfe.Controls.Add(this.edt_BillNum);
            this.gbox_danfe.Controls.Add(this.lbl_serieDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_tipoDanfe);
            this.gbox_danfe.Controls.Add(this.lbl_numDanfe);
            this.gbox_danfe.Location = new System.Drawing.Point(12, 82);
            this.gbox_danfe.Name = "gbox_danfe";
            this.gbox_danfe.Size = new System.Drawing.Size(234, 77);
            this.gbox_danfe.TabIndex = 39;
            this.gbox_danfe.TabStop = false;
            this.gbox_danfe.Text = "* Informações NFe";
            this.gbox_danfe.Leave += new System.EventHandler(this.gbox_danfe_Leave);
            // 
            // edt_BillModel
            // 
            this.edt_BillModel.Location = new System.Drawing.Point(85, 40);
            this.edt_BillModel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_BillModel.Name = "edt_BillModel";
            this.edt_BillModel.Size = new System.Drawing.Size(65, 20);
            this.edt_BillModel.TabIndex = 37;
            this.edt_BillModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_BillModel.Leave += new System.EventHandler(this.edt_BillModel_Leave);
            // 
            // edt_BillSeries
            // 
            this.edt_BillSeries.Location = new System.Drawing.Point(156, 41);
            this.edt_BillSeries.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_BillSeries.Name = "edt_BillSeries";
            this.edt_BillSeries.Size = new System.Drawing.Size(60, 20);
            this.edt_BillSeries.TabIndex = 36;
            this.edt_BillSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_BillSeries.Leave += new System.EventHandler(this.edt_BillSeries_Leave);
            // 
            // edt_BillNum
            // 
            this.edt_BillNum.Location = new System.Drawing.Point(6, 40);
            this.edt_BillNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_BillNum.Name = "edt_BillNum";
            this.edt_BillNum.Size = new System.Drawing.Size(73, 20);
            this.edt_BillNum.TabIndex = 36;
            this.edt_BillNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_BillNum.Leave += new System.EventHandler(this.edt_BillNum_Leave);
            // 
            // lbl_serieDanfe
            // 
            this.lbl_serieDanfe.AutoSize = true;
            this.lbl_serieDanfe.Location = new System.Drawing.Point(153, 24);
            this.lbl_serieDanfe.Name = "lbl_serieDanfe";
            this.lbl_serieDanfe.Size = new System.Drawing.Size(31, 13);
            this.lbl_serieDanfe.TabIndex = 2;
            this.lbl_serieDanfe.Text = "Série";
            // 
            // lbl_tipoDanfe
            // 
            this.lbl_tipoDanfe.AutoSize = true;
            this.lbl_tipoDanfe.Location = new System.Drawing.Point(82, 24);
            this.lbl_tipoDanfe.Name = "lbl_tipoDanfe";
            this.lbl_tipoDanfe.Size = new System.Drawing.Size(42, 13);
            this.lbl_tipoDanfe.TabIndex = 1;
            this.lbl_tipoDanfe.Text = "Modelo";
            // 
            // lbl_numDanfe
            // 
            this.lbl_numDanfe.AutoSize = true;
            this.lbl_numDanfe.Location = new System.Drawing.Point(3, 24);
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
            this.gbox_supplier.Location = new System.Drawing.Point(57, 8);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(358, 68);
            this.gbox_supplier.TabIndex = 38;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "* Fornecedor";
            this.gbox_supplier.Leave += new System.EventHandler(this.gbox_supplier_Leave);
            // 
            // btn_SearchSupplier
            // 
            this.btn_SearchSupplier.Location = new System.Drawing.Point(275, 37);
            this.btn_SearchSupplier.Name = "btn_SearchSupplier";
            this.btn_SearchSupplier.Size = new System.Drawing.Size(75, 21);
            this.btn_SearchSupplier.TabIndex = 37;
            this.btn_SearchSupplier.Text = "Bu&scar";
            this.btn_SearchSupplier.UseVisualStyleBackColor = true;
            this.btn_SearchSupplier.Click += new System.EventHandler(this.btn_SearchSupplier_Click);
            // 
            // edt_supplierId
            // 
            this.edt_supplierId.Enabled = false;
            this.edt_supplierId.Location = new System.Drawing.Point(6, 38);
            this.edt_supplierId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_supplierId.Name = "edt_supplierId";
            this.edt_supplierId.Size = new System.Drawing.Size(48, 20);
            this.edt_supplierId.TabIndex = 36;
            this.edt_supplierId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_supplierName
            // 
            this.edt_supplierName.Enabled = false;
            this.edt_supplierName.Location = new System.Drawing.Point(60, 38);
            this.edt_supplierName.MaxLength = 30;
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
            this.lbl_supplierName.Text = "Nome";
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
            // gbox_isPaid
            // 
            this.gbox_isPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_isPaid.Controls.Add(this.check_Cancelled);
            this.gbox_isPaid.Controls.Add(this.check_Active);
            this.gbox_isPaid.Controls.Add(this.check_Paid);
            this.gbox_isPaid.Enabled = false;
            this.gbox_isPaid.Location = new System.Drawing.Point(795, 8);
            this.gbox_isPaid.Name = "gbox_isPaid";
            this.gbox_isPaid.Size = new System.Drawing.Size(95, 86);
            this.gbox_isPaid.TabIndex = 36;
            this.gbox_isPaid.TabStop = false;
            this.gbox_isPaid.Text = "* Status";
            // 
            // check_Cancelled
            // 
            this.check_Cancelled.AutoSize = true;
            this.check_Cancelled.Location = new System.Drawing.Point(6, 60);
            this.check_Cancelled.Name = "check_Cancelled";
            this.check_Cancelled.Size = new System.Drawing.Size(77, 17);
            this.check_Cancelled.TabIndex = 14;
            this.check_Cancelled.Text = "Cancelado";
            this.check_Cancelled.UseVisualStyleBackColor = true;
            // 
            // check_Active
            // 
            this.check_Active.AutoSize = true;
            this.check_Active.Checked = true;
            this.check_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Active.Location = new System.Drawing.Point(6, 14);
            this.check_Active.Name = "check_Active";
            this.check_Active.Size = new System.Drawing.Size(75, 17);
            this.check_Active.TabIndex = 11;
            this.check_Active.Text = "Em Aberto";
            this.check_Active.UseVisualStyleBackColor = true;
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
            // 
            // gbox_cancelReason
            // 
            this.gbox_cancelReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_cancelReason.Controls.Add(this.txt_cancelMot);
            this.gbox_cancelReason.Location = new System.Drawing.Point(368, 91);
            this.gbox_cancelReason.Name = "gbox_cancelReason";
            this.gbox_cancelReason.Size = new System.Drawing.Size(296, 150);
            this.gbox_cancelReason.TabIndex = 43;
            this.gbox_cancelReason.TabStop = false;
            this.gbox_cancelReason.Text = "* Motivo de Cancelamento";
            this.gbox_cancelReason.Leave += new System.EventHandler(this.gbox_cancelReason_Leave);
            // 
            // txt_cancelMot
            // 
            this.txt_cancelMot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cancelMot.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cancelMot.Location = new System.Drawing.Point(6, 16);
            this.txt_cancelMot.MaxLength = 150;
            this.txt_cancelMot.Name = "txt_cancelMot";
            this.txt_cancelMot.Size = new System.Drawing.Size(284, 128);
            this.txt_cancelMot.TabIndex = 0;
            this.txt_cancelMot.Text = "";
            // 
            // gbox_newBill
            // 
            this.gbox_newBill.Controls.Add(this.edt_instalmentValue);
            this.gbox_newBill.Controls.Add(this.lbl_instalment);
            this.gbox_newBill.Location = new System.Drawing.Point(421, 12);
            this.gbox_newBill.Name = "gbox_newBill";
            this.gbox_newBill.Size = new System.Drawing.Size(102, 73);
            this.gbox_newBill.TabIndex = 42;
            this.gbox_newBill.TabStop = false;
            this.gbox_newBill.Text = "* Nova conta";
            this.gbox_newBill.Leave += new System.EventHandler(this.gbox_newBill_Leave);
            // 
            // edt_instalmentValue
            // 
            this.edt_instalmentValue.DecimalPlaces = 2;
            this.edt_instalmentValue.Location = new System.Drawing.Point(6, 33);
            this.edt_instalmentValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instalmentValue.Name = "edt_instalmentValue";
            this.edt_instalmentValue.Size = new System.Drawing.Size(71, 20);
            this.edt_instalmentValue.TabIndex = 27;
            this.edt_instalmentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_instalmentValue.ValueChanged += new System.EventHandler(this.edt_instalmentValue_ValueChanged);
            // 
            // lbl_instalment
            // 
            this.lbl_instalment.AutoSize = true;
            this.lbl_instalment.Location = new System.Drawing.Point(3, 18);
            this.lbl_instalment.Name = "lbl_instalment";
            this.lbl_instalment.Size = new System.Drawing.Size(58, 13);
            this.lbl_instalment.TabIndex = 15;
            this.lbl_instalment.Text = "Valor Total";
            // 
            // gbox_billDates
            // 
            this.gbox_billDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_billDates.Controls.Add(this.lbl_cancelDate);
            this.gbox_billDates.Controls.Add(this.date_cancelled);
            this.gbox_billDates.Controls.Add(this.lbl_paidDate);
            this.gbox_billDates.Controls.Add(this.datePicker_PaidDate);
            this.gbox_billDates.Controls.Add(this.lbl_DueDate);
            this.gbox_billDates.Controls.Add(this.lbl_EmissionDate);
            this.gbox_billDates.Controls.Add(this.datePicker_due);
            this.gbox_billDates.Controls.Add(this.datePicker_emission);
            this.gbox_billDates.Location = new System.Drawing.Point(676, 6);
            this.gbox_billDates.Name = "gbox_billDates";
            this.gbox_billDates.Size = new System.Drawing.Size(113, 212);
            this.gbox_billDates.TabIndex = 41;
            this.gbox_billDates.TabStop = false;
            this.gbox_billDates.Text = "* Data de Movimento";
            this.gbox_billDates.Leave += new System.EventHandler(this.gbox_billDates_Leave);
            // 
            // lbl_cancelDate
            // 
            this.lbl_cancelDate.AutoSize = true;
            this.lbl_cancelDate.Location = new System.Drawing.Point(4, 170);
            this.lbl_cancelDate.Name = "lbl_cancelDate";
            this.lbl_cancelDate.Size = new System.Drawing.Size(75, 13);
            this.lbl_cancelDate.TabIndex = 7;
            this.lbl_cancelDate.Text = "Cancelamento";
            // 
            // date_cancelled
            // 
            this.date_cancelled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_cancelled.Location = new System.Drawing.Point(7, 186);
            this.date_cancelled.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date_cancelled.Name = "date_cancelled";
            this.date_cancelled.Size = new System.Drawing.Size(96, 20);
            this.date_cancelled.TabIndex = 6;
            this.date_cancelled.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_paidDate
            // 
            this.lbl_paidDate.AutoSize = true;
            this.lbl_paidDate.Location = new System.Drawing.Point(3, 117);
            this.lbl_paidDate.Name = "lbl_paidDate";
            this.lbl_paidDate.Size = new System.Drawing.Size(61, 13);
            this.lbl_paidDate.TabIndex = 5;
            this.lbl_paidDate.Text = "Pagamento";
            // 
            // datePicker_PaidDate
            // 
            this.datePicker_PaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_PaidDate.Location = new System.Drawing.Point(6, 133);
            this.datePicker_PaidDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker_PaidDate.Name = "datePicker_PaidDate";
            this.datePicker_PaidDate.Size = new System.Drawing.Size(96, 20);
            this.datePicker_PaidDate.TabIndex = 4;
            this.datePicker_PaidDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Location = new System.Drawing.Point(4, 74);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(63, 13);
            this.lbl_DueDate.TabIndex = 3;
            this.lbl_DueDate.Text = "Vencimento";
            // 
            // lbl_EmissionDate
            // 
            this.lbl_EmissionDate.AutoSize = true;
            this.lbl_EmissionDate.Location = new System.Drawing.Point(3, 32);
            this.lbl_EmissionDate.Name = "lbl_EmissionDate";
            this.lbl_EmissionDate.Size = new System.Drawing.Size(46, 13);
            this.lbl_EmissionDate.TabIndex = 2;
            this.lbl_EmissionDate.Text = "Emissão";
            // 
            // datePicker_due
            // 
            this.datePicker_due.Enabled = false;
            this.datePicker_due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_due.Location = new System.Drawing.Point(7, 90);
            this.datePicker_due.Name = "datePicker_due";
            this.datePicker_due.Size = new System.Drawing.Size(96, 20);
            this.datePicker_due.TabIndex = 1;
            // 
            // datePicker_emission
            // 
            this.datePicker_emission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_emission.Location = new System.Drawing.Point(6, 48);
            this.datePicker_emission.MinDate = new System.DateTime(2000, 1, 5, 0, 0, 0, 0);
            this.datePicker_emission.Name = "datePicker_emission";
            this.datePicker_emission.Size = new System.Drawing.Size(96, 20);
            this.datePicker_emission.TabIndex = 0;
            this.datePicker_emission.Value = new System.DateTime(2023, 3, 15, 22, 38, 56, 0);
            // 
            // gbox_paymentCondition
            // 
            this.gbox_paymentCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gbox_paymentCondition.Location = new System.Drawing.Point(12, 290);
            this.gbox_paymentCondition.Name = "gbox_paymentCondition";
            this.gbox_paymentCondition.Size = new System.Drawing.Size(810, 121);
            this.gbox_paymentCondition.TabIndex = 44;
            this.gbox_paymentCondition.TabStop = false;
            this.gbox_paymentCondition.Text = "* Condição de Pagamento";
            this.gbox_paymentCondition.Leave += new System.EventHandler(this.gbox_paymentCondition_Leave);
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
            this.InstalmentMethod,
            this.InstalmentValue});
            this.DGV_Instalments.Enabled = false;
            this.DGV_Instalments.Location = new System.Drawing.Point(400, 10);
            this.DGV_Instalments.MultiSelect = false;
            this.DGV_Instalments.Name = "DGV_Instalments";
            this.DGV_Instalments.ReadOnly = true;
            this.DGV_Instalments.RowHeadersVisible = false;
            this.DGV_Instalments.RowHeadersWidth = 51;
            this.DGV_Instalments.Size = new System.Drawing.Size(405, 105);
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
            // InstalmentValue
            // 
            this.InstalmentValue.HeaderText = "Valor";
            this.InstalmentValue.Name = "InstalmentValue";
            this.InstalmentValue.ReadOnly = true;
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
            1410065407,
            2,
            0,
            0});
            this.edt_payConditionQnt.Name = "edt_payConditionQnt";
            this.edt_payConditionQnt.Size = new System.Drawing.Size(43, 20);
            this.edt_payConditionQnt.TabIndex = 7;
            this.edt_payConditionQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_payConditionDiscount
            // 
            this.edt_payConditionDiscount.DecimalPlaces = 2;
            this.edt_payConditionDiscount.Enabled = false;
            this.edt_payConditionDiscount.Location = new System.Drawing.Point(114, 82);
            this.edt_payConditionDiscount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_payConditionDiscount.Name = "edt_payConditionDiscount";
            this.edt_payConditionDiscount.Size = new System.Drawing.Size(44, 20);
            this.edt_payConditionDiscount.TabIndex = 6;
            this.edt_payConditionDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_payConditionFine
            // 
            this.edt_payConditionFine.DecimalPlaces = 2;
            this.edt_payConditionFine.Enabled = false;
            this.edt_payConditionFine.Location = new System.Drawing.Point(63, 82);
            this.edt_payConditionFine.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_payConditionFine.Name = "edt_payConditionFine";
            this.edt_payConditionFine.Size = new System.Drawing.Size(45, 20);
            this.edt_payConditionFine.TabIndex = 5;
            this.edt_payConditionFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_payConditionFees
            // 
            this.edt_payConditionFees.Enabled = false;
            this.edt_payConditionFees.Location = new System.Drawing.Point(14, 82);
            this.edt_payConditionFees.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_payConditionFees.Name = "edt_payConditionFees";
            this.edt_payConditionFees.Size = new System.Drawing.Size(43, 20);
            this.edt_payConditionFees.TabIndex = 4;
            this.edt_payConditionFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            1410065407,
            2,
            0,
            0});
            this.edt_payConditionId.Name = "edt_payConditionId";
            this.edt_payConditionId.Size = new System.Drawing.Size(44, 20);
            this.edt_payConditionId.TabIndex = 1;
            this.edt_payConditionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // gbox_billInstalment
            // 
            this.gbox_billInstalment.Controls.Add(this.lbl_finalValue);
            this.gbox_billInstalment.Controls.Add(this.edt_finalValue);
            this.gbox_billInstalment.Controls.Add(this.lbl_instFirstValue);
            this.gbox_billInstalment.Controls.Add(this.edt_instValue);
            this.gbox_billInstalment.Controls.Add(this.label1);
            this.gbox_billInstalment.Controls.Add(this.label2);
            this.gbox_billInstalment.Controls.Add(this.label3);
            this.gbox_billInstalment.Controls.Add(this.edt_instDisc);
            this.gbox_billInstalment.Controls.Add(this.edt_instFine);
            this.gbox_billInstalment.Controls.Add(this.edt_instFee);
            this.gbox_billInstalment.Controls.Add(this.edt_instalmentId);
            this.gbox_billInstalment.Controls.Add(this.lbl_instalmentNumber);
            this.gbox_billInstalment.Controls.Add(this.cbox_paymentMethod);
            this.gbox_billInstalment.Controls.Add(this.lbl_PaymentForm);
            this.gbox_billInstalment.Location = new System.Drawing.Point(12, 165);
            this.gbox_billInstalment.Name = "gbox_billInstalment";
            this.gbox_billInstalment.Size = new System.Drawing.Size(329, 122);
            this.gbox_billInstalment.TabIndex = 38;
            this.gbox_billInstalment.TabStop = false;
            this.gbox_billInstalment.Text = "* Parcela";
            // 
            // lbl_finalValue
            // 
            this.lbl_finalValue.AutoSize = true;
            this.lbl_finalValue.Location = new System.Drawing.Point(136, 74);
            this.lbl_finalValue.Name = "lbl_finalValue";
            this.lbl_finalValue.Size = new System.Drawing.Size(56, 13);
            this.lbl_finalValue.TabIndex = 41;
            this.lbl_finalValue.Text = "Valor Final";
            // 
            // edt_finalValue
            // 
            this.edt_finalValue.DecimalPlaces = 2;
            this.edt_finalValue.Location = new System.Drawing.Point(139, 90);
            this.edt_finalValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_finalValue.Name = "edt_finalValue";
            this.edt_finalValue.Size = new System.Drawing.Size(75, 20);
            this.edt_finalValue.TabIndex = 40;
            this.edt_finalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_instFirstValue
            // 
            this.lbl_instFirstValue.AutoSize = true;
            this.lbl_instFirstValue.Location = new System.Drawing.Point(61, 19);
            this.lbl_instFirstValue.Name = "lbl_instFirstValue";
            this.lbl_instFirstValue.Size = new System.Drawing.Size(60, 13);
            this.lbl_instFirstValue.TabIndex = 39;
            this.lbl_instFirstValue.Text = "Valor inicial";
            // 
            // edt_instValue
            // 
            this.edt_instValue.Location = new System.Drawing.Point(63, 35);
            this.edt_instValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instValue.Name = "edt_instValue";
            this.edt_instValue.Size = new System.Drawing.Size(60, 20);
            this.edt_instValue.TabIndex = 38;
            this.edt_instValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Desconto %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Multa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Taxa";
            // 
            // edt_instDisc
            // 
            this.edt_instDisc.DecimalPlaces = 2;
            this.edt_instDisc.Enabled = false;
            this.edt_instDisc.Location = new System.Drawing.Point(264, 35);
            this.edt_instDisc.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instDisc.Name = "edt_instDisc";
            this.edt_instDisc.Size = new System.Drawing.Size(61, 20);
            this.edt_instDisc.TabIndex = 34;
            this.edt_instDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_instFine
            // 
            this.edt_instFine.DecimalPlaces = 2;
            this.edt_instFine.Enabled = false;
            this.edt_instFine.Location = new System.Drawing.Point(197, 35);
            this.edt_instFine.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instFine.Name = "edt_instFine";
            this.edt_instFine.Size = new System.Drawing.Size(61, 20);
            this.edt_instFine.TabIndex = 33;
            this.edt_instFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_instFee
            // 
            this.edt_instFee.Enabled = false;
            this.edt_instFee.Location = new System.Drawing.Point(133, 35);
            this.edt_instFee.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instFee.Name = "edt_instFee";
            this.edt_instFee.Size = new System.Drawing.Size(58, 20);
            this.edt_instFee.TabIndex = 32;
            this.edt_instFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_instalmentId
            // 
            this.edt_instalmentId.Enabled = false;
            this.edt_instalmentId.Location = new System.Drawing.Point(6, 35);
            this.edt_instalmentId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.edt_instalmentId.Name = "edt_instalmentId";
            this.edt_instalmentId.Size = new System.Drawing.Size(39, 20);
            this.edt_instalmentId.TabIndex = 26;
            this.edt_instalmentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_instalmentId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_instalmentNumber
            // 
            this.lbl_instalmentNumber.AutoSize = true;
            this.lbl_instalmentNumber.Location = new System.Drawing.Point(3, 19);
            this.lbl_instalmentNumber.Name = "lbl_instalmentNumber";
            this.lbl_instalmentNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_instalmentNumber.TabIndex = 23;
            this.lbl_instalmentNumber.Text = "Número";
            // 
            // cbox_paymentMethod
            // 
            this.cbox_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_paymentMethod.FormattingEnabled = true;
            this.cbox_paymentMethod.Location = new System.Drawing.Point(9, 89);
            this.cbox_paymentMethod.MaxDropDownItems = 20;
            this.cbox_paymentMethod.Name = "cbox_paymentMethod";
            this.cbox_paymentMethod.Size = new System.Drawing.Size(114, 21);
            this.cbox_paymentMethod.TabIndex = 31;
            // 
            // lbl_PaymentForm
            // 
            this.lbl_PaymentForm.AutoSize = true;
            this.lbl_PaymentForm.Location = new System.Drawing.Point(1, 73);
            this.lbl_PaymentForm.Name = "lbl_PaymentForm";
            this.lbl_PaymentForm.Size = new System.Drawing.Size(122, 13);
            this.lbl_PaymentForm.TabIndex = 26;
            this.lbl_PaymentForm.Text = "* Método de Pagamento";
            // 
            // Frm_Create_BillsToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(897, 474);
            this.Controls.Add(this.gbox_billInstalment);
            this.Controls.Add(this.gbox_paymentCondition);
            this.Controls.Add(this.gbox_cancelReason);
            this.Controls.Add(this.gbox_newBill);
            this.Controls.Add(this.gbox_billDates);
            this.Controls.Add(this.gbox_danfe);
            this.Controls.Add(this.gbox_supplier);
            this.Controls.Add(this.gbox_isPaid);
            this.Name = "Frm_Create_BillsToPay";
            this.Text = "Criar Conta à Pagar";
            this.Controls.SetChildIndex(this.lbl_requiredSymbol, 0);
            this.Controls.SetChildIndex(this.gbox_isPaid, 0);
            this.Controls.SetChildIndex(this.gbox_supplier, 0);
            this.Controls.SetChildIndex(this.gbox_danfe, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.gbox_billDates, 0);
            this.Controls.SetChildIndex(this.gbox_newBill, 0);
            this.Controls.SetChildIndex(this.gbox_cancelReason, 0);
            this.Controls.SetChildIndex(this.gbox_paymentCondition, 0);
            this.Controls.SetChildIndex(this.gbox_billInstalment, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_danfe.ResumeLayout(false);
            this.gbox_danfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_BillNum)).EndInit();
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supplierId)).EndInit();
            this.gbox_isPaid.ResumeLayout(false);
            this.gbox_isPaid.PerformLayout();
            this.gbox_cancelReason.ResumeLayout(false);
            this.gbox_newBill.ResumeLayout(false);
            this.gbox_newBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentValue)).EndInit();
            this.gbox_billDates.ResumeLayout(false);
            this.gbox_billDates.PerformLayout();
            this.gbox_paymentCondition.ResumeLayout(false);
            this.gbox_paymentCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Instalments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_payConditionId)).EndInit();
            this.gbox_billInstalment.ResumeLayout(false);
            this.gbox_billInstalment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_finalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_instalmentId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbox_danfe;
        private System.Windows.Forms.NumericUpDown edt_BillModel;
        private System.Windows.Forms.NumericUpDown edt_BillSeries;
        private System.Windows.Forms.NumericUpDown edt_BillNum;
        private System.Windows.Forms.Label lbl_serieDanfe;
        private System.Windows.Forms.Label lbl_tipoDanfe;
        private System.Windows.Forms.Label lbl_numDanfe;
        private System.Windows.Forms.GroupBox gbox_supplier;
        private System.Windows.Forms.Button btn_SearchSupplier;
        private System.Windows.Forms.NumericUpDown edt_supplierId;
        private System.Windows.Forms.TextBox edt_supplierName;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.Label lbl_supplierId;
        private System.Windows.Forms.GroupBox gbox_isPaid;
        private System.Windows.Forms.CheckBox check_Active;
        private System.Windows.Forms.CheckBox check_Paid;
        private System.Windows.Forms.CheckBox check_Cancelled;
        private System.Windows.Forms.GroupBox gbox_cancelReason;
        private System.Windows.Forms.RichTextBox txt_cancelMot;
        private System.Windows.Forms.GroupBox gbox_newBill;
        private System.Windows.Forms.NumericUpDown edt_instalmentValue;
        private System.Windows.Forms.Label lbl_instalment;
        private System.Windows.Forms.GroupBox gbox_billDates;
        private System.Windows.Forms.Label lbl_cancelDate;
        private System.Windows.Forms.DateTimePicker date_cancelled;
        private System.Windows.Forms.Label lbl_paidDate;
        private System.Windows.Forms.DateTimePicker datePicker_PaidDate;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.Label lbl_EmissionDate;
        private System.Windows.Forms.DateTimePicker datePicker_due;
        private System.Windows.Forms.DateTimePicker datePicker_emission;
        private System.Windows.Forms.GroupBox gbox_paymentCondition;
        private System.Windows.Forms.DataGridView DGV_Instalments;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentValue;
        private System.Windows.Forms.Label lbl_payConditionInstalments;
        private System.Windows.Forms.Label lbl_payConditionDiscount;
        private System.Windows.Forms.Label lbl_payConditionFine;
        private System.Windows.Forms.Label lbl_payConditionFees;
        private System.Windows.Forms.Button btn_SearchPayCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionQnt;
        private System.Windows.Forms.NumericUpDown edt_payConditionDiscount;
        private System.Windows.Forms.NumericUpDown edt_payConditionFine;
        private System.Windows.Forms.NumericUpDown edt_payConditionFees;
        private System.Windows.Forms.Label lbl_payCondition;
        private System.Windows.Forms.TextBox edt_payCondition;
        private System.Windows.Forms.NumericUpDown edt_payConditionId;
        private System.Windows.Forms.Label lbl_payConditionID;
        private System.Windows.Forms.GroupBox gbox_billInstalment;
        private System.Windows.Forms.Label lbl_finalValue;
        private System.Windows.Forms.NumericUpDown edt_finalValue;
        private System.Windows.Forms.Label lbl_instFirstValue;
        private System.Windows.Forms.NumericUpDown edt_instValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edt_instDisc;
        private System.Windows.Forms.NumericUpDown edt_instFine;
        private System.Windows.Forms.NumericUpDown edt_instFee;
        private System.Windows.Forms.NumericUpDown edt_instalmentId;
        private System.Windows.Forms.Label lbl_instalmentNumber;
        private System.Windows.Forms.ComboBox cbox_paymentMethod;
        private System.Windows.Forms.Label lbl_PaymentForm;
    }
}
