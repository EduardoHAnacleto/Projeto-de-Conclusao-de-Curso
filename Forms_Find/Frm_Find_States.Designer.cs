namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Find_States
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
            this.lbl_StateName = new System.Windows.Forms.Label();
            this.lbl_FedUnit = new System.Windows.Forms.Label();
            this.edt_stateName = new System.Windows.Forms.TextBox();
            this.edt_FU = new System.Windows.Forms.TextBox();
            this.DGV_States = new System.Windows.Forms.DataGridView();
            this.ID_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.States = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateFederationUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_States)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress_1);
            // 
            // lbl_StateName
            // 
            this.lbl_StateName.AutoSize = true;
            this.lbl_StateName.Location = new System.Drawing.Point(46, 7);
            this.lbl_StateName.Name = "lbl_StateName";
            this.lbl_StateName.Size = new System.Drawing.Size(32, 13);
            this.lbl_StateName.TabIndex = 4;
            this.lbl_StateName.Text = "State";
            // 
            // lbl_FedUnit
            // 
            this.lbl_FedUnit.AutoSize = true;
            this.lbl_FedUnit.Location = new System.Drawing.Point(402, 7);
            this.lbl_FedUnit.Name = "lbl_FedUnit";
            this.lbl_FedUnit.Size = new System.Drawing.Size(79, 13);
            this.lbl_FedUnit.TabIndex = 5;
            this.lbl_FedUnit.Text = "Federation Unit";
            // 
            // edt_stateName
            // 
            this.edt_stateName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_stateName.Location = new System.Drawing.Point(49, 23);
            this.edt_stateName.Name = "edt_stateName";
            this.edt_stateName.Size = new System.Drawing.Size(334, 20);
            this.edt_stateName.TabIndex = 7;
            this.edt_stateName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_stateName_KeyPress);
            // 
            // edt_FU
            // 
            this.edt_FU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_FU.Location = new System.Drawing.Point(405, 23);
            this.edt_FU.Name = "edt_FU";
            this.edt_FU.Size = new System.Drawing.Size(45, 20);
            this.edt_FU.TabIndex = 8;
            this.edt_FU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_FU_KeyPress);
            // 
            // DGV_States
            // 
            this.DGV_States.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_States.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_STATE,
            this.States,
            this.StateFederationUnit,
            this.StateCountryName});
            this.DGV_States.Location = new System.Drawing.Point(9, 50);
            this.DGV_States.MultiSelect = false;
            this.DGV_States.Name = "DGV_States";
            this.DGV_States.ReadOnly = true;
            this.DGV_States.RowHeadersWidth = 51;
            this.DGV_States.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_States.Size = new System.Drawing.Size(582, 272);
            this.DGV_States.TabIndex = 9;
            this.DGV_States.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_States_CellClick);
            this.DGV_States.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_States_CellContentDoubleClick);
            this.DGV_States.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_States_KeyPress);
            // 
            // ID_STATE
            // 
            this.ID_STATE.HeaderText = "ID";
            this.ID_STATE.MinimumWidth = 6;
            this.ID_STATE.Name = "ID_STATE";
            this.ID_STATE.ReadOnly = true;
            this.ID_STATE.Width = 50;
            // 
            // States
            // 
            this.States.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.States.HeaderText = "States name";
            this.States.MinimumWidth = 6;
            this.States.Name = "States";
            this.States.ReadOnly = true;
            // 
            // StateFederationUnit
            // 
            this.StateFederationUnit.HeaderText = "Federation Unit";
            this.StateFederationUnit.MinimumWidth = 6;
            this.StateFederationUnit.Name = "StateFederationUnit";
            this.StateFederationUnit.ReadOnly = true;
            this.StateFederationUnit.Width = 125;
            // 
            // StateCountryName
            // 
            this.StateCountryName.HeaderText = "Country";
            this.StateCountryName.MinimumWidth = 6;
            this.StateCountryName.Name = "StateCountryName";
            this.StateCountryName.ReadOnly = true;
            this.StateCountryName.Width = 125;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(466, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 21);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Find_States
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.DGV_States);
            this.Controls.Add(this.edt_FU);
            this.Controls.Add(this.edt_stateName);
            this.Controls.Add(this.lbl_FedUnit);
            this.Controls.Add(this.lbl_StateName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Find_States";
            this.Text = "Find States";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.lbl_StateName, 0);
            this.Controls.SetChildIndex(this.lbl_FedUnit, 0);
            this.Controls.SetChildIndex(this.edt_stateName, 0);
            this.Controls.SetChildIndex(this.edt_FU, 0);
            this.Controls.SetChildIndex(this.DGV_States, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_States)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StateName;
        private System.Windows.Forms.Label lbl_FedUnit;
        private System.Windows.Forms.TextBox edt_stateName;
        private System.Windows.Forms.TextBox edt_FU;
        private System.Windows.Forms.DataGridView DGV_States;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn States;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateFederationUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCountryName;
    }
}
