namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Find_Purchases
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
            this.DGV_Purchases = new System.Windows.Forms.DataGridView();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_billSeries = new System.Windows.Forms.Label();
            this.lbl_billModel = new System.Windows.Forms.Label();
            this.lbl_billNumber = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.edt_billSeries = new System.Windows.Forms.NumericUpDown();
            this.edt_billModel = new System.Windows.Forms.NumericUpDown();
            this.edt_billNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(617, 360);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(686, 360);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(557, 360);
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
            this.PurchaseTotalValue,
            this.PurchaseDateCreation,
            this.PurchaseDueDate,
            this.PurchaseCancelDate});
            this.DGV_Purchases.Location = new System.Drawing.Point(10, 49);
            this.DGV_Purchases.MultiSelect = false;
            this.DGV_Purchases.Name = "DGV_Purchases";
            this.DGV_Purchases.ReadOnly = true;
            this.DGV_Purchases.RowHeadersVisible = false;
            this.DGV_Purchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Purchases.Size = new System.Drawing.Size(733, 302);
            this.DGV_Purchases.TabIndex = 7;
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
            // PurchaseDueDate
            // 
            this.PurchaseDueDate.HeaderText = "Data de Vencimento";
            this.PurchaseDueDate.Name = "PurchaseDueDate";
            this.PurchaseDueDate.ReadOnly = true;
            // 
            // PurchaseCancelDate
            // 
            this.PurchaseCancelDate.HeaderText = "Cancelamento";
            this.PurchaseCancelDate.Name = "PurchaseCancelDate";
            this.PurchaseCancelDate.ReadOnly = true;
            this.PurchaseCancelDate.Width = 90;
            // 
            // lbl_billSeries
            // 
            this.lbl_billSeries.AutoSize = true;
            this.lbl_billSeries.Location = new System.Drawing.Point(200, 7);
            this.lbl_billSeries.Name = "lbl_billSeries";
            this.lbl_billSeries.Size = new System.Drawing.Size(31, 13);
            this.lbl_billSeries.TabIndex = 22;
            this.lbl_billSeries.Text = "Série";
            // 
            // lbl_billModel
            // 
            this.lbl_billModel.AutoSize = true;
            this.lbl_billModel.Location = new System.Drawing.Point(127, 7);
            this.lbl_billModel.Name = "lbl_billModel";
            this.lbl_billModel.Size = new System.Drawing.Size(42, 13);
            this.lbl_billModel.TabIndex = 21;
            this.lbl_billModel.Text = "Modelo";
            // 
            // lbl_billNumber
            // 
            this.lbl_billNumber.AutoSize = true;
            this.lbl_billNumber.Location = new System.Drawing.Point(51, 7);
            this.lbl_billNumber.Name = "lbl_billNumber";
            this.lbl_billNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_billNumber.TabIndex = 20;
            this.lbl_billNumber.Text = "Número";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(284, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Bu&scar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_billSeries
            // 
            this.edt_billSeries.Location = new System.Drawing.Point(203, 23);
            this.edt_billSeries.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billSeries.Name = "edt_billSeries";
            this.edt_billSeries.Size = new System.Drawing.Size(75, 20);
            this.edt_billSeries.TabIndex = 18;
            // 
            // edt_billModel
            // 
            this.edt_billModel.Location = new System.Drawing.Point(130, 23);
            this.edt_billModel.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billModel.Name = "edt_billModel";
            this.edt_billModel.Size = new System.Drawing.Size(67, 20);
            this.edt_billModel.TabIndex = 17;
            // 
            // edt_billNumber
            // 
            this.edt_billNumber.Location = new System.Drawing.Point(54, 23);
            this.edt_billNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_billNumber.Name = "edt_billNumber";
            this.edt_billNumber.Size = new System.Drawing.Size(70, 20);
            this.edt_billNumber.TabIndex = 16;
            // 
            // Frm_Find_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(751, 389);
            this.Controls.Add(this.lbl_billSeries);
            this.Controls.Add(this.lbl_billModel);
            this.Controls.Add(this.lbl_billNumber);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.edt_billSeries);
            this.Controls.Add(this.edt_billModel);
            this.Controls.Add(this.edt_billNumber);
            this.Controls.Add(this.DGV_Purchases);
            this.Name = "Frm_Find_Purchases";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.DGV_Purchases, 0);
            this.Controls.SetChildIndex(this.edt_billNumber, 0);
            this.Controls.SetChildIndex(this.edt_billModel, 0);
            this.Controls.SetChildIndex(this.edt_billSeries, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.lbl_billNumber, 0);
            this.Controls.SetChildIndex(this.lbl_billModel, 0);
            this.Controls.SetChildIndex(this.lbl_billSeries, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Purchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Purchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCancelDate;
        private System.Windows.Forms.Label lbl_billSeries;
        private System.Windows.Forms.Label lbl_billModel;
        private System.Windows.Forms.Label lbl_billNumber;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.NumericUpDown edt_billSeries;
        private System.Windows.Forms.NumericUpDown edt_billModel;
        private System.Windows.Forms.NumericUpDown edt_billNumber;
    }
}
