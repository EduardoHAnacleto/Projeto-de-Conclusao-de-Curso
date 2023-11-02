namespace ProjetoEduardoAnacletoWindowsForm1.Authorization
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.edt_secret = new System.Windows.Forms.MaskedTextBox();
            this.edt_login = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(114, 33);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(124, 13);
            this.lbl_login.TabIndex = 13;
            this.lbl_login.Text = "Autenticação de Usuário";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(256, 153);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Enter.Location = new System.Drawing.Point(175, 153);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 11;
            this.btn_Enter.Text = "Login";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // edt_secret
            // 
            this.edt_secret.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_secret.Location = new System.Drawing.Point(78, 112);
            this.edt_secret.Name = "edt_secret";
            this.edt_secret.Size = new System.Drawing.Size(200, 20);
            this.edt_secret.TabIndex = 10;
            this.edt_secret.UseSystemPasswordChar = true;
            // 
            // edt_login
            // 
            this.edt_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_login.Location = new System.Drawing.Point(78, 86);
            this.edt_login.MaxLength = 15;
            this.edt_login.Name = "edt_login";
            this.edt_login.Size = new System.Drawing.Size(200, 20);
            this.edt_login.TabIndex = 9;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(28, 115);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(44, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Senha :";
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(28, 89);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(49, 13);
            this.lbl_User.TabIndex = 7;
            this.lbl_User.Text = "Usuário :";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 221);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.edt_secret);
            this.Controls.Add(this.edt_login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.MaskedTextBox edt_secret;
        private System.Windows.Forms.TextBox edt_login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
    }
}