using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Create_BillsToPay : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_BillsToPay(string use, BillsToPay bill, Users user)
        {
            InitializeComponent();
            edt_supplierId.Controls[0].Visible = false;
            edt_BillNum.Controls[0].Visible = false;
            edt_BillSeries.Controls[0].Visible = false;
            edt_BillModel.Controls[0].Visible = false;
            btn_SelectDelete.Visible = false;
            DGV_Instalments.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PopulateComboBox();
            SetFormToUse(use, bill);
            SetUser(user);
        }

        public string _FormFunction { get; set; }
        public Users User { get; private set; }
        public bool FromPurchase = false;
        public bool ValidatedBill { get; set; } = false;
        public bool HasSaved = false;
        public List<BillsToPay> _auxObjList = new List<BillsToPay>();
        private BillsToPay _auxObj;
        private BillsToPay_Controller _controller = new BillsToPay_Controller();
        private readonly Suppliers_Controller _supplierController = new Suppliers_Controller();
        private readonly PaymentMethods_Controller _pMController = new PaymentMethods_Controller();


        private void SetUser(Users user)
        {
            User = user;
        }

        private void SetFormToUse(string use, BillsToPay obj)
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

            gbox_billInstalment.Visible = true;
            gbox_billInstalment.Enabled = false;
            gbox_newBill.Enabled = false;
            btn_SearchSupplier.Enabled = false;
            gbox_newBill.Visible = false;
            gbox_isPaid.Enabled = false;
            gbox_paymentCondition.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_billInstalment.Visible = false;
            edt_instalmentValue.Enabled = false;
            gbox_cancelReason.Enabled = true;
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
            gbox_isPaid.Enabled = false;
            gbox_billInstalment.Visible = true;
            gbox_billInstalment.Enabled = false;
            btn_SearchSupplier.Enabled = false;
            gbox_newBill.Enabled = false;
            gbox_newBill.Visible = false;
            gbox_paymentCondition.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_cancelReason.Enabled = false;
            gbox_cancelReason.Visible = false;
            gbox_danfe.Enabled = false;
            edt_instalmentValue.Enabled = false;

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

            gbox_billInstalment.Visible = false;
            gbox_billInstalment.Enabled = false;
            gbox_newBill.Enabled = false;
            gbox_paymentCondition.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_billInstalment.Visible = false;
            gbox_cancelReason.Enabled = false;
            gbox_cancelReason.Visible = false;
            gbox_isPaid.Enabled = false;

            datePicker_due.Enabled = false;
            datePicker_emission.Enabled = false;
            datePicker_PaidDate.Enabled = false;
            date_cancelled.Enabled = false;
        }

        public bool ValidateCampsToValidateBill()
        {
            if (edt_BillModel.Value != 0
                    && edt_BillNum.Value != 0
                    && edt_BillSeries.Value != 0
                    && edt_supplierId.Value != 0)
            {
                if (FoundBill())
                {
                    MessageBox.Show("Nota já cadastrada.");
                }
                else
                {
                    UnlockCamps();
                    LockBillKeys();
                }
            }
            return false;             
        }

        private void LockBillKeys()
        {
            gbox_supplier.Enabled = false;
            gbox_danfe.Enabled = false;
        }

        private bool FoundBill()
        {
            int bNum = (int)edt_BillNum.Value;
            int bMod = (int)edt_BillModel.Value;
            int bSer = (int)edt_BillSeries.Value;
            int supId = (int)edt_supplierId.Value;
            var obj = _controller.FindItemId(bMod, bNum, bSer, supId);
            if (obj.Count > 0)
            {
                ValidatedBill = false;
                return true;
            }
            else
            {
                ValidatedBill = true;
                return false;
            }
        }

        private PaymentMethods GetPaymentMethod(string payMethod)
        {
            return _pMController.FindItemName(payMethod);
        }

        private Suppliers GetSupplier(int supplierId)
        {
            return _supplierController.FindItemId(supplierId);
        }

        private PaymentConditions GetPaymentCondition(int id)
        {
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            return pcController.FindItemId(id);
        }

        public void PopulateCamps(BillsToPay bill)
        {
            _auxObj = bill;
            edt_BillModel.Value = bill.BillModel;
            edt_BillNum.Value = bill.BillNumber;
            edt_BillSeries.Value = bill.BillSeries;
            edt_instalmentId.Value = bill.InstalmentNumber;
            lbl_CreationDate.Text = bill.dateOfCreation.ToString();

            cbox_paymentMethod.SelectedItem = bill.PaymentMethod.paymentMethod;
            datePicker_due.Value = bill.DueDate;
            lbl_CreationDate.Text = bill.dateOfCreation.ToShortDateString();
            edt_supplierId.Value = bill.Supplier.id;
            edt_supplierName.Text = bill.Supplier.name;
            datePicker_emission.Value = bill.EmissionDate;

            if (bill.dateOfLastUpdate != null)
            {
                lbl_LastUpdate.Text = bill.dateOfLastUpdate.ToShortDateString();
                lbl_LastUpdate.Visible = true;
            }
            if (bill.PaidDate.HasValue)
            {
                datePicker_PaidDate.Value = (DateTime)bill.PaidDate;
            }

            if (bill.CancelledDate.HasValue)
            {
                gbox_cancelReason.Visible = true;
                gbox_cancelReason.Enabled = false;
                txt_cancelMot.Text = bill.CancelMotive;
                date_cancelled.Value = (DateTime)bill.CancelledDate;
                LockCamps();
            }

            edt_instValue.Value = bill.TotalValue;
            edt_instFee.Value = bill.PaymentCondition.paymentFees;
            edt_instFine.Value = bill.PaymentCondition.fineValue;
            edt_instDisc.Value = bill.PaymentCondition.discountPerc;
            //decimal instalmentValue = bill.TotalValue * (bill.PaymentCondition.BillsInstalments[bill.InstalmentNumber].ValuePercentage /100);
            edt_finalValue.Value = PaymentConditions.CalcValue(bill.TotalValue, bill.PaymentCondition, bill.DueDate);
            edt_instalmentValue.Value = bill.TotalValue;
                                  
            var obj = _controller.FindItemId(bill.BillNumber, bill.BillModel, bill.BillSeries, bill.Supplier.id);
            FoundPaymentCondition(bill.PaymentCondition);
        }

        public override void LockCamps()
        {
            gbox_billDates.Enabled = false;
            gbox_danfe.Enabled = false;
            gbox_supplier.Enabled = false;
            gbox_billInstalment.Enabled = false;
            gbox_cancelReason.Enabled = false;
            btn_SearchSupplier.Enabled = false;
            gbox_dates.Enabled = false;
            gbox_newBill.Enabled = false;
            edt_instalmentValue.Enabled = false;
            btn_Edit.Enabled = false;
            btn_NewSave.Enabled = false;
            btn_SelectDelete.Enabled = false;
            datePicker_emission.Enabled = false;
            datePicker_due.Enabled = false;
            date_cancelled.Enabled = false;
            datePicker_PaidDate.Enabled = false;
            gbox_isPaid.Enabled = false;
        }

        public override void UnlockCamps()
        {
            gbox_paymentCondition.Enabled = true;
            gbox_billDates.Enabled = true;
            gbox_newBill.Enabled = true;
            gbox_dates.Enabled = true;
            datePicker_emission.Enabled = true;

        }

        public override void ClearCamps()
        {
            edt_supplierId.Value = 0;
            edt_supplierName.Text = string.Empty;
            edt_BillModel.Value = 0;
            edt_BillNum.Value = 0;
            edt_BillSeries.Value = 0;
            edt_finalValue.Value = 0;
            datePicker_due.Value = datePicker_due.MinDate;
            datePicker_PaidDate.Value = datePicker_PaidDate.MinDate;
            check_Active.Checked = false;
            check_Paid.Checked = false;
            lbl_CreationDate.Text = DateTime.Now.ToShortDateString();
            if (cbox_paymentMethod.Items.Count > 0)
            {
                cbox_paymentMethod.SelectedIndex = 0;
            }
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
                        var list = BillsToPay.MakeBills(obj, obj.PaymentCondition);
                        foreach (var bill in list)
                        {
                            status = _controller.SaveItem(bill);
                        }
                        if (status)
                        {
                            MessageBox.Show("Conta criada com sucesso.");
                        }
                        else { MessageBox.Show("Erro."); }

                        ClearCamps();
                        UnlockCamps();
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
                            MessageBox.Show("Contas canceladas com sucesso.");
                            LockCamps();
                        }
                        else { MessageBox.Show("Erro."); }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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

        public override bool CheckCamps() //Validacao de campos
        {
            if (ValidateCancelMotive()
                && ValidateSupplier() && ValidateDates() && ValidatePaymentCondition())
            {
                return true;
            }
            else
                return false;           
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

        private bool ValidateSupplier()
        {
            if (edt_supplierId.Value == 0 && _FormFunction == "New")
            {
                string message = "Fornecedor deve ser selecionado.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }           
            return true;
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

        private bool ValidateCancelMotive()
        {
            if ((txt_cancelMot.Text.Trim().Length < 5)
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

        private bool ValidateDates()
        {
            if (_FormFunction == "New")
            {
                if (datePicker_emission.Value > DateTime.Today.Date)
                {
                    string message = "Data de emissão não pode ser após hoje.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
                else if (datePicker_emission.Value == datePicker_emission.MinDate)
                {
                    string message = "Data de emissão deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
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
                    return false;
                }
                else if (datePicker_PaidDate.Value == datePicker_PaidDate.MinDate)
                {
                    string message = "Data de pagamento deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
                else if (datePicker_PaidDate.Value < datePicker_emission.Value)
                {
                    string message = "Data de pagamento não deve ser menor que a data de emissão.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
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
                    return false;
                }
                else if (date_cancelled.Value < datePicker_emission.Value)
                {
                    string message = "Data de cancelamento não deve ser menor que a data de emissão.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
                else if (date_cancelled.Value == date_cancelled.MinDate)
                {
                    string message = "Data de cancelamento deve ser selecionada.";
                    string caption = "Item inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
            }
            return true;
        }

        private bool ValidateNFe()
        {
            if ( _FormFunction == "New" && edt_BillModel.Value < 0 && edt_BillNum.Value < 0
                && edt_BillSeries.Value < 0)
            {
                string message = "Campos de Número, Modelo e Série são obrigatórios.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (_FormFunction == "New" && edt_BillModel.Value > 0 && edt_BillNum.Value > 0
                && edt_BillSeries.Value > 0 && edt_supplierId.Value > 0)
            {
                int billNum = (int)edt_BillNum.Value;
                int billMod = (int)edt_BillModel.Value;
                int billSer = (int)edt_BillSeries.Value;
                int suppId = (int)edt_supplierId.Value;
                var obj = _controller.FindItemId(billNum, billMod, billSer, suppId);
                if (obj != null)
                {
                    string message = "Conta já existente.";
                    string caption = "Conta encontrada.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
            }
            return true;
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

        public BillsToPay GetObject()
        {
            var obj = new BillsToPay();
            var pcController = new PaymentConditions_Controller();
            obj.Supplier = _supplierController.FindItemId((int)edt_supplierId.Value);
            
            obj.BillNumber = (int)edt_BillNum.Value;
            obj.BillModel = (int)edt_BillModel.Value;
            obj.BillSeries = (int)edt_BillSeries.Value;
            if (_FormFunction != "New")
            {
                obj.PaymentMethod = _pMController.FindItemName(cbox_paymentMethod.SelectedItem.ToString());
            }
            else
            {
                obj.PaymentMethod = null;
            }
            obj.PaymentCondition = pcController.FindItemId(Convert.ToInt32(edt_payConditionId.Value));
            obj.Purchase = new Purchases();
            obj.Purchase.id = 0;
            obj.InstalmentNumber = (int)edt_instalmentId.Value;
            obj.User = User;
            obj.TotalValue = edt_instalmentValue.Value;
            obj.DueDate = datePicker_due.Value;
            obj.EmissionDate = DateTime.Now;
            if (check_Paid.Checked)
            {
                obj.PaidDate = date_cancelled.Value;
                obj.Status = 1;
            }
            else if (check_Active.Checked) 
            {
                obj.Status = 0;
                obj.PaidDate = null;
            }
            else if (check_Cancelled.Checked)
            {
                obj.Status = 2;
                obj.PaidDate = null;
                obj.CancelledDate = date_cancelled.Value;
                obj.CancelMotive = txt_cancelMot.Text;
            }
            return obj;
        }




        //public override void Save()
        //{
        //    if (CheckCamps())
        //    {
        //        LockCamps();
        //        try
        //        {
        //            if (btn_Edit.Text == "&Alterar")
        //            {   
        //                _controller.SaveItem(this.GetObject());
        //                if (FromPurchase)
        //                {
        //                    HasSaved = true;
        //                    _auxObjList.Add(this.GetObject());
        //                }
        //                ClearCamps();
        //                Populated(false);
        //            }
        //            else if (btn_Edit.Text == "Cancelar")
        //            {
        //                if (RightInstalment())
        //                {
        //                    var obj = GetObject();
        //                    _controller.CancelPurchaseBills(obj.BillNumber, obj.BillModel, obj.BillSeries, obj.Supplier.id);
        //                    Purchases_Controller purchController = new Purchases_Controller();
        //                    var purchase = purchController.FindItemId(obj.BillModel, obj.BillNumber, obj.BillSeries, obj.Supplier.id);
        //                    purchController.CancelPurchase(purchase); //Cancela a compra
        //                    btn_Edit.Text = "&Alterar";
        //                    btn_NewSave.Enabled = false;
        //                    btn_SelectDelete.Enabled = false;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //}

        private bool RightInstalment()
        {
            var billNumber = Convert.ToInt32(edt_BillNum.Value);
            var billModel = Convert.ToInt32(edt_BillModel.Value);
            var billSeries = Convert.ToInt32(edt_BillSeries.Value);
            var supplierId = Convert.ToInt32(edt_supplierId.Value);
            var instalmentNum = Convert.ToInt32(edt_instalmentId.Value);
            var obj = _controller.FindItemId(billNumber,billModel,billSeries,supplierId);
            if (instalmentNum > 1)
            {
                for (int i = 0; i > obj.Count; i++) 
                {
                    if (obj[i].Status == 2) //Confirmar
                    {
                        string message = "As contas referente a essa nota foram canceladas, não é possível alterar.";
                        string caption = "Não é possível alterar a parcela.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, icon);
                        return false;
                    }
                    if (obj[i].PaidDate == null && obj[i].Status == 0)
                    {
                        string message = "Existem parcelas anteriores referente a essa compra em aberto.";
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

        public override void Populated(bool populated)
        {
            if (populated)
            {
                this.LockCamps();
                btn_SelectDelete.Enabled = false;
                btn_Edit.Enabled = true;
                btn_NewSave.Enabled = false;
            }
            else if (!populated)
            {
                btn_SelectDelete.Enabled = false;
                //btn_Edit.Enabled = false;
                btn_NewSave.Enabled = true;

                this.UnlockCamps();
                this.ClearCamps();
            }
        }

        public override void EditObject() //EditObject
        {
            if (btn_Edit.Text == "&Alterar")
            {
                UnlockCamps();
                btn_Edit.Text = "Cancelar";
                btn_NewSave.Enabled = true;
                btn_SelectDelete.Enabled = true;
                _auxObj = GetObject();
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

        public override void DeleteObject() //DeleteObject
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    int billNum = Convert.ToInt32(edt_BillNum.Value);
                    int billModel = Convert.ToInt32(edt_BillModel.Value);
                    int billSeries = Convert.ToInt32(edt_BillSeries.Value);
                    int instalmentNum = Convert.ToInt32(edt_instalmentId.Value);
                    int supplierId = Convert.ToInt32(edt_supplierId.Value);

                    _controller.DeleteItem(billNum, billModel, billSeries, instalmentNum, supplierId);
                    this.ClearCamps();
                    this.edt_id.Value = this.BringNewId();
                    btn_SelectDelete.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_Edit.Text = "&Alterar";
                    Populated(false);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            UnlockCamps();
        }

        public override void Exit()
        {
            if (FromPurchase)
            {
                this.Hide();
            }
            else
            {
                base.Exit();
            }
        }

        public void PopulateSupplier(Suppliers supplier)
        {
            edt_supplierId.Value = supplier.id;
            edt_supplierName.Text = supplier.name;
        }

        public void SearchSupplier()
        {
            Suppliers supplier = new Suppliers();
            Frm_Find_Suppliers formSupplier = new Frm_Find_Suppliers();
            formSupplier.hasFather = true;
            formSupplier.ShowDialog();
            if (!formSupplier.ActiveControl.ContainsFocus)
            {
                supplier = formSupplier.GetObject();
            }
            formSupplier.Close();
            if (supplier != null)
            {
                PopulateSupplier(supplier);
            }
        }

        public void PopulateFromPurchase(Purchases purchase)
        {
            edt_supplierId.Value = purchase.Supplier.id;
            edt_supplierName.Text = purchase.Supplier.name;
            gbox_supplier.Enabled = false;
            btn_Edit.Enabled = false;
            btn_SelectDelete.Enabled = false;
            check_Active.Checked = true;
        }

        private void btn_SearchSupplier_Click(object sender, EventArgs e)
        {
            SearchSupplier();
        }

        private void check_Completed_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void LockCancelled()
        {
            check_Cancelled.Enabled = false;
        }

        private void gbox_newBill_Leave(object sender, EventArgs e)
        {
            ValidateBillValue();
            PopulateValueToDGV();
        }

        private void gbox_billDates_Leave(object sender, EventArgs e)
        {
            ValidateDates();
        }

        private void gbox_paymentCondition_Leave(object sender, EventArgs e)
        {
            ValidatePaymentCondition();
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
                    FoundPaymentCondition(payCondition);
                }
            }
            formPayCondition.Close();
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

        private void gbox_supplier_Leave(object sender, EventArgs e)
        {
            ValidateSupplier();
        }

        private void gbox_cancelReason_Leave(object sender, EventArgs e)
        {
            ValidateCancelMotive();
        }

        private void PopulateValueToDGV()
        {
            if (DGV_Instalments.Rows.Count > 0 && edt_instalmentValue.Value > 0)
            {
                if (_FormFunction == "New")
                {
                    PaymentConditions_Controller payCondController = new PaymentConditions_Controller();
                    var payCond = payCondController.FindItemId(Convert.ToInt32(edt_payConditionId.Value));
                    decimal billValue = (decimal)edt_instalmentValue.Value;
                    foreach (DataGridViewRow row in DGV_Instalments.Rows)
                    {
                        decimal percentage = payCond.BillsInstalments[row.Index].ValuePercentage;
                        row.Cells["InstalmentValue"].Value = Math.Round((billValue * (percentage / 100)), 2);
                    }
                }
                else
                {
                    var billNum = (int)edt_BillNum.Value;
                    var billMod = (int)edt_BillModel.Value;
                    var billSer = (int)edt_BillSeries.Value;
                    var suppId = (int)edt_supplierId.Value;
                    var list = _controller.FindItemId(billNum, billMod, billSer, suppId);
                    int i = 0;
                    foreach (DataGridViewRow row in DGV_Instalments.Rows)
                    {
                        row.Cells["InstalmentValue"].Value = Math.Round(list[i].TotalValue, 2);
                        i++;
                    }
                }
            }
        }

        private void btn_SearchPayCondition_Click(object sender, EventArgs e)
        {
            SearchPaymentCondition();
        }

        private void edt_instalmentValue_ValueChanged(object sender, EventArgs e)
        {
            PopulateValueToDGV();
        }

        private void edt_supplierId_ValueChanged(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void edt_BillNum_Leave(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void edt_BillModel_Leave(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill(); 
        }

        private void edt_BillSeries_Leave(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void gbox_danfe_Leave(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void edt_BillSeries_ValueChanged(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void edt_BillModel_ValueChanged(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }

        private void edt_BillNum_ValueChanged(object sender, EventArgs e)
        {
            ValidateCampsToValidateBill();
        }
    }
}
