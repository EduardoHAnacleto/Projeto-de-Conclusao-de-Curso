namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_People
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
            this.medt_regNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.edt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV_People = new System.Windows.Forms.DataGridView();
            this.IdPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Location = new System.Drawing.Point(361, 23);
            this.medt_regNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medt_regNumber.Mask = "000.000.000-00";
            this.medt_regNumber.Name = "medt_regNumber";
            this.medt_regNumber.Size = new System.Drawing.Size(101, 20);
            this.medt_regNumber.TabIndex = 38;
            this.medt_regNumber.ValidatingType = typeof(int);
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Location = new System.Drawing.Point(358, 8);
            this.lbl_regNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(46, 13);
            this.lbl_regNumber.TabIndex = 37;
            this.lbl_regNumber.Text = "Registro";
            // 
            // edt_Name
            // 
            this.edt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_Name.Location = new System.Drawing.Point(53, 23);
            this.edt_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edt_Name.Name = "edt_Name";
            this.edt_Name.Size = new System.Drawing.Size(303, 20);
            this.edt_Name.TabIndex = 32;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(50, 7);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 31;
            this.lbl_Name.Text = "Nome";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(476, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 39;
            this.btn_Search.Text = "Bu&scar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DGV_People
            // 
            this.DGV_People.AllowUserToAddRows = false;
            this.DGV_People.AllowUserToDeleteRows = false;
            this.DGV_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_People.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerson,
            this.NamePerson,
            this.InfoPerson});
            this.DGV_People.Location = new System.Drawing.Point(9, 58);
            this.DGV_People.MultiSelect = false;
            this.DGV_People.Name = "DGV_People";
            this.DGV_People.ReadOnly = true;
            this.DGV_People.RowHeadersWidth = 51;
            this.DGV_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_People.Size = new System.Drawing.Size(579, 274);
            this.DGV_People.TabIndex = 40;
            this.DGV_People.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_People_CellClick);
            this.DGV_People.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_People_CellContentDoubleClick);
            this.DGV_People.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_People_KeyPress);
            // 
            // IdPerson
            // 
            this.IdPerson.HeaderText = "ID";
            this.IdPerson.MinimumWidth = 6;
            this.IdPerson.Name = "IdPerson";
            this.IdPerson.ReadOnly = true;
            this.IdPerson.Width = 55;
            // 
            // NamePerson
            // 
            this.NamePerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamePerson.HeaderText = "Nome";
            this.NamePerson.MinimumWidth = 6;
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.ReadOnly = true;
            // 
            // InfoPerson
            // 
            this.InfoPerson.HeaderText = "Tipo";
            this.InfoPerson.MinimumWidth = 6;
            this.InfoPerson.Name = "InfoPerson";
            this.InfoPerson.ReadOnly = true;
            this.InfoPerson.Width = 125;
            // 
            // Frm_Find_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGV_People);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.medt_regNumber);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.edt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_People";
            this.Text = "Buscar Pessaos";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.edt_Name, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.DGV_People, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox medt_regNumber;
        public System.Windows.Forms.Label lbl_regNumber;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.TextBox edt_Name;
        public System.Windows.Forms.DataGridView DGV_People;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoPerson;
    }
}
