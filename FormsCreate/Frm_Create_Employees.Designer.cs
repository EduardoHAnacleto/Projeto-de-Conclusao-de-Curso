namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Employees
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
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_weeklyHours = new System.Windows.Forms.Label();
            this.lbl_baseSalary = new System.Windows.Forms.Label();
            this.lbl_jobRole = new System.Windows.Forms.Label();
            this.edt_weeklyHours = new System.Windows.Forms.TextBox();
            this.edt_baseSalary = new System.Windows.Forms.TextBox();
            this.gbox_jobInfo = new System.Windows.Forms.GroupBox();
            this.medt_endDate = new System.Windows.Forms.DateTimePicker();
            this.medt_startDate = new System.Windows.Forms.DateTimePicker();
            this.edt_jobRole = new System.Windows.Forms.TextBox();
            this.rbtn_active = new System.Windows.Forms.RadioButton();
            this.rbtn_dismissed = new System.Windows.Forms.RadioButton();
            this.gbox_empStatus = new System.Windows.Forms.GroupBox();
            this.gbox_gender.SuspendLayout();
            this.gbox_address.SuspendLayout();
            this.gbox_phones.SuspendLayout();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.gbox_jobInfo.SuspendLayout();
            this.gbox_empStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_age
            // 
            this.edt_age.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_Name
            // 
            this.edt_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.edt_Name.Size = new System.Drawing.Size(384, 22);
            // 
            // edt_complement
            // 
            this.edt_complement.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_district
            // 
            this.edt_district.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_houseNumber
            // 
            this.edt_houseNumber.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_street
            // 
            this.edt_street.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // medt_zipCode
            // 
            this.medt_zipCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_email
            // 
            this.edt_email.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // medt_phone3
            // 
            this.medt_phone3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // medt_phone2
            // 
            this.medt_phone2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // medt_phone1
            // 
            this.medt_phone1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // edt_StateFU
            // 
            this.edt_StateFU.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // edt_countryAcronym
            // 
            this.edt_countryAcronym.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // edt_city
            // 
            this.edt_city.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // edt_homeType
            // 
            this.edt_homeType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(119, 110);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(103, 16);
            this.lbl_endDate.TabIndex = 44;
            this.lbl_endDate.Text = "Dismissed Date";
            this.lbl_endDate.Visible = false;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(3, 111);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(102, 16);
            this.lbl_startDate.TabIndex = 43;
            this.lbl_startDate.Text = "Admission Date";
            // 
            // lbl_weeklyHours
            // 
            this.lbl_weeklyHours.AutoSize = true;
            this.lbl_weeklyHours.Location = new System.Drawing.Point(7, 64);
            this.lbl_weeklyHours.Name = "lbl_weeklyHours";
            this.lbl_weeklyHours.Size = new System.Drawing.Size(92, 16);
            this.lbl_weeklyHours.TabIndex = 41;
            this.lbl_weeklyHours.Text = "Weekly Hours";
            // 
            // lbl_baseSalary
            // 
            this.lbl_baseSalary.AutoSize = true;
            this.lbl_baseSalary.Location = new System.Drawing.Point(104, 65);
            this.lbl_baseSalary.Name = "lbl_baseSalary";
            this.lbl_baseSalary.Size = new System.Drawing.Size(81, 16);
            this.lbl_baseSalary.TabIndex = 40;
            this.lbl_baseSalary.Text = "Base Salary";
            // 
            // lbl_jobRole
            // 
            this.lbl_jobRole.AutoSize = true;
            this.lbl_jobRole.Location = new System.Drawing.Point(11, 18);
            this.lbl_jobRole.Name = "lbl_jobRole";
            this.lbl_jobRole.Size = new System.Drawing.Size(62, 16);
            this.lbl_jobRole.TabIndex = 39;
            this.lbl_jobRole.Text = "Job Role";
            // 
            // edt_weeklyHours
            // 
            this.edt_weeklyHours.Location = new System.Drawing.Point(7, 82);
            this.edt_weeklyHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_weeklyHours.Name = "edt_weeklyHours";
            this.edt_weeklyHours.Size = new System.Drawing.Size(63, 22);
            this.edt_weeklyHours.TabIndex = 35;
            // 
            // edt_baseSalary
            // 
            this.edt_baseSalary.Location = new System.Drawing.Point(108, 84);
            this.edt_baseSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_baseSalary.Name = "edt_baseSalary";
            this.edt_baseSalary.Size = new System.Drawing.Size(79, 22);
            this.edt_baseSalary.TabIndex = 33;
            // 
            // gbox_jobInfo
            // 
            this.gbox_jobInfo.Controls.Add(this.medt_endDate);
            this.gbox_jobInfo.Controls.Add(this.medt_startDate);
            this.gbox_jobInfo.Controls.Add(this.edt_jobRole);
            this.gbox_jobInfo.Controls.Add(this.lbl_endDate);
            this.gbox_jobInfo.Controls.Add(this.edt_baseSalary);
            this.gbox_jobInfo.Controls.Add(this.lbl_startDate);
            this.gbox_jobInfo.Controls.Add(this.edt_weeklyHours);
            this.gbox_jobInfo.Controls.Add(this.lbl_weeklyHours);
            this.gbox_jobInfo.Controls.Add(this.lbl_baseSalary);
            this.gbox_jobInfo.Controls.Add(this.lbl_jobRole);
            this.gbox_jobInfo.Location = new System.Drawing.Point(485, 10);
            this.gbox_jobInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_jobInfo.Name = "gbox_jobInfo";
            this.gbox_jobInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_jobInfo.Size = new System.Drawing.Size(229, 160);
            this.gbox_jobInfo.TabIndex = 45;
            this.gbox_jobInfo.TabStop = false;
            this.gbox_jobInfo.Text = "Job Information";
            // 
            // medt_endDate
            // 
            this.medt_endDate.Enabled = false;
            this.medt_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.medt_endDate.Location = new System.Drawing.Point(123, 129);
            this.medt_endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medt_endDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.medt_endDate.Name = "medt_endDate";
            this.medt_endDate.Size = new System.Drawing.Size(105, 22);
            this.medt_endDate.TabIndex = 47;
            this.medt_endDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.medt_endDate.Visible = false;
            // 
            // medt_startDate
            // 
            this.medt_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.medt_startDate.Location = new System.Drawing.Point(7, 129);
            this.medt_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medt_startDate.Name = "medt_startDate";
            this.medt_startDate.Size = new System.Drawing.Size(111, 22);
            this.medt_startDate.TabIndex = 46;
            // 
            // edt_jobRole
            // 
            this.edt_jobRole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_jobRole.Location = new System.Drawing.Point(7, 38);
            this.edt_jobRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_jobRole.Name = "edt_jobRole";
            this.edt_jobRole.Size = new System.Drawing.Size(180, 22);
            this.edt_jobRole.TabIndex = 45;
            // 
            // rbtn_active
            // 
            this.rbtn_active.AutoSize = true;
            this.rbtn_active.Checked = true;
            this.rbtn_active.Location = new System.Drawing.Point(23, 27);
            this.rbtn_active.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_active.Name = "rbtn_active";
            this.rbtn_active.Size = new System.Drawing.Size(65, 20);
            this.rbtn_active.TabIndex = 48;
            this.rbtn_active.TabStop = true;
            this.rbtn_active.Text = "Active";
            this.rbtn_active.UseVisualStyleBackColor = true;
            this.rbtn_active.CheckedChanged += new System.EventHandler(this.rbtn_active_CheckedChanged);
            // 
            // rbtn_dismissed
            // 
            this.rbtn_dismissed.AutoSize = true;
            this.rbtn_dismissed.Location = new System.Drawing.Point(23, 47);
            this.rbtn_dismissed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_dismissed.Name = "rbtn_dismissed";
            this.rbtn_dismissed.Size = new System.Drawing.Size(74, 20);
            this.rbtn_dismissed.TabIndex = 49;
            this.rbtn_dismissed.TabStop = true;
            this.rbtn_dismissed.Text = "Inactive";
            this.rbtn_dismissed.UseVisualStyleBackColor = true;
            this.rbtn_dismissed.CheckedChanged += new System.EventHandler(this.rbtn_dismissed_CheckedChanged);
            // 
            // gbox_empStatus
            // 
            this.gbox_empStatus.Controls.Add(this.rbtn_active);
            this.gbox_empStatus.Controls.Add(this.rbtn_dismissed);
            this.gbox_empStatus.Location = new System.Drawing.Point(723, 87);
            this.gbox_empStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_empStatus.Name = "gbox_empStatus";
            this.gbox_empStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbox_empStatus.Size = new System.Drawing.Size(147, 76);
            this.gbox_empStatus.TabIndex = 50;
            this.gbox_empStatus.TabStop = false;
            this.gbox_empStatus.Text = "Status";
            // 
            // Frm_Create_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.gbox_empStatus);
            this.Controls.Add(this.gbox_jobInfo);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Create_Employees";
            this.Text = "Create Employees";
            this.Controls.SetChildIndex(this.gbox_jobInfo, 0);
            this.Controls.SetChildIndex(this.gbox_empStatus, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.edt_Name, 0);
            this.Controls.SetChildIndex(this.gbox_phones, 0);
            this.Controls.SetChildIndex(this.gbox_address, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.gbox_gender, 0);
            this.Controls.SetChildIndex(this.edt_age, 0);
            this.Controls.SetChildIndex(this.lbl_age, 0);
            this.Controls.SetChildIndex(this.lbl_dob, 0);
            this.Controls.SetChildIndex(this.medt_dob, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.gbox_gender.ResumeLayout(false);
            this.gbox_gender.PerformLayout();
            this.gbox_address.ResumeLayout(false);
            this.gbox_address.PerformLayout();
            this.gbox_phones.ResumeLayout(false);
            this.gbox_phones.PerformLayout();
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.gbox_jobInfo.ResumeLayout(false);
            this.gbox_jobInfo.PerformLayout();
            this.gbox_empStatus.ResumeLayout(false);
            this.gbox_empStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_weeklyHours;
        private System.Windows.Forms.Label lbl_baseSalary;
        private System.Windows.Forms.Label lbl_jobRole;
        private System.Windows.Forms.TextBox edt_weeklyHours;
        private System.Windows.Forms.TextBox edt_baseSalary;
        private System.Windows.Forms.GroupBox gbox_jobInfo;
        private System.Windows.Forms.TextBox edt_jobRole;
        private System.Windows.Forms.DateTimePicker medt_endDate;
        private System.Windows.Forms.DateTimePicker medt_startDate;
        private System.Windows.Forms.RadioButton rbtn_dismissed;
        private System.Windows.Forms.RadioButton rbtn_active;
        private System.Windows.Forms.GroupBox gbox_empStatus;
    }
}
