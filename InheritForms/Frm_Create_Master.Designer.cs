namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_Create_Master
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
            this.gbox_dates = new System.Windows.Forms.GroupBox();
            this.lbl_LastUpdate = new System.Windows.Forms.Label();
            this.lbl_CreationDate = new System.Windows.Forms.Label();
            this.lbl_Sign_LastUpdate = new System.Windows.Forms.Label();
            this.lbl_Sign_creationDate = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_SelectDelete = new System.Windows.Forms.Button();
            this.btn_NewSave = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.edt_id = new System.Windows.Forms.NumericUpDown();
            this.lbl_requiredSymbol = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_dates
            // 
            this.gbox_dates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbox_dates.Controls.Add(this.lbl_LastUpdate);
            this.gbox_dates.Controls.Add(this.lbl_CreationDate);
            this.gbox_dates.Controls.Add(this.lbl_Sign_LastUpdate);
            this.gbox_dates.Controls.Add(this.lbl_Sign_creationDate);
            this.gbox_dates.Location = new System.Drawing.Point(12, 322);
            this.gbox_dates.Name = "gbox_dates";
            this.gbox_dates.Size = new System.Drawing.Size(174, 48);
            this.gbox_dates.TabIndex = 14;
            this.gbox_dates.TabStop = false;
            // 
            // lbl_LastUpdate
            // 
            this.lbl_LastUpdate.AutoSize = true;
            this.lbl_LastUpdate.Location = new System.Drawing.Point(99, 29);
            this.lbl_LastUpdate.Name = "lbl_LastUpdate";
            this.lbl_LastUpdate.Size = new System.Drawing.Size(69, 13);
            this.lbl_LastUpdate.TabIndex = 8;
            this.lbl_LastUpdate.Text = "dd/mm/aaaa";
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.AutoSize = true;
            this.lbl_CreationDate.Location = new System.Drawing.Point(99, 16);
            this.lbl_CreationDate.Name = "lbl_CreationDate";
            this.lbl_CreationDate.Size = new System.Drawing.Size(69, 13);
            this.lbl_CreationDate.TabIndex = 2;
            this.lbl_CreationDate.Text = "dd/mm/aaaa";
            // 
            // lbl_Sign_LastUpdate
            // 
            this.lbl_Sign_LastUpdate.AutoSize = true;
            this.lbl_Sign_LastUpdate.Location = new System.Drawing.Point(6, 29);
            this.lbl_Sign_LastUpdate.Name = "lbl_Sign_LastUpdate";
            this.lbl_Sign_LastUpdate.Size = new System.Drawing.Size(90, 13);
            this.lbl_Sign_LastUpdate.TabIndex = 1;
            this.lbl_Sign_LastUpdate.Text = "Última Alteração :";
            // 
            // lbl_Sign_creationDate
            // 
            this.lbl_Sign_creationDate.AutoSize = true;
            this.lbl_Sign_creationDate.Location = new System.Drawing.Point(6, 16);
            this.lbl_Sign_creationDate.Name = "lbl_Sign_creationDate";
            this.lbl_Sign_creationDate.Size = new System.Drawing.Size(90, 13);
            this.lbl_Sign_creationDate.TabIndex = 0;
            this.lbl_Sign_creationDate.Text = "Data de Criação :";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(489, 351);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(56, 19);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "&Alterar";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_SelectDelete
            // 
            this.btn_SelectDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectDelete.Enabled = false;
            this.btn_SelectDelete.Location = new System.Drawing.Point(549, 351);
            this.btn_SelectDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SelectDelete.Name = "btn_SelectDelete";
            this.btn_SelectDelete.Size = new System.Drawing.Size(56, 19);
            this.btn_SelectDelete.TabIndex = 12;
            this.btn_SelectDelete.Text = "E&xcluir";
            this.btn_SelectDelete.UseVisualStyleBackColor = true;
            this.btn_SelectDelete.Click += new System.EventHandler(this.btn_SelectDelete_Click);
            // 
            // btn_NewSave
            // 
            this.btn_NewSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewSave.Location = new System.Drawing.Point(429, 351);
            this.btn_NewSave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewSave.Name = "btn_NewSave";
            this.btn_NewSave.Size = new System.Drawing.Size(56, 19);
            this.btn_NewSave.TabIndex = 10;
            this.btn_NewSave.Text = "&Salvar";
            this.btn_NewSave.UseVisualStyleBackColor = true;
            this.btn_NewSave.Click += new System.EventHandler(this.btn_NewSave_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(609, 351);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(56, 19);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Sai&r";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 8);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID";
            // 
            // edt_id
            // 
            this.edt_id.Enabled = false;
            this.edt_id.Location = new System.Drawing.Point(12, 24);
            this.edt_id.Name = "edt_id";
            this.edt_id.Size = new System.Drawing.Size(39, 20);
            this.edt_id.TabIndex = 15;
            this.edt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_requiredSymbol
            // 
            this.lbl_requiredSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_requiredSymbol.AutoSize = true;
            this.lbl_requiredSymbol.Location = new System.Drawing.Point(192, 357);
            this.lbl_requiredSymbol.Name = "lbl_requiredSymbol";
            this.lbl_requiredSymbol.Size = new System.Drawing.Size(112, 13);
            this.lbl_requiredSymbol.TabIndex = 16;
            this.lbl_requiredSymbol.Text = "* Campos obrigatórios.";
            // 
            // Frm_Create_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 379);
            this.Controls.Add(this.lbl_requiredSymbol);
            this.Controls.Add(this.edt_id);
            this.Controls.Add(this.gbox_dates);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_SelectDelete);
            this.Controls.Add(this.btn_NewSave);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_Create_Master";
            this.Text = "Frm_Create_Master";
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbox_dates;
        public System.Windows.Forms.Label lbl_LastUpdate;
        public System.Windows.Forms.Label lbl_CreationDate;
        public System.Windows.Forms.Label lbl_Sign_LastUpdate;
        public System.Windows.Forms.Label lbl_Sign_creationDate;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Button btn_SelectDelete;
        public System.Windows.Forms.Button btn_NewSave;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.NumericUpDown edt_id;
        public System.Windows.Forms.Label lbl_requiredSymbol;
    }
}