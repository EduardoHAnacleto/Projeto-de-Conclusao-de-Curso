namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Find_Sales
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
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePayCond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(641, 351);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(710, 351);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(581, 351);
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.AllowUserToAddRows = false;
            this.DGV_Sales.AllowUserToDeleteRows = false;
            this.DGV_Sales.AllowUserToResizeRows = false;
            this.DGV_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.SaleClientName,
            this.SaleTotalValue,
            this.SalePayCond,
            this.SaleDate,
            this.SaleStatus});
            this.DGV_Sales.Location = new System.Drawing.Point(10, 49);
            this.DGV_Sales.MultiSelect = false;
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.ReadOnly = true;
            this.DGV_Sales.RowHeadersVisible = false;
            this.DGV_Sales.RowHeadersWidth = 51;
            this.DGV_Sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Sales.Size = new System.Drawing.Size(754, 295);
            this.DGV_Sales.TabIndex = 7;
            // 
            // SaleId
            // 
            this.SaleId.HeaderText = "ID Venda";
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            this.SaleId.Width = 50;
            // 
            // SaleClientName
            // 
            this.SaleClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleClientName.HeaderText = "Cliente";
            this.SaleClientName.MinimumWidth = 6;
            this.SaleClientName.Name = "SaleClientName";
            this.SaleClientName.ReadOnly = true;
            // 
            // SaleTotalValue
            // 
            this.SaleTotalValue.HeaderText = "Valor Total";
            this.SaleTotalValue.MinimumWidth = 6;
            this.SaleTotalValue.Name = "SaleTotalValue";
            this.SaleTotalValue.ReadOnly = true;
            this.SaleTotalValue.Width = 75;
            // 
            // SalePayCond
            // 
            this.SalePayCond.HeaderText = "Condição de Pagamento";
            this.SalePayCond.MinimumWidth = 6;
            this.SalePayCond.Name = "SalePayCond";
            this.SalePayCond.ReadOnly = true;
            this.SalePayCond.Width = 160;
            // 
            // SaleDate
            // 
            this.SaleDate.HeaderText = "Data de Emissão";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            this.SaleDate.Width = 120;
            // 
            // SaleStatus
            // 
            this.SaleStatus.HeaderText = "Status";
            this.SaleStatus.MinimumWidth = 6;
            this.SaleStatus.Name = "SaleStatus";
            this.SaleStatus.ReadOnly = true;
            this.SaleStatus.Width = 90;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(280, 22);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 20);
            this.btn_Find.TabIndex = 14;
            this.btn_Find.Text = "Buscar";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(45, 7);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(39, 13);
            this.lbl_clientName.TabIndex = 13;
            this.lbl_clientName.Text = "Cliente";
            // 
            // edt_clientName
            // 
            this.edt_clientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_clientName.Location = new System.Drawing.Point(48, 22);
            this.edt_clientName.MaxLength = 50;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(226, 20);
            this.edt_clientName.TabIndex = 12;
            // 
            // Frm_Find_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(775, 380);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_clientName);
            this.Controls.Add(this.edt_clientName);
            this.Controls.Add(this.DGV_Sales);
            this.Name = "Frm_Find_Sales";
            this.Text = "Buscar Vendas";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.DGV_Sales, 0);
            this.Controls.SetChildIndex(this.edt_clientName, 0);
            this.Controls.SetChildIndex(this.lbl_clientName, 0);
            this.Controls.SetChildIndex(this.btn_Find, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePayCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleStatus;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.TextBox edt_clientName;
    }
}
