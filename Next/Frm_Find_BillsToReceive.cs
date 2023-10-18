using ProjetoEduardoAnacletoWindowsForm1.Authorization;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
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
        public Frm_Find_BillsToReceive(Users user)
        {
            InitializeComponent();
            DGV_BillsToReceive.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToReceive.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToReceive.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToReceive.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToReceive.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToReceive.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SetBillsToReceiveDataSourceToDGV();
            lbl_id.Visible = false;
            edt_id.Visible = false;
            SetUser(user);
        }

        private void SetUser(Users user)
        {
            _User = user;
        }

        public Users _User { get; private set; }
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
                        DGV_BillsToReceive.Rows.Add(BillId);
                        DGV_BillsToReceive.Rows[i].Cells["BillId"].Value = dr["id_bill"].ToString();
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
                        if (dr["date_cancelled"] != DBNull.Value)
                        {
                            DGV_BillsToReceive.Rows[i].Cells["StatusBillsReceive"].Value = "CANCELADO";
                        }
                        else if (dr["paidDate"] != DBNull.Value)
                        {
                            DGV_BillsToReceive.Rows[i].Cells["StatusBillsReceive"].Value = "PAGO";
                        }
                        else
                        {
                            DGV_BillsToReceive.Rows[i].Cells["StatusBillsReceive"].Value = "ATIVO";
                        }

                    }
                    i++;
                }
            }
            //UpdateDGVBillsToReceiveColumnItem();
        }

        //public void UpdateDGVBillsToReceiveColumnItem() //Formata campo Status para PAID ou ACTIVE
        //{
        //    foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
        //    {
        //        if (row != null)
        //        {
        //            if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 1)
        //            {
        //                row.Cells["StatusBillsReceive"].Value = "PAGO";
        //            }
        //            else if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 0)
        //            {
        //                row.Cells["StatusBillsReceive"].Value = "ATIVO";
        //            }
        //            else if (Convert.ToInt32(row.Cells["StatusBillsReceive"].Value) == 2)
        //            {
        //                row.Cells["StatusBillsReceive"].Value = "CANCELADO";
        //            }
        //        }
        //    }
        //}

        private void btn_Find_Click(object sender, EventArgs e)
        {
            FindClientBills();
        }

        private void FindClientBills()
        {
            bool found = false;
            DGV_BillsToReceive.Rows.Clear();
            if (edt_clientName.Text != string.Empty)
            {
                SetBillsToReceiveDataSourceToDGV();
                for (int i = DGV_BillsToReceive.Rows.Count-1; i >= 0; i--)
                {
                    DataGridViewRow row = DGV_BillsToReceive.Rows[i];
                    if (row.Cells["ClientName"].Value.ToString() != edt_clientName.Text)
                    {
                        DGV_BillsToReceive.Rows.Remove(row);
                    }
                    else
                    {
                        found = true;
                    }
                } 
            }
            if (!found)
            {
                if (Utilities.AskToFind())
                {
                    SetBillsToReceiveDataSourceToDGV();
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

        public override void SelectObject()
        {
            try
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
                        NewPopulatedForm(obj, "Check");
                        SetDataSourceToDGV();
                    }
                }
                else
                {
                    Utilities.IsNotSelected(obj, "Conta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        public BillsToReceive GetObject()
        {
            if (DGV_BillsToReceive.SelectedRows[0] != null)
            {
                var billId = Convert.ToInt32(DGV_BillsToReceive.SelectedRows[0].Cells["BillId"].Value);
                var iNum = Convert.ToInt32(DGV_BillsToReceive.SelectedRows[0].Cells["InstalmentNumber"].Value);
                var obj = _controller.FindItemId(billId, iNum);
                return obj;
            }
            return null;
        }

        public void NewPopulatedForm(BillsToReceive obj, string formFunc)
        {
            Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive(formFunc, obj, _User);
            frmBillsToReceive.ShowDialog();
            this.SetBillsToReceiveDataSourceToDGV();
        }

        public override void NewObject()
        {
            string formFunc = "New";
            Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive(formFunc, null, _User);
            frmBillsToReceive.ShowDialog();
            this.SetBillsToReceiveDataSourceToDGV();
        }

        private void btn_SetPaidBill_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToReceive.Rows.Count > 1)
            {
                var obj = GetObject();
                if (obj.PaidDate != null || DGV_BillsToReceive.SelectedRows[0].Cells["StatusBillsReceive"].Value.ToString() == "PAGO")
                {
                    string message = "Conta já foi paga.";
                    string caption = "Não é possível alterar a parcela.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, icon);
                }
                else if (obj.CancelledDate != null || DGV_BillsToReceive.SelectedRows[0].Cells["StatusBillsReceive"].Value.ToString() == "CANCELADO")
                {
                    string message = "Está conta já foi cancelada.";
                    string caption = "Não é possível alterar a parcela.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, icon);
                }
                else if (RightInstalment())
                {
                    NewPopulatedToPayForm();
                }
            }
        }

        private bool RightInstalment()
        {
            var billId = Convert.ToInt32(DGV_BillsToReceive.SelectedRows[0].Cells["BillId"].Value);
            var instalmentNum = Convert.ToInt32(DGV_BillsToReceive.SelectedRows[0].Cells["InstalmentNumber"].Value);
            var obj = _controller.FindItemId(billId);
            if (instalmentNum > 1)
            {
                for (int i = 0; i < instalmentNum-1; i++)
                {
                    if (obj[i].CancelledDate.HasValue) //Confirmar
                    {
                        string message = "As contas referente a essa nota foram canceladas, não é possível alterar.";
                        string caption = "Não é possível alterar a parcela.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, icon);
                        return false;
                    }
                    else if (!obj[i].PaidDate.HasValue)
                    {
                        string message = "Existem parcelas anteriores referente a essa conta em aberto.";
                        string caption = "Não é possível alterar essa parcela.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, icon);
                        return false;
                    }
                }
            }
            return true;
        }

        private void NewPopulatedToPayForm()
        {
            var obj = GetObject();
            if (obj != null)
            {
                string formFunc = "Pay";
                Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive(formFunc, obj, _User);
                frmBillsToReceive.ShowDialog();
                SetBillsToReceiveDataSourceToDGV();              
            }
            else
            {
                Utilities.IsNotSelected(obj, "Conta");
            }
        }

        private void NewPopulatedToCancelForm()
        {
            var obj = GetObject();
            if (obj != null)
            {
                string formFunc = "Cancel";
                Frm_Create_BillsToReceive frmBillsToReceive = new Frm_Create_BillsToReceive(formFunc, obj, _User);
                frmBillsToReceive.ShowDialog();
                SetBillsToReceiveDataSourceToDGV();
            }
            else
            {
                Utilities.IsNotSelected(obj, "Conta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToReceive.Rows.Count > 1)
            {
                if (Authentication.Authenticate(_User.AccessLevel, 3))
                {
                    if (AbleToCancel())
                    {
                        NewPopulatedToCancelForm();
                    }
                }
            }
        }

        private bool AbleToCancel()
        {
           var obj = GetObject();
            if (obj != null)
            {
                var list = _controller.FindItemId(obj.id);
                for (int i = 0; i < obj.InstalmentNumber; i++)
                {
                    if (list[i].PaidDate != null || list[i].PaidDate.HasValue)
                    {
                        string message = "Não é possível cancelar essa conta pois já existem notas pagas relacionadas a essa venda.";
                        string caption = "Conta já paga.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        Utilities.Msgbox(message, caption, buttons, icon);
                        return false;
                    }
                    else if (list[i].CancelledDate != null || list[i].CancelledDate.HasValue)
                    {
                        string message = "Conta já cancelada.";
                        string caption = "Conta cancelada.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        Utilities.Msgbox(message, caption, buttons, icon);
                        return false;
                    }
                }
                if (obj.Sale.id < 0)
                {
                    string message = "Não é possível cancelar contas relacionadas a vendas, cancelamento deve ser feito pelo formulário de Vendas.";
                    string caption = "Conta a receber relacionada com Venda.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
                else return true;
            }
            else return false;
        }
    }
}
