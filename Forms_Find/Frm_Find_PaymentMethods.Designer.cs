namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    partial class Frm_Find_PaymentMethods
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
            this.lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.edt_paymentMethod = new System.Windows.Forms.TextBox();
            this.DGV_PayMethods = new System.Windows.Forms.DataGridView();
            this.IDPayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PayMethods)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.edt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_id_KeyPress);
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(80, 9);
            this.lbl_PaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(108, 16);
            this.lbl_PaymentMethod.TabIndex = 18;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // edt_paymentMethod
            // 
            this.edt_paymentMethod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_paymentMethod.Location = new System.Drawing.Point(84, 28);
            this.edt_paymentMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_paymentMethod.Name = "edt_paymentMethod";
            this.edt_paymentMethod.Size = new System.Drawing.Size(321, 22);
            this.edt_paymentMethod.TabIndex = 17;
            this.edt_paymentMethod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_paymentMethod_KeyPress);
            // 
            // DGV_PayMethods
            // 
            this.DGV_PayMethods.AllowUserToAddRows = false;
            this.DGV_PayMethods.AllowUserToDeleteRows = false;
            this.DGV_PayMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PayMethods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPayMethod,
            this.Payment_Method});
            this.DGV_PayMethods.Location = new System.Drawing.Point(12, 92);
            this.DGV_PayMethods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_PayMethods.MultiSelect = false;
            this.DGV_PayMethods.Name = "DGV_PayMethods";
            this.DGV_PayMethods.ReadOnly = true;
            this.DGV_PayMethods.RowHeadersWidth = 51;
            this.DGV_PayMethods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PayMethods.Size = new System.Drawing.Size(776, 300);
            this.DGV_PayMethods.TabIndex = 19;
            this.DGV_PayMethods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayMethods_CellClick);
            this.DGV_PayMethods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayMethods_CellContentClick);
            this.DGV_PayMethods.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PayMethods_CellContentDoubleClick);
            // 
            // IDPayMethod
            // 
            this.IDPayMethod.HeaderText = "ID";
            this.IDPayMethod.MinimumWidth = 6;
            this.IDPayMethod.Name = "IDPayMethod";
            this.IDPayMethod.ReadOnly = true;
            this.IDPayMethod.Width = 65;
            // 
            // Payment_Method
            // 
            this.Payment_Method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payment_Method.HeaderText = "Payment Method";
            this.Payment_Method.MinimumWidth = 6;
            this.Payment_Method.Name = "Payment_Method";
            this.Payment_Method.ReadOnly = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(427, 28);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 25);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Find_PaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.DGV_PayMethods);
            this.Controls.Add(this.lbl_PaymentMethod);
            this.Controls.Add(this.edt_paymentMethod);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Frm_Find_PaymentMethods";
            this.Text = "Find Payment Method";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_paymentMethod, 0);
            this.Controls.SetChildIndex(this.lbl_PaymentMethod, 0);
            this.Controls.SetChildIndex(this.DGV_PayMethods, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PayMethods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.TextBox edt_paymentMethod;
        private System.Windows.Forms.DataGridView DGV_PayMethods;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Method;
    }
}
