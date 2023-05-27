using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Clients : ProjetoEduardoAnacletoWindowsForm1.FormsCreate.Frm_Create_People
    {
        public Frm_Create_Clients()
        {
            InitializeComponent();
            base.PopulatePhoneClassificationsComboBox();
        }

        private Clients_Controller controller = new Clients_Controller();
        Clients auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        private void check_NaturalClient_CheckedChanged(object sender, EventArgs e)
        {
            SetFormToNatural();
        }

        public void SetFormToNatural()
        {
            if (check_NaturalClient.Checked)
            {
                check_LegalClient.Checked = false;
                gbox_gender.Enabled = true;
                medt_regNumber.Mask = "000.000.000-00";
                medt_dob.Enabled = true;
                medt_dob.Value = Convert.ToDateTime("01/01/2000");
                edt_age.Enabled = true;
                edt_age.Clear();
            }
        }

        public void SetFormToLegal()
        {
            if (check_LegalClient.Checked)
            {
                check_NaturalClient.Checked = false;
                gbox_gender.Enabled = false;
                medt_regNumber.Mask = "00.000.000/0000.00";
                medt_dob.Value = Convert.ToDateTime("01/01/2000");
                medt_dob.Enabled = false;
                edt_age.Enabled = false;
                edt_age.Text = "0";
            }
        }

        private void check_LegalClient_CheckedChanged(object sender, EventArgs e)
        {
            SetFormToLegal();
        }


        public override bool CheckPeopleCamps()
        {
            if (!base.CheckPeopleCamps())
            {
                return false;
            }
            else if (check_NaturalClient.Checked)
            {
                if (!check_female.Checked && !check_male.Checked && !check_otherGender.Checked)
                {
                    string message = "Gender is not selected.";
                    string caption = "Required camp is not selected.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    gbox_gender.Focus();
                    return false;
                }
                else if (String.IsNullOrWhiteSpace(edt_age.Text))
                {
                    string message = "Date of Birth is not selected.";
                    string caption = "Required camp is not selected.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    medt_dob.Focus();
                    return false;
                }
                else if (!Validator.IsCpf(Utilities.RemoveRegMask(medt_regNumber.Text)))
                {
                    string message = "CPF Registration Number is not valid.";
                    string caption = "Required camp is not valid.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    medt_dob.Focus();
                    return false;
                }
            }
            else if (check_LegalClient.Checked)
            {
                if (!Validator.IsCnpj(medt_regNumber.Text))
                {
                    string message = "CNPJ Registration Number is not valid.";
                    string caption = "Required camp is not valid.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    medt_dob.Focus();
                    return false;
                }
            }
            else if (!check_NaturalClient.Checked && !check_LegalClient.Checked)
            {
                string message = "Client type is not selected.";
                string caption = "Required camp is not selected.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                gbox_clientType.Focus();
                return false;
            }
            return true;          
        }

        public Clients GetObject()
        {
            if (CheckPeopleCamps())
            {
                Clients client = new Clients();
                //personal info
                client.id = Convert.ToInt32(edt_id.Text);
                client.name = edt_Name.Text;
                client.email = edt_email.Text;
                string regN = Utilities.RemoveRegMask(medt_regNumber.Text);
                client.registrationNumber = regN;
                client.dateOfBirth = Convert.ToDateTime(medt_dob.Text);

                //Phones
                client.phoneNumber1 = Utilities.RemoveRegMask(medt_phone1.Text);
                client.phoneClass1 = TakePhoneClass(cbox_phone1.SelectedItem.ToString());
                //Nullable Phones
                if (cbox_phone2.SelectedItem != null)
                {
                    client.phoneClass2 = TakePhoneClass(cbox_phone2.SelectedItem.ToString());
                }
                else { 
                    client.phoneClass2 = new PhoneClassifications();
                    client.phoneClass2.id = 2;
                }
                //
                if (cbox_phone3.SelectedItem != null)
                {
                    client.phoneClass3 = TakePhoneClass(cbox_phone3.SelectedItem.ToString());
                }
                else
                {
                    client.phoneClass3 = new PhoneClassifications();
                    client.phoneClass3.id = 2;
                }
                client.phoneNumber2 = Utilities.RemoveRegMask(medt_phone2.Text);
                client.phoneNumber3 = Utilities.RemoveRegMask(medt_phone3.Text);
               
                //Address
                client.district = edt_district.Text;
                client.zipCode = medt_zipCode.Text;
                client.streetName = edt_street.Text;
                client.homeType = edt_homeType.Text;
                client.complement = edt_complement.Text;
                client.dateOfCreation = Convert.ToDateTime(lbl_CreationDate.Text);
                client.dateOfLastUpdate = DateTime.Now ;
                Cities city = TakeCity(edt_city.Text);
                client.city = city;
                client.houseNumber = edt_houseNumber.Text;

                //Gender+Type
                if (check_NaturalClient.Checked)
                {
                    client.clientType = 1;
                    client.dateOfBirth = Convert.ToDateTime(medt_dob.Text);
                    client.age = Convert.ToInt32(edt_age.Text);
                    if (check_female.Checked)
                    {
                        client.gender = 2;
                    }
                    else if (check_male.Checked)
                    {
                        client.gender = 1;
                    }
                    else if (check_otherGender.Checked)
                    {
                        client.gender = 3;
                    }

                }
                else if (check_LegalClient.Checked)
                {
                    client.age = 0;
                    //var stringDate = DateTime.MinValue;
                    //var date =Convert.ToDateTime( stringDate.ToShortDateString());
                    //client.dateOfBirth = date;
                    client.gender = 0;
                    client.clientType = 2;
                }

                return client;
            }
            else return null;
        }
    
        public void PopulateCamps(Clients client)
        {
            //Client Type and Genders + SetForm Legal or Natural
            if (client.clientType == 1)
            {
                check_NaturalClient.Checked = true;
                SetFormToNatural();
                if (client.gender == 1)
                {
                    check_male.Checked = true;
                }
                else if (client.gender == 2)
                {
                    check_female.Checked = true;
                }
                else if (client.gender == 3)
                {
                    check_otherGender.Checked = true;
                }
            }
            else if (client.clientType == 2)
            {
                SetFormToLegal();
                check_LegalClient.Checked = true;
            }
            //Personal
            edt_id.Value = client.id;
            edt_Name.Text = client.name;
            edt_age.Text = client.age.ToString();
            edt_email.Text = client.email;
            medt_dob.Value = client.dateOfBirth;
            medt_regNumber.Text = client.registrationNumber.ToString();

            //Address
            edt_city.Text = client.city.cityName;
            edt_StateFU.Text = client.city.state.fedUnit;
            edt_complement.Text = client.complement;
            medt_zipCode.Text = client.zipCode;
            edt_countryAcronym.Text = client.city.state.country.countryAcronym;
            edt_district.Text = client.district;
            edt_homeType.Text = client.homeType;
            edt_houseNumber.Text = client.houseNumber;
            edt_street.Text = client.streetName;

            //Phone Numbers
            medt_phone1.Text = client.phoneNumber1;
            medt_phone2.Text = client.phoneNumber2;
            medt_phone3.Text = client.phoneNumber3;

            //Phone classification
            cbox_phone1.SelectedItem = client.phoneClass1.phoneClass;
            if (client.phoneClass2 != null)
            {
                cbox_phone2.SelectedItem = client.phoneClass2.phoneClass;
            }
            if (client.phoneClass3 != null)
            {
                cbox_phone3.SelectedItem = client.phoneClass3.phoneClass;
            }
        }

        public void NewPopulatedForm()  //Ok - Abre form create populada com o item selecionado
        {
            Frm_Create_Clients formClient = new Frm_Create_Clients();
            formClient.Populated(true);
            formClient.PopulateCamps(this.GetObject());
            formClient.ShowDialog();
        }
        //
        public override void UnlockCamps()
        {
            base.UnlockCamps();
            gbox_clientType.Enabled = true;
            if (check_LegalClient.Checked)
            {
                gbox_gender.Enabled = false;
                medt_dob.Enabled = false;
                edt_age.Enabled = false;
            }
        }

        public override void LockCamps()
        {
            base.LockCamps();
            gbox_clientType.Enabled = false;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            check_LegalClient.Checked = false;
            check_NaturalClient.Checked = false;
        }

        //

        public override void Save() // Save
        {
            if (CheckPeopleCamps())
            {
                LockCamps();
                try
                {
                    if (btn_Edit.Text == "E&dit")
                    {
                        controller.SaveItem(this.GetObject());
                        ClearCamps();
                        Populated(false);
                    }
                    else if (btn_Edit.Text == "Cancel")
                    {
                        this.controller.UpdateItem(GetObject());
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
            if (CheckPeopleCamps())
            {
                LockCamps();
                try
                {
                    controller.DeleteItem(Convert.ToInt32(this.edt_id.Value));
                    this.ClearCamps();
                    this.edt_id.Value = this.BringNewId();
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
    }
}
