using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms
{
    public partial class Frm_Create_BillsToReceive : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        private BillsToReceive_Controller billToReceive_Controller = new BillsToReceive_Controller();

        public Frm_Create_BillsToReceive()
        {
            InitializeComponent();
            datePicker_emission.Text = DateTime.Now.ToString();
            datePicker_due.MinDate = DateTime.Now;
            PopulateComboBox();
            edt_clientId.Controls[0].Visible = false;
            edt_instalmentId.Controls[0].Visible = false;
            //datePicker_emission.CustomFormat = "dd-MM-yyyy";
            //datePicker_due.CustomFormat = "dd-MM-yyyy";
            //datePicker_emission.Format = DateTimePickerFormat.Custom;
            //datePicker_due.Format = DateTimePickerFormat.Custom;
        }

        public BillsToReceive getBillToReceive()  //Cria um OBJ a partir dos campos
        {
            BillsToReceive bill = new BillsToReceive();
            bill.Client.id = Convert.ToInt32(edt_clientId.Text);
            bill.Client.name = edt_clientName.Text;
            //bill.paymentForm.id = cbox_paymentMethod.SelectedIndex; //verificar se vai entrar na ordem certa
            bill.InstalmentValue = Convert.ToDouble(medt_instalmentValue.Text);
            bill.EmissionDate = Convert.ToDateTime(datePicker_emission.Text);
            bill.DueDate = Convert.ToDateTime(datePicker_due.Text);
            //bill.BillInstalment.id = Convert.ToInt32(edt_instalmentId.Text);
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



        public void Save() //Salva item no DB
        {
            try
            {
                billToReceive_Controller.SaveItem(getBillToReceive());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditObject()  //Update o item no DB
        {
            try
            {
                billToReceive_Controller.UpdateItem(getBillToReceive());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteObject() //Deleta o item do DB
        {
            try
            {
                billToReceive_Controller.DeleteItem(getBillToReceive().id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckCamps() //Validacao de campos
        {
            if (Utilities.HasOnlyLetters(edt_clientName.Text, "Client name"))
            {
                edt_clientName.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(medt_instalmentValue.Text,"Instalment value")) 
            {
                medt_instalmentValue.Focus();
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
            else if (Utilities.IsNotSelected(cbox_paymentMethod.SelectedItem,"Payment Method"))
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

        private void btn_search_Click(object sender, EventArgs e) //TERMINAR -Abre form de FIND PEOPLE, volta com obj e popula CLiente
        {
            //Search abre form find person
            People person = new People();
            //funcao tras obj de volta
            edt_clientName.Text = person.name;
            edt_clientId.Text = person.id.ToString();
        }

        private void btn_AddInstalments_Click(object sender, EventArgs e) // TERMINAR - Abre form Create Instalments, volta e tras novo Row
        {
            //Open Instalment create form
        }

        private void btn_Edit_Click(object sender, EventArgs e) //Chama CheckCamps e EditObj
        {
            if (CheckCamps())
            {
                EditObject();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) //Chama CheckCamps e DeleteObj
        {
            if (CheckCamps())
            {
                DeleteObject();
            }
        }

        private void btn_save_Click(object sender, EventArgs e) //Chama CheckCamps e SaveObj
        {
            if (CheckCamps())
            {
                Save();
            }
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e) //GrupoBox Ativo&Pago
        {
            if (check_Active.Checked)
            {
                check_Paid.Checked = false;
            } else
            if (check_Paid.Checked)
            {
                check_Active.Checked = false;
            }
        }

        //public void SetDataSourceToDGV()
        //{
        //    BillsInstalments_Controller controller = new BillsInstalments_Controller();
        //    List<BillsInstalments> sql = controller.LoadItems();
        //    DataTable instalments = new DataTable();
        //    instalments = sql;
        //    DGV_Instalments.DataSource = instalments;
        //    //BindingSource bs = new BindingSource();
        //    //DGV_Instalments.AutoGenerateColumns = false;
        //    List <BillsInstalments> sql =  

        //    DGV_Instalments.DataSource = null;
        //}
    }
}
