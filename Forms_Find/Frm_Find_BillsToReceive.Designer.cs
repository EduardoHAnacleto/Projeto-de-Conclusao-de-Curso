﻿namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    partial class Frm_Find_BillsToReceive
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
            this.DGV_BillsToReceive = new System.Windows.Forms.DataGridView();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.SetPaidBill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNumberBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValueBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmissionDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDateBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusBillsReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(671, 419);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(740, 419);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(611, 419);
            // 
            // DGV_BillsToReceive
            // 
            this.DGV_BillsToReceive.AllowUserToAddRows = false;
            this.DGV_BillsToReceive.AllowUserToDeleteRows = false;
            this.DGV_BillsToReceive.AllowUserToResizeRows = false;
            this.DGV_BillsToReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_BillsToReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BillsToReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.SaleNumberBillsReceive,
            this.ClientName,
            this.InstalmentNumber,
            this.TotalValueBillsReceive,
            this.EmissionDateBillsReceive,
            this.DueDateBillsReceive,
            this.StatusBillsReceive});
            this.DGV_BillsToReceive.Location = new System.Drawing.Point(10, 49);
            this.DGV_BillsToReceive.MultiSelect = false;
            this.DGV_BillsToReceive.Name = "DGV_BillsToReceive";
            this.DGV_BillsToReceive.ReadOnly = true;
            this.DGV_BillsToReceive.RowHeadersVisible = false;
            this.DGV_BillsToReceive.RowHeadersWidth = 51;
            this.DGV_BillsToReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BillsToReceive.Size = new System.Drawing.Size(783, 360);
            this.DGV_BillsToReceive.TabIndex = 8;
            // 
            // edt_clientName
            // 
            this.edt_clientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_clientName.Location = new System.Drawing.Point(48, 22);
            this.edt_clientName.MaxLength = 50;
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(226, 20);
            this.edt_clientName.TabIndex = 9;
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Location = new System.Drawing.Point(45, 7);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(39, 13);
            this.lbl_clientName.TabIndex = 10;
            this.lbl_clientName.Text = "Cliente";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(280, 22);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 20);
            this.btn_Find.TabIndex = 11;
            this.btn_Find.Text = "Buscar";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // SetPaidBill
            // 
            this.SetPaidBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPaidBill.Location = new System.Drawing.Point(424, 417);
            this.SetPaidBill.Name = "SetPaidBill";
            this.SetPaidBill.Size = new System.Drawing.Size(75, 23);
            this.SetPaidBill.TabIndex = 12;
            this.SetPaidBill.Text = "Baixar Conta";
            this.SetPaidBill.UseVisualStyleBackColor = true;
            this.SetPaidBill.Click += new System.EventHandler(this.btn_SetPaidBill_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(505, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillId
            // 
            this.BillId.HeaderText = "ID Conta";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            this.BillId.Width = 70;
            // 
            // SaleNumberBillsReceive
            // 
            this.SaleNumberBillsReceive.HeaderText = "Venda";
            this.SaleNumberBillsReceive.MinimumWidth = 6;
            this.SaleNumberBillsReceive.Name = "SaleNumberBillsReceive";
            this.SaleNumberBillsReceive.ReadOnly = true;
            this.SaleNumberBillsReceive.Width = 55;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Cliente";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // InstalmentNumber
            // 
            this.InstalmentNumber.HeaderText = "Nº Parcela";
            this.InstalmentNumber.MinimumWidth = 6;
            this.InstalmentNumber.Name = "InstalmentNumber";
            this.InstalmentNumber.ReadOnly = true;
            this.InstalmentNumber.Width = 75;
            // 
            // TotalValueBillsReceive
            // 
            this.TotalValueBillsReceive.HeaderText = "Valor da Parcela";
            this.TotalValueBillsReceive.MinimumWidth = 6;
            this.TotalValueBillsReceive.Name = "TotalValueBillsReceive";
            this.TotalValueBillsReceive.ReadOnly = true;
            this.TotalValueBillsReceive.Width = 80;
            // 
            // EmissionDateBillsReceive
            // 
            this.EmissionDateBillsReceive.HeaderText = "Data de Emissão";
            this.EmissionDateBillsReceive.MinimumWidth = 6;
            this.EmissionDateBillsReceive.Name = "EmissionDateBillsReceive";
            this.EmissionDateBillsReceive.ReadOnly = true;
            // 
            // DueDateBillsReceive
            // 
            this.DueDateBillsReceive.HeaderText = "Data de Vencimento";
            this.DueDateBillsReceive.MinimumWidth = 6;
            this.DueDateBillsReceive.Name = "DueDateBillsReceive";
            this.DueDateBillsReceive.ReadOnly = true;
            // 
            // StatusBillsReceive
            // 
            this.StatusBillsReceive.HeaderText = "Status";
            this.StatusBillsReceive.MinimumWidth = 6;
            this.StatusBillsReceive.Name = "StatusBillsReceive";
            this.StatusBillsReceive.ReadOnly = true;
            // 
            // Frm_Find_BillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(805, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SetPaidBill);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_clientName);
            this.Controls.Add(this.edt_clientName);
            this.Controls.Add(this.DGV_BillsToReceive);
            this.Name = "Frm_Find_BillsToReceive";
            this.Text = "Buscar Contas à Receber";
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_New, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.edt_id, 0);
            this.Controls.SetChildIndex(this.DGV_BillsToReceive, 0);
            this.Controls.SetChildIndex(this.edt_clientName, 0);
            this.Controls.SetChildIndex(this.lbl_clientName, 0);
            this.Controls.SetChildIndex(this.btn_Find, 0);
            this.Controls.SetChildIndex(this.SetPaidBill, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BillsToReceive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_BillsToReceive;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button SetPaidBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumberBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValueBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmissionDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDateBillsReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusBillsReceive;
    }
}
