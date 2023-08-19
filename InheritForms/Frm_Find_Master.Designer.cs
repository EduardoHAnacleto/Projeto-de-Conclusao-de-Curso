namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_Find_Master
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.edt_id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(7, 7);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(535, 337);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(56, 19);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Sai&r";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(406, 337);
            this.btn_New.Margin = new System.Windows.Forms.Padding(2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(56, 19);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "&Novo";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(466, 337);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(56, 19);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "&Selecionar";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // edt_id
            // 
            this.edt_id.Location = new System.Drawing.Point(10, 23);
            this.edt_id.Name = "edt_id";
            this.edt_id.Size = new System.Drawing.Size(32, 20);
            this.edt_id.TabIndex = 6;
            this.edt_id.ValueChanged += new System.EventHandler(this.edt_id_ValueChanged);
            // 
            // Frm_Find_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.edt_id);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Find_Master";
            this.Text = "Frm_Find_Master";
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_Select;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_New;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.NumericUpDown edt_id;
    }
}