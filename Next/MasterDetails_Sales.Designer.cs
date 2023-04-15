namespace ProjetoEduardoAnacletoWindowsForm1.MasterDetails
{
    partial class MasterDetails_Sales
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
            this.DGV_Clients = new System.Windows.Forms.DataGridView();
            this.lbl_client = new System.Windows.Forms.Label();
            this.edt_clientName = new System.Windows.Forms.TextBox();
            this.btn_FindClient = new System.Windows.Forms.Button();
            this.lbl_Sale = new System.Windows.Forms.Label();
            this.DGV_Sales = new System.Windows.Forms.DataGridView();
            this.btn_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Clients
            // 
            this.DGV_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clients.Location = new System.Drawing.Point(12, 36);
            this.DGV_Clients.Name = "DGV_Clients";
            this.DGV_Clients.Size = new System.Drawing.Size(610, 124);
            this.DGV_Clients.TabIndex = 0;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(9, 12);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(39, 13);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client :";
            // 
            // edt_clientName
            // 
            this.edt_clientName.Location = new System.Drawing.Point(54, 9);
            this.edt_clientName.Name = "edt_clientName";
            this.edt_clientName.Size = new System.Drawing.Size(239, 20);
            this.edt_clientName.TabIndex = 2;
            // 
            // btn_FindClient
            // 
            this.btn_FindClient.Location = new System.Drawing.Point(299, 7);
            this.btn_FindClient.Name = "btn_FindClient";
            this.btn_FindClient.Size = new System.Drawing.Size(75, 23);
            this.btn_FindClient.TabIndex = 3;
            this.btn_FindClient.Text = "&Search";
            this.btn_FindClient.UseVisualStyleBackColor = true;
            // 
            // lbl_Sale
            // 
            this.lbl_Sale.AutoSize = true;
            this.lbl_Sale.Location = new System.Drawing.Point(9, 177);
            this.lbl_Sale.Name = "lbl_Sale";
            this.lbl_Sale.Size = new System.Drawing.Size(28, 13);
            this.lbl_Sale.TabIndex = 5;
            this.lbl_Sale.Text = "Sale";
            // 
            // DGV_Sales
            // 
            this.DGV_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sales.Location = new System.Drawing.Point(12, 192);
            this.DGV_Sales.Name = "DGV_Sales";
            this.DGV_Sales.Size = new System.Drawing.Size(610, 208);
            this.DGV_Sales.TabIndex = 6;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(547, 411);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 7;
            this.btn_Select.Text = "&Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // MasterDetails_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.DGV_Sales);
            this.Controls.Add(this.lbl_Sale);
            this.Controls.Add(this.btn_FindClient);
            this.Controls.Add(this.edt_clientName);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.DGV_Clients);
            this.Name = "MasterDetails_Sales";
            this.Text = "Frm_MasterDetails";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Clients;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox edt_clientName;
        private System.Windows.Forms.Button btn_FindClient;
        private System.Windows.Forms.Label lbl_Sale;
        private System.Windows.Forms.DataGridView DGV_Sales;
        private System.Windows.Forms.Button btn_Select;
    }
}