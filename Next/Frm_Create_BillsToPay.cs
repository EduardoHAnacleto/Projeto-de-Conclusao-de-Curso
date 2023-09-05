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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Create_BillsToPay : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_BillsToPay()
        {
            InitializeComponent();
            edt_instalmentNumber.Controls[0].Visible = false;
            edt_supplierId.Controls[0].Visible = false;
            edt_BillNum.Controls[0].Visible = false;
            edt_BillSeries.Controls[0].Visible = false;
            edt_totalValue.Controls[0].Visible = false;
            edt_BillModel.Controls[0].Visible = false;
            PopulateComboBox();
        }

        public bool FromPurchase = false;
        public bool HasSaved = false;
        public List<BillsToPay> _auxObjList = new List<BillsToPay>();
        private BillsToPay _auxObj;
        private BillsToPay_Controller _controller = new BillsToPay_Controller();
        private readonly Suppliers_Controller _supplierController = new Suppliers_Controller();
        private readonly PaymentMethods_Controller _pMController = new PaymentMethods_Controller();


        public override bool CheckCamps()   //Valida Campos
        {
            if (edt_BillModel.Value <= 0 && edt_BillNum.Value <= 0 && edt_BillSeries.Value <= 0)
            {
                string message = "Nota fiscal deve ser inserida.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (datePicker_due.Value <= datePicker_due.MinDate)
            {
                string message = "Data de vencimento deve ser selecionada.";
                string caption = "Data de vencimento inválida.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_payMethod.SelectedItem, "Método de pagamento"))
            {
                cbox_payMethod.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(edt_instalmentNumber.Text, "Número da Parcela"))
            {
                edt_instalmentNumber.Focus();
                return false;
            }
            else if (edt_instalmentNumber.Value <= 0)
            {
                string message = "Número de parcela deve ser maior que 0.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (edt_totalValue.Value <= 0)
            {
                string message = "Valor total deve ser maior que 0.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (!(check_Active.Checked) && !(check_Paid.Checked))
            {
                string message = "Status deve ser selecionado.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                gbox_isPaid.Focus();
                return false;
            }
            return true;
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
                cbox_payMethod.Items.Add(text);
            }
        }

        public BillsToPay GetObject()
        {
            var obj = new BillsToPay();
            obj.Supplier = _supplierController.FindItemId((int)edt_supplierId.Value);

            obj.BillNumber = (int)edt_BillNum.Value;
            obj.BillModel = (int)edt_BillModel.Value;
            obj.BillSeries = (int)edt_BillSeries.Value;
            obj.PaymentMethod = _pMController.FindItemName(cbox_payMethod.SelectedItem.ToString());
            obj.Purchase = new Purchases();
            obj.Purchase.id = 0;
            obj.InstalmentNumber = (int)edt_instalmentNumber.Value;
            obj.TotalValue = (double)edt_totalValue.Value;
            obj.DueDate = datePicker_due.Value;
            obj.EmissionDate = DateTime.Now;
            if (check_Paid.Checked)
            {
                obj.PaidDate = datePicker_paid.Value;
                obj.Status = 1;
            }
            else if (check_Active.Checked) 
            {
                obj.Status = 0;
                obj.PaidDate = null;
            }
            else
            {
                obj.Status = 2;
                obj.PaidDate = null;
            }
            return obj;
        }

        public override void LockCamps()
        {
            gbox_supplier.Enabled = false;
            gbox_isPaid.Enabled = false;
            gbox_dates.Enabled = false;
            gbox_danfe.Enabled = false;
            gbox_billInfo.Enabled = false;
            check_Active.Enabled = false;
            check_Paid.Enabled = false;
        }

        public override void UnlockCamps()
        {
            gbox_supplier.Enabled = true;
            gbox_isPaid.Enabled = true;
            gbox_dates.Enabled = true;
            //gbox_danfe.Enabled = true;
            gbox_billInfo.Enabled = true;
            check_Active.Enabled = true;
            check_Paid.Enabled = true;

        }

        public override void ClearCamps()
        {
            edt_supplierId.Value = 0;
            edt_supplierName.Text = string.Empty;
            edt_BillModel.Value = 0;
            edt_BillNum.Value = 0;
            edt_BillSeries.Value = 0;
            edt_instalmentNumber.Value = 0;
            edt_totalValue.Value = 0;
            cbox_payMethod.SelectedIndex = 0;
            datePicker_due.Value = datePicker_due.MinDate;
            datePicker_paid.Value = datePicker_paid.MinDate;
            check_Active.Checked = false;
            check_Paid.Checked = false;
            lbl_CreationDate.Text = DateTime.Now.ToShortDateString();
            cbox_payMethod.SelectedIndex = 0;
            lbl_LastUpdate.Visible = false;
        }

        public override void Save()
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    if (btn_Edit.Text == "&Alterar")
                    {   
                        _controller.SaveItem(this.GetObject());
                        if (FromPurchase)
                        {
                            HasSaved = true;
                            _auxObjList.Add(this.GetObject());
                        }
                        ClearCamps();
                        Populated(false);
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

        public void PopulateCamps(BillsToPay bill)
        {
            edt_BillModel.Value = bill.BillModel;
            edt_BillNum.Value = bill.BillNumber;
            edt_BillSeries.Value = bill.BillSeries;
            edt_instalmentNumber.Value = bill.InstalmentNumber;
            if (bill.DueDate > DateTime.Today)
            {
                edt_totalValue.Value = Convert.ToDecimal(bill.TotalValue - (bill.TotalValue * bill.PaymentCondition.discountPerc/100));
            }
            else
            {
                edt_totalValue.Value = Convert.ToDecimal(bill.TotalValue + bill.PaymentCondition.fineValue);
            }

            cbox_payMethod.SelectedItem = bill.PaymentMethod.paymentMethod;
            datePicker_due.Value = bill.DueDate;
            lbl_CreationDate.Text = bill.dateOfCreation.ToShortTimeString();
            edt_supplierId.Value = bill.Supplier.id;
            edt_supplierName.Text = bill.Supplier.name;
            if (bill.dateOfLastUpdate != null)
            {
                lbl_LastUpdate.Text = bill.dateOfLastUpdate.ToShortTimeString();
                lbl_LastUpdate.Visible = true;
            }
            if (bill.PaidDate != null)
            {
                datePicker_paid.Value = (DateTime)bill.PaidDate;
            }
            if (bill.Status == 1)
            {
                check_Paid.Checked = true;
                check_Active.Checked = false;
                check_onHold.Checked = false;
            }
            else if (bill.Status == 0)
            {
                check_Active.Checked = true;
                check_Paid.Checked = false;
                check_onHold.Checked = false;
            }
            else if (bill.Status == 2)
            {
                check_onHold.Checked = true;
                check_Active.Checked = false;
                check_Paid.Checked = false;
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
                    int instalmentNum = Convert.ToInt32(edt_instalmentNumber.Value);
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


        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
                check_onHold.Checked = false;
                lbl_paidDate.Visible = false;
                datePicker_paid.Visible = false;
                check_Completed.Checked = false;
            }
        }

        private void check_Paid_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Paid.Checked)
            {
                check_onHold.Checked = false;
                check_Active.Checked = false;
                check_Completed.Checked = false;
                lbl_paidDate.Visible = true;
                datePicker_paid.Visible = true;
            }
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
            if (edt_supplierName.Text == string.Empty)
            {
                Frm_Find_Suppliers formSupplier = new Frm_Find_Suppliers();
                formSupplier.hasFather = true;
                formSupplier.ShowDialog();
                if (!formSupplier.ActiveControl.ContainsFocus)
                {
                    supplier = formSupplier.GetObject();
                }
                formSupplier.Close();
            }
            else if (edt_supplierId.Value > 0)
            {
                supplier = _supplierController.FindItemId(Convert.ToInt32(edt_supplierId.Value));      
            }
            else if (!string.IsNullOrWhiteSpace(edt_supplierName.Text))
            {
                supplier = _supplierController.FindItemName(edt_supplierName.Text);
            }
            else if (Utilities.AskToFind())
            {
                Frm_Find_Suppliers formSupplier = new Frm_Find_Suppliers();
                formSupplier.hasFather = true;
                formSupplier.ShowDialog();
                if (!formSupplier.ActiveControl.ContainsFocus)
                {
                    supplier = formSupplier.GetObject();
                }
                formSupplier.Close();
            }
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

        private void check_onHold_CheckedChanged(object sender, EventArgs e)
        {
            if (check_onHold.Checked)
            {
                check_Paid.Checked = false;
                check_Completed.Checked = false;
                check_Active.Checked = false;
                lbl_paidDate.Visible = false;
                datePicker_paid.Visible = false;
            }
        }

        private void check_Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Completed.Checked)
            {
                check_Paid.Checked = false;
                check_onHold.Checked = false;
                check_Active.Checked = false;
                lbl_paidDate.Visible = true;
                datePicker_paid.Visible = true;
            }
        }
    }
}
