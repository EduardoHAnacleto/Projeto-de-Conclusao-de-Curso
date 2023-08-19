namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_Services
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
            this.edt_serviceDescription = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV_Services = new System.Windows.Forms.DataGridView();
            this.lbl_serviceDescription = new System.Windows.Forms.Label();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // edt_serviceDescription
            // 
            this.edt_serviceDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_serviceDescription.Location = new System.Drawing.Point(48, 22);
            this.edt_serviceDescription.Name = "edt_serviceDescription";
            this.edt_serviceDescription.Size = new System.Drawing.Size(312, 20);
            this.edt_serviceDescription.TabIndex = 7;
            this.edt_serviceDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_serviceDescription_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(366, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 21);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Bu&scar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DGV_Services
            // 
            this.DGV_Services.AllowUserToAddRows = false;
            this.DGV_Services.AllowUserToDeleteRows = false;
            this.DGV_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceDescription,
            this.ServiceValue});
            this.DGV_Services.Location = new System.Drawing.Point(10, 61);
            this.DGV_Services.MultiSelect = false;
            this.DGV_Services.Name = "DGV_Services";
            this.DGV_Services.ReadOnly = true;
            this.DGV_Services.RowHeadersWidth = 51;
            this.DGV_Services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Services.Size = new System.Drawing.Size(578, 259);
            this.DGV_Services.TabIndex = 9;
            this.DGV_Services.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Services_CellClick);
            this.DGV_Services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Services_CellContentClick);
            this.DGV_Services.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Services_CellContentDoubleClick);
            this.DGV_Services.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Services_KeyPress);
            // 
            // lbl_serviceDescription
            // 
            this.lbl_serviceDescription.AutoSize = true;
            this.lbl_serviceDescription.Location = new System.Drawing.Point(45, 7);
            this.lbl_serviceDescription.Name = "lbl_serviceDescription";
            this.lbl_serviceDescription.Size = new System.Drawing.Size(43, 13);
            this.lbl_serviceDescription.TabIndex = 10;
            this.lbl_serviceDescription.Text = "Serviço";
            // 
            // ServiceId
            // 
            this.ServiceId.HeaderText = "ID";
            this.ServiceId.MinimumWidth = 6;
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Width = 55;
            // 
            // ServiceDescription
            // 
            this.ServiceDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceDescription.HeaderText = "Serviço";
            this.ServiceDescription.MinimumWidth = 6;
            this.ServiceDescription.Name = "ServiceDescription";
            this.ServiceDescription.ReadOnly = true;
            // 
            // ServiceValue
            // 
            this.ServiceValue.HeaderText = "Valor";
            this.ServiceValue.MinimumWidth = 6;
            this.ServiceValue.Name = "ServiceValue";
            this.ServiceValue.ReadOnly = true;
            this.ServiceValue.Width = 80;
            // 
            // Frm_Find_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_serviceDescription);
            this.Controls.Add(this.DGV_Services);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.edt_serviceDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_Services";
            this.Text = "Buscar Serviços";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.edt_serviceDescription, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.DGV_Services, 0);
            this.Controls.SetChildIndex(this.lbl_serviceDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_serviceDescription;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView DGV_Services;
        private System.Windows.Forms.Label lbl_serviceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceValue;
    }
}
