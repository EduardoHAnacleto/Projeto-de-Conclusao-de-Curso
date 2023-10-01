namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_Products
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
            this.DGV_Products = new System.Windows.Forms.DataGridView();
            this.DGVIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVProductValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVProductGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVProductBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // DGV_Products
            // 
            this.DGV_Products.AllowUserToAddRows = false;
            this.DGV_Products.AllowUserToDeleteRows = false;
            this.DGV_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVIdProduct,
            this.DGVProductName,
            this.DGVProductValue,
            this.DGVProductGroup,
            this.DGVProductBrand,
            this.DGVProductStock});
            this.DGV_Products.Location = new System.Drawing.Point(9, 59);
            this.DGV_Products.MultiSelect = false;
            this.DGV_Products.Name = "DGV_Products";
            this.DGV_Products.ReadOnly = true;
            this.DGV_Products.RowHeadersVisible = false;
            this.DGV_Products.RowHeadersWidth = 51;
            this.DGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Products.Size = new System.Drawing.Size(582, 273);
            this.DGV_Products.TabIndex = 6;
            this.DGV_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Products_CellClick);
            this.DGV_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Products_CellContentClick);
            this.DGV_Products.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Products_CellContentDoubleClick);
            // 
            // DGVIdProduct
            // 
            this.DGVIdProduct.HeaderText = "ID";
            this.DGVIdProduct.MinimumWidth = 6;
            this.DGVIdProduct.Name = "DGVIdProduct";
            this.DGVIdProduct.ReadOnly = true;
            this.DGVIdProduct.Width = 40;
            // 
            // DGVProductName
            // 
            this.DGVProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVProductName.HeaderText = "Produto";
            this.DGVProductName.MinimumWidth = 6;
            this.DGVProductName.Name = "DGVProductName";
            this.DGVProductName.ReadOnly = true;
            // 
            // DGVProductValue
            // 
            this.DGVProductValue.HeaderText = "Valor";
            this.DGVProductValue.MinimumWidth = 6;
            this.DGVProductValue.Name = "DGVProductValue";
            this.DGVProductValue.ReadOnly = true;
            this.DGVProductValue.Width = 60;
            // 
            // DGVProductGroup
            // 
            this.DGVProductGroup.HeaderText = "Grupo";
            this.DGVProductGroup.MinimumWidth = 6;
            this.DGVProductGroup.Name = "DGVProductGroup";
            this.DGVProductGroup.ReadOnly = true;
            this.DGVProductGroup.Width = 125;
            // 
            // DGVProductBrand
            // 
            this.DGVProductBrand.HeaderText = "Marca";
            this.DGVProductBrand.MinimumWidth = 6;
            this.DGVProductBrand.Name = "DGVProductBrand";
            this.DGVProductBrand.ReadOnly = true;
            this.DGVProductBrand.Width = 125;
            // 
            // DGVProductStock
            // 
            this.DGVProductStock.HeaderText = "Estoque";
            this.DGVProductStock.MinimumWidth = 6;
            this.DGVProductStock.Name = "DGVProductStock";
            this.DGVProductStock.ReadOnly = true;
            this.DGVProductStock.Width = 55;
            // 
            // edt_productName
            // 
            this.edt_productName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_productName.Location = new System.Drawing.Point(50, 23);
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(273, 20);
            this.edt_productName.TabIndex = 7;
            this.edt_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_productName_KeyPress);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(47, 7);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(44, 13);
            this.lbl_ProductName.TabIndex = 8;
            this.lbl_ProductName.Text = "Produto";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(329, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Bu&scar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Find_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.edt_productName);
            this.Controls.Add(this.DGV_Products);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_Products";
            this.Text = "Buscar Produtos";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.DGV_Products, 0);
            this.Controls.SetChildIndex(this.edt_productName, 0);
            this.Controls.SetChildIndex(this.lbl_ProductName, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Products;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVProductValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVProductGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVProductStock;
    }
}
