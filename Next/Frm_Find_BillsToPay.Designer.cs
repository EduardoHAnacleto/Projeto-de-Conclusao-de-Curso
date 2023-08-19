namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Find_BillsToPay
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
            this.edt_billNumber = new System.Windows.Forms.NumericUpDown();
            this.edt_billModel = new System.Windows.Forms.NumericUpDown();
            this.edt_billSeries = new System.Windows.Forms.NumericUpDown();
            this.btn_search = new System.Windows.Forms.Button();
            this.DGV_BillsToPay = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_billNumber = new System.Windows.Forms.Label();
            this.lbl_billModel = new System.Windows.Forms.Label();
            this.lbl_billSeries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.Visible = false;
            // 
            // edt_id
            // 
            this.edt_id.Visible = false;
            // 
            // edt_billNumber
            // 
            this.edt_billNumber.Location = new System.Drawing.Point(57, 23);
            this.edt_billNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.edt_billNumber.Name = "edt_billNumber";
            this.edt_billNumber.Size = new System.Drawing.Size(70, 20);
            this.edt_billNumber.TabIndex = 7;
            // 
            // edt_billModel
            // 
            this.edt_billModel.Location = new System.Drawing.Point(133, 23);
            this.edt_billModel.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billModel.Name = "edt_billModel";
            this.edt_billModel.Size = new System.Drawing.Size(67, 20);
            this.edt_billModel.TabIndex = 8;
            // 
            // edt_billSeries
            // 
            this.edt_billSeries.Location = new System.Drawing.Point(206, 23);
            this.edt_billSeries.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.edt_billSeries.Name = "edt_billSeries";
            this.edt_billSeries.Size = new System.Drawing.Size(75, 20);
            this.edt_billSeries.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(287, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Bu&scar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // DGV_BillsToPay
            // 
            this.DGV_BillsToPay.AllowUserToAddRows = false;
            this.DGV_BillsToPay.AllowUserToDeleteRows = false;
            this.DGV_BillsToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BillsToPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.BillNumber,
            this.billModel,
            this.billSeries,
            this.InstalmentNumber,
            this.dueDate,
            this.isPaid});
            this.DGV_BillsToPay.Location = new System.Drawing.Point(10, 63);
            this.DGV_BillsToPay.MultiSelect = false;
            this.DGV_BillsToPay.Name = "DGV_BillsToPay";
            this.DGV_BillsToPay.ReadOnly = true;
            this.DGV_BillsToPay.RowHeadersVisible = false;
            this.DGV_BillsToPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToPay.Size = new System.Drawing.Size(581, 269);
            this.DGV_BillsToPay.TabIndex = 12;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "ID Fornecedor";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Width = 65;
            // 
            // BillNumber
            // 
            this.BillNumber.HeaderText = "Número";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            this.BillNumber.Width = 55;
            // 
            // billModel
            // 
            this.billModel.HeaderText = "Modelo";
            this.billModel.Name = "billModel";
            this.billModel.ReadOnly = true;
            this.billModel.Width = 55;
            // 
            // billSeries
            // 
            this.billSeries.HeaderText = "Série";
            this.billSeries.Name = "billSeries";
            this.billSeries.ReadOnly = true;
            this.billSeries.Width = 55;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Nº da Parcela";
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 70;
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDate.HeaderText = "Data de Vencimento";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // isPaid
            // 
            this.isPaid.HeaderText = "Status";
            this.isPaid.Name = "isPaid";
            this.isPaid.ReadOnly = true;
            this.isPaid.Width = 110;
            // 
            // lbl_billNumber
            // 
            this.lbl_billNumber.AutoSize = true;
            this.lbl_billNumber.Location = new System.Drawing.Point(54, 7);
            this.lbl_billNumber.Name = "lbl_billNumber";
            this.lbl_billNumber.Size = new System.Drawing.Size(44, 13);
            this.lbl_billNumber.TabIndex = 13;
            this.lbl_billNumber.Text = "Número";
            // 
            // lbl_billModel
            // 
            this.lbl_billModel.AutoSize = true;
            this.lbl_billModel.Location = new System.Drawing.Point(130, 7);
            this.lbl_billModel.Name = "lbl_billModel";
            this.lbl_billModel.Size = new System.Drawing.Size(42, 13);
            this.lbl_billModel.TabIndex = 14;
            this.lbl_billModel.Text = "Modelo";
            // 
            // lbl_billSeries
            // 
            this.lbl_billSeries.AutoSize = true;
            this.lbl_billSeries.Location = new System.Drawing.Point(203, 7);
            this.lbl_billSeries.Name = "lbl_billSeries";
            this.lbl_billSeries.Size = new System.Drawing.Size(31, 13);
            this.lbl_billSeries.TabIndex = 15;
            this.lbl_billSeries.Text = "Série";
            // 
            // Frm_Find_BillsToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_billSeries);
            this.Controls.Add(this.lbl_billModel);
            this.Controls.Add(this.lbl_billNumber);
            this.Controls.Add(this.DGV_BillsToPay);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.edt_billSeries);
            this.Controls.Add(this.edt_billModel);
            this.Controls.Add(this.edt_billNumber);
            this.Name = "Frm_Find_BillsToPay";
            this.Text = "Buscar Compras à Pagar";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.edt_billNumber, 0);
            this.Controls.SetChildIndex(this.edt_billModel, 0);
            this.Controls.SetChildIndex(this.edt_billSeries, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.DGV_BillsToPay, 0);
            this.Controls.SetChildIndex(this.lbl_billNumber, 0);
            this.Controls.SetChildIndex(this.lbl_billModel, 0);
            this.Controls.SetChildIndex(this.lbl_billSeries, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_billSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown edt_billNumber;
        private System.Windows.Forms.NumericUpDown edt_billModel;
        private System.Windows.Forms.NumericUpDown edt_billSeries;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView DGV_BillsToPay;
        private System.Windows.Forms.Label lbl_billNumber;
        private System.Windows.Forms.Label lbl_billModel;
        private System.Windows.Forms.Label lbl_billSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn billModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn billSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaid;
    }
}
