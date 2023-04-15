using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public partial class Frm_Create_BillsToPay : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Create_BillsToPay()
        {
            InitializeComponent();
            datePicker_due.MinDate = DateTime.Now;
            edt_instalmentNumber.Controls[0].Visible = false;
            edt_supplierId.Controls[0].Visible = false;
            edt_pagDanfe.Controls[0].Visible = false;
            edt_numDanfe.Controls[0].Visible = false;
            edt_serieDanfe.Controls[0].Visible = false;
            PopulateComboBox();
        }


        public bool CheckCamps()   //Valida Campos
        {
            if (datePicker_due.Text == null)
            {

            }
            else if ( !Utilities.HasOnlyDigits(edt_supplierId.Text, "Supplier ID"))
            {

                edt_supplierId.Focus();
                return false;
            }
            else if (!Utilities.IsNotSelected(cbox_payMethod.SelectedItem, "Payment Method"))
            {
                cbox_payMethod.Focus();
                return false;
            }
            else if ( !Utilities.HasOnlyDigits(edt_instalmentNumber.Text, "Instalment Number"))
            {

                edt_instalmentNumber.Focus();
                return false;
            }
            else if ( !(check_Active.Checked) && !(check_Paid.Checked) )
            {
                gbox_isPaid.Focus();
                return false;
            }
            return true;
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e) //Troca o Check entre Active e PAID
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
            }
        }

        private void check_Paid_CheckedChanged(object sender, EventArgs e) //Troca o Check entre Active e PAID
        {
            if (check_Paid.Checked)
            {
                check_Active.Checked = false;
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
                cbox_payMethod.Items.Add(text);
            }
        }
    }
}
