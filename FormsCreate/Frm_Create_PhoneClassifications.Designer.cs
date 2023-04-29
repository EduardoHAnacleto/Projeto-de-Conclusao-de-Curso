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
            this.lbl_LastUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lbl_phoneClassification
            // 
            this.lbl_phoneClassification.AutoSize = true;
            this.lbl_phoneClassification.Location = new System.Drawing.Point(72, 12);
            this.lbl_phoneClassification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phoneClassification.Name = "lbl_phoneClassification";
            this.lbl_phoneClassification.Size = new System.Drawing.Size(126, 16);
            this.lbl_phoneClassification.TabIndex = 16;
            this.lbl_phoneClassification.Text = "Phone classification";
            // 
            // edt_phoneClassification
            // 
            this.edt_phoneClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_phoneClassification.Location = new System.Drawing.Point(76, 30);
            this.edt_phoneClassification.Margin = new System.Windows.Forms.Padding(4);
            this.edt_phoneClassification.MaxLength = 20;
            this.edt_phoneClassification.Name = "edt_phoneClassification";
            this.edt_phoneClassification.Size = new System.Drawing.Size(304, 22);
            this.edt_phoneClassification.TabIndex = 15;
            // 
            // Frm_Create_PhoneClassifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.lbl_phoneClassification);
            this.Controls.Add(this.edt_phoneClassification);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Create_PhoneClassifications";
            this.Text = "Create Phone Classification";
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
