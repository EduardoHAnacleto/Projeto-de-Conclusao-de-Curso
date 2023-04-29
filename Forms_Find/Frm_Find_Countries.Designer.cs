namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Find_Countries
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
            this.lbl_countryName = new System.Windows.Forms.Label();
            this.lbl_countryAcronym = new System.Windows.Forms.Label();
            this.lbl_phonePrefix = new System.Windows.Forms.Label();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.edt_countryName = new System.Windows.Forms.TextBox();
            this.edt_acronym = new System.Windows.Forms.TextBox();
            this.edt_phonePrefix = new System.Windows.Forms.TextBox();
            this.edt_currency = new System.Windows.Forms.TextBox();
            this.DGV_Countries = new System.Windows.Forms.DataGridView();
            this.IdCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcronymCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonePrefixCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Countries)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click_1);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // lbl_countryName
            // 
            this.lbl_countryName.AutoSize = true;
            this.lbl_countryName.Location = new System.Drawing.Point(47, 7);
            this.lbl_countryName.Name = "lbl_countryName";
            this.lbl_countryName.Size = new System.Drawing.Size(43, 13);
            this.lbl_countryName.TabIndex = 4;
            this.lbl_countryName.Text = "Country";
            // 
            // lbl_countryAcronym
            // 
            this.lbl_countryAcronym.AutoSize = true;
            this.lbl_countryAcronym.Location = new System.Drawing.Point(349, 7);
            this.lbl_countryAcronym.Name = "lbl_countryAcronym";
            this.lbl_countryAcronym.Size = new System.Drawing.Size(48, 13);
            this.lbl_countryAcronym.TabIndex = 5;
            this.lbl_countryAcronym.Text = "Acronym";
            // 
            // lbl_phonePrefix
            // 
            this.lbl_phonePrefix.AutoSize = true;
            this.lbl_phonePrefix.Location = new System.Drawing.Point(402, 7);
            this.lbl_phonePrefix.Name = "lbl_phonePrefix";
            this.lbl_phonePrefix.Size = new System.Drawing.Size(67, 13);
            this.lbl_phonePrefix.TabIndex = 6;
            this.lbl_phonePrefix.Text = "Phone Prefix";
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Location = new System.Drawing.Point(471, 7);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(49, 13);
            this.lbl_currency.TabIndex = 7;
            this.lbl_currency.Text = "Currency";
            // 
            // edt_countryName
            // 
            this.edt_countryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_countryName.Location = new System.Drawing.Point(50, 23);
            this.edt_countryName.Name = "edt_countryName";
            this.edt_countryName.Size = new System.Drawing.Size(296, 20);
            this.edt_countryName.TabIndex = 8;
            this.edt_countryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_countryName_KeyPress);
            // 
            // edt_acronym
            // 
            this.edt_acronym.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_acronym.Location = new System.Drawing.Point(352, 23);
            this.edt_acronym.Name = "edt_acronym";
            this.edt_acronym.Size = new System.Drawing.Size(45, 20);
            this.edt_acronym.TabIndex = 9;
            this.edt_acronym.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_acronym_KeyPress);
            // 
            // edt_phonePrefix
            // 
            this.edt_phonePrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_phonePrefix.Enabled = false;
            this.edt_phonePrefix.Location = new System.Drawing.Point(403, 23);
            this.edt_phonePrefix.Name = "edt_phonePrefix";
            this.edt_phonePrefix.Size = new System.Drawing.Size(47, 20);
            this.edt_phonePrefix.TabIndex = 10;
            // 
            // edt_currency
            // 
            this.edt_currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_currency.Enabled = false;
            this.edt_currency.Location = new System.Drawing.Point(473, 23);
            this.edt_currency.Name = "edt_currency";
            this.edt_currency.Size = new System.Drawing.Size(46, 20);
            this.edt_currency.TabIndex = 11;
            // 
            // DGV_Countries
            // 
            this.DGV_Countries.AllowUserToAddRows = false;
            this.DGV_Countries.AllowUserToDeleteRows = false;
            this.DGV_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Countries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCountry,
            this.NameCountry,
            this.AcronymCountry,
            this.PhonePrefixCountry,
            this.CurrencyCountry});
            this.DGV_Countries.Location = new System.Drawing.Point(9, 59);
            this.DGV_Countries.MultiSelect = false;
            this.DGV_Countries.Name = "DGV_Countries";
            this.DGV_Countries.ReadOnly = true;
            this.DGV_Countries.RowHeadersWidth = 51;
            this.DGV_Countries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Countries.Size = new System.Drawing.Size(582, 243);
            this.DGV_Countries.TabIndex = 1;
            this.DGV_Countries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Countries_CellClick);
            this.DGV_Countries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Countries_CellContentDoubleClick);
            this.DGV_Countries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Countries_KeyPress);
            // 
            // IdCountry
            // 
            this.IdCountry.HeaderText = "ID";
            this.IdCountry.MinimumWidth = 6;
            this.IdCountry.Name = "IdCountry";
            this.IdCountry.ReadOnly = true;
            this.IdCountry.Width = 50;
            // 
            // NameCountry
            // 
            this.NameCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCountry.HeaderText = "Country name";
            this.NameCountry.MinimumWidth = 6;
            this.NameCountry.Name = "NameCountry";
            this.NameCountry.ReadOnly = true;
            // 
            // AcronymCountry
            // 
            this.AcronymCountry.HeaderText = "Acronym";
            this.AcronymCountry.MinimumWidth = 6;
            this.AcronymCountry.Name = "AcronymCountry";
            this.AcronymCountry.ReadOnly = true;
            this.AcronymCountry.Width = 65;
            // 
            // PhonePrefixCountry
            // 
            this.PhonePrefixCountry.HeaderText = "Phone Prefix";
            this.PhonePrefixCountry.MinimumWidth = 6;
            this.PhonePrefixCountry.Name = "PhonePrefixCountry";
            this.PhonePrefixCountry.ReadOnly = true;
            this.PhonePrefixCountry.Width = 65;
            // 
            // CurrencyCountry
            // 
            this.CurrencyCountry.HeaderText = "Currency";
            this.CurrencyCountry.MinimumWidth = 6;
            this.CurrencyCountry.Name = "CurrencyCountry";
            this.CurrencyCountry.ReadOnly = true;
            this.CurrencyCountry.Width = 65;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(525, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(66, 20);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Find_Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.DGV_Countries);
            this.Controls.Add(this.edt_currency);
            this.Controls.Add(this.edt_phonePrefix);
            this.Controls.Add(this.edt_acronym);
            this.Controls.Add(this.edt_countryName);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.lbl_phonePrefix);
            this.Controls.Add(this.lbl_countryAcronym);
            this.Controls.Add(this.lbl_countryName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_Countries";
            this.Text = "Find Countries";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.lbl_countryName, 0);
            this.Controls.SetChildIndex(this.lbl_countryAcronym, 0);
            this.Controls.SetChildIndex(this.lbl_phonePrefix, 0);
            this.Controls.SetChildIndex(this.lbl_currency, 0);
            this.Controls.SetChildIndex(this.edt_countryName, 0);
            this.Controls.SetChildIndex(this.edt_acronym, 0);
            this.Controls.SetChildIndex(this.edt_phonePrefix, 0);
            this.Controls.SetChildIndex(this.edt_currency, 0);
            this.Controls.SetChildIndex(this.DGV_Countries, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Countries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_countryName;
        private System.Windows.Forms.Label lbl_countryAcronym;
        private System.Windows.Forms.Label lbl_phonePrefix;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.TextBox edt_countryName;
        private System.Windows.Forms.TextBox edt_acronym;
        private System.Windows.Forms.TextBox edt_phonePrefix;
        private System.Windows.Forms.TextBox edt_currency;
        private System.Windows.Forms.DataGridView DGV_Countries;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcronymCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonePrefixCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCountry;
    }
}
