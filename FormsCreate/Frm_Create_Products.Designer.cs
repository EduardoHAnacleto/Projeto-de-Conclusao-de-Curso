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
            this.edt_productName = new System.Windows.Forms.TextBox();
            this.lbl_productGroup = new System.Windows.Forms.Label();
            this.lbl_salePrice = new System.Windows.Forms.Label();
            this.lbl_productCost = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.btn_SearchPGroup = new System.Windows.Forms.Button();
            this.edt_stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_barCode = new System.Windows.Forms.Label();
            this.edt_ProfitPerc = new System.Windows.Forms.NumericUpDown();
            this.lbl_profitPerc = new System.Windows.Forms.Label();
            this.edt_productCost = new System.Windows.Forms.NumericUpDown();
            this.edt_barCode = new System.Windows.Forms.TextBox();
            this.edt_und = new System.Windows.Forms.TextBox();
            this.lbl_und = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProfitPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productCost)).BeginInit();
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
            this.edt_id.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            // 
            // cbox_ProductGroup
            // 
            this.cbox_ProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ProductGroup.FormattingEnabled = true;
            this.cbox_ProductGroup.Location = new System.Drawing.Point(474, 23);
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
            this.btn_SearchBrand.Text = "Buscar";
            this.btn_SearchBrand.UseVisualStyleBackColor = true;
            this.btn_SearchBrand.Click += new System.EventHandler(this.btn_SearchBrand_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(10, 53);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(44, 13);
            this.lbl_brand.TabIndex = 29;
            this.lbl_brand.Text = "* Marca";
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
            this.edt_productSalePrice.Location = new System.Drawing.Point(567, 66);
            this.edt_productSalePrice.MaxLength = 6;
            this.edt_productSalePrice.Name = "edt_productSalePrice";
            this.edt_productSalePrice.Size = new System.Drawing.Size(73, 20);
            this.edt_productSalePrice.TabIndex = 27;
            this.edt_productSalePrice.Text = "0";
            this.edt_productSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_productName
            // 
            this.edt_productName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_productName.Location = new System.Drawing.Point(80, 24);
            this.edt_productName.MaxLength = 30;
            this.edt_productName.Name = "edt_productName";
            this.edt_productName.Size = new System.Drawing.Size(250, 20);
            this.edt_productName.TabIndex = 25;
            // 
            // lbl_productGroup
            // 
            this.lbl_productGroup.AutoSize = true;
            this.lbl_productGroup.Location = new System.Drawing.Point(471, 7);
            this.lbl_productGroup.Name = "lbl_productGroup";
            this.lbl_productGroup.Size = new System.Drawing.Size(36, 13);
            this.lbl_productGroup.TabIndex = 24;
            this.lbl_productGroup.Text = "Grupo";
            // 
            // lbl_salePrice
            // 
            this.lbl_salePrice.AutoSize = true;
            this.lbl_salePrice.Location = new System.Drawing.Point(564, 53);
            this.lbl_salePrice.Name = "lbl_salePrice";
            this.lbl_salePrice.Size = new System.Drawing.Size(86, 13);
            this.lbl_salePrice.TabIndex = 23;
            this.lbl_salePrice.Text = "* Valor de venda";
            // 
            // lbl_productCost
            // 
            this.lbl_productCost.AutoSize = true;
            this.lbl_productCost.Location = new System.Drawing.Point(340, 51);
            this.lbl_productCost.Name = "lbl_productCost";
            this.lbl_productCost.Size = new System.Drawing.Size(41, 13);
            this.lbl_productCost.TabIndex = 22;
            this.lbl_productCost.Text = "* Custo";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(77, 8);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(51, 13);
            this.lbl_productName.TabIndex = 21;
            this.lbl_productName.Text = "* Produto";
            // 
            // btn_SearchPGroup
            // 
            this.btn_SearchPGroup.Location = new System.Drawing.Point(586, 23);
            this.btn_SearchPGroup.Name = "btn_SearchPGroup";
            this.btn_SearchPGroup.Size = new System.Drawing.Size(75, 21);
            this.btn_SearchPGroup.TabIndex = 32;
            this.btn_SearchPGroup.Text = "Bu&scar";
            this.btn_SearchPGroup.UseVisualStyleBackColor = true;
            this.btn_SearchPGroup.Click += new System.EventHandler(this.btn_SearchPGroup_Click);
            // 
            // edt_stock
            // 
            this.edt_stock.Enabled = false;
            this.edt_stock.Location = new System.Drawing.Point(408, 67);
            this.edt_stock.Margin = new System.Windows.Forms.Padding(2);
            this.edt_stock.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.edt_stock.Name = "edt_stock";
            this.edt_stock.Size = new System.Drawing.Size(56, 20);
            this.edt_stock.TabIndex = 33;
            this.edt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(405, 52);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(53, 13);
            this.lbl_stock.TabIndex = 34;
            this.lbl_stock.Text = "* Estoque";
            // 
            // lbl_barCode
            // 
            this.lbl_barCode.AutoSize = true;
            this.lbl_barCode.Location = new System.Drawing.Point(9, 106);
            this.lbl_barCode.Name = "lbl_barCode";
            this.lbl_barCode.Size = new System.Drawing.Size(87, 13);
            this.lbl_barCode.TabIndex = 36;
            this.lbl_barCode.Text = "Código de barras";
            // 
            // edt_ProfitPerc
            // 
            this.edt_ProfitPerc.DecimalPlaces = 2;
            this.edt_ProfitPerc.Location = new System.Drawing.Point(469, 67);
            this.edt_ProfitPerc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edt_ProfitPerc.Name = "edt_ProfitPerc";
            this.edt_ProfitPerc.Size = new System.Drawing.Size(68, 20);
            this.edt_ProfitPerc.TabIndex = 37;
            this.edt_ProfitPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edt_ProfitPerc.ValueChanged += new System.EventHandler(this.edt_ProfitPerc_ValueChanged);
            // 
            // lbl_profitPerc
            // 
            this.lbl_profitPerc.AutoSize = true;
            this.lbl_profitPerc.Location = new System.Drawing.Point(467, 52);
            this.lbl_profitPerc.Name = "lbl_profitPerc";
            this.lbl_profitPerc.Size = new System.Drawing.Size(94, 13);
            this.lbl_profitPerc.TabIndex = 38;
            this.lbl_profitPerc.Text = "*Margem de Lucro";
            // 
            // edt_productCost
            // 
            this.edt_productCost.DecimalPlaces = 2;
            this.edt_productCost.Enabled = false;
            this.edt_productCost.Location = new System.Drawing.Point(343, 67);
            this.edt_productCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edt_productCost.Name = "edt_productCost";
            this.edt_productCost.Size = new System.Drawing.Size(60, 20);
            this.edt_productCost.TabIndex = 39;
            this.edt_productCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_barCode
            // 
            this.edt_barCode.Location = new System.Drawing.Point(11, 122);
            this.edt_barCode.MaxLength = 13;
            this.edt_barCode.Name = "edt_barCode";
            this.edt_barCode.Size = new System.Drawing.Size(250, 20);
            this.edt_barCode.TabIndex = 41;
            this.edt_barCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edt_und
            // 
            this.edt_und.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_und.Location = new System.Drawing.Point(336, 24);
            this.edt_und.MaxLength = 15;
            this.edt_und.Name = "edt_und";
            this.edt_und.Size = new System.Drawing.Size(111, 20);
            this.edt_und.TabIndex = 42;
            // 
            // lbl_und
            // 
            this.lbl_und.AutoSize = true;
            this.lbl_und.Location = new System.Drawing.Point(333, 8);
            this.lbl_und.Name = "lbl_und";
            this.lbl_und.Size = new System.Drawing.Size(31, 13);
            this.lbl_und.TabIndex = 43;
            this.lbl_und.Text = "UND";
            // 
            // Frm_Create_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_und);
            this.Controls.Add(this.edt_und);
            this.Controls.Add(this.edt_barCode);
            this.Controls.Add(this.edt_productCost);
            this.Controls.Add(this.lbl_profitPerc);
            this.Controls.Add(this.edt_ProfitPerc);
            this.Controls.Add(this.lbl_barCode);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.edt_stock);
            this.Controls.Add(this.btn_SearchPGroup);
            this.Controls.Add(this.cbox_ProductGroup);
            this.Controls.Add(this.btn_SearchBrand);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.cbox_brands);
            this.Controls.Add(this.edt_productSalePrice);
            this.Controls.Add(this.edt_productName);
            this.Controls.Add(this.lbl_productGroup);
            this.Controls.Add(this.lbl_salePrice);
            this.Controls.Add(this.lbl_productCost);
            this.Controls.Add(this.lbl_productName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_Products";
            this.Text = "Criar Produto";
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
            this.Controls.SetChildIndex(this.edt_productSalePrice, 0);
            this.Controls.SetChildIndex(this.cbox_brands, 0);
            this.Controls.SetChildIndex(this.lbl_brand, 0);
            this.Controls.SetChildIndex(this.btn_SearchBrand, 0);
            this.Controls.SetChildIndex(this.cbox_ProductGroup, 0);
            this.Controls.SetChildIndex(this.btn_SearchPGroup, 0);
            this.Controls.SetChildIndex(this.edt_stock, 0);
            this.Controls.SetChildIndex(this.lbl_stock, 0);
            this.Controls.SetChildIndex(this.lbl_barCode, 0);
            this.Controls.SetChildIndex(this.edt_ProfitPerc, 0);
            this.Controls.SetChildIndex(this.lbl_profitPerc, 0);
            this.Controls.SetChildIndex(this.edt_productCost, 0);
            this.Controls.SetChildIndex(this.edt_barCode, 0);
            this.Controls.SetChildIndex(this.edt_und, 0);
            this.Controls.SetChildIndex(this.lbl_und, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ProfitPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_productCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ProductGroup;
        private System.Windows.Forms.Button btn_SearchBrand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.ComboBox cbox_brands;
        private System.Windows.Forms.TextBox edt_productSalePrice;
        private System.Windows.Forms.TextBox edt_productName;
        private System.Windows.Forms.Label lbl_productGroup;
        private System.Windows.Forms.Label lbl_salePrice;
        private System.Windows.Forms.Label lbl_productCost;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Button btn_SearchPGroup;
        private System.Windows.Forms.NumericUpDown edt_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_barCode;
        private System.Windows.Forms.NumericUpDown edt_ProfitPerc;
        private System.Windows.Forms.Label lbl_profitPerc;
        private System.Windows.Forms.NumericUpDown edt_productCost;
        private System.Windows.Forms.TextBox edt_barCode;
        private System.Windows.Forms.TextBox edt_und;
        private System.Windows.Forms.Label lbl_und;
    }
}
