namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_ProductGroups
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
            this.edt_productGroupName = new System.Windows.Forms.TextBox();
            this.lbl_productGroup = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV_ProdGroups = new System.Windows.Forms.DataGridView();
            this.PGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProdGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // edt_productGroupName
            // 
            this.edt_productGroupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_productGroupName.Location = new System.Drawing.Point(50, 23);
            this.edt_productGroupName.Name = "edt_productGroupName";
            this.edt_productGroupName.Size = new System.Drawing.Size(272, 20);
            this.edt_productGroupName.TabIndex = 19;
            this.edt_productGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_productGroupName_KeyPress);
            // 
            // lbl_productGroup
            // 
            this.lbl_productGroup.AutoSize = true;
            this.lbl_productGroup.Location = new System.Drawing.Point(47, 7);
            this.lbl_productGroup.Name = "lbl_productGroup";
            this.lbl_productGroup.Size = new System.Drawing.Size(140, 13);
            this.lbl_productGroup.TabIndex = 18;
            this.lbl_productGroup.Text = "Nome do grupo de Produtos";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(328, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Bu&scar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DGV_ProdGroups
            // 
            this.DGV_ProdGroups.AllowUserToAddRows = false;
            this.DGV_ProdGroups.AllowUserToDeleteRows = false;
            this.DGV_ProdGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ProdGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ProdGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PGroupId,
            this.PGroupName});
            this.DGV_ProdGroups.Location = new System.Drawing.Point(9, 51);
            this.DGV_ProdGroups.MultiSelect = false;
            this.DGV_ProdGroups.Name = "DGV_ProdGroups";
            this.DGV_ProdGroups.ReadOnly = true;
            this.DGV_ProdGroups.RowHeadersVisible = false;
            this.DGV_ProdGroups.RowHeadersWidth = 51;
            this.DGV_ProdGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ProdGroups.Size = new System.Drawing.Size(582, 281);
            this.DGV_ProdGroups.TabIndex = 21;
            this.DGV_ProdGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ProdGroups_CellClick);
            this.DGV_ProdGroups.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ProdGroups_CellContentDoubleClick);
            this.DGV_ProdGroups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_ProdGroups_KeyPress);
            // 
            // PGroupId
            // 
            this.PGroupId.HeaderText = "ID";
            this.PGroupId.MinimumWidth = 6;
            this.PGroupId.Name = "PGroupId";
            this.PGroupId.ReadOnly = true;
            this.PGroupId.Width = 65;
            // 
            // PGroupName
            // 
            this.PGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PGroupName.HeaderText = "Grupo de Produtos";
            this.PGroupName.MinimumWidth = 6;
            this.PGroupName.Name = "PGroupName";
            this.PGroupName.ReadOnly = true;
            // 
            // Frm_Find_ProductGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGV_ProdGroups);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.edt_productGroupName);
            this.Controls.Add(this.lbl_productGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_ProductGroups";
            this.Text = "Buscar Grupos de Produtos";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.lbl_productGroup, 0);
            this.Controls.SetChildIndex(this.edt_productGroupName, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.DGV_ProdGroups, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProdGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_productGroupName;
        private System.Windows.Forms.Label lbl_productGroup;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView DGV_ProdGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGroupName;
    }
}
