namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Services
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
            this.lbl_serviceDescription = new System.Windows.Forms.Label();
            this.lbl_serviceValue = new System.Windows.Forms.Label();
            this.edt_serviceDescription = new System.Windows.Forms.TextBox();
            this.edt_serviceValue = new System.Windows.Forms.TextBox();
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
            // lbl_serviceDescription
            // 
            this.lbl_serviceDescription.AutoSize = true;
            this.lbl_serviceDescription.Location = new System.Drawing.Point(61, 8);
            this.lbl_serviceDescription.Name = "lbl_serviceDescription";
            this.lbl_serviceDescription.Size = new System.Drawing.Size(50, 13);
            this.lbl_serviceDescription.TabIndex = 16;
            this.lbl_serviceDescription.Text = "* Serviço";
            // 
            // lbl_serviceValue
            // 
            this.lbl_serviceValue.AutoSize = true;
            this.lbl_serviceValue.Location = new System.Drawing.Point(401, 8);
            this.lbl_serviceValue.Name = "lbl_serviceValue";
            this.lbl_serviceValue.Size = new System.Drawing.Size(38, 13);
            this.lbl_serviceValue.TabIndex = 17;
            this.lbl_serviceValue.Text = "* Valor";
            // 
            // edt_serviceDescription
            // 
            this.edt_serviceDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_serviceDescription.Location = new System.Drawing.Point(64, 24);
            this.edt_serviceDescription.Name = "edt_serviceDescription";
            this.edt_serviceDescription.Size = new System.Drawing.Size(334, 20);
            this.edt_serviceDescription.TabIndex = 18;
            // 
            // edt_serviceValue
            // 
            this.edt_serviceValue.Location = new System.Drawing.Point(404, 23);
            this.edt_serviceValue.Name = "edt_serviceValue";
            this.edt_serviceValue.Size = new System.Drawing.Size(53, 20);
            this.edt_serviceValue.TabIndex = 19;
            // 
            // Frm_Create_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.edt_serviceValue);
            this.Controls.Add(this.edt_serviceDescription);
            this.Controls.Add(this.lbl_serviceValue);
            this.Controls.Add(this.lbl_serviceDescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_Services";
            this.Text = "Criar Serviço";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.lbl_serviceDescription, 0);
            this.Controls.SetChildIndex(this.lbl_serviceValue, 0);
            this.Controls.SetChildIndex(this.edt_serviceDescription, 0);
            this.Controls.SetChildIndex(this.edt_serviceValue, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_serviceDescription;
        private System.Windows.Forms.Label lbl_serviceValue;
        private System.Windows.Forms.TextBox edt_serviceDescription;
        private System.Windows.Forms.TextBox edt_serviceValue;
    }
}
