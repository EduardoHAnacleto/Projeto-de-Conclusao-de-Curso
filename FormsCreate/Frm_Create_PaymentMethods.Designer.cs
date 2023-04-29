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
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(75, 10);
            this.lbl_PaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(108, 16);
            this.lbl_PaymentMethod.TabIndex = 16;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // edt_paymentMethod
            // 
            this.edt_paymentMethod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_paymentMethod.Location = new System.Drawing.Point(79, 30);
            this.edt_paymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.edt_paymentMethod.MaxLength = 30;
            this.edt_paymentMethod.Name = "edt_paymentMethod";
            this.edt_paymentMethod.Size = new System.Drawing.Size(335, 22);
            this.edt_paymentMethod.TabIndex = 15;
            // 
            // Frm_Create_PaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.lbl_PaymentMethod);
            this.Controls.Add(this.edt_paymentMethod);
            this.Margin = new System.Windows.Forms.Padding(5);
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
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.TextBox edt_paymentMethod;
    }
}
