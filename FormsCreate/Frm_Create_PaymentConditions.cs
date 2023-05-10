using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
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

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_PaymentConditions : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_PaymentConditions()
        {
            InitializeComponent();
            edt_instalmentNumber.Controls[0].Visible = false;
            edt_daysCount.Controls[0].Visible = false;
            edt_discount.Controls[0].Visible = false;
            edt_paymentFee.Controls[0].Visible = false;
            edt_paymentFine.Controls[0].Visible = false;
            edt_valuePercentage.Controls[0].Visible = false;
            PopulateComboBox();
            btn_NewSave.Enabled = false;
        }

        private PaymentConditions_Controller controller = new PaymentConditions_Controller();
        PaymentConditions auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId()
        {
            return controller.BringNewId();
        }

        public override void LockCamps()
        {
            edt_daysCount.Enabled = false;
            edt_discount.Enabled = false;
            edt_paymentCondition.Enabled = false;
            edt_paymentFee.Enabled = false;
            edt_totalPercentage.Enabled = false;
            edt_paymentFine.Enabled = false;
            edt_instalmentNumber.Enabled = false;
            edt_valuePercentage.Enabled = false;
            btn_SearchMethod.Enabled = false;
            DGV_Instalments.Enabled = false;
            cbox_payMethods.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_daysCount.Enabled = true;
            edt_discount.Enabled = true;
            edt_paymentCondition.Enabled = true;
            edt_paymentFee.Enabled = true;
            edt_totalPercentage.Enabled = true;
            edt_paymentFine.Enabled = true;
            edt_instalmentNumber.Enabled = true;
            edt_valuePercentage.Enabled = true;
            btn_SearchMethod.Enabled = true;
            DGV_Instalments.Enabled = true;
            cbox_payMethods.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_daysCount.Value = 0;
            edt_discount.Text = String.Empty;
            edt_paymentCondition.Text = String.Empty;
            edt_paymentFee.Text = String.Empty;
            edt_totalPercentage.Text = String.Empty;
            edt_paymentFine.Text = String.Empty;
            edt_instalmentNumber.Value = 0;
            edt_valuePercentage.Text = String.Empty;
            DGV_Instalments.Rows.Clear();
        }

        public override bool CheckCamps()
        {
            if (Utilities.HasSpecialChars(edt_paymentCondition.Text,"Payment Condition") ||
                Utilities.HasOnlySpaces(edt_paymentCondition.Text, "Payment Condition"))
            {
                edt_paymentCondition.Focus();
                return false;
            }
            if (!Utilities.IsDouble(edt_paymentFine.Text,"Payment Fine"))
            {
                edt_paymentFine.Focus();
                return false;
            }
            if (!Utilities.IsDouble(edt_paymentFee.Text,"Payment Fee"))
            {
                edt_paymentFee.Focus();
                return false;
            }
            if (!Utilities.IsDouble(edt_discount.Text,"Discount"))
            {
                edt_discount.Focus();
                return false;
            }
            else return true;
        }

        public void SearchMethod()
        {
            Frm_Find_PaymentMethods formMethods = new Frm_Find_PaymentMethods();
            formMethods.hasFather = true;
            formMethods.ShowDialog();
            if (!formMethods.ActiveControl.ContainsFocus)
            {
                PaymentMethods payMethod = new PaymentMethods();
                payMethod = formMethods.GetObject();
                if (payMethod != null)
                {
                    cbox_payMethods.SelectedItem = payMethod.paymentMethod;

                }
                formMethods.Close();
            }
        }

        private void btn_SearchMethod_Click(object sender, EventArgs e)
        {
            SearchMethod();
        }

        public bool CheckInstalmentCamps()
        {
            if (edt_daysCount.Value < 0)
            {
                string message = "Days camp must be 0 or higher.";
                string caption = "Required camp is empty.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_daysCount.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(edt_valuePercentage.Text, "Value Percentage"))
            {
                edt_valuePercentage.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_payMethods.SelectedItem, "Payment Method" ))
            {
                cbox_payMethods.Focus();
                return false;
            }
            return true;
        }

        public void AddInstalment()
        {
            if (CheckInstalmentCamps())
            {
                AddToDGV();
                edt_instalmentNumber.Value++;
            }
            CalculateMaxPercentage();
        }

        private void btn_AddInstalment_Click(object sender, EventArgs e)
        {
            AddInstalment();
        }

        public void AddToDGV()
        {
            DGV_Instalments.Rows.Add(
                edt_instalmentNumber.Value,
                edt_daysCount.Value,
                edt_valuePercentage.Value,
                cbox_payMethods.SelectedItem.ToString());
        }

        public PaymentConditions GetObject()
        {
            PaymentMethods_Controller method = new PaymentMethods_Controller();
            var conditions = new PaymentConditions();
            List<BillsInstalments> billList = new List<BillsInstalments>();
            BillsInstalments bill = null;
            DateTime time = DateTime.Now;
            conditions.id = Convert.ToInt32(edt_id.Value);
            conditions.conditionName = edt_paymentCondition.Text;
            conditions.fineValue = Convert.ToDouble(edt_paymentFine.Value);
            conditions.paymentFees = Convert.ToDouble(edt_paymentFee.Value);
            conditions.discountPerc = Convert.ToDouble(edt_discount.Value);
            if (conditions.dateOfCreation == DateTime.MinValue)
            {
                conditions.dateOfCreation = time;
            }
            conditions.dateOfLastUpdate = DateTime.Now;
            foreach (DataGridViewRow row in DGV_Instalments.Rows)
            {
                bill = new BillsInstalments();
                bill.id = conditions.id;
                bill.InstalmentNumber = Convert.ToInt32(row.Cells["InstalmentNumber"].Value);
                bill.TotalDays = Convert.ToInt32(row.Cells["IntalmentDays"].Value);
                bill.ValuePercentage = Convert.ToDouble(row.Cells["InstalmentPercentage"].Value);
                bill.PaymentMethod = method.FindItemName(row.Cells["InstalmentPayMethod"].Value.ToString());
                if (bill.dateOfCreation == DateTime.MinValue)
                {
                    bill.dateOfCreation = time;
                }
                bill.dateOfLastUpdate = time;

                billList.Add(bill);
            }
            conditions.BillsInstalments = billList;
            conditions.instalmentQuantity = conditions.BillsInstalments.Count();
            return conditions;
        }

        public void EventRowDeleted()
        {
            if (edt_instalmentNumber.Value > 1)
            {
                edt_instalmentNumber.Value--;
            }
            CalculateMaxPercentage();
        }

        private void DGV_Instalments_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            EventRowDeleted();
        }

        public void CalculateMaxPercentage()
        {
            double  aux = 0;
            foreach (DataGridViewRow row in DGV_Instalments.Rows)
            {
                aux += Convert.ToDouble(row.Cells["InstalmentPercentage"].Value);
            }
            if (aux > 100)
            {
                btn_AddInstalment.Enabled = false;
                btn_NewSave.Enabled = false;
                string message = "Total value percentage must not be higher than 100%. Remove an instalment.";
                string caption = "Value percentage above limit.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                DGV_Instalments.Focus();
            }
            else if (aux < 100)
            {
                btn_NewSave.Enabled = false;
                btn_AddInstalment.Enabled = true;
            }
            else if (aux == 100)
            {
                btn_NewSave.Enabled = true;
                btn_AddInstalment.Enabled = false;
            }
            edt_totalPercentage.Text = aux.ToString();
        }

        public void PopulateCamps(PaymentConditions cond)
        {
            edt_id.Value = cond.id;
            edt_paymentCondition.Text = cond.conditionName;
            edt_paymentFee.Text = cond.paymentFees.ToString();
            edt_discount.Text = cond.discountPerc.ToString();
            edt_paymentFine.Text = cond.fineValue.ToString();
            lbl_CreationDate.Text = cond.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = cond.dateOfLastUpdate.ToShortDateString();
            PopulateDGV(cond.BillsInstalments);
        }

        public void PopulateDGV(List<BillsInstalments> bills)
        {
            DGV_Instalments.Rows.Clear();
            int i = 0;
            if (bills != null)
            {
                foreach (BillsInstalments item in bills)
                {
                    DGV_Instalments.Rows.Add();
                    DGV_Instalments.Rows[i].Cells["InstalmentNumber"].Value = item.InstalmentNumber.ToString();
                    DGV_Instalments.Rows[i].Cells["IntalmentDays"].Value = item.TotalDays.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentPercentage"].Value = item.ValuePercentage.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentPayMethod"].Value = item.PaymentMethod.paymentMethod.ToString();
                    i++;
                }
            }
            CalculateMaxPercentage();
        }

        public void PopulateComboBox()
        {
            ComboBox comboBox = new ComboBox();
            PaymentMethods_Controller pController = new PaymentMethods_Controller();
            DataTable dt = pController.PopulateDGV();
            //cbox_phone1.
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr.ItemArray[1].ToString());
            }
            foreach (string text in comboBox.Items)
            {
                cbox_payMethods.Items.Add(text);
            }
        }

        //
        public override void Save() // Save
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    if (btn_Edit.Text == "E&dit")
                    {
                        controller.SaveItem(this.GetObject());
                        ClearCamps();
                        Populated(false);
                        SetNewId();
                    }
                    else if (btn_Edit.Text == "Cancel")
                    {
                        this.controller.UpdateItem(this.GetObject());
                        btn_Edit.Text = "E&dit";
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

        public override void EditObject() //EditObject
        {
            if (btn_Edit.Text == "E&dit")
            {
                UnlockCamps();
                btn_Edit.Text = "Cancel";
                btn_NewSave.Enabled = true;
                btn_SelectDelete.Enabled = true;
                auxObj = GetObject();
            }
            else if (btn_Edit.Text == "Cancel")
            {
                btn_Edit.Text = "E&dit";
                LockCamps();
                btn_SelectDelete.Enabled = false;
                btn_NewSave.Enabled = false;
                this.PopulateCamps(auxObj);
            }
        }

        public override void DeleteObject() //DeleteObject
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    controller.DeleteItem(Convert.ToInt32(this.edt_id.Value));
                    this.ClearCamps();
                    //SetNewId();
                    btn_SelectDelete.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_Edit.Text = "E&dit";
                    Populated(false);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            UnlockCamps();
        }

        private void ReOrderInstalmentsNumber()
        {
            int num = (int)edt_instalmentNumber.Value;
            int rowsQtd = DGV_Instalments.Rows.Count;
            if (num > rowsQtd - 1)
            {
                int order = 1;
                foreach (DataGridViewRow row in DGV_Instalments.Rows)
                {
                    row.Cells["InstalmentNumber"].Value = order;
                    order++;
                }
            }
        }

        private void DGV_Instalments_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ReOrderInstalmentsNumber();

        }
    }
}
