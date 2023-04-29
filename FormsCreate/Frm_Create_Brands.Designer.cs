namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Brands
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
            this.lbl_brandName = new System.Windows.Forms.Label();
            this.edt_BrandName = new System.Windows.Forms.TextBox();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LastUpdate
            // 
            this.lbl_LastUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastUpdate.Size = new System.Drawing.Size(65, 13);
            this.lbl_LastUpdate.Text = "18/03/2023";
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lbl_brandName
            // 
            this.lbl_brandName.AutoSize = true;
            this.lbl_brandName.Location = new System.Drawing.Point(61, 8);
            this.lbl_brandName.Name = "lbl_brandName";
            this.lbl_brandName.Size = new System.Drawing.Size(70, 13);
            this.lbl_brandName.TabIndex = 16;
            this.lbl_brandName.Text = "*Brand Name";
            // 
            // edt_BrandName
            // 
            this.edt_BrandName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_BrandName.Location = new System.Drawing.Point(64, 24);
            this.edt_BrandName.MaxLength = 30;
            this.edt_BrandName.Name = "edt_BrandName";
            this.edt_BrandName.Size = new System.Drawing.Size(222, 20);
            this.edt_BrandName.TabIndex = 15;
            // 
            // Frm_Create_Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_brandName);
            this.Controls.Add(this.edt_BrandName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Create_Brands";
            this.Text = "Create Brand";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_BrandName, 0);
            this.Controls.SetChildIndex(this.lbl_brandName, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_brandName;
        private System.Windows.Forms.TextBox edt_BrandName;
    }
}
