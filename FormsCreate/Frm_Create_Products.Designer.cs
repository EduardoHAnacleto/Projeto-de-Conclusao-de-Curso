namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Products
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
            this.cbox_ProductGroup = new System.Windows.Forms.ComboBox();
            this.btn_SearchBrand = new System.Windows.Forms.Button();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.cbox_brands = new System.Windows.Forms.ComboBox();
            this.edt_productSalePrice = new System.Windows.Forms.TextBox();
            this.edt_productCost = new System.Windows.Forms.TextBox();
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.lbl_productGroup = new System.Windows.Forms.Label();
            this.lbl_salePrice = new System.Windows.Forms.Label();
            this.lbl_productCost = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.btn_SearchPGroup = new System.Windows.Forms.Button();
            this.edt_stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.edt_barCode = new System.Windows.Forms.TextBox();
            this.lbl_barCode = new System.Windows.Forms.Label();
            this.edt_ProfitPerc = new System.Windows.Forms.NumericUpDown();
            this.lbl_profitPerc = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProfitPerc)).BeginInit();
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
            // cbox_ProductGroup
            // 
            this.cbox_ProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ProductGroup.FormattingEnabled = true;
            this.cbox_ProductGroup.Location = new System.Drawing.Point(453, 24);
            this.cbox_ProductGroup.Name = "cbox_ProductGroup";
            this.cbox_ProductGroup.Size = new System.Drawing.Size(106, 21);
            this.cbox_ProductGroup.TabIndex = 31;
            // 
            // btn_SearchBrand
            // 
            this.btn_SearchBrand.Location = new System.Drawing.Point(271, 67);
            this.btn_SearchBrand.Name = "btn_SearchBrand";
            this.btn_SearchBrand.Size = new System.Drawing.Size(62, 23);
            this.btn_SearchBrand.TabIndex = 30;
            this.btn_SearchBrand.Text = "Search";
            this.btn_SearchBrand.UseVisualStyleBackColor = true;
            this.btn_SearchBrand.Click += new System.EventHandler(this.btn_SearchBrand_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(10, 53);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(35, 13);
            this.lbl_brand.TabIndex = 29;
            this.lbl_brand.Text = "Brand";
            // 
            // cbox_brands
            // 
            this.cbox_brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_brands.FormattingEnabled = true;
            this.cbox_brands.Location = new System.Drawing.Point(11, 69);
            this.cbox_brands.Name = "cbox_brands";
            this.cbox_brands.Size = new System.Drawing.Size(250, 21);
            this.cbox_brands.TabIndex = 28;
            // 
            // edt_productSalePrice
            // 
            this.edt_productSalePrice.Location = new System.Drawing.Point(463, 71);
            this.edt_productSalePrice.Name = "edt_productSalePrice";
            this.edt_productSalePrice.Size = new System.Drawing.Size(52, 20);
            this.edt_productSalePrice.TabIndex = 27;
            // 
            // edt_productCost
            // 
            this.edt_productCost.Location = new System.Drawing.Point(336, 24);
            this.edt_productCost.Name = "edt_productCost";
            this.edt_productCost.Size = new System.Drawing.Size(44, 20);
            this.edt_productCost.TabIndex = 26;
            // 
            // edt_productName
            // 
            this.edt_productName.Location = new System.Drawing.Point(80, 24);
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(250, 20);
            this.edt_productName.TabIndex = 25;
            // 
            // lbl_productGroup
            // 
            this.lbl_productGroup.AutoSize = true;
            this.lbl_productGroup.Location = new System.Drawing.Point(450, 8);
            this.lbl_productGroup.Name = "lbl_productGroup";
            this.lbl_productGroup.Size = new System.Drawing.Size(36, 13);
            this.lbl_productGroup.TabIndex = 24;
            this.lbl_productGroup.Text = "Group";
            // 
            // lbl_salePrice
            // 
            this.lbl_salePrice.AutoSize = true;
            this.lbl_salePrice.Location = new System.Drawing.Point(460, 55);
            this.lbl_salePrice.Name = "lbl_salePrice";
            this.lbl_salePrice.Size = new System.Drawing.Size(55, 13);
            this.lbl_salePrice.TabIndex = 23;
            this.lbl_salePrice.Text = "Sale Price";
            // 
            // lbl_productCost
            // 
            this.lbl_productCost.AutoSize = true;
            this.lbl_productCost.Location = new System.Drawing.Point(333, 8);
            this.lbl_productCost.Name = "lbl_productCost";
            this.lbl_productCost.Size = new System.Drawing.Size(28, 13);
            this.lbl_productCost.TabIndex = 22;
            this.lbl_productCost.Text = "Cost";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(77, 8);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(44, 13);
            this.lbl_productName.TabIndex = 21;
            this.lbl_productName.Text = "Product";
            // 
            // btn_SearchPGroup
            // 
            this.btn_SearchPGroup.Location = new System.Drawing.Point(565, 24);
            this.btn_SearchPGroup.Name = "btn_SearchPGroup";
            this.btn_SearchPGroup.Size = new System.Drawing.Size(75, 21);
            this.btn_SearchPGroup.TabIndex = 32;
            this.btn_SearchPGroup.Text = "Search";
            this.btn_SearchPGroup.UseVisualStyleBackColor = true;
            this.btn_SearchPGroup.Click += new System.EventHandler(this.btn_SearchPGroup_Click);
            // 
            // edt_stock
            // 
            this.edt_stock.Location = new System.Drawing.Point(389, 24);
            this.edt_stock.Margin = new System.Windows.Forms.Padding(2);
            this.edt_stock.Name = "edt_stock";
            this.edt_stock.Size = new System.Drawing.Size(44, 20);
            this.edt_stock.TabIndex = 33;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(387, 9);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_stock.TabIndex = 34;
            this.lbl_stock.Text = "Stock";
            // 
            // edt_barCode
            // 
            this.edt_barCode.Location = new System.Drawing.Point(11, 122);
            this.edt_barCode.Name = "edt_barCode";
            this.edt_barCode.Size = new System.Drawing.Size(319, 20);
            this.edt_barCode.TabIndex = 35;
            // 
            // lbl_barCode
            // 
            this.lbl_barCode.AutoSize = true;
            this.lbl_barCode.Location = new System.Drawing.Point(9, 106);
            this.lbl_barCode.Name = "lbl_barCode";
            this.lbl_barCode.Size = new System.Drawing.Size(50, 13);
            this.lbl_barCode.TabIndex = 36;
            this.lbl_barCode.Text = "Bar code";
            // 
            // edt_ProfitPerc
            // 
            this.edt_ProfitPerc.DecimalPlaces = 2;
            this.edt_ProfitPerc.Location = new System.Drawing.Point(390, 71);
            this.edt_ProfitPerc.Name = "edt_ProfitPerc";
            this.edt_ProfitPerc.Size = new System.Drawing.Size(49, 20);
            this.edt_ProfitPerc.TabIndex = 37;
            this.edt_ProfitPerc.ValueChanged += new System.EventHandler(this.edt_ProfitPerc_ValueChanged);
            // 
            // lbl_profitPerc
            // 
            this.lbl_profitPerc.AutoSize = true;
            this.lbl_profitPerc.Location = new System.Drawing.Point(387, 54);
            this.lbl_profitPerc.Name = "lbl_profitPerc";
            this.lbl_profitPerc.Size = new System.Drawing.Size(66, 13);
            this.lbl_profitPerc.TabIndex = 38;
            this.lbl_profitPerc.Text = "Profit Margin";
            // 
            // Frm_Create_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_profitPerc);
            this.Controls.Add(this.edt_ProfitPerc);
            this.Controls.Add(this.lbl_barCode);
            this.Controls.Add(this.edt_barCode);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.edt_stock);
            this.Controls.Add(this.btn_SearchPGroup);
            this.Controls.Add(this.cbox_ProductGroup);
            this.Controls.Add(this.btn_SearchBrand);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.cbox_brands);
            this.Controls.Add(this.edt_productSalePrice);
            this.Controls.Add(this.edt_productCost);
            this.Controls.Add(this.edt_productName);
            this.Controls.Add(this.lbl_productGroup);
            this.Controls.Add(this.lbl_salePrice);
            this.Controls.Add(this.lbl_productCost);
            this.Controls.Add(this.lbl_productName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_Products";
            this.Text = "Create Products";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_productName, 0);
            this.Controls.SetChildIndex(this.lbl_productCost, 0);
            this.Controls.SetChildIndex(this.lbl_salePrice, 0);
            this.Controls.SetChildIndex(this.lbl_productGroup, 0);
            this.Controls.SetChildIndex(this.edt_productName, 0);
            this.Controls.SetChildIndex(this.edt_productCost, 0);
            this.Controls.SetChildIndex(this.edt_productSalePrice, 0);
            this.Controls.SetChildIndex(this.cbox_brands, 0);
            this.Controls.SetChildIndex(this.lbl_brand, 0);
            this.Controls.SetChildIndex(this.btn_SearchBrand, 0);
            this.Controls.SetChildIndex(this.cbox_ProductGroup, 0);
            this.Controls.SetChildIndex(this.btn_SearchPGroup, 0);
            this.Controls.SetChildIndex(this.edt_stock, 0);
            this.Controls.SetChildIndex(this.lbl_stock, 0);
            this.Controls.SetChildIndex(this.edt_barCode, 0);
            this.Controls.SetChildIndex(this.lbl_barCode, 0);
            this.Controls.SetChildIndex(this.edt_ProfitPerc, 0);
            this.Controls.SetChildIndex(this.lbl_profitPerc, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProfitPerc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ProductGroup;
        private System.Windows.Forms.Button btn_SearchBrand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.ComboBox cbox_brands;
        private System.Windows.Forms.TextBox edt_productSalePrice;
        private System.Windows.Forms.TextBox edt_productCost;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Label lbl_productGroup;
        private System.Windows.Forms.Label lbl_salePrice;
        private System.Windows.Forms.Label lbl_productCost;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Button btn_SearchPGroup;
        private System.Windows.Forms.NumericUpDown edt_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox edt_barCode;
        private System.Windows.Forms.Label lbl_barCode;
        private System.Windows.Forms.NumericUpDown edt_ProfitPerc;
        private System.Windows.Forms.Label lbl_profitPerc;
    }
}
