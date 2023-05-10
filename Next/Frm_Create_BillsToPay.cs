using ProjetoEduardoAnacletoWindowsForm1.Controllers;
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
            datePicker_due.MinDate = DateTime.Now;
            edt_instalmentNumber.Controls[0].Visible = false;
            edt_supplierId.Controls[0].Visible = false;
            edt_BillPage.Controls[0].Visible = false;
            edt_BillNum.Controls[0].Visible = false;
            edt_BillSeries.Controls[0].Visible = false;
            edt_totalValue.Controls[0].Visible = false;
            PopulateComboBox();
        }

        private readonly Suppliers_Controller _supplierController = new Suppliers_Controller();

        public override bool CheckCamps()   //Valida Campos
        {
            if (edt_BillModel.Value == 0 && edt_BillNum.Value == 0 && edt_BillSeries.Value == 0 && edt_BillPage.Value == 0)
            {
                string message = "DANFe camps must be inserted.";
                string caption = "Invalid camps.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (datePicker_due.Value <= datePicker_due.MinDate)
            {
                string message = "Due date must be more selected.";
                string caption = "Invalid camp.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (!Utilities.HasOnlyDigits(edt_supplierId.Text, "Supplier ID"))
            {
                edt_supplierId.Focus();
                return false;
            }
            else if (!Utilities.IsNotSelected(cbox_payMethod.SelectedItem, "Payment Method"))
            {
                cbox_payMethod.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(edt_instalmentNumber.Text, "Instalment Number"))
            {
                edt_instalmentNumber.Focus();
                return false;
            }
            else if (!(check_Active.Checked) && !(check_Paid.Checked))
            {
                string message = "Status must be more selected.";
                string caption = "Invalid camp.";
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
            obj.BillPage = (int)edt_BillPage.Value;

            obj.InstalmentNumber = (int)edt_instalmentNumber.Value;
            obj.TotalValue = (double)edt_totalValue.Value;
            obj.DueDate = datePicker_due.Value;
            if (check_Paid.Checked)
            {
                obj.PaidDate = datePicker_paid.Value;
                obj.IsPaid = true;
            }
            else
            {
                obj.IsPaid = false;
                obj.PaidDate = null;
            }
            return obj;
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
            }
        }

        private void check_Paid_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Paid.Checked)
            {
                check_Active.Checked = false;
            }
        }
    }
}
