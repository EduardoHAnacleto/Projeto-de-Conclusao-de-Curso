namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Users
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
            this.cbox_levelAccess = new System.Windows.Forms.ComboBox();
            this.lbl_userLogin = new System.Windows.Forms.Label();
            this.edt_userLogin = new System.Windows.Forms.TextBox();
            this.lbl_userPassword = new System.Windows.Forms.Label();
            this.lbl_levelAccess = new System.Windows.Forms.Label();
            this.lbl_repeatPassword = new System.Windows.Forms.Label();
            this.gbox_user = new System.Windows.Forms.GroupBox();
            this.medt_userPassword = new System.Windows.Forms.TextBox();
            this.medt_repeatPassword = new System.Windows.Forms.TextBox();
            this.lbl_passwordInfo = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_levelAccess
            // 
            this.cbox_levelAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_levelAccess.FormattingEnabled = true;
            this.cbox_levelAccess.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cbox_levelAccess.Location = new System.Drawing.Point(185, 33);
            this.cbox_levelAccess.Name = "cbox_levelAccess";
            this.cbox_levelAccess.Size = new System.Drawing.Size(82, 21);
            this.cbox_levelAccess.TabIndex = 18;
            // 
            // lbl_userLogin
            // 
            this.lbl_userLogin.AutoSize = true;
            this.lbl_userLogin.Location = new System.Drawing.Point(7, 18);
            this.lbl_userLogin.Name = "lbl_userLogin";
            this.lbl_userLogin.Size = new System.Drawing.Size(33, 13);
            this.lbl_userLogin.TabIndex = 19;
            this.lbl_userLogin.Text = "Login";
            // 
            // edt_userLogin
            // 
            this.edt_userLogin.Location = new System.Drawing.Point(10, 34);
            this.edt_userLogin.MaxLength = 15;
            this.edt_userLogin.Name = "edt_userLogin";
            this.edt_userLogin.Size = new System.Drawing.Size(141, 20);
            this.edt_userLogin.TabIndex = 20;
            // 
            // lbl_userPassword
            // 
            this.lbl_userPassword.AutoSize = true;
            this.lbl_userPassword.Location = new System.Drawing.Point(7, 72);
            this.lbl_userPassword.Name = "lbl_userPassword";
            this.lbl_userPassword.Size = new System.Drawing.Size(38, 13);
            this.lbl_userPassword.TabIndex = 21;
            this.lbl_userPassword.Text = "Senha";
            // 
            // lbl_levelAccess
            // 
            this.lbl_levelAccess.AutoSize = true;
            this.lbl_levelAccess.Location = new System.Drawing.Point(182, 17);
            this.lbl_levelAccess.Name = "lbl_levelAccess";
            this.lbl_levelAccess.Size = new System.Drawing.Size(86, 13);
            this.lbl_levelAccess.TabIndex = 23;
            this.lbl_levelAccess.Text = "Nível de Acesso";
            // 
            // lbl_repeatPassword
            // 
            this.lbl_repeatPassword.AutoSize = true;
            this.lbl_repeatPassword.Location = new System.Drawing.Point(7, 121);
            this.lbl_repeatPassword.Name = "lbl_repeatPassword";
            this.lbl_repeatPassword.Size = new System.Drawing.Size(79, 13);
            this.lbl_repeatPassword.TabIndex = 25;
            this.lbl_repeatPassword.Text = "Repita a senha";
            // 
            // gbox_user
            // 
            this.gbox_user.Controls.Add(this.lbl_passwordInfo);
            this.gbox_user.Controls.Add(this.medt_repeatPassword);
            this.gbox_user.Controls.Add(this.medt_userPassword);
            this.gbox_user.Controls.Add(this.cbox_levelAccess);
            this.gbox_user.Controls.Add(this.lbl_userLogin);
            this.gbox_user.Controls.Add(this.edt_userLogin);
            this.gbox_user.Controls.Add(this.lbl_repeatPassword);
            this.gbox_user.Controls.Add(this.lbl_userPassword);
            this.gbox_user.Controls.Add(this.lbl_levelAccess);
            this.gbox_user.Location = new System.Drawing.Point(69, 12);
            this.gbox_user.Name = "gbox_user";
            this.gbox_user.Size = new System.Drawing.Size(389, 191);
            this.gbox_user.TabIndex = 28;
            this.gbox_user.TabStop = false;
            this.gbox_user.Text = "* Informação do usuário";
            // 
            // medt_userPassword
            // 
            this.medt_userPassword.Location = new System.Drawing.Point(10, 88);
            this.medt_userPassword.MaxLength = 15;
            this.medt_userPassword.Name = "medt_userPassword";
            this.medt_userPassword.Size = new System.Drawing.Size(100, 20);
            this.medt_userPassword.TabIndex = 28;
            this.medt_userPassword.UseSystemPasswordChar = true;
            // 
            // medt_repeatPassword
            // 
            this.medt_repeatPassword.Location = new System.Drawing.Point(10, 137);
            this.medt_repeatPassword.MaxLength = 15;
            this.medt_repeatPassword.Name = "medt_repeatPassword";
            this.medt_repeatPassword.Size = new System.Drawing.Size(100, 20);
            this.medt_repeatPassword.TabIndex = 29;
            this.medt_repeatPassword.UseSystemPasswordChar = true;
            // 
            // lbl_passwordInfo
            // 
            this.lbl_passwordInfo.AutoSize = true;
            this.lbl_passwordInfo.Location = new System.Drawing.Point(7, 160);
            this.lbl_passwordInfo.Name = "lbl_passwordInfo";
            this.lbl_passwordInfo.Size = new System.Drawing.Size(377, 13);
            this.lbl_passwordInfo.TabIndex = 30;
            this.lbl_passwordInfo.Text = "*Senha deve conter ao mínimo uma letra, um número e um caractére especial.";
            // 
            // Frm_Create_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.gbox_user);
            this.Name = "Frm_Create_Users";
            this.Text = "Create Users";
            this.Controls.SetChildIndex(this.lbl_requiredSymbol, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.gbox_user, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_user.ResumeLayout(false);
            this.gbox_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbox_levelAccess;
        private System.Windows.Forms.Label lbl_userLogin;
        private System.Windows.Forms.TextBox edt_userLogin;
        private System.Windows.Forms.Label lbl_userPassword;
        private System.Windows.Forms.Label lbl_levelAccess;
        private System.Windows.Forms.Label lbl_repeatPassword;
        private System.Windows.Forms.GroupBox gbox_user;
        private System.Windows.Forms.TextBox medt_repeatPassword;
        private System.Windows.Forms.TextBox medt_userPassword;
        private System.Windows.Forms.Label lbl_passwordInfo;
    }
}
