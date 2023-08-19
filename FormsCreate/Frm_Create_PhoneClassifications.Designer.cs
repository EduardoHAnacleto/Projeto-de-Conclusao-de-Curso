namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_PhoneClassifications
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
            this.lbl_phoneClassification = new System.Windows.Forms.Label();
            this.edt_phoneClassification = new System.Windows.Forms.TextBox();
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
            // lbl_phoneClassification
            // 
            this.lbl_phoneClassification.AutoSize = true;
            this.lbl_phoneClassification.Location = new System.Drawing.Point(54, 10);
            this.lbl_phoneClassification.Name = "lbl_phoneClassification";
            this.lbl_phoneClassification.Size = new System.Drawing.Size(136, 13);
            this.lbl_phoneClassification.TabIndex = 16;
            this.lbl_phoneClassification.Text = "* Classificação de Telefone";
            // 
            // edt_phoneClassification
            // 
            this.edt_phoneClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_phoneClassification.Location = new System.Drawing.Point(57, 24);
            this.edt_phoneClassification.MaxLength = 20;
            this.edt_phoneClassification.Name = "edt_phoneClassification";
            this.edt_phoneClassification.Size = new System.Drawing.Size(229, 20);
            this.edt_phoneClassification.TabIndex = 15;
            // 
            // Frm_Create_PhoneClassifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_phoneClassification);
            this.Controls.Add(this.edt_phoneClassification);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Create_PhoneClassifications";
            this.Text = "Criar Classificação de Telefone";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_phoneClassification, 0);
            this.Controls.SetChildIndex(this.lbl_phoneClassification, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phoneClassification;
        private System.Windows.Forms.TextBox edt_phoneClassification;
    }
}
