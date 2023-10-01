namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_States
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
            this.btn_SearchCountry = new System.Windows.Forms.Button();
            this.edt_FU = new System.Windows.Forms.TextBox();
            this.edt_stateName = new System.Windows.Forms.TextBox();
            this.lbl_FedUnit = new System.Windows.Forms.Label();
            this.lbl_StateName = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.edt_country = new System.Windows.Forms.TextBox();
            this.edt_countryId = new System.Windows.Forms.TextBox();
            this.lbl_countryId = new System.Windows.Forms.Label();
            this.gbox_country = new System.Windows.Forms.GroupBox();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_country.SuspendLayout();
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
            // btn_SearchCountry
            // 
            this.btn_SearchCountry.Location = new System.Drawing.Point(263, 35);
            this.btn_SearchCountry.Name = "btn_SearchCountry";
            this.btn_SearchCountry.Size = new System.Drawing.Size(75, 20);
            this.btn_SearchCountry.TabIndex = 19;
            this.btn_SearchCountry.Text = "Search";
            this.btn_SearchCountry.UseVisualStyleBackColor = true;
            this.btn_SearchCountry.Click += new System.EventHandler(this.btn_SearchCountry_Click);
            // 
            // edt_FU
            // 
            this.edt_FU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_FU.Location = new System.Drawing.Point(388, 24);
            this.edt_FU.MaxLength = 3;
            this.edt_FU.Name = "edt_FU";
            this.edt_FU.Size = new System.Drawing.Size(45, 20);
            this.edt_FU.TabIndex = 18;
            // 
            // edt_stateName
            // 
            this.edt_stateName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_stateName.Location = new System.Drawing.Point(66, 24);
            this.edt_stateName.MaxLength = 50;
            this.edt_stateName.Name = "edt_stateName";
            this.edt_stateName.Size = new System.Drawing.Size(300, 20);
            this.edt_stateName.TabIndex = 17;
            // 
            // lbl_FedUnit
            // 
            this.lbl_FedUnit.AutoSize = true;
            this.lbl_FedUnit.Location = new System.Drawing.Point(385, 8);
            this.lbl_FedUnit.Name = "lbl_FedUnit";
            this.lbl_FedUnit.Size = new System.Drawing.Size(123, 13);
            this.lbl_FedUnit.TabIndex = 16;
            this.lbl_FedUnit.Text = "* Unidade de Federação";
            // 
            // lbl_StateName
            // 
            this.lbl_StateName.AutoSize = true;
            this.lbl_StateName.Location = new System.Drawing.Point(63, 8);
            this.lbl_StateName.Name = "lbl_StateName";
            this.lbl_StateName.Size = new System.Drawing.Size(47, 13);
            this.lbl_StateName.TabIndex = 15;
            this.lbl_StateName.Text = "* Estado";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(55, 20);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(36, 13);
            this.lbl_Country.TabIndex = 20;
            this.lbl_Country.Text = "* País";
            // 
            // edt_country
            // 
            this.edt_country.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_country.Enabled = false;
            this.edt_country.Location = new System.Drawing.Point(58, 36);
            this.edt_country.MaxLength = 50;
            this.edt_country.Name = "edt_country";
            this.edt_country.Size = new System.Drawing.Size(199, 20);
            this.edt_country.TabIndex = 21;
            this.edt_country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_country_KeyPress);
            // 
            // edt_countryId
            // 
            this.edt_countryId.Enabled = false;
            this.edt_countryId.Location = new System.Drawing.Point(6, 35);
            this.edt_countryId.MaxLength = 9;
            this.edt_countryId.Name = "edt_countryId";
            this.edt_countryId.Size = new System.Drawing.Size(36, 20);
            this.edt_countryId.TabIndex = 22;
            this.edt_countryId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_countryId_KeyPress);
            // 
            // lbl_countryId
            // 
            this.lbl_countryId.AutoSize = true;
            this.lbl_countryId.Location = new System.Drawing.Point(7, 19);
            this.lbl_countryId.Name = "lbl_countryId";
            this.lbl_countryId.Size = new System.Drawing.Size(22, 13);
            this.lbl_countryId.TabIndex = 23;
            this.lbl_countryId.Text = "*ID";
            // 
            // gbox_country
            // 
            this.gbox_country.Controls.Add(this.edt_countryId);
            this.gbox_country.Controls.Add(this.lbl_countryId);
            this.gbox_country.Controls.Add(this.btn_SearchCountry);
            this.gbox_country.Controls.Add(this.lbl_Country);
            this.gbox_country.Controls.Add(this.edt_country);
            this.gbox_country.Location = new System.Drawing.Point(12, 64);
            this.gbox_country.Name = "gbox_country";
            this.gbox_country.Size = new System.Drawing.Size(344, 71);
            this.gbox_country.TabIndex = 24;
            this.gbox_country.TabStop = false;
            this.gbox_country.Text = "País";
            // 
            // Frm_Create_States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.gbox_country);
            this.Controls.Add(this.edt_FU);
            this.Controls.Add(this.edt_stateName);
            this.Controls.Add(this.lbl_FedUnit);
            this.Controls.Add(this.lbl_StateName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_States";
            this.Text = "Criar Estado";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_StateName, 0);
            this.Controls.SetChildIndex(this.lbl_FedUnit, 0);
            this.Controls.SetChildIndex(this.edt_stateName, 0);
            this.Controls.SetChildIndex(this.edt_FU, 0);
            this.Controls.SetChildIndex(this.gbox_country, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_country.ResumeLayout(false);
            this.gbox_country.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchCountry;
        private System.Windows.Forms.TextBox edt_FU;
        private System.Windows.Forms.TextBox edt_stateName;
        private System.Windows.Forms.Label lbl_FedUnit;
        private System.Windows.Forms.Label lbl_StateName;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.TextBox edt_country;
        private System.Windows.Forms.TextBox edt_countryId;
        private System.Windows.Forms.Label lbl_countryId;
        private System.Windows.Forms.GroupBox gbox_country;
    }
}
