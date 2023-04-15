namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Find_Brands
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
            this.edt_BrandName = new System.Windows.Forms.TextBox();
            this.lbl_brandName = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV_Brands = new System.Windows.Forms.DataGridView();
            this.BrandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Brands)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // edt_BrandName
            // 
            this.edt_BrandName.Location = new System.Drawing.Point(71, 23);
            this.edt_BrandName.Name = "edt_BrandName";
            this.edt_BrandName.Size = new System.Drawing.Size(222, 20);
            this.edt_BrandName.TabIndex = 4;
            this.edt_BrandName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_BrandName_KeyPress);
            // 
            // lbl_brandName
            // 
            this.lbl_brandName.AutoSize = true;
            this.lbl_brandName.Location = new System.Drawing.Point(68, 7);
            this.lbl_brandName.Name = "lbl_brandName";
            this.lbl_brandName.Size = new System.Drawing.Size(66, 13);
            this.lbl_brandName.TabIndex = 5;
            this.lbl_brandName.Text = "Brand Name";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(299, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(54, 20);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DGV_Brands
            // 
            this.DGV_Brands.AllowUserToAddRows = false;
            this.DGV_Brands.AllowUserToDeleteRows = false;
            this.DGV_Brands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Brands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandId,
            this.BrandName});
            this.DGV_Brands.Location = new System.Drawing.Point(9, 65);
            this.DGV_Brands.MultiSelect = false;
            this.DGV_Brands.Name = "DGV_Brands";
            this.DGV_Brands.ReadOnly = true;
            this.DGV_Brands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Brands.Size = new System.Drawing.Size(579, 243);
            this.DGV_Brands.TabIndex = 8;
            this.DGV_Brands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Brands_CellClick);
            this.DGV_Brands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Brands_CellContentClick);
            this.DGV_Brands.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Brands_CellContentDoubleClick);
            // 
            // BrandId
            // 
            this.BrandId.HeaderText = "ID";
            this.BrandId.Name = "BrandId";
            this.BrandId.ReadOnly = true;
            this.BrandId.Width = 50;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // Frm_Find_Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGV_Brands);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_brandName);
            this.Controls.Add(this.edt_BrandName);
            this.Name = "Frm_Find_Brands";
            this.Text = "Find Brands";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_BrandName, 0);
            this.Controls.SetChildIndex(this.lbl_brandName, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.DGV_Brands, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Brands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_BrandName;
        private System.Windows.Forms.Label lbl_brandName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView DGV_Brands;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
    }
}
