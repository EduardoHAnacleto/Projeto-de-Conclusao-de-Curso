namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Find_Cities
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
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_phonePrefix = new System.Windows.Forms.Label();
            this.edt_cityName = new System.Windows.Forms.TextBox();
            this.edt_cityPhonePrefix = new System.Windows.Forms.TextBox();
            this.DGV_Cities = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonePrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cities)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(85, 11);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(29, 16);
            this.lbl_city.TabIndex = 4;
            this.lbl_city.Text = "City";
            // 
            // lbl_phonePrefix
            // 
            this.lbl_phonePrefix.AutoSize = true;
            this.lbl_phonePrefix.Location = new System.Drawing.Point(513, 9);
            this.lbl_phonePrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phonePrefix.Name = "lbl_phonePrefix";
            this.lbl_phonePrefix.Size = new System.Drawing.Size(82, 16);
            this.lbl_phonePrefix.TabIndex = 5;
            this.lbl_phonePrefix.Text = "Phone Prefix";
            // 
            // edt_cityName
            // 
            this.edt_cityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_cityName.Location = new System.Drawing.Point(89, 28);
            this.edt_cityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_cityName.Name = "edt_cityName";
            this.edt_cityName.Size = new System.Drawing.Size(395, 22);
            this.edt_cityName.TabIndex = 7;
            this.edt_cityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_cityName_KeyPress);
            // 
            // edt_cityPhonePrefix
            // 
            this.edt_cityPhonePrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_cityPhonePrefix.Enabled = false;
            this.edt_cityPhonePrefix.Location = new System.Drawing.Point(517, 28);
            this.edt_cityPhonePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_cityPhonePrefix.Name = "edt_cityPhonePrefix";
            this.edt_cityPhonePrefix.Size = new System.Drawing.Size(69, 22);
            this.edt_cityPhonePrefix.TabIndex = 8;
            // 
            // DGV_Cities
            // 
            this.DGV_Cities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.CityName,
            this.PhonePrefix,
            this.IdState});
            this.DGV_Cities.Location = new System.Drawing.Point(9, 87);
            this.DGV_Cities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Cities.MultiSelect = false;
            this.DGV_Cities.Name = "DGV_Cities";
            this.DGV_Cities.ReadOnly = true;
            this.DGV_Cities.RowHeadersWidth = 51;
            this.DGV_Cities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cities.Size = new System.Drawing.Size(775, 298);
            this.DGV_Cities.TabIndex = 9;
            this.DGV_Cities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cities_CellClick);
            this.DGV_Cities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cities_CellContentClick);
            this.DGV_Cities.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cities_CellContentDoubleClick);
            this.DGV_Cities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Cities_KeyPress);
            // 
            // CityId
            // 
            this.CityId.HeaderText = "ID";
            this.CityId.MinimumWidth = 6;
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            this.CityId.Width = 60;
            // 
            // CityName
            // 
            this.CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityName.HeaderText = "City name";
            this.CityName.MinimumWidth = 6;
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // PhonePrefix
            // 
            this.PhonePrefix.HeaderText = "Phone Prefix";
            this.PhonePrefix.MinimumWidth = 6;
            this.PhonePrefix.Name = "PhonePrefix";
            this.PhonePrefix.ReadOnly = true;
            this.PhonePrefix.Width = 75;
            // 
            // IdState
            // 
            this.IdState.HeaderText = "State";
            this.IdState.MinimumWidth = 6;
            this.IdState.Name = "IdState";
            this.IdState.ReadOnly = true;
            this.IdState.Width = 120;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(611, 27);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 25);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Sea&rch";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // Frm_Find_Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.DGV_Cities);
            this.Controls.Add(this.edt_cityPhonePrefix);
            this.Controls.Add(this.edt_cityName);
            this.Controls.Add(this.lbl_phonePrefix);
            this.Controls.Add(this.lbl_city);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Frm_Find_Cities";
            this.Text = "Find City";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.lbl_city, 0);
            this.Controls.SetChildIndex(this.lbl_phonePrefix, 0);
            this.Controls.SetChildIndex(this.edt_cityName, 0);
            this.Controls.SetChildIndex(this.edt_cityPhonePrefix, 0);
            this.Controls.SetChildIndex(this.DGV_Cities, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_phonePrefix;
        private System.Windows.Forms.TextBox edt_cityName;
        private System.Windows.Forms.TextBox edt_cityPhonePrefix;
        private System.Windows.Forms.DataGridView DGV_Cities;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonePrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdState;
    }
}
