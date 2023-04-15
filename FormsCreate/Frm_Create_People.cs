using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_People : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_People()
        {
            InitializeComponent();
            PopulatePhoneClassificationsComboBox();
        }

       // People_Controller controller = new People_Controller();

        //public Clients getPerson()
        //{
        //    Clients person = new Clients();
        //    person.name = edt_Name.Text;
        //    person.email = edt_email.Text;
        //    person.complement = edt_complement.Text;
        //    person.phoneNumber1 = medt_phone1.Text;
        //    person.phoneClass1 = TakePhoneClass(cbox_phone1.SelectedItem.ToString());
        //    person.phoneClass2 = TakePhoneClass(cbox_phone2.SelectedItem.ToString());
        //    person.phoneClass3 = TakePhoneClass(cbox_phone3.SelectedItem.ToString());
        //    person.phoneNumber2 = medt_phone2.Text;
        //    person.phoneNumber3 = medt_phone3.Text;
        //    person.age = Convert.ToInt32(edt_age.Text);
        //    person.district = edt_district.Text;
        //    person.dateOfBirth = Convert.ToDateTime(medt_dob.Text);
        //    person.registrationNumber = Convert.ToInt32(medt_regNumber.Text);
        //    person.zipCode = medt_zipCode.Text;
        //    person.dateOfCreation = DateTime.Now;
        //    Cities city = this.TakeCity(edt_city.Text);
        //    person.city = city;
        //    person.houseNumber = edt_houseNumber.Text;

        //    if (check_female.Checked)
        //    {
        //        person.gender = 2;
        //    }
        //    else if (check_male.Checked) 
        //    {
        //        person.gender = 1;
        //    }
        //    else if (check_otherGender.Checked)
        //    {
        //        person.gender = 3;
        //    }

        //    return person;
        //}

        public PhoneClassifications TakePhoneClass(string name)
        {
            PhoneClassifications phoneClass = new PhoneClassifications();
            PhoneClassifications_DAO _DAO = new PhoneClassifications_DAO();
            phoneClass = _DAO.SelectFromDb(name);
            return phoneClass;
        }

        public Cities TakeCity(string name)
        {
            Cities city = new Cities();
            Cities_DAO _DAO = new Cities_DAO();
            city = _DAO.SelectFromDb(name);
            return city;
        }

        public virtual bool CheckPeopleCamps()
        {
            if (!Utilities.HasOnlyLetters(edt_Name.Text, "Name") || Utilities.HasOnlySpaces(edt_Name.Text,"Name"))
            {
                edt_Name.Focus();
                return false;
            }
            else if (!Validator.isEmail(edt_email.Text))
            {
                string message = "Email text camp is invalid or blank.";
                string caption = "Required camp is invalid.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_email.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone1.Text),"Phone Number 1"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone2.Text)) && !Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone2.Text), "Phone Number 2"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone3.Text)) && !Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone3.Text), "Phone Number 3"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_phone1.SelectedItem, "Phone Classification 1" ))
            {
                cbox_phone1.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone2.Text)) &&
                Utilities.IsNotSelected(cbox_phone2.SelectedItem,"Phone Classification 2"))
            {
                cbox_phone2.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone3.Text)) &&
                Utilities.IsNotSelected(cbox_phone3.SelectedItem, "Phone Classification 3"))
            {
                cbox_phone3.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_district.Text, "District"))
            {
                edt_district.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_street.Text,"Street Name"))
            {
                edt_street.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_houseNumber.Text.Trim(), "House Number")
                || Utilities.HasSpecialChars(edt_houseNumber.Text, "House Number"))
            {
                edt_houseNumber.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_zipCode.Text), "Zip-Code"))
            {
                medt_zipCode.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyLetters(edt_homeType.Text, "Home Type"))
            {
                MessageBox.Show(edt_homeType.Text);
                MessageBox.Show(Utilities.RemoveRegMask(edt_homeType.Text));
                edt_homeType.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_city.Text, "City"))
            {
                btn_findCity.Focus();
                return false;
            }
            return true;
        }

        public void Gender_Checked()
        {
            if (check_male.Checked)
            {
                check_female.Checked = false;
                check_otherGender.Checked = false;
            }
            else if (check_female.Checked)
            {
                check_otherGender.Checked = false;
                check_male.Checked = false;
            }
            else if (check_otherGender.Checked)
            {
                check_female.Checked = false;
                check_male.Checked = false;
            }
        }

        private void check_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender_Checked();
        }

        private void check_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender_Checked();
        }

        private void check_otherGender_CheckedChanged(object sender, EventArgs e)
        {
            Gender_Checked();
        }

        public void PopulatePhoneClassificationsComboBox() //Popula os itens dos PhoneClassification ComboBox
        {
            ComboBox comboBox = new ComboBox();
            PhoneClassifications_Controller pController = new PhoneClassifications_Controller();
            DataTable dt = pController.PopulateDGV();
            cbox_phone1.DataSource = dt.DataSet; //???
            //cbox_phone1.
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr.ItemArray[1].ToString());
            }
            foreach (string text in comboBox.Items)
            {
                cbox_phone1.Items.Add(text);
                cbox_phone2.Items.Add(text);
                cbox_phone3.Items.Add(text);
            }
            cbox_phone1.Items.Remove("Nulo");
        }

        private void btn_findCity_Click(object sender, EventArgs e)
        {
            SearchCity();
        }

        public void SearchCity() //Procura e seleciona a cidade, e popula os campos
        {
            Frm_Find_Cities formCity = new Frm_Find_Cities();
            formCity.hasFather = true;
            formCity.ShowDialog();
            if (!formCity.ActiveControl.ContainsFocus)
            {
                Cities city = new Cities();
                city = formCity.GetObject();
                if (city != null )
                {
                    edt_city.Text = city.cityName;
                    edt_StateFU.Text = city.state.fedUnit;
                    edt_countryAcronym.Text = city.state.country.countryAcronym;
                }
                formCity.Close();
            }
        }

        public void SetAgeCamp()
        {
            DateTime dob = Convert.ToDateTime(medt_dob.Text);
            int age = Utilities.CalculateAge(dob);
            edt_age.Text = age.ToString();
        }

        public override void UnlockCamps()
        {
            edt_age.Enabled = true;
            //edt_city.Enabled = true;
            //edt_complement.Enabled = true;
            //edt_countryAcronym.Enabled = true;
            //edt_district.Enabled = true;
            edt_email.Enabled = true;
            //edt_homeType.Enabled = true;
            //edt_houseNumber.Enabled = true;
            edt_Name.Enabled = true;
            //edt_street.Enabled = true;
            medt_dob.Enabled = true;
            medt_regNumber.Enabled = true;
            //medt_phone1.Enabled = true;
            //medt_phone2.Enabled = true;
            //medt_phone3.Enabled = true;
            //cbox_phone1.Enabled = true;
            //cbox_phone2.Enabled = true;
            //cbox_phone3.Enabled = true;
            //medt_regNumber.Enabled = true;
            //btn_findCity.Enabled = true;
            //medt_zipCode.Enabled = true;
            gbox_address.Enabled = true;
            gbox_phones.Enabled = true;
            gbox_gender.Enabled = true;
            gbox_address.Enabled = true;
        }

        public override void ClearCamps()
        {
            edt_age.Text = string.Empty;
            edt_city.Text = string.Empty;
            edt_complement.Text = string.Empty;
            edt_countryAcronym.Text = string.Empty;
            edt_age.Text = string.Empty;
            edt_district.Text = string.Empty;
            edt_email.Text = string.Empty;
            edt_homeType.Text = string.Empty;
            edt_houseNumber.Text = string.Empty;
            edt_Name.Text = string.Empty;
            edt_street.Text = string.Empty;
            medt_dob.Text = string.Empty;
            medt_phone1.Text = string.Empty;
            medt_phone2.Text = string.Empty;
            medt_phone3.Text = string.Empty;
            cbox_phone1.SelectedItem = null;
            cbox_phone2.SelectedItem = null;
            cbox_phone3.SelectedItem = null;
            medt_regNumber.Text = string.Empty;
            medt_zipCode.Clear();
            check_female.Checked = false;
            check_male.Checked = false;
            check_otherGender.Checked = false;
            edt_StateFU.Text = string.Empty;

        }

        public override void LockCamps()
        {
            edt_age.Enabled = false;
            //edt_city.Enabled = false;
            //edt_complement.Enabled = false;
            //edt_countryAcronym.Enabled = false;
            //edt_district.Enabled = false;
            edt_email.Enabled = false;
            //edt_homeType.Enabled = false;
            //edt_houseNumber.Enabled = false;
            edt_Name.Enabled = false;
            //edt_street.Enabled = false;
            medt_dob.Enabled = false;
            //medt_phone1.Enabled = false;
            //medt_phone2.Enabled = false;
            //medt_phone3.Enabled = false;
            //cbox_phone1.Enabled = false;
            //cbox_phone2.Enabled = false;
            //cbox_phone3.Enabled = false;
            medt_regNumber.Enabled = false;
            //btn_findCity.Enabled = false;
            //medt_zipCode.Enabled = false;
            gbox_address.Enabled = false;
            gbox_phones.Enabled = false;
            gbox_gender.Enabled = false;
            gbox_address.Enabled = false;

        }

        private void medt_dob_Leave_1(object sender, EventArgs e)
        {
            SetAgeCamp();
        }
    }
}
