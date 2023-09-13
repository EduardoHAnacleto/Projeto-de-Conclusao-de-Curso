using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Find_Sales : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Sales()
        {
            InitializeComponent();
            SetDataSourceToDGV();
            edt_id.Visible = false;
            lbl_id.Visible = false;
        }

        private Sales_Controller _controller = new Sales_Controller();

        private void btn_Find_Click(object sender, EventArgs e)
        {
            FindClientSales();
        }

        private void FindClientSales()
        {
            if (edt_clientName.Text != string.Empty)
            {
                bool found = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["SaleClientName"].Value.ToString() != edt_clientName.Text)
                    {
                        DGV_Sales.Rows.RemoveAt(row.Index);
                    }
                    else
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    if (Utilities.AskToFind())
                    {
                        Frm_Find_Clients frmFindClientes = new Frm_Find_Clients();
                        frmFindClientes.hasFather = true;
                        frmFindClientes.ShowDialog();
                        if (!frmFindClientes.ActiveControl.ContainsFocus)
                        {
                            Clients client = new Clients();
                            client = frmFindClientes.GetObject();
                            if (client != null)
                            {
                                edt_clientName.Text = client.name;
                            }
                            frmFindClientes.Close();
                            FindClientSales();
                        }
                    }
                }
            }
        }

        public override void SetDataSourceToDGV() //Popula Clients DGV
        {
            DGV_Sales.Rows.Clear();
            DataTable dt = _controller.PopulateDGV();
            Clients_Controller clientsController = new Clients_Controller();
            PaymentConditions_Controller payCondController = new PaymentConditions_Controller();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr != null)
                    {
                        decimal totalValue = (decimal)dr["sale_total_value"];
                        string saleStatus = "ATIVO";
                        if (dr["sale_cancel_date"].ToString() != string.Empty)
                        {
                            saleStatus = "CANCELADO";
                        }
                        DGV_Sales.Rows.Add();
                        DGV_Sales.Rows[i].Cells["SaleId"].Value = dr["id_sale"].ToString();
                        DGV_Sales.Rows[i].Cells["SaleClientName"].Value = clientsController.FindItemId(Convert.ToInt32(dr["client_id"])).name;
                        DGV_Sales.Rows[i].Cells["SaleTotalValue"].Value = totalValue.ToString("0.00");
                        DGV_Sales.Rows[i].Cells["SalePayCond"].Value = payCondController.FindItemId(Convert.ToInt32(dr["paycondition_id"])).conditionName;
                        DGV_Sales.Rows[i].Cells["SaleDate"].Value = Convert.ToDateTime(dr["date_creation"]).ToShortDateString();
                        DGV_Sales.Rows[i].Cells["SaleStatus"].Value = saleStatus;
                    }
                    i++;
                }
            }
        }

        public override void SelectObject()
        {
            var obj = GetObject();
            if (obj != null)
            {
                if (hasFather)
                {
                    base.item = obj;
                    this.Hide();
                }
                else
                {
                    NewPopulatedForm(obj);
                    SetDataSourceToDGV();
                }
            }
            else
            {
                Utilities.IsNotSelected(obj, "A Linha");
            }
        }

        private void NewPopulatedForm(Sales obj)
        {
            Frm_Sale frmPurchases = new Frm_Sale(obj.User);
            frmPurchases.PopulateCamps(obj);
            frmPurchases.Populated(true);
            frmPurchases.ShowDialog();
        }

        private Sales GetObject()
        {
            if (DGV_Sales.SelectedRows[0] != null)
            {
                var obj = new Sales();
                var saleId = Convert.ToInt32(DGV_Sales.SelectedRows[0].Cells["SaleId"].Value);
                obj = _controller.FindItemId(saleId);
                return obj;
            }
            return null;
        }
    }
}
