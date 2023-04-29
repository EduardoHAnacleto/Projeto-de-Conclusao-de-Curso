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
            this.lbl_empName = new System.Windows.Forms.Label();
            this.edt_employeeName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbox_levelAccess = new System.Windows.Forms.ComboBox();
            this.lbl_userLogin = new System.Windows.Forms.Label();
            this.edt_userLogin = new System.Windows.Forms.TextBox();
            this.lbl_userPassword = new System.Windows.Forms.Label();
            this.lbl_levelAccess = new System.Windows.Forms.Label();
            this.lbl_repeatPassword = new System.Windows.Forms.Label();
            this.medt_userPassword = new System.Windows.Forms.MaskedTextBox();
            this.medt_repeatPassword = new System.Windows.Forms.MaskedTextBox();
            this.gbox_user = new System.Windows.Forms.GroupBox();
            this.gbox_employee = new System.Windows.Forms.GroupBox();
            this.lbl_empId = new System.Windows.Forms.Label();
            this.edt_idEmployee = new System.Windows.Forms.NumericUpDown();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_user.SuspendLayout();
            this.gbox_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_idEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(2, 59);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(35, 13);
            this.lbl_empName.TabIndex = 15;
            this.lbl_empName.Text = "Name";
            // 
            // edt_employeeName
            // 
            this.edt_employeeName.Enabled = false;
            this.edt_employeeName.Location = new System.Drawing.Point(5, 75);
            this.edt_employeeName.Name = "edt_employeeName";
            this.edt_employeeName.Size = new System.Drawing.Size(238, 20);
            this.edt_employeeName.TabIndex = 16;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(249, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(63, 21);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbox_levelAccess
            // 
            this.cbox_levelAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_levelAccess.FormattingEnabled = true;
            this.cbox_levelAccess.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbox_levelAccess.Location = new System.Drawing.Point(185, 33);
            this.cbox_levelAccess.Name = "cbox_levelAccess";
            this.cbox_levelAccess.Size = new System.Drawing.Size(63, 21);
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
            this.edt_userLogin.Name = "edt_userLogin";
            this.edt_userLogin.Size = new System.Drawing.Size(141, 20);
            this.edt_userLogin.TabIndex = 20;
            // 
            // lbl_userPassword
            // 
            this.lbl_userPassword.AutoSize = true;
            this.lbl_userPassword.Location = new System.Drawing.Point(7, 72);
            this.lbl_userPassword.Name = "lbl_userPassword";
            this.lbl_userPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_userPassword.TabIndex = 21;
            this.lbl_userPassword.Text = "Password";
            // 
            // lbl_levelAccess
            // 
            this.lbl_levelAccess.AutoSize = true;
            this.lbl_levelAccess.Location = new System.Drawing.Point(182, 17);
            this.lbl_levelAccess.Name = "lbl_levelAccess";
            this.lbl_levelAccess.Size = new System.Drawing.Size(71, 13);
            this.lbl_levelAccess.TabIndex = 23;
            this.lbl_levelAccess.Text = "Level Access";
            // 
            // lbl_repeatPassword
            // 
            this.lbl_repeatPassword.AutoSize = true;
            this.lbl_repeatPassword.Location = new System.Drawing.Point(7, 121);
            this.lbl_repeatPassword.Name = "lbl_repeatPassword";
            this.lbl_repeatPassword.Size = new System.Drawing.Size(91, 13);
            this.lbl_repeatPassword.TabIndex = 25;
            this.lbl_repeatPassword.Text = "Repeat Password";
            // 
            // medt_userPassword
            // 
            this.medt_userPassword.Location = new System.Drawing.Point(10, 88);
            this.medt_userPassword.Name = "medt_userPassword";
            this.medt_userPassword.Size = new System.Drawing.Size(141, 20);
            this.medt_userPassword.TabIndex = 26;
            // 
            // medt_repeatPassword
            // 
            this.medt_repeatPassword.Location = new System.Drawing.Point(10, 137);
            this.medt_repeatPassword.Name = "medt_repeatPassword";
            this.medt_repeatPassword.Size = new System.Drawing.Size(141, 20);
            this.medt_repeatPassword.TabIndex = 27;
            // 
            // gbox_user
            // 
            this.gbox_user.Controls.Add(this.cbox_levelAccess);
            this.gbox_user.Controls.Add(this.medt_repeatPassword);
            this.gbox_user.Controls.Add(this.lbl_userLogin);
            this.gbox_user.Controls.Add(this.medt_userPassword);
            this.gbox_user.Controls.Add(this.edt_userLogin);
            this.gbox_user.Controls.Add(this.lbl_repeatPassword);
            this.gbox_user.Controls.Add(this.lbl_userPassword);
            this.gbox_user.Controls.Add(this.lbl_levelAccess);
            this.gbox_user.Location = new System.Drawing.Point(41, 117);
            this.gbox_user.Name = "gbox_user";
            this.gbox_user.Size = new System.Drawing.Size(260, 175);
            this.gbox_user.TabIndex = 28;
            this.gbox_user.TabStop = false;
            this.gbox_user.Text = "*User Information";
            // 
            // gbox_employee
            // 
            this.gbox_employee.Controls.Add(this.lbl_empId);
            this.gbox_employee.Controls.Add(this.edt_idEmployee);
            this.gbox_employee.Controls.Add(this.btn_Search);
            this.gbox_employee.Controls.Add(this.lbl_empName);
            this.gbox_employee.Controls.Add(this.edt_employeeName);
            this.gbox_employee.Location = new System.Drawing.Point(71, 8);
            this.gbox_employee.Name = "gbox_employee";
            this.gbox_employee.Size = new System.Drawing.Size(321, 103);
            this.gbox_employee.TabIndex = 29;
            this.gbox_employee.TabStop = false;
            this.gbox_employee.Text = "*Employee";
            // 
            // lbl_empId
            // 
            this.lbl_empId.AutoSize = true;
            this.lbl_empId.Location = new System.Drawing.Point(2, 20);
            this.lbl_empId.Name = "lbl_empId";
            this.lbl_empId.Size = new System.Drawing.Size(18, 13);
            this.lbl_empId.TabIndex = 19;
            this.lbl_empId.Text = "ID";
            // 
            // edt_idEmployee
            // 
            this.edt_idEmployee.Enabled = false;
            this.edt_idEmployee.Location = new System.Drawing.Point(5, 36);
            this.edt_idEmployee.Name = "edt_idEmployee";
            this.edt_idEmployee.Size = new System.Drawing.Size(45, 20);
            this.edt_idEmployee.TabIndex = 18;
            // 
            // Frm_Create_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.gbox_employee);
            this.Controls.Add(this.gbox_user);
            this.Name = "Frm_Create_Users";
            this.Text = "Create Users";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.gbox_user, 0);
            this.Controls.SetChildIndex(this.gbox_employee, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_user.ResumeLayout(false);
            this.gbox_user.PerformLayout();
            this.gbox_employee.ResumeLayout(false);
            this.gbox_employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_idEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox edt_employeeName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbox_levelAccess;
        private System.Windows.Forms.Label lbl_userLogin;
        private System.Windows.Forms.TextBox edt_userLogin;
        private System.Windows.Forms.Label lbl_userPassword;
        private System.Windows.Forms.Label lbl_levelAccess;
        private System.Windows.Forms.Label lbl_repeatPassword;
        private System.Windows.Forms.MaskedTextBox medt_userPassword;
        private System.Windows.Forms.MaskedTextBox medt_repeatPassword;
        private System.Windows.Forms.GroupBox gbox_user;
        private System.Windows.Forms.GroupBox gbox_employee;
        private System.Windows.Forms.Label lbl_empId;
        private System.Windows.Forms.NumericUpDown edt_idEmployee;
    }
}
