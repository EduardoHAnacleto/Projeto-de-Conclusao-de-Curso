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
            //PopulatePhoneClassificationsComboBox();
        }


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
            if (!Utilities.HasOnlyLetters(edt_Name.Text, "Nome") || Utilities.HasOnlySpaces(edt_Name.Text,"Nome"))
            {
                edt_Name.Focus();
                return false;
            }
            else if (!Validator.isEmail(edt_email.Text))
            {
                string message = "Campo E-Mail inválido ou vazio.";
                string caption = "Campo é requerido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_email.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone1.Text),"Telefone N. 1"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone2.Text)) && !Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone2.Text), "Telefone N. 2"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone3.Text)) && !Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_phone3.Text), "Telefone N. 3"))
            {
                gbox_phones.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_phone1.SelectedItem, "Classificação de Telefone N. 1" ))
            {
                cbox_phone1.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone2.Text)) &&
                Utilities.IsNotSelected(cbox_phone2.SelectedItem, "Classificação de Telefone N. 2"))
            {
                cbox_phone2.Focus();
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(Utilities.RemoveRegMask(medt_phone3.Text)) &&
                Utilities.IsNotSelected(cbox_phone3.SelectedItem, "Classificação de Telefone N. 3"))
            {
                cbox_phone3.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_district.Text, "Bairro"))
            {
                edt_district.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_street.Text,"Logradouro"))
            {
                edt_street.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_houseNumber.Text.Trim(), "Número da casa")
                || Utilities.HasSpecialChars(edt_houseNumber.Text, "Número da casa"))
            {
                edt_houseNumber.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_zipCode.Text), "CEP"))
            {
                medt_zipCode.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyLetters(edt_homeType.Text, "Tipo de construção"))
            {
                MessageBox.Show(edt_homeType.Text);
                MessageBox.Show(Utilities.RemoveRegMask(edt_homeType.Text));
                edt_homeType.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_city.Text, "Cidade"))
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
            cbox_phone1.Items.Remove("NULL");
            cbox_phone1.Items.Remove("NULO");
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
            edt_email.Enabled = true;
            edt_Name.Enabled = true;
            medt_dob.Enabled = true;
            medt_regNumber.Enabled = true;
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
            medt_dob.Value = medt_dob.MinDate;
            medt_phone1.Text = string.Empty;
            medt_phone2.Text = string.Empty;
            medt_phone3.Text = string.Empty;
            cbox_phone1.SelectedIndex = 1;
            cbox_phone2.SelectedIndex = 1;
            cbox_phone3.SelectedIndex = 1;
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

            edt_email.Enabled = false;
            edt_Name.Enabled = false;
            medt_dob.Enabled = false;
            medt_regNumber.Enabled = false;
            gbox_address.Enabled = false;
            gbox_phones.Enabled = false;
            gbox_gender.Enabled = false;
            gbox_address.Enabled = false;

        }

        private void medt_dob_Leave_1(object sender, EventArgs e)
        {
            SetAgeCamp();
        }

        private void edt_age_TextChanged(object sender, EventArgs e)
        {
            if (edt_age.Text != string.Empty)
            {
                try
                {
                    medt_dob.Value = Utilities.CalculateDateTimeAge(Convert.ToInt32(edt_age.Text));
                }
                catch { }
            }
        }
    }
}
