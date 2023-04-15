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

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Employees : ProjetoEduardoAnacletoWindowsForm1.FormsCreate.Frm_Create_People
    {
        public Frm_Create_Employees() 
        {
            InitializeComponent();
        }

        private Employees_Controller controller = new Employees_Controller();
        Employees auxObj = null;

        public override void SetNewId() //ok
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() //ok
        {
            return controller.BringNewId();
        }

        public Employees GetObject() //ok
        {
            if (CheckPeopleCamps())
            {
                Employees employee = new Employees();
                //personal info
                employee.id = Convert.ToInt32(edt_id.Text);
                employee.name = edt_Name.Text;
                employee.email = edt_email.Text;
                string regN = Utilities.RemoveRegMask(medt_regNumber.Text);
                employee.registrationNumber = regN;
                employee.dateOfBirth = Convert.ToDateTime(medt_dob.Text);

                //Phones
                employee.phoneNumber1 = Utilities.RemoveRegMask(medt_phone1.Text);
                employee.phoneClass1 = TakePhoneClass(cbox_phone1.SelectedItem.ToString());
                //Nullable Phones
                if (cbox_phone2.SelectedItem != null)
                {
                    employee.phoneClass2 = TakePhoneClass(cbox_phone2.SelectedItem.ToString());
                }
                else
                {
                    employee.phoneClass2 = new PhoneClassifications();
                    employee.phoneClass2.id = 2;
                }
                //
                if (cbox_phone3.SelectedItem != null)
                {
                    employee.phoneClass3 = TakePhoneClass(cbox_phone3.SelectedItem.ToString());
                }
                else
                {
                    employee.phoneClass3 = new PhoneClassifications();
                    employee.phoneClass3.id = 2;
                }
                employee.phoneNumber2 = Utilities.RemoveRegMask(medt_phone2.Text);
                employee.phoneNumber3 = Utilities.RemoveRegMask(medt_phone3.Text);

                //Address
                employee.district = edt_district.Text;
                employee.zipCode = medt_zipCode.Text;
                employee.streetName = edt_street.Text;
                employee.homeType = edt_homeType.Text;
                employee.complement = edt_complement.Text;
                employee.dateOfCreation = Convert.ToDateTime(lbl_CreationDate.Text);
                employee.dateOfLastUpdate = DateTime.Now;
                Cities city = TakeCity(edt_city.Text);
                employee.city = city;
                employee.houseNumber = edt_houseNumber.Text;

                //Gender+Type
                employee.dateOfBirth = Convert.ToDateTime(medt_dob.Text);
                employee.age = Convert.ToInt32(edt_age.Text);
                if (check_female.Checked)
                {
                    employee.gender = 2;
                }
                else if (check_male.Checked)
                {
                    employee.gender = 1;
                }
                else if (check_otherGender.Checked)
                {
                    employee.gender = 3;
                }
                //////Employee Info//////
                employee.baseSalary = Convert.ToDouble(edt_baseSalary.Text);
                employee.startDate = Convert.ToDateTime(medt_startDate.Text);
                employee.jobRole = edt_jobRole.Text;
                employee.weeklyHours = Convert.ToInt32(edt_weeklyHours.Text);
                //Employee Status
                if (rbtn_active.Checked)
                {
                    employee.jobStatus = 1;
                    employee.endDate = Convert.ToDateTime("01/01/2000"); //
                }
                else if (rbtn_dismissed.Checked)
                {
                    employee.jobStatus = 0;
                    employee.endDate = Convert.ToDateTime(medt_endDate.Text);
                }
                //
                return employee;
            }//
            else return null;
        }

        public override bool CheckPeopleCamps()
        {
            if (!base.CheckPeopleCamps())
            {
                return false;
            }
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
            else if (!Utilities.HasOnlyLetters(edt_jobRole.Text, "Job Role") || Utilities.HasOnlySpaces(edt_jobRole.Text,"Job Role"))
            {
                edt_jobRole.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits(edt_weeklyHours.Text, "Weekly Hours"))
            {
                edt_weeklyHours.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(edt_baseSalary.Text, "Base Salary"))
            {
                edt_baseSalary.Focus();
                return false;
            }
            else if (medt_startDate.Value <= DateTime.MinValue)
            {
                string message = "Admission date must be selected.";
                string caption = "Invalid Camp.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                medt_startDate.Focus();
                return false;
            }
            else if (medt_startDate.Value < medt_endDate.Value)
            {
                string message = "Admission date must be lower than end date.";
                string caption = "Invalid Camp.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                medt_startDate.Focus();
                return false;
            }
            return true;
        }

        public void PopulateCamps(Employees employee) //Ok
        {
            //Employee Status Set Form Status
            if (employee.jobStatus == 1)
            {
                rbtn_dismissed.Checked = false;
                rbtn_active.Checked = true;
                Status_Checked();
            }
            else if (employee.jobStatus == 0)
            {
                rbtn_active.Checked = false;
                rbtn_dismissed.Checked = true;
                Status_Checked();
            }

            //Gender
            if (employee.gender == 1)
            {
                check_male.Checked = true;
            }
            else if (employee.gender == 2)
            {
                check_female.Checked = true;
            }
            else if (employee.gender == 3)
            {
                check_otherGender.Checked = true;
            }

            //Employees
            edt_baseSalary.Text = employee.baseSalary.ToString();
            edt_jobRole.Text = employee.jobRole;
            edt_weeklyHours.Text = employee.weeklyHours.ToString();
            medt_startDate.Value = employee.startDate;

            //Personal
            edt_id.Value = employee.id;
            edt_Name.Text = employee.name;
            edt_age.Text = employee.age.ToString();
            edt_email.Text = employee.email;
            medt_dob.Value = employee.dateOfBirth;
            medt_regNumber.Text = employee.registrationNumber.ToString();

            //Address
            edt_city.Text = employee.city.cityName;
            edt_StateFU.Text = employee.city.state.fedUnit;
            edt_complement.Text = employee.complement;
            medt_zipCode.Text = employee.zipCode;
            edt_countryAcronym.Text = employee.city.state.country.countryAcronym;
            edt_district.Text = employee.district;
            edt_homeType.Text = employee.homeType;
            edt_houseNumber.Text = employee.houseNumber;
            edt_street.Text = employee.streetName;

            //Phone Numbers
            medt_phone1.Text = employee.phoneNumber1;
            medt_phone2.Text = employee.phoneNumber2;
            medt_phone3.Text = employee.phoneNumber3;

            //Phone classification
            cbox_phone1.SelectedItem = employee.phoneClass1.phoneClass;
            if (employee.phoneClass2 != null)
            {
                cbox_phone2.SelectedItem = employee.phoneClass2.phoneClass;
            }
            if (employee.phoneClass3 != null)
            {
                cbox_phone3.SelectedItem = employee.phoneClass3.phoneClass;
            }
        }

        public void NewPopulatedForm()  //Ok 
        {
            Frm_Create_Employees formEmployee = new Frm_Create_Employees();
            formEmployee.Populated(true);
            formEmployee.PopulateCamps(GetObject());
            formEmployee.ShowDialog();
        }

        public override void UnlockCamps() // ok
        {
            base.UnlockCamps();
            gbox_empStatus.Enabled = true;
            gbox_jobInfo.Enabled = true;
            Status_Checked();
        }

        public override void LockCamps() //ok
        {
            base.LockCamps();
            gbox_empStatus.Enabled = false;
            gbox_jobInfo.Enabled = false;
        }

        public override void ClearCamps() //ok
        {
            base.ClearCamps();
            edt_baseSalary.Clear();
            edt_jobRole.Clear();
            edt_weeklyHours.Clear();
            medt_startDate.Value = Convert.ToDateTime("01/01/2000");
            medt_endDate.Value = Convert.ToDateTime("01/01/2000");
            rbtn_active.Checked = true;
            Status_Checked();
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

        public void Status_Checked() //ok
        {
            if (rbtn_active.Checked)
            {
                rbtn_dismissed.Checked = false;
                medt_endDate.Enabled = false;
                medt_endDate.Visible = false;
                lbl_endDate.Visible = false;
            }
            else if (rbtn_dismissed.Checked)
            {
                rbtn_active.Checked = false;
                medt_endDate.Enabled = true;
                medt_endDate.Visible = true;
                lbl_endDate.Visible = true;
            }
        }

        private void rbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            Status_Checked();
        }

        private void rbtn_dismissed_CheckedChanged(object sender, EventArgs e)
        {
            Status_Checked();
        }
    }
}
