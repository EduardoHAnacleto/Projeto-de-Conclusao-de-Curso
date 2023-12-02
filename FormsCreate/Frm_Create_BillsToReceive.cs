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
using System.Windows;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Create_BillsToReceive : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_BillsToReceive(string use, BillsToReceive bill, Users user )
        {
            InitializeComponent();
            edt_clientId.Controls[0].Visible = false;
            edt_instalmentId.Controls[0].Visible = false;   
            edt_instalmentValue.Controls[0].Visible = false;
            PopulateComboBox();
            btn_SelectDelete.Visible = false;
            DGV_Instalments.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SetFormToUse(use, bill);
            SetUser(user);
        }

        private readonly BillsToReceive_Controller _controller = new BillsToReceive_Controller();
        private readonly Clients_Controller _cController = new Clients_Controller();
        private readonly Sales_Controller _salesController = new Sales_Controller();
        private readonly PaymentMethods_Controller _payMethodController = new PaymentMethods_Controller();
        private BillsToReceive _auxObj;
        public Users User { get; private set; }
        public string _FormFunction { get; set; }

        private void SetUser(Users user)
        {
            User = user;
        }

        private void SetFormToUse(string use, BillsToReceive obj)
        {
            _FormFunction = use;
            if (_FormFunction == "New")
            {
                SetFormToNew();
            }
            else if (_FormFunction == "Pay")
            {
                SetFormToPay();
                PopulateCamps(obj);
            }
            else if (_FormFunction == "Cancel")
            {
                SetFormToCancel();
                PopulateCamps(obj);
            }
            else if (_FormFunction == "Check")
            {
                LockCamps();
                PopulateCamps(obj);
            }
        }

        private void SetFormToCancel()
        {
            check_Active.Checked = false;
            check_Cancelled.Checked = true;
            check_Paid.Checked = false;

            gbox_newBill.Enabled = false;
            gbox_newBill.Visible = false;
            gbox_paymentCondition.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_billInstalment.Visible = false;
            gbox_cancelReason.Enabled = true;
            txt_cancelMot.Enabled = true;
            gbox_cancelReason.Visible = true;

            datePicker_due.Enabled = false;
            datePicker_emission.Enabled = false;
            datePicker_PaidDate.Enabled = false;
            date_cancelled.Value = DateTime.Now.Date;
        }

        private void SetFormToPay()
        {
            check_Active.Checked = false;
            check_Cancelled.Checked = false;
            check_Paid.Checked = true;

            gbox_newBill.Enabled = false ;
            gbox_newBill.Visible = false;
            gbox_paymentCondition.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_cancelReason.Enabled = false;
            gbox_cancelReason.Visible = false;

            datePicker_due.Enabled = false;
            datePicker_emission.Enabled = false;
            datePicker_PaidDate.Enabled = true;
            date_cancelled.Enabled = false;
            datePicker_PaidDate.Value = DateTime.Now.Date;
        }

        private void SetFormToNew()
        {
            check_Active.Checked = true;
            check_Cancelled.Checked = false;
            check_Paid.Checked = false;

            gbox_newBill.Enabled = true;
            gbox_paymentCondition.Enabled = true;
            gbox_billInstalment.Enabled = false;
            gbox_billInstalment.Visible = false;
            gbox_cancelReason.Enabled = false;
            gbox_cancelReason.Visible = false;

            datePicker_due.Enabled = false;
            datePicker_emission.Enabled = true;
            datePicker_PaidDate.Enabled = false;
            date_cancelled.Enabled = false;
            datePicker_emission.Value = DateTime.Today.Date;
            edt_id.Value = _controller.GetNewId();
        }

        private PaymentMethods GetPaymentMethod(string payMethod)
        {
            return _payMethodController.FindItemName(payMethod);
        }

        private Clients GetClient(int clientId)
        {
            return _cController.FindItemId(clientId);
        }

        private PaymentConditions GetPaymentCondition(int id)
        {
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            return pcController.FindItemId(id);
        }

        public BillsToReceive GetObject()
        {
            var obj = new BillsToReceive();

            obj.Client = GetClient(Convert.ToInt32(edt_clientId.Value));
            if (_FormFunction != "New")
            {
                obj.PaymentMethod = GetPaymentMethod(DGV_Instalments.Rows[0].Cells["InstalmentMethod"].Value.ToString());
            }
            else { obj.PaymentMethod = null; }
            if (_FormFunction == "Pay")
            {
                obj.PaidDate = datePicker_PaidDate.Value;
            }
            if (_FormFunction == "Cancel")
            {
                obj.CancelledDate = date_cancelled.Value;
                obj.CancelMotive = txt_cancelMot.Text;
            }
            obj.InstalmentNumber = Convert.ToInt32(edt_instalmentId.Value);

            obj.PaymentCondition = GetPaymentCondition(Convert.ToInt32(edt_payConditionId.Value));
            obj.User = User;
            obj.Sale = new Sales();
            obj.Sale.id = 0;
            obj.InstalmentValue = edt_instalmentValue.Value;

            obj.EmissionDate = datePicker_emission.Value;
            obj.InstalmentsQtd = DGV_Instalments.Rows.Count;
            if (edt_id.Value > 0)
            {
                obj.id = Convert.ToInt32(edt_id.Value);
            }

            return obj;
        }

        public void PopulateCamps(BillsToReceive obj)
        {
            edt_id.Value = obj.id;
            _auxObj = obj;
            if (obj.dateOfLastUpdate != null)
            {
                lbl_LastUpdate.Visible = true;
                lbl_LastUpdate.Text = obj.dateOfLastUpdate.ToShortDateString();
            }
            edt_clientId.Value = obj.Client.id;
            edt_clientName.Text = obj.Client.name;
            edt_instalmentId.Value = obj.InstalmentNumber;

            cbox_paymentMethod.SelectedItem = obj.PaymentMethod.paymentMethod;
            datePicker_emission.Value = obj.EmissionDate;
            datePicker_due.Value = obj.DueDate;
            if (obj.PaidDate.HasValue)
            {
                datePicker_PaidDate.Value = (DateTime)obj.PaidDate;
            }

            if (obj.CancelledDate.HasValue)
            {
                gbox_cancelReason.Visible = true;
                gbox_cancelReason.Enabled = false;
                txt_cancelMot.Text = obj.CancelMotive;
                date_cancelled.Value = (DateTime)obj.CancelledDate;
                LockCamps();
            }

            edt_finalValue.Value = PaymentConditions.CalcValue(obj.InstalmentValue, obj.PaymentCondition, obj.DueDate);
            edt_instalmentValue.Value = obj.InstalmentValue;

            edt_instDisc.Value = obj.PaymentCondition.discountPerc;
            edt_instFee.Value = obj.PaymentCondition.paymentFees;
            edt_instFine.Value = obj.PaymentCondition.fineValue;
            edt_instValue.Value = obj.InstalmentValue;

            List<BillsToReceive> listBills = null;
            listBills = _controller.FindItemId(obj.id);
            FoundPaymentCondition(obj.PaymentCondition);
            PopulateDGV(listBills);
        }

        private void FoundPaymentCondition(PaymentConditions payCondition)
        {
            if (payCondition != null)
            {
                edt_payCondition.Text = payCondition.conditionName;
                edt_payConditionDiscount.Value = (decimal)payCondition.discountPerc;
                edt_payConditionFees.Value = (decimal)payCondition.paymentFees;
                edt_payConditionFine.Value = (decimal)payCondition.fineValue;
                edt_payConditionQnt.Value = payCondition.instalmentQuantity;
                edt_payConditionId.Value = payCondition.id;
                SetBillInstalmentsToDGV(payCondition.id);
                PopulateValueToDGV();
            }
        }

        public void PopulateDGV(List<BillsToReceive> obj)
        {
            DGV_Instalments.Rows.Clear();
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            var payCond = pcController.FindItemId(Convert.ToInt32(edt_payConditionId.Value));
            PopulatePaymentCondition(payCond);
            
            if (obj != null)
            {
                int k = 0;
                foreach (DataGridViewRow row in DGV_Instalments.Rows)
                {
                    row.Cells["InstalmentValue"].Value = obj[k].InstalmentValue;
                }
            }
        }

        public override void LockCamps()
        {
            gbox_client.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_cancelReason.Enabled = false;
            gbox_billDates.Enabled = false;
            gbox_dates.Enabled = false;
            gbox_newBill.Enabled = false;
            btn_Edit.Enabled = false;
            btn_NewSave.Enabled = false;
            btn_SelectDelete.Enabled = false;
        }

        public override void UnlockCamps()
        {

        }

        public override void ClearCamps()
        {
            edt_clientId.Value = 0;
            edt_clientName.Text = string.Empty;
            edt_instalmentId.Value = 0;
            edt_instalmentValue.Value = 0;
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
                if (CheckCamps())
                {
                    if (_FormFunction == "New")
                    {
                        bool status = false;
                        var obj = GetObject();
                        var list = BillsToReceive.MakeBills(obj, obj.PaymentCondition);
                        int billId = _controller.GetNewId();
                        foreach (var bill in list)
                        {
                            bill.id = billId;
                            status = _controller.SaveItem(bill);
                        }
                        if (status)
                        {
                            MessageBox.Show("Conta criada com sucesso.");
                        }
                        else { MessageBox.Show("Erro."); }

                        LockCamps();                  
                    }
                    else if (_FormFunction == "Pay")
                    {
                        _controller.PayBill(this.GetObject());
                        LockCamps();
                    }
                    else if (_FormFunction == "Cancel")
                    {
                        bool status = _controller.CancelBill(this.GetObject());
                        if (status)
                        {
                            MessageBox.Show("Conta cancelada com sucesso.");
                        }
                        LockCamps();
                    }

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
                gbox_Status.Enabled = true;
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

        public static bool AskToPay()
        {
            string message = "Deseja baixar essa nota?";
            string caption = "Confirmação.";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        public void PopulateComboBox()
        {
            cbox_paymentMethod.Items.Clear();
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
            if (ValidateBillValue() && ValidateCancelMotive()
                && ValidateClient() && ValidateDates() && ValidatePaymentCondition())
            {
                return true;
            }
            else return false;
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
                    PopulatePaymentCondition(client.PaymentCondition);
                }
            }
            formClient.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchClient();
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

        public void PopulateToPay()
        {
            check_Paid.Checked = true;
            check_Cancelled.Checked = false;
            check_Active.Checked = false;
        }

        public void PopulateToCancel()
        {
            check_Paid.Checked = false;
            check_Cancelled.Checked = true;
            check_Active.Checked = false;
        }

        private void btn_SearchPayCondition_Click(object sender, EventArgs e)
        {
            SearchPaymentCondition();
        }

        public void SearchPaymentCondition()
        {
            Frm_Find_PaymentConditions formPayCondition = new Frm_Find_PaymentConditions();
            formPayCondition.hasFather = true;
            formPayCondition.ShowDialog();
            if (!formPayCondition.ActiveControl.ContainsFocus)
            {
                PaymentConditions payCondition = new PaymentConditions();
                payCondition = formPayCondition.GetObject();
                if (payCondition != null)
                {
                    PopulatePaymentCondition(payCondition);
                }
            }
            formPayCondition.Close();
        }

        private void PopulatePaymentCondition(PaymentConditions payCondition)
        {
            if (payCondition != null)
            {
                edt_payCondition.Text = payCondition.conditionName;
                edt_payConditionDiscount.Value = (decimal)payCondition.discountPerc;
                edt_payConditionFees.Value = (decimal)payCondition.paymentFees;
                edt_payConditionFine.Value = (decimal)payCondition.fineValue;
                edt_payConditionQnt.Value = payCondition.instalmentQuantity;
                edt_payConditionId.Value = payCondition.id;
                SetBillInstalmentsToDGV(payCondition.id);
                PopulateValueToDGV();
            }
        }

        private void PopulateValueToDGV()
        {
            if (DGV_Instalments.Rows.Count > 0 && edt_instalmentValue.Value > 0)
            {
                PaymentConditions_Controller payCondController = new PaymentConditions_Controller();
                var payCond = payCondController.FindItemId(Convert.ToInt32(edt_payConditionId.Value));
                decimal billValue = (decimal)edt_instalmentValue.Value;
                foreach (DataGridViewRow row in DGV_Instalments.Rows)
                {
                    decimal percentage = payCond.BillsInstalments[row.Index].ValuePercentage;
                    row.Cells["InstalmentValue"].Value = Math.Round((billValue * (percentage/100)),2);
                }
            }
        }

        public void SetBillInstalmentsToDGV(int condId) //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            PaymentConditions_Controller pCController = new PaymentConditions_Controller();
            PaymentMethods_Controller pMController = new PaymentMethods_Controller();
            DGV_Instalments.Rows.Clear();
            var obj = pCController.FindItemId(condId).BillsInstalments;
            foreach (BillsInstalments bill in obj)
            {
                string method = pMController.FindItemId(Convert.ToInt32(bill.PaymentMethod.id)).paymentMethod;
                DGV_Instalments.Rows.Add(
                    bill.InstalmentNumber.ToString(),
                    bill.TotalDays.ToString(),
                    bill.ValuePercentage.ToString(),
                    method
                    );
            }
        }

        private void gbox_client_Leave(object sender, EventArgs e)
        {
            ValidateClient();
        }

        private bool ValidateClient()
        {
            if (edt_clientId.Value == 0 && _FormFunction == "New")
            {
                string message = "Cliente deve ser selecionado.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            return true;
        }

        private void gbox_newBill_Leave(object sender, EventArgs e)
        {
            ValidateBillValue();
            PopulateValueToDGV();
        }

        private bool ValidateBillValue()
        {
            if (edt_instalmentValue.Value == 0 && _FormFunction == "New")
            {
                string message = "Valor deve ser inserido.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            return true;
        }

        private void gbox_cancelReason_Leave(object sender, EventArgs e)
        {
            ValidateCancelMotive();
        }

        private bool ValidateCancelMotive()
        {
            if ((txt_cancelMot.Text == string.Empty || txt_cancelMot.Text.Length < 5) 
                && _FormFunction == "Cancel")
            {
                string message = "Motivo de cancelamento deve ser inserido com o mínimo de 5 caractéres.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            return true;
        }

        private void gbox_paymentCondition_Leave(object sender, EventArgs e)
        {
            ValidatePaymentCondition();
            PopulateValueToDGV();
        }

        private bool ValidatePaymentCondition()
        {
            if (edt_payConditionId.Value == 0 && _FormFunction == "New")
            {
                string message = "Condição de pagamento deve ser selecionada.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            return true;
        }

        private void gbox_billDates_Leave(object sender, EventArgs e)
        {
            ValidateDates();
        }

        private bool ValidateDates()
        {
            if (_FormFunction == "New")
            {
                if (datePicker_emission.Value > DateTime.Today)
                {
                    string message = "Data de emissão não pode ser após hoje.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_emission.Value = DateTime.Now;
                    return false;
                }
                else if (datePicker_emission.Value == datePicker_emission.MinDate)
                {
                    string message = "Data de emissão deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_emission.Value = DateTime.Now;
                    return false;                 
                }
            }
            else if (_FormFunction == "Pay")
            {
                if (datePicker_PaidDate.Value > DateTime.Today)
                {
                    string message = "Data de pagamento não pode ser após hoje.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_PaidDate.Value = datePicker_emission.Value;
                    return false;
                }
                else if (datePicker_PaidDate.Value == datePicker_PaidDate.MinDate)
                {
                    string message = "Data de pagamento deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_PaidDate.Value = datePicker_emission.Value;
                    return false;
                }
                else if (datePicker_PaidDate.Value < datePicker_emission.Value)
                {
                    string message = "Data de pagamento não deve ser menor que a data de emissão.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    datePicker_PaidDate.Value = datePicker_emission.Value;
                    return false;
                }
            }
            else if (_FormFunction == "Cancel")
            {
                if (date_cancelled.Value > DateTime.Today)
                {
                    string message = "Data de cancelamento não pode ser após hoje.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    date_cancelled.Value = datePicker_emission.Value;
                    return false;
                }
                else if (date_cancelled.Value < datePicker_emission.Value)
                {
                    string message = "Data de cancelamento não deve ser menor que a data de emissão.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    date_cancelled.Value = datePicker_emission.Value;
                    return false;
                }
                else if (date_cancelled.Value == date_cancelled.MinDate)
                {
                    string message = "Data de cancelamento deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    date_cancelled.Value = datePicker_emission.Value;
                    return false;
                }
            }
            return true;
        }

        private void edt_instalmentValue_ValueChanged(object sender, EventArgs e)
        {
            PopulateValueToDGV();
        }

        private void edt_payCondition_TextChanged(object sender, EventArgs e)
        {
            PopulateValueToDGV();
        }
    }
}
