namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_ProductGroups
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
            this.edt_groupDescription = new System.Windows.Forms.TextBox();
            this.edt_productGroupName = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_productGroup = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // edt_groupDescription
            // 
            this.edt_groupDescription.Location = new System.Drawing.Point(56, 73);
            this.edt_groupDescription.Name = "edt_groupDescription";
            this.edt_groupDescription.Size = new System.Drawing.Size(307, 20);
            this.edt_groupDescription.TabIndex = 18;
            // 
            // edt_productGroupName
            // 
            this.edt_productGroupName.Location = new System.Drawing.Point(56, 24);
            this.edt_productGroupName.Name = "edt_productGroupName";
            this.edt_productGroupName.Size = new System.Drawing.Size(203, 20);
            this.edt_productGroupName.TabIndex = 17;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(53, 57);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 16;
            this.lbl_description.Text = "Description";
            // 
            // lbl_productGroup
            // 
            this.lbl_productGroup.AutoSize = true;
            this.lbl_productGroup.Location = new System.Drawing.Point(53, 8);
            this.lbl_productGroup.Name = "lbl_productGroup";
            this.lbl_productGroup.Size = new System.Drawing.Size(105, 13);
            this.lbl_productGroup.TabIndex = 15;
            this.lbl_productGroup.Text = "Product Group name";
            // 
            // Frm_Create_ProductGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.edt_groupDescription);
            this.Controls.Add(this.edt_productGroupName);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_productGroup);
            this.Name = "Frm_Create_ProductGroups";
            this.Text = "Create Product Groups";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_productGroup, 0);
            this.Controls.SetChildIndex(this.lbl_description, 0);
            this.Controls.SetChildIndex(this.edt_productGroupName, 0);
            this.Controls.SetChildIndex(this.edt_groupDescription, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_groupDescription;
        private System.Windows.Forms.TextBox edt_productGroupName;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_productGroup;
    }
}
