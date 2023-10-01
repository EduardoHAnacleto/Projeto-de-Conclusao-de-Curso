namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_PaymentConditions
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
            this.DGV_PayConditions = new System.Windows.Forms.DataGridView();
            this.ID_PayCond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_payCond = new System.Windows.Forms.Label();
            this.edt_payCond = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PayConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            // 
            // DGV_PayConditions
            // 
            this.DGV_PayConditions.AllowUserToAddRows = false;
            this.DGV_PayConditions.AllowUserToDeleteRows = false;
            this.DGV_PayConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_PayConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PayConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PayCond,
            this.PaymentCondition,
            this.PaymentFees,
            this.FineValue,
            this.DiscountPerc,
            this.InstalmentQuantity});
            this.DGV_PayConditions.Location = new System.Drawing.Point(10, 49);
            this.DGV_PayConditions.MultiSelect = false;
            this.DGV_PayConditions.Name = "DGV_PayConditions";
            this.DGV_PayConditions.ReadOnly = true;
            this.DGV_PayConditions.RowHeadersVisible = false;
            this.DGV_PayConditions.RowHeadersWidth = 51;
            this.DGV_PayConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PayConditions.Size = new System.Drawing.Size(578, 283);
            this.DGV_PayConditions.TabIndex = 7;
            this.DGV_PayConditions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayConditions_CellClick);
            this.DGV_PayConditions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayConditions_CellContentClick);
            this.DGV_PayConditions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayConditions_CellContentDoubleClick);
            // 
            // ID_PayCond
            // 
            this.ID_PayCond.HeaderText = "ID";
            this.ID_PayCond.MinimumWidth = 6;
            this.ID_PayCond.Name = "ID_PayCond";
            this.ID_PayCond.ReadOnly = true;
            this.ID_PayCond.Width = 40;
            // 
            // PaymentCondition
            // 
            this.PaymentCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentCondition.HeaderText = "Condição de Pagamento";
            this.PaymentCondition.MinimumWidth = 6;
            this.PaymentCondition.Name = "PaymentCondition";
            this.PaymentCondition.ReadOnly = true;
            // 
            // PaymentFees
            // 
            this.PaymentFees.HeaderText = "Taxa";
            this.PaymentFees.MinimumWidth = 6;
            this.PaymentFees.Name = "PaymentFees";
            this.PaymentFees.ReadOnly = true;
            this.PaymentFees.Width = 65;
            // 
            // FineValue
            // 
            this.FineValue.HeaderText = "Multa";
            this.FineValue.MinimumWidth = 6;
            this.FineValue.Name = "FineValue";
            this.FineValue.ReadOnly = true;
            this.FineValue.Width = 65;
            // 
            // DiscountPerc
            // 
            this.DiscountPerc.HeaderText = "Desconto %";
            this.DiscountPerc.MinimumWidth = 6;
            this.DiscountPerc.Name = "DiscountPerc";
            this.DiscountPerc.ReadOnly = true;
            this.DiscountPerc.Width = 65;
            // 
            // InstalmentQuantity
            // 
            this.InstalmentQuantity.HeaderText = "Qtde de Parcelas";
            this.InstalmentQuantity.MinimumWidth = 6;
            this.InstalmentQuantity.Name = "InstalmentQuantity";
            this.InstalmentQuantity.ReadOnly = true;
            this.InstalmentQuantity.Width = 65;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(327, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(64, 20);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Bu&scar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_payCond
            // 
            this.lbl_payCond.AutoSize = true;
            this.lbl_payCond.Location = new System.Drawing.Point(47, 7);
            this.lbl_payCond.Name = "lbl_payCond";
            this.lbl_payCond.Size = new System.Drawing.Size(124, 13);
            this.lbl_payCond.TabIndex = 9;
            this.lbl_payCond.Text = "Condição de Pagamento";
            // 
            // edt_payCond
            // 
            this.edt_payCond.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_payCond.Location = new System.Drawing.Point(50, 23);
            this.edt_payCond.Name = "edt_payCond";
            this.edt_payCond.Size = new System.Drawing.Size(271, 20);
            this.edt_payCond.TabIndex = 10;
            // 
            // Frm_Find_PaymentConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.edt_payCond);
            this.Controls.Add(this.lbl_payCond);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.DGV_PayConditions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_PaymentConditions";
            this.Text = "Buscar Condições de Pagamento";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.DGV_PayConditions, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.lbl_payCond, 0);
            this.Controls.SetChildIndex(this.edt_payCond, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PayConditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PayConditions;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_payCond;
        private System.Windows.Forms.TextBox edt_payCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PayCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentQuantity;
    }
}
