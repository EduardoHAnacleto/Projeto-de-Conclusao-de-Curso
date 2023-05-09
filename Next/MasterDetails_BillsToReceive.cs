using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public partial class MasterDetails_BillsToReceive : Form
    {

        public MasterDetails_BillsToReceive()
        {
            InitializeComponent();
            edt_clientId.Controls[0].Visible = false;
            edt_saleNumber.Controls[0].Visible = false;
        }

        private Clients_Controller _clientsController = new Clients_Controller();
        private BillsToReceive_Controller _billsController = new BillsToReceive_Controller();
        private PaymentConditions_Controller _payConditionsController = new PaymentConditions_Controller();

        public void SearchClient() //Procura o cliente baseado nos campos txt e popula esses campos + seleciona a Row da DGV do Cliente
        {
            Clients client = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(edt_clientId.Text))
                {
                    client = _clientsController.FindItemId(Convert.ToInt32(edt_clientId.Text));
                }
                else if (!string.IsNullOrWhiteSpace(edt_clientName.Text))
                {
                    client = _clientsController.FindItemName(edt_clientName.Text);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (client != null)
                {
                    edt_clientId.Text = client.id.ToString();
                    edt_clientName.Text = client.name;
                    foreach (DataGridViewRow row in DGV_Clients.Rows)
                    {
                        if (row.Cells["NameClient"].Value != null && row.Cells["NameClient"].Value.ToString() == client.name)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_searchClient_Click(object sender, EventArgs e) //Procura PERSON(Client) e Popula nos campos
        {
            SearchClient();
        }

        private void edt_clientName_KeyPress(object sender, KeyPressEventArgs e) //Chama Utilities para verificar se ENTER foi pressionado -> Busca Client
        {
            if (Utilities.EnterSearch(e))
            {
                SearchClient();
            }
        }

        public void SelectRowByClient()
        {
            string clientName = DGV_Clients.SelectedRows[0].Cells["NameClient"].Value.ToString();
            foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
            {
                if (row.Cells["ClientName"].Value.ToString() != clientName)
                {
                    DGV_BillsToReceive.Rows.Remove(row);
                }
            }
        }

        private void DGV_Clients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowByClient();
        }


        public void SetBillsToReceiveDataSourceToDGV() //Popula DGV Bills
        {
            DGV_BillsToReceive.Rows.Clear();
            DataTable dt = this._billsController.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_BillsToReceive.Rows.Add();
                        DGV_BillsToReceive.Rows[i].Cells["ClientName"].Value = _clientsController.FindItemId(Convert.ToInt32(dr["client_id"])).name;
                        DGV_BillsToReceive.Rows[i].Cells["SaleNumberBillReceive"].Value = dr["sale_id"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["PayConditionBillsReceive"].Value = _payConditionsController.FindItemId(Convert.ToInt32(dr["paycondition_id"])).conditionName;
                        DGV_BillsToReceive.Rows[i].Cells["InstalmentNumber"].Value = dr["instalmentNumber"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["TotalValueBillsReceive"].Value = dr["instalmentValue"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["PaymentMethod"].Value = _payConditionsController.FindItemId(Convert.ToInt32(dr["paycondition_id"])).BillsInstalments[Convert.ToInt32(dr["instalmentNumber"])].PaymentMethod.paymentMethod;
                        DGV_BillsToReceive.Rows[i].Cells["EmissionDateBillsReceive"].Value = dr["emissionDate"].ToString();
                        DGV_BillsToReceive.Rows[i].Cells["DueDateBillsReceive"].Value = null;
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
                    if (Convert.ToBoolean(row.Cells["StatusBillsReceive"].Value) == true)
                    {
                        row.Cells["StatusBillsReceive"].Value = "PAID";
                    }
                    else row.Cells["StatusBillsReceive"].Value = "ACTIVE";
                }
            }
        }

        public void SetClientsDataSourceToDGV() //Popula Clients DGV
        {
            DGV_Clients.Rows.Clear();
            DataTable dt = this._clientsController.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_Clients.Rows.Add();
                        DGV_Clients.Rows[i].Cells["IdClient"].Value = dr["id_client"].ToString();
                        DGV_Clients.Rows[i].Cells["NameClient"].Value = dr["client_name"].ToString();
                        DGV_Clients.Rows[i].Cells["RegNumberClient"].Value = dr["client_name"].ToString();
                        DGV_Clients.Rows[i].Cells["TypeClient"].Value = dr["client_type"].ToString();
                    }
                    i++;
                }
            }
            UpdateDGVClientsColumnItem();
        }

        public void UpdateDGVClientsColumnItem() // Formata Type dos clientes para Natural e Legal
        {
            foreach (DataGridViewRow dr in DGV_Clients.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (dr.Cells["TypeClient"].Value.ToString() == "1")
                    {
                        dr.Cells["TypeClient"].Value = "NATURAL";
                    }
                    else
                        if (dr.Cells["TypeClient"].Value.ToString() == "2")
                    {
                        dr.Cells["TypeClient"].Value = "LEGAL";
                    }

                }
            }
        }

        private void emissionDate_bills_ValueChanged(object sender, EventArgs e)
        {
            SortDGVByDate();
        }

        private void SortDGVByDate()
        {
            DateTime standardDate = new DateTime(2000, 01, 01);
            DateTime emissionDate, dueDate;
            emissionDate = Convert.ToDateTime(emissionDate_bills.Value);
            dueDate = Convert.ToDateTime(emissionDate_bills.Value);

            foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
            {
                var emission = Convert.ToDateTime(row.Cells["EmissionDateBillsReceive"].Value);
                var due = Convert.ToDateTime(row.Cells["DueDateBillsReceive"].Value);

                if (emission < emissionDate)
                {
                    row.Dispose();
                }
                else if (dueDate != standardDate && due > dueDate )
                {
                    row.Dispose();
                }
            }
        }

        private void dueDate_bills_ValueChanged(object sender, EventArgs e)
        {
            SortDGVByDate();
        }

        private void btn_ClearDateSort_Click(object sender, EventArgs e)
        {
            SetBillsToReceiveDataSourceToDGV();
        }
    }
}
