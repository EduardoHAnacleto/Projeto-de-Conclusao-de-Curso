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
            this.gbox_dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SearchCountry
            // 
            this.btn_SearchCountry.Location = new System.Drawing.Point(323, 80);
            this.btn_SearchCountry.Name = "btn_SearchCountry";
            this.btn_SearchCountry.Size = new System.Drawing.Size(75, 20);
            this.btn_SearchCountry.TabIndex = 19;
            this.btn_SearchCountry.Text = "Search";
            this.btn_SearchCountry.UseVisualStyleBackColor = true;
            this.btn_SearchCountry.Click += new System.EventHandler(this.btn_SearchCountry_Click);
            // 
            // edt_FU
            // 
            this.edt_FU.Location = new System.Drawing.Point(388, 24);
            this.edt_FU.Name = "edt_FU";
            this.edt_FU.Size = new System.Drawing.Size(45, 20);
            this.edt_FU.TabIndex = 18;
            // 
            // edt_stateName
            // 
            this.edt_stateName.Location = new System.Drawing.Point(66, 24);
            this.edt_stateName.Name = "edt_stateName";
            this.edt_stateName.Size = new System.Drawing.Size(300, 20);
            this.edt_stateName.TabIndex = 17;
            // 
            // lbl_FedUnit
            // 
            this.lbl_FedUnit.AutoSize = true;
            this.lbl_FedUnit.Location = new System.Drawing.Point(385, 8);
            this.lbl_FedUnit.Name = "lbl_FedUnit";
            this.lbl_FedUnit.Size = new System.Drawing.Size(79, 13);
            this.lbl_FedUnit.TabIndex = 16;
            this.lbl_FedUnit.Text = "Federation Unit";
            // 
            // lbl_StateName
            // 
            this.lbl_StateName.AutoSize = true;
            this.lbl_StateName.Location = new System.Drawing.Point(63, 8);
            this.lbl_StateName.Name = "lbl_StateName";
            this.lbl_StateName.Size = new System.Drawing.Size(32, 13);
            this.lbl_StateName.TabIndex = 15;
            this.lbl_StateName.Text = "State";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(115, 65);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 20;
            this.lbl_Country.Text = "Country";
            // 
            // edt_country
            // 
            this.edt_country.Enabled = false;
            this.edt_country.Location = new System.Drawing.Point(118, 81);
            this.edt_country.Name = "edt_country";
            this.edt_country.Size = new System.Drawing.Size(199, 20);
            this.edt_country.TabIndex = 21;
            this.edt_country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_country_KeyPress);
            // 
            // edt_countryId
            // 
            this.edt_countryId.Enabled = false;
            this.edt_countryId.Location = new System.Drawing.Point(66, 80);
            this.edt_countryId.Name = "edt_countryId";
            this.edt_countryId.Size = new System.Drawing.Size(36, 20);
            this.edt_countryId.TabIndex = 22;
            this.edt_countryId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_countryId_KeyPress);
            // 
            // lbl_countryId
            // 
            this.lbl_countryId.AutoSize = true;
            this.lbl_countryId.Location = new System.Drawing.Point(67, 64);
            this.lbl_countryId.Name = "lbl_countryId";
            this.lbl_countryId.Size = new System.Drawing.Size(18, 13);
            this.lbl_countryId.TabIndex = 23;
            this.lbl_countryId.Text = "ID";
            // 
            // Frm_Create_States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_countryId);
            this.Controls.Add(this.edt_countryId);
            this.Controls.Add(this.edt_country);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.btn_SearchCountry);
            this.Controls.Add(this.edt_FU);
            this.Controls.Add(this.edt_stateName);
            this.Controls.Add(this.lbl_FedUnit);
            this.Controls.Add(this.lbl_StateName);
            this.Name = "Frm_Create_States";
            this.Text = "Create State";
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
            this.Controls.SetChildIndex(this.btn_SearchCountry, 0);
            this.Controls.SetChildIndex(this.lbl_Country, 0);
            this.Controls.SetChildIndex(this.edt_country, 0);
            this.Controls.SetChildIndex(this.edt_countryId, 0);
            this.Controls.SetChildIndex(this.lbl_countryId, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
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
    }
}
