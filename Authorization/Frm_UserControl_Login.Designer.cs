namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_UserControl_Login
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.edt_login = new System.Windows.Forms.TextBox();
            this.edt_secret = new System.Windows.Forms.MaskedTextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(44, 99);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(35, 13);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "User :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(20, 125);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(59, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password :";
            // 
            // edt_login
            // 
            this.edt_login.Location = new System.Drawing.Point(85, 99);
            this.edt_login.Name = "edt_login";
            this.edt_login.Size = new System.Drawing.Size(200, 20);
            this.edt_login.TabIndex = 2;
            // 
            // edt_secret
            // 
            this.edt_secret.Location = new System.Drawing.Point(85, 125);
            this.edt_secret.Mask = "************";
            this.edt_secret.Name = "edt_secret";
            this.edt_secret.Size = new System.Drawing.Size(200, 20);
            this.edt_secret.TabIndex = 3;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(182, 166);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(263, 166);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_UserControl_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.edt_secret);
            this.Controls.Add(this.edt_login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Name = "Frm_UserControl_Login";
            this.Size = new System.Drawing.Size(363, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox edt_login;
        private System.Windows.Forms.MaskedTextBox edt_secret;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
    }
}
