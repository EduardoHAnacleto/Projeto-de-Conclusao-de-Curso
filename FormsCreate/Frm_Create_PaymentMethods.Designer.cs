namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_PaymentMethods
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
            this.lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.edt_paymentMethod = new System.Windows.Forms.TextBox();
            this.gbox_dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(56, 8);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lbl_PaymentMethod.TabIndex = 16;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // edt_paymentMethod
            // 
            this.edt_paymentMethod.Location = new System.Drawing.Point(59, 24);
            this.edt_paymentMethod.Name = "edt_paymentMethod";
            this.edt_paymentMethod.Size = new System.Drawing.Size(252, 20);
            this.edt_paymentMethod.TabIndex = 15;
            // 
            // Frm_Create_PaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_PaymentMethod);
            this.Controls.Add(this.edt_paymentMethod);
            this.Name = "Frm_Create_PaymentMethods";
            this.Text = "Create Payment Methods";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.edt_paymentMethod, 0);
            this.Controls.SetChildIndex(this.lbl_PaymentMethod, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.TextBox edt_paymentMethod;
    }
}
