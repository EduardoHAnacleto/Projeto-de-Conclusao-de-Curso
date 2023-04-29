namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Cities
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
            this.lbl_stateId = new System.Windows.Forms.Label();
            this.edt_stateId = new System.Windows.Forms.TextBox();
            this.edt_state = new System.Windows.Forms.TextBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.btn_SearchState = new System.Windows.Forms.Button();
            this.edt_phonePrefix = new System.Windows.Forms.TextBox();
            this.edt_cityName = new System.Windows.Forms.TextBox();
            this.lbl_phonePrefix = new System.Windows.Forms.Label();
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.gbox_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LastUpdate
            // 
            this.lbl_LastUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // lbl_CreationDate
            // 
            this.lbl_CreationDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // lbl_stateId
            // 
            this.lbl_stateId.AutoSize = true;
            this.lbl_stateId.Location = new System.Drawing.Point(72, 80);
            this.lbl_stateId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stateId.Name = "lbl_stateId";
            this.lbl_stateId.Size = new System.Drawing.Size(20, 16);
            this.lbl_stateId.TabIndex = 32;
            this.lbl_stateId.Text = "ID";
            // 
            // edt_stateId
            // 
            this.edt_stateId.Enabled = false;
            this.edt_stateId.Location = new System.Drawing.Point(74, 101);
            this.edt_stateId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_stateId.Name = "edt_stateId";
            this.edt_stateId.Size = new System.Drawing.Size(47, 22);
            this.edt_stateId.TabIndex = 31;
            this.edt_stateId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_stateId_KeyPress);
            // 
            // edt_state
            // 
            this.edt_state.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_state.Enabled = false;
            this.edt_state.Location = new System.Drawing.Point(144, 100);
            this.edt_state.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_state.MaxLength = 50;
            this.edt_state.Name = "edt_state";
            this.edt_state.Size = new System.Drawing.Size(264, 22);
            this.edt_state.TabIndex = 30;
            this.edt_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_state_KeyPress);
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(140, 80);
            this.lbl_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(38, 16);
            this.lbl_State.TabIndex = 29;
            this.lbl_State.Text = "State";
            // 
            // btn_SearchState
            // 
            this.btn_SearchState.Location = new System.Drawing.Point(417, 98);
            this.btn_SearchState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SearchState.Name = "btn_SearchState";
            this.btn_SearchState.Size = new System.Drawing.Size(100, 25);
            this.btn_SearchState.TabIndex = 28;
            this.btn_SearchState.Text = "Search";
            this.btn_SearchState.UseVisualStyleBackColor = true;
            this.btn_SearchState.Click += new System.EventHandler(this.btn_SearchState_Click);
            // 
            // edt_phonePrefix
            // 
            this.edt_phonePrefix.Location = new System.Drawing.Point(504, 30);
            this.edt_phonePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_phonePrefix.MaxLength = 4;
            this.edt_phonePrefix.Name = "edt_phonePrefix";
            this.edt_phonePrefix.Size = new System.Drawing.Size(59, 22);
            this.edt_phonePrefix.TabIndex = 27;
            // 
            // edt_cityName
            // 
            this.edt_cityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_cityName.Location = new System.Drawing.Point(75, 30);
            this.edt_cityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_cityName.MaxLength = 50;
            this.edt_cityName.Name = "edt_cityName";
            this.edt_cityName.Size = new System.Drawing.Size(399, 22);
            this.edt_cityName.TabIndex = 26;
            // 
            // lbl_phonePrefix
            // 
            this.lbl_phonePrefix.AutoSize = true;
            this.lbl_phonePrefix.Location = new System.Drawing.Point(500, 10);
            this.lbl_phonePrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phonePrefix.Name = "lbl_phonePrefix";
            this.lbl_phonePrefix.Size = new System.Drawing.Size(82, 16);
            this.lbl_phonePrefix.TabIndex = 25;
            this.lbl_phonePrefix.Text = "Phone Prefix";
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Location = new System.Drawing.Point(71, 10);
            this.lbl_cityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(29, 16);
            this.lbl_cityName.TabIndex = 24;
            this.lbl_cityName.Text = "City";
            // 
            // Frm_Create_Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.lbl_stateId);
            this.Controls.Add(this.edt_stateId);
            this.Controls.Add(this.edt_state);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.btn_SearchState);
            this.Controls.Add(this.edt_phonePrefix);
            this.Controls.Add(this.edt_cityName);
            this.Controls.Add(this.lbl_phonePrefix);
            this.Controls.Add(this.lbl_cityName);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Create_Cities";
            this.Text = "Create Cities";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_NewSave, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_SelectDelete, 0);
            this.Controls.SetChildIndex(this.btn_Edit, 0);
            this.Controls.SetChildIndex(this.gbox_dates, 0);
            this.Controls.SetChildIndex(this.lbl_cityName, 0);
            this.Controls.SetChildIndex(this.lbl_phonePrefix, 0);
            this.Controls.SetChildIndex(this.edt_cityName, 0);
            this.Controls.SetChildIndex(this.edt_phonePrefix, 0);
            this.Controls.SetChildIndex(this.btn_SearchState, 0);
            this.Controls.SetChildIndex(this.lbl_State, 0);
            this.Controls.SetChildIndex(this.edt_state, 0);
            this.Controls.SetChildIndex(this.edt_stateId, 0);
            this.Controls.SetChildIndex(this.lbl_stateId, 0);
            this.gbox_dates.ResumeLayout(false);
            this.gbox_dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stateId;
        private System.Windows.Forms.TextBox edt_stateId;
        private System.Windows.Forms.TextBox edt_state;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Button btn_SearchState;
        private System.Windows.Forms.TextBox edt_phonePrefix;
        private System.Windows.Forms.TextBox edt_cityName;
        private System.Windows.Forms.Label lbl_phonePrefix;
        private System.Windows.Forms.Label lbl_cityName;
    }
}
