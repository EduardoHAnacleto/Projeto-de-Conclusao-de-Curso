namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Countries
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
            this.edt_currency = new System.Windows.Forms.TextBox();
            this.edt_phonePrefix = new System.Windows.Forms.TextBox();
            this.edt_acronym = new System.Windows.Forms.TextBox();
            this.edt_countryName = new System.Windows.Forms.TextBox();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.lbl_phonePrefix = new System.Windows.Forms.Label();
            this.lbl_countryAcronym = new System.Windows.Forms.Label();
            this.lbl_countryName = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
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
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            // 
            // edt_currency
            // 
            this.edt_currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_currency.Location = new System.Drawing.Point(465, 24);
            this.edt_currency.MaxLength = 10;
            this.edt_currency.Name = "edt_currency";
            this.edt_currency.Size = new System.Drawing.Size(71, 20);
            this.edt_currency.TabIndex = 22;
            // 
            // edt_phonePrefix
            // 
            this.edt_phonePrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_phonePrefix.Location = new System.Drawing.Point(391, 24);
            this.edt_phonePrefix.MaxLength = 4;
            this.edt_phonePrefix.Name = "edt_phonePrefix";
            this.edt_phonePrefix.Size = new System.Drawing.Size(47, 20);
            this.edt_phonePrefix.TabIndex = 21;
            // 
            // edt_acronym
            // 
            this.edt_acronym.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_acronym.Location = new System.Drawing.Point(340, 24);
            this.edt_acronym.MaxLength = 3;
            this.edt_acronym.Name = "edt_acronym";
            this.edt_acronym.Size = new System.Drawing.Size(45, 20);
            this.edt_acronym.TabIndex = 20;
            // 
            // edt_countryName
            // 
            this.edt_countryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_countryName.Location = new System.Drawing.Point(59, 24);
            this.edt_countryName.MaxLength = 50;
            this.edt_countryName.Name = "edt_countryName";
            this.edt_countryName.Size = new System.Drawing.Size(275, 20);
            this.edt_countryName.TabIndex = 19;
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Location = new System.Drawing.Point(463, 8);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(47, 13);
            this.lbl_currency.TabIndex = 18;
            this.lbl_currency.Text = "* Moeda";
            // 
            // lbl_phonePrefix
            // 
            this.lbl_phonePrefix.AutoSize = true;
            this.lbl_phonePrefix.Location = new System.Drawing.Point(390, 8);
            this.lbl_phonePrefix.Name = "lbl_phonePrefix";
            this.lbl_phonePrefix.Size = new System.Drawing.Size(33, 13);
            this.lbl_phonePrefix.TabIndex = 17;
            this.lbl_phonePrefix.Text = "* DDI";
            // 
            // lbl_countryAcronym
            // 
            this.lbl_countryAcronym.AutoSize = true;
            this.lbl_countryAcronym.Location = new System.Drawing.Point(337, 8);
            this.lbl_countryAcronym.Name = "lbl_countryAcronym";
            this.lbl_countryAcronym.Size = new System.Drawing.Size(37, 13);
            this.lbl_countryAcronym.TabIndex = 16;
            this.lbl_countryAcronym.Text = "* Sigla";
            // 
            // lbl_countryName
            // 
            this.lbl_countryName.AutoSize = true;
            this.lbl_countryName.Location = new System.Drawing.Point(56, 8);
            this.lbl_countryName.Name = "lbl_countryName";
            this.lbl_countryName.Size = new System.Drawing.Size(36, 13);
            this.lbl_countryName.TabIndex = 15;
            this.lbl_countryName.Text = "* País";
            // 
            // Frm_Create_Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.edt_currency);
            this.Controls.Add(this.edt_phonePrefix);
            this.Controls.Add(this.edt_acronym);
            this.Controls.Add(this.edt_countryName);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.lbl_phonePrefix);
            this.Controls.Add(this.lbl_countryAcronym);
            this.Controls.Add(this.lbl_countryName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_Countries";
            this.Text = " ";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_countryName, 0);
            this.Controls.SetChildIndex(this.lbl_countryAcronym, 0);
            this.Controls.SetChildIndex(this.lbl_phonePrefix, 0);
            this.Controls.SetChildIndex(this.lbl_currency, 0);
            this.Controls.SetChildIndex(this.edt_countryName, 0);
            this.Controls.SetChildIndex(this.edt_acronym, 0);
            this.Controls.SetChildIndex(this.edt_phonePrefix, 0);
            this.Controls.SetChildIndex(this.edt_currency, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_currency;
        private System.Windows.Forms.TextBox edt_phonePrefix;
        private System.Windows.Forms.TextBox edt_acronym;
        private System.Windows.Forms.TextBox edt_countryName;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Label lbl_phonePrefix;
        private System.Windows.Forms.Label lbl_countryAcronym;
        private System.Windows.Forms.Label lbl_countryName;
    }
}
