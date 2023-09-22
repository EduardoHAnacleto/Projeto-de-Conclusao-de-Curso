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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Find_BillsToReceive : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_BillsToReceive()
        {
            InitializeComponent();
            SetBillsToReceiveDataSourceToDGV();
            lbl_id.Visible = false;
            edt_id.Visible = false;
        }

        private BillsToReceive_Controller _controller = new BillsToReceive_Controller();

        public void SetBillsToReceiveDataSourceToDGV() //Popula DGV Bills
        {
            DGV_BillsToReceive.Rows.Clear();
            var billsController = new BillsToReceive_Controller();
            var _payMethodsController = new PaymentMethods_Controller();
            var _clientsController = new Clients_Controller();
            DataTable dt = billsController.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                string dueDate;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_BillsToReceive.Rows.Add();
                        DGV_BillsToReceive.Rows[i].Cells["ClientName"].Value = _clientsController.FindItemId(Convert.ToInt32(dr["client_id"])).name;
                        DGV_BillsToReceive.Rows[i].Cells["SaleNumberBillsReceive"].Value = dr["sale_id"].ToString();
                        //DGV_BillsToReceive.Rows[i].Cells["PaymentMethodBillsToReceive"].Value = _payMethodsController.FindItemId(Convert.ToInt32(dr["paymethod_id"])).paymentMethod;
                        DGV_BillsToReceive.Rows[i].Cells["InstalmentNumber"].Value = dr["instalmentNumber"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["TotalValueBillsReceive"].Value = dr["instalmentValue"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["EmissionDateBillsReceive"].Value = Convert.ToDateTime(dr["emissionDate"].ToString()).ToShortDateString();
                        if (dr["dueDate"].ToString() != null)
                        {
                            dueDate = Convert.ToDateTime(dr["dueDate"].ToString()).ToShortDateString();
                        }
                        else
                        {
                            dueDate = "";
                        }
                        DGV_BillsToReceive.Rows[i].Cells["DueDateBillsReceive"].Value = dueDate;
                        DGV_BillsToReceive.Rows[i].Cells["StatusBillsReceive"].Value = dr["isPaid"].ToString();
                    }
                    i++;
                }
            }
            UpdateDGVBillsToReceiveColumnItem(dt);
        }

        public void UpdateDGVBillsToReceiveColumnItem(DataTable dt) //Formata campo Status para PAID ou ACTIVE
        {
            foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
            {
                if (row != null)
                {
                    if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 1)
                    {
                        row.Cells["StatusBillsReceive"].Value = "PAGO";
                    }
                    else if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 0)
                    {
                        row.Cells["StatusBillsReceive"].Value = "ATIVO";
                    }
                    else
                    {
                        row.Cells["StatusBillsReceive"].Value = "EM ESPERA";
                    }
                }
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            FindClientBills();
        }

        private void FindClientBills()
        {
            if (edt_clientName.Text != string.Empty)
            {
                bool found = false;
                foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
                {
                    if (row.Cells["ClientName"].Value.ToString() != edt_clientName.Text)
                    {
                        DGV_BillsToReceive.Rows.RemoveAt(row.Index);
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
                            FindClientBills();
                        }
                    }
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

        public BillsToReceive GetObject()
        {
            if (DGV_BillsToReceive.SelectedRows[0] != null)
            {
                var obj = new BillsToReceive();
                obj = _controller.FindSaleId(Convert.ToInt32(DGV_BillsToReceive.SelectedRows[0].Cells["SaleNumberBillsReceive"].Value)).FirstOrDefault();
                return obj;
            }
            return null;
        }

        public void NewPopulatedForm(BillsToReceive obj)
        {
            Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive();
            frmBillsToReceive.PopulateCamps(obj);
            frmBillsToReceive.Populated(true);
            frmBillsToReceive.ShowDialog();
        }

        public override void NewObject()
        {
            Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive();
            frmBillsToReceive.Populated(false);
            frmBillsToReceive.ShowDialog();
            this.SetDataSourceToDGV();
        }


    }
}
