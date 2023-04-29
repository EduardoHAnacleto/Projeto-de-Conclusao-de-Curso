namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Clients
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
            this.check_LegalClient = new System.Windows.Forms.CheckBox();
            this.check_NaturalClient = new System.Windows.Forms.CheckBox();
            this.gbox_clientType = new System.Windows.Forms.GroupBox();
            this.gbox_gender.SuspendLayout();
            this.gbox_address.SuspendLayout();
            this.gbox_phones.SuspendLayout();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_clientType.SuspendLayout();
            this.SuspendLayout();
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_age
            // 
            this.edt_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_Name
            // 
            this.edt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_complement
            // 
            this.edt_complement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_district
            // 
            this.edt_district.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_houseNumber
            // 
            this.edt_houseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_street
            // 
            this.edt_street.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // medt_zipCode
            // 
            this.medt_zipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_email
            // 
            this.edt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // medt_phone3
            // 
            this.medt_phone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // medt_phone2
            // 
            this.medt_phone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // medt_phone1
            // 
            this.medt_phone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // edt_StateFU
            // 
            this.edt_StateFU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // edt_countryAcronym
            // 
            this.edt_countryAcronym.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // edt_city
            // 
            this.edt_city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // edt_homeType
            // 
            this.edt_homeType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // medt_dob
            // 
            this.medt_dob.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // check_LegalClient
            // 
            this.check_LegalClient.AutoSize = true;
            this.check_LegalClient.Location = new System.Drawing.Point(6, 43);
            this.check_LegalClient.Name = "check_LegalClient";
            this.check_LegalClient.Size = new System.Drawing.Size(52, 17);
            this.check_LegalClient.TabIndex = 35;
            this.check_LegalClient.Text = "Legal";
            this.check_LegalClient.UseVisualStyleBackColor = true;
            this.check_LegalClient.CheckedChanged += new System.EventHandler(this.check_LegalClient_CheckedChanged);
            // 
            // check_NaturalClient
            // 
            this.check_NaturalClient.AutoSize = true;
            this.check_NaturalClient.Location = new System.Drawing.Point(6, 19);
            this.check_NaturalClient.Name = "check_NaturalClient";
            this.check_NaturalClient.Size = new System.Drawing.Size(60, 17);
            this.check_NaturalClient.TabIndex = 34;
            this.check_NaturalClient.Text = "Natural";
            this.check_NaturalClient.UseVisualStyleBackColor = true;
            this.check_NaturalClient.CheckedChanged += new System.EventHandler(this.check_NaturalClient_CheckedChanged);
            // 
            // gbox_clientType
            // 
            this.gbox_clientType.Controls.Add(this.check_NaturalClient);
            this.gbox_clientType.Controls.Add(this.check_LegalClient);
            this.gbox_clientType.Location = new System.Drawing.Point(418, 11);
            this.gbox_clientType.Name = "gbox_clientType";
            this.gbox_clientType.Size = new System.Drawing.Size(114, 65);
            this.gbox_clientType.TabIndex = 36;
            this.gbox_clientType.TabStop = false;
            this.gbox_clientType.Text = "*Client Type";
            // 
            // Frm_Create_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.gbox_clientType);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Create_Clients";
            this.Text = "Create Clients";
            this.Controls.SetChildIndex(this.gbox_clientType, 0);
            this.Controls.SetChildIndex(this.gbox_gender, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.edt_Name, 0);
            this.Controls.SetChildIndex(this.gbox_phones, 0);
            this.Controls.SetChildIndex(this.gbox_address, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_age, 0);
            this.Controls.SetChildIndex(this.lbl_age, 0);
            this.Controls.SetChildIndex(this.lbl_dob, 0);
            this.Controls.SetChildIndex(this.medt_dob, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.gbox_gender.ResumeLayout(false);
            this.gbox_gender.PerformLayout();
            this.gbox_address.ResumeLayout(false);
            this.gbox_address.PerformLayout();
            this.gbox_phones.ResumeLayout(false);
            this.gbox_phones.PerformLayout();
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_clientType.ResumeLayout(false);
            this.gbox_clientType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox check_LegalClient;
        public System.Windows.Forms.CheckBox check_NaturalClient;
        public System.Windows.Forms.GroupBox gbox_clientType;
    }
}
