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
            datePicker_emission.Text = DateTime.Now.ToString();
            datePicker_due.MinDate = DateTime.Now;
            edt_clientId.Controls[0].Visible = false;
            edt_instalmentId.Controls[0].Visible = false;
            edt_saleNumber.Controls[0].Visible = false;
            edt_instalmentValue.Controls[0].Visible = false;
            PopulateComboBox();
        }

        private readonly Clients_Controller _cController = new Clients_Controller();

        public BillsToReceive GetBillToReceive()  //Cria um OBJ a partir dos campos
        {
            BillsToReceive bill = new BillsToReceive();
            bill.Client = _cController.FindItemId(Convert.ToInt32(edt_clientId.Value));
            bill.InstalmentValue = Convert.ToDouble(edt_instalmentValue.Value);
            bill.EmissionDate = Convert.ToDateTime(datePicker_emission.Text);
            bill.DueDate = Convert.ToDateTime(datePicker_due.Text);
            bill.dateOfCreation = DateTime.Now;
            bill.dateOfLastUpdate = DateTime.Now;
            return bill;
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

        public override bool CheckCamps() //Validacao de campos
        {
            if (Utilities.HasOnlyLetters(edt_clientName.Text, "Client name"))
            {
                edt_clientName.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(edt_instalmentValue.Text, "Instalment value"))
            {
                edt_instalmentValue.Focus();
                return false;
            }
            else if ((!check_Active.Checked) && (!check_Paid.Checked))
            {
                string message = "At least one status box must be checked.";
                string caption = "Status not checked.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                gbox_isPaid.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_paymentMethod.SelectedItem, "Payment Method"))
            {
                cbox_paymentMethod.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(datePicker_due.Text, "Date Movements"))  //testar
            {
                //gbox_dates.Focus();
                return false;
            }
            else return true;
        }

        private void check_Paid_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Paid.Checked)
            {
                check_Active.Checked = false;
            }
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
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
    }
}
