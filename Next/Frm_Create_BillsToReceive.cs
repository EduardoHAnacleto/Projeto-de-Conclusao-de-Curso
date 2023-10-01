using ProjetoEduardoAnacletoWindowsForm1.Controllers;
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
    public partial class Frm_Create_BillsToReceive : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_BillsToReceive()
        {
            InitializeComponent();
            edt_clientId.Controls[0].Visible = false;
            edt_instalmentId.Controls[0].Visible = false;
            edt_saleNumber.Controls[0].Visible = false;
            edt_instalmentValue.Controls[0].Visible = false;
            PopulateComboBox();
            btn_SelectDelete.Visible = false;
            edt_id.Visible = false;
            lbl_id.Visible = false;
            check_Cancelled.Enabled = false;
            DGV_Instalments.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private readonly BillsToReceive_Controller _controller = new BillsToReceive_Controller();
        private readonly Clients_Controller _cController = new Clients_Controller();
        private readonly Sales_Controller _salesController = new Sales_Controller();
        private readonly PaymentMethods_Controller _payMethodController = new PaymentMethods_Controller();
        private BillsToReceive _auxObj;

        public BillsToReceive GetBillToReceive()  //Cria um OBJ a partir dos campos
        {
            BillsToReceive bill = new BillsToReceive();
            bill.Client = _cController.FindItemId(Convert.ToInt32(edt_clientId.Value));
            bill.InstalmentValue = Convert.ToDecimal(edt_instalmentValue.Value);
            bill.EmissionDate = Convert.ToDateTime(datePicker_emission.Text);
            bill.DueDate = Convert.ToDateTime(datePicker_due.Text);
            bill.dateOfLastUpdate = DateTime.Now;
            return bill;
        }

        public BillsToReceive GetObject()
        {
            var obj = new BillsToReceive();
            obj.Client = _cController.FindItemId(Convert.ToInt32(edt_clientId.Value));
            if (edt_saleNumber.Value != 0)
            {
                obj.Sale = _salesController.FindItemId(Convert.ToInt32(edt_saleNumber.Value));
            }
            else
            {
                obj.Sale = new Sales();
                obj.Sale.id = 0;
            }

            obj.PaymentMethod = _payMethodController.FindItemName(DGV_Instalments.Rows[0].Cells["PaymentMethod_Name"].Value.ToString());
            obj.InstalmentNumber = (int)edt_instalmentId.Value;
            obj.InstalmentValue = Convert.ToDecimal(DGV_Instalments.Rows[0].Cells["Value"].Value);
            obj.EmissionDate = datePicker_emission.Value;
            obj.DueDate = Convert.ToDateTime(DGV_Instalments.Rows[0].Cells["DueDate"].Value);
            obj.InstalmentsQtd = DGV_Instalments.Rows.Count;

            if (check_Active.Checked)
            {
                obj.PaidDate = null;
                obj.IsPaid = false;
                obj.CancelledDate = null;
            }
            else if (check_Paid.Checked)
            {
                obj.IsPaid = true;
                obj.PaidDate = datePicker_PaidDate.Value;
                obj.CancelledDate = null;
            }
            else if (check_Cancelled.Checked)
            {
                obj.IsPaid = false;
                obj.CancelledDate = DateTime.Now;
            }
            return obj;
        }

        public void PopulateCamps(BillsToReceive obj)
        {
            check_Cancelled.Enabled = true;
            _auxObj = obj;
            if (obj.dateOfLastUpdate != null)
            {
                lbl_LastUpdate.Visible = true;
                lbl_LastUpdate.Text = obj.dateOfLastUpdate.ToShortDateString();

            }
            edt_id.Text = obj.Sale.id.ToString();
            edt_clientId.Value = obj.Client.id;
            edt_clientName.Text = obj.Client.name;
            edt_instalmentId.Value = obj.InstalmentNumber;


            edt_saleNumber.Value = obj.Sale.id;
            cbox_paymentMethod.SelectedItem = obj.PaymentMethod.paymentMethod;
            datePicker_emission.Value = obj.EmissionDate;
            datePicker_due.Value = obj.DueDate;
            if (obj.PaidDate.HasValue)
            {
                datePicker_PaidDate.Value = (DateTime)obj.PaidDate;
                check_Active.Checked = false;
                check_Paid.Checked = true;
                check_Cancelled.Checked = false;
            }
            else
            {
                check_Cancelled.Checked = false;
                check_Active.Checked = true;
                check_Paid.Checked = false;
            }
            if (obj.CancelledDate.HasValue)
            {
                check_Active.Checked = false;
                check_Paid.Checked = false;
                check_Cancelled.Checked = true;
                LockCamps();
                btn_Edit.Enabled = false;
                btn_Edit.Visible = false;
                lbl_Sign_LastUpdate.Text = "Cancelado em : ";
                btn_NewSave.Visible = false;
                lbl_LastUpdate.Text = Convert.ToDateTime( obj.CancelledDate).ToShortDateString();
            }

            if (obj.Sale.id <= 1 || obj.PaidDate.HasValue)
            {
                edt_instalmentValue.Value = (decimal)obj.InstalmentValue;
            }
            else
            {
                edt_instalmentValue.Value = PaymentConditions.CalcValue(obj.InstalmentValue, obj.PaymentCondition, obj.DueDate);
                obj.InstalmentValue = edt_instalmentValue.Value;
            }
            PopulateDGV(obj);
        }

        public void PopulateDGV(BillsToReceive obj)
        {
            DGV_Instalments.Rows.Clear();
            if (obj != null)
            {
                string dueDate;
                if (obj.DueDate != null)
                {
                    dueDate = obj.DueDate.ToShortTimeString();
                }
                else
                {
                    dueDate = "";
                }
                DGV_Instalments.Rows.Add(obj.InstalmentNumber, obj.DueDate.ToString(), obj.InstalmentValue, obj.PaymentMethod.paymentMethod);
            }
        }

        public override void LockCamps()
        {
            gbox_client.Enabled = false;
            datePicker_due.Enabled = false;
            datePicker_emission.Enabled = false;
            datePicker_PaidDate.Enabled = false;
            edt_instalmentId.Enabled = false;
            edt_instalmentValue.Enabled = false;
            DGV_Instalments.Enabled = false;
            gbox_isPaid.Enabled = false;
            edt_saleNumber.Enabled = false;
            cbox_paymentMethod.Enabled = false;
        }

        public override void UnlockCamps()
        {
            gbox_client.Enabled = true;
            gbox_billDates.Enabled = true;
            gbox_billInstalment.Enabled = true;
            DGV_Instalments.Enabled = true;
            gbox_isPaid.Enabled = true;
            edt_saleNumber.Enabled = true;
            cbox_paymentMethod.Enabled = true;
        }

        public override void ClearCamps()
        {
            edt_clientId.Value = 0;
            edt_clientName.Text = string.Empty;
            edt_instalmentId.Value = 0;
            edt_instalmentValue.Value = 0;
            edt_saleNumber.Value = 0;
            cbox_paymentMethod.SelectedIndex = 0;
            datePicker_due.Value = datePicker_due.MinDate;
            datePicker_emission.Value = datePicker_emission.MinDate;
            datePicker_PaidDate.Value = datePicker_PaidDate.MinDate;
            check_Active.Checked = false;
            check_Paid.Checked = false;
            DGV_Instalments.Rows.Clear();
            lbl_CreationDate.Text = DateTime.Now.ToShortDateString();
            lbl_LastUpdate.Visible = false;
        }

        public override void Save()
        {
            LockCamps();
            try
            {
                if (btn_Edit.Text == "&Alterar")
                {
                    if (CheckCamps())
                    {
                        _controller.SaveItem(this.GetObject());
                        ClearCamps();
                        UnlockCamps();
                    }
                }
                else if (btn_Edit.Text == "Cancelar")
                {
                    _controller.UpdateItem(GetObject());
                    btn_Edit.Text = "&Alterar";
                    btn_NewSave.Enabled = false;
                    btn_SelectDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override void EditObject() //EditObject
        {
            if (btn_Edit.Text == "&Alterar")
            {
                edt_instalmentValue.Enabled = true;
                gbox_isPaid.Enabled = true;
                datePicker_PaidDate.Enabled = true;
                btn_Edit.Text = "Cancelar";
                btn_NewSave.Enabled = true;
                btn_SelectDelete.Enabled = true;
            }
            else if (btn_Edit.Text == "Cancelar")
            {
                btn_Edit.Text = "&Alterar";
                LockCamps();
                btn_SelectDelete.Enabled = false;
                btn_NewSave.Enabled = false;
                this.PopulateCamps(_auxObj);
            }
        }

        public void PopulateComboBox()
        {
            ComboBox comboBox = new ComboBox();
            PaymentMethods_Controller pController = new PaymentMethods_Controller();
            DataTable dt = pController.PopulateDGV();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr.ItemArray[1].ToString());
            }
            foreach (string text in comboBox.Items)
            {
                cbox_paymentMethod.Items.Add(text);
            }
            cbox_paymentMethod.SelectedIndex = 0;
        }

        public override bool CheckCamps() //Validacao de campos
        {
            if (edt_clientId.Value == 0)
            {
                string message = "Data de pagamento não pode ser menor que a da emissão.";
                string caption = "Data de pagamento inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_clientName.Focus();
                return false;
            }
            else if (datePicker_emission.Value <= datePicker_emission.MinDate)  //testar
            {
                string message = "Data de emissão deve ser ao mínimo 30 dias atrás.";
                string caption = "Data de emissão inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                datePicker_emission.Focus();
                return false;
            }
            else if (!check_Active.Checked && !check_Cancelled.Checked && !check_Paid.Checked)
            {
                string message = "Status da compra deve ser selecionado.";
                string caption = "Status não selecionado.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                gbox_isPaid.Focus();
                return false;
            }
            if (datePicker_emission.Value < DateTime.Today.Date)
            {
                TimeSpan diff = DateTime.Now - datePicker_emission.Value;
                if (diff.TotalDays < 30)
                {
                    string message = "Data de emissão deve ser ao mínimo 30 dias atrás.";
                    string caption = "Data de emissão inválida.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_emission.Focus();
                    return false;
                }
            }
            return true;
        }

        private void check_Paid_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Paid.Checked)
            {
                check_Active.Checked = false;
                check_Cancelled.Checked = false;
                datePicker_PaidDate.Value = DateTime.Now;
                datePicker_PaidDate.Visible = true;
                lbl_Sign_LastUpdate.Text = "Atualizado em : ";
                lbl_LastUpdate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
                check_Cancelled.Checked = false;
                datePicker_PaidDate.Visible = false;
                lbl_Sign_LastUpdate.Text = "Atualizado em : ";
                lbl_LastUpdate.Text = DateTime.Now.ToShortDateString();
            }
        }

        public void SearchClient() // Abre Form para encontrar e levar Cliente
        {
            Frm_Find_Clients formClient = new Frm_Find_Clients();
            formClient.hasFather = true;
            formClient.ShowDialog();
            if (!formClient.ActiveControl.ContainsFocus)
            {
                Clients client = new Clients();
                client = formClient.GetObject();
                if (client != null)
                {
                    edt_clientId.Value = client.id;
                    edt_clientName.Text = client.name;
                }
            }
            formClient.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchClient();
        }

        private void check_Cancelled_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Cancelled.Checked)
            {
                check_Active.Checked = false;
                check_Paid.Checked = false;
                lbl_Sign_LastUpdate.Text = "Cancelado em : ";
                lbl_LastUpdate.Text = DateTime.Now.ToShortDateString();
                datePicker_PaidDate.Visible = false;
            }
        }

        private void datePicker_PaidDate_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker_PaidDate.Value < datePicker_emission.Value && datePicker_PaidDate.Value != datePicker_PaidDate.MinDate)
            {
                string message = "Data de pagamento não pode ser menor que a da emissão.";
                string caption = "Data de pagamento inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
            }
            else
            {
                check_Paid.Checked = true;
                check_Active.Checked = false;
                check_Cancelled.Checked = false;
                datePicker_PaidDate.Value = DateTime.Now;
                datePicker_PaidDate.Visible = true;
            }
        }

        private void btn_AddInstalments_Click(object sender, EventArgs e)
        {
            AddInstalmentToDGV();
        }

        private void AddInstalmentToDGV()
        {
            if (edt_instalmentValue.Value > 0)
            {
                DGV_Instalments.Rows.Clear();
                DGV_Instalments.Rows.Add(
                    1,
                    datePicker_due.Value,
                    edt_instalmentValue.Value,
                    cbox_paymentMethod.SelectedItem.ToString()
                    );
            }
            else if (edt_instalmentValue.Value <= 0)
            {
                string message = "Valor da parcela deve ser maior que 0.";
                string caption = "Valor da parcela inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
            }
            else if (datePicker_due.Value < DateTime.Today.Date)
            {
                string message = "Data de vencimento deve ser hoje ou maior.";
                string caption = "Data de vencimento inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
            }
        }
    }
}
