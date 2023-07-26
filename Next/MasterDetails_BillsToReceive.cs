using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Next;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            //Thread clientsThread = new Thread(SetClientsDataSourceToDGV);
           // Thread billsThread = new Thread(SetBillsToReceiveDataSourceToDGV);
            //clientsThread.Start();
            //billsThread.Start();
        }

        
        private BillsToReceive_Controller _billsController = new BillsToReceive_Controller();
        //private PaymentConditions_Controller _payConditionsController = null;
        private Clients_Controller _clientsController = new Clients_Controller();

        public void SearchClient() //Procura o cliente baseado nos campos txt e popula esses campos + seleciona a Row da DGV do Cliente
        {
            Clients client = null;
            var _clientsController = new Clients_Controller();
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
            var row = DGV_Clients.SelectedRows[0];
            NewClientsForm(Convert.ToInt32(row.Cells["IdClient"].Value));
        }

        private void NewClientsForm(int clientId)
        {
            var formClients = new Frm_Create_Clients();
            var obj = _clientsController.FindItemId(clientId);
            formClients.PopulateCamps(obj);
            formClients.Populated(true);
            formClients.ShowDialog();
            SetClientsDataSourceToDGV();
        }

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
                        DGV_BillsToReceive.Rows[i].Cells["PaymentMethodBillsToReceive"].Value = _payMethodsController.FindItemId(Convert.ToInt32(dr["paymethod_id"])).paymentMethod;
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
                        row.Cells["StatusBillsReceive"].Value = "PAID";
                    }
                    else if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 0) {
                        row.Cells["StatusBillsReceive"].Value = "ACTIVE";
                    }
                    else
                    {
                        row.Cells["StatusBillsReceive"].Value = "ON HOLD";
                    }
                }
            }
        }

        public void SetClientsDataSourceToDGV() //Popula Clients DGV
        {
            var clientsController = new Clients_Controller();
            DGV_Clients.Rows.Clear();
            DataTable dt = clientsController.PopulateDGV();
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
                        DGV_Clients.Rows[i].Cells["RegNumberClient"].Value = dr["client_registration"].ToString();
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
            DateTime emissionDate = Convert.ToDateTime(emissionDate_bills.Value);
            DateTime dueDate = Convert.ToDateTime(emissionDate_bills.Value);

            foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
            {
                var dgvEmission = Convert.ToDateTime(row.Cells["EmissionDateBillsReceive"].Value);
                var dgvDue = Convert.ToDateTime(row.Cells["DueDateBillsReceive"].Value);

                if (dgvEmission < emissionDate)
                {
                    row.Dispose();
                }
                if (dueDate != dueDate_bills.MinDate &&
                    dgvDue > dueDate )
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

        private void btn_resetClients_Click(object sender, EventArgs e)
        {
            SetClientsDataSourceToDGV();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtn_LegalClients_CheckedChanged(object sender, EventArgs e)
        {
            SortByClientType("LEGAL");
        }

        private void SortByClientType(string sortString)
        {
            SetClientsDataSourceToDGV();
            if (DGV_Clients.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Clients.Rows)
                {
                    if (row.Cells["TypeClient"].Value.ToString() != sortString)
                    {
                        DGV_Clients.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_Natural_CheckedChanged(object sender, EventArgs e)
        {
            SortByClientType("NATURAL");
        }

        private void btn_ClearClientFilters_Click(object sender, EventArgs e)
        {
            ResetDGVClients();
        }

        private void ResetDGVClients()
        {
            SetClientsDataSourceToDGV();
        }

        private void rbtn_ActiveStatus_CheckedChanged(object sender, EventArgs e)
        {
            SortByBillStatus("ACTIVE");
        }

        private void SortByBillStatus(string sortString)
        {
            SetBillsToReceiveDataSourceToDGV();
            if (DGV_BillsToReceive.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
                {
                    if (row.Cells["StatusBillsReceive"].Value.ToString() != sortString)
                    {
                        DGV_BillsToReceive.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_PaidStatus_CheckedChanged(object sender, EventArgs e)
        {
            SortByBillStatus("PAID");
        }

        private void btn_ClearSaleFilters_Click(object sender, EventArgs e)
        {
            SetClientsDataSourceToDGV();
        }

        private void edt_saleNumber_ValueChanged(object sender, EventArgs e)
        {
            SortBySaleId(Convert.ToInt32(edt_saleNumber.Value));
        }

        private void SortBySaleId(int id)
        {
            if (DGV_BillsToReceive.Rows.Count <= 0)
            {
                SetBillsToReceiveDataSourceToDGV();
                foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
                {
                    if (Convert.ToInt32(row.Cells["SaleNumberBillReceive"].Value) != id)
                    {
                        row.Dispose();
                    }
                }
            }
        }

        private void DGV_BillsToReceive_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DGV_BillsToReceive.SelectedRows[0];
            NewBillToReceiveForm(Convert.ToInt32(row.Cells["SaleNumberBillsReceive"].Value),
                Convert.ToInt32(row.Cells["InstalmentNumber"].Value));
        }

        private void NewBillToReceiveForm(int saleId, int instalmentNumber)
        {
            var formBillsToReceive = new Frm_Create_BillsToReceive();
            var obj = _billsController.FindItemId(saleId, instalmentNumber);
            formBillsToReceive.PopulateCamps(obj);
            formBillsToReceive.Populated(true);
            formBillsToReceive.ShowDialog();
            SetBillsToReceiveDataSourceToDGV();
        }

        private void DGV_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowByClient();
        }

        private void rbtn_onHold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_onHold.Checked)
            {
                rbtn_ActiveStatus.Checked = false;
                rbtn_PaidStatus.Checked = false;
                SortByBillStatus("ON HOLD");
            }
        }
    }
}
