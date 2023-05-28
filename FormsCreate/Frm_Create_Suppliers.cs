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
    public partial class Frm_Create_Suppliers : ProjetoEduardoAnacletoWindowsForm1.FormsCreate.Frm_Create_People
    {
        public Frm_Create_Suppliers()
        {
            InitializeComponent();
            SetFormForSuppliers();
            base.PopulatePhoneClassificationsComboBox();
        }

        private Suppliers_Controller controller = new Suppliers_Controller();
        Suppliers auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public void SetFormForSuppliers()
        {
            gbox_gender.Visible = false;
            lbl_age.Visible = false;
            lbl_dob.Visible = false;
            edt_age.Visible = false;
            medt_dob.Visible = false;
            medt_regNumber.Mask = "00.000.000/0000.00";
        }

        public Suppliers GetObject()
        {
            if (CheckPeopleCamps())
            {
                Suppliers supplier = new Suppliers();

                //Supplier

                supplier.socialReason = edt_socialReason.Text;
                supplier.stateInscription = edt_stateInscription.Text;
                //personal info
                supplier.id = Convert.ToInt32(edt_id.Text);
                supplier.name = edt_Name.Text;
                supplier.email = edt_email.Text;
                string regN = Utilities.RemoveRegMask(medt_regNumber.Text);
                supplier.registrationNumber = regN;

                //Phones
                supplier.phoneNumber1 = Utilities.RemoveRegMask(medt_phone1.Text);
                supplier.phoneClass1 = TakePhoneClass(cbox_phone1.SelectedItem.ToString());
                //Nullable Phones
                if (cbox_phone2.SelectedItem != null)
                {
                    supplier.phoneClass2 = TakePhoneClass(cbox_phone2.SelectedItem.ToString());
                }
                else
                {
                    supplier.phoneClass2 = new PhoneClassifications();
                    supplier.phoneClass2.id = 2;
                }
                //
                if (cbox_phone3.SelectedItem != null)
                {
                    supplier.phoneClass3 = TakePhoneClass(cbox_phone3.SelectedItem.ToString());
                }
                else
                {
                    supplier.phoneClass3 = new PhoneClassifications();
                    supplier.phoneClass3.id = 2;
                }
                supplier.phoneNumber2 = Utilities.RemoveRegMask(medt_phone2.Text);
                supplier.phoneNumber3 = Utilities.RemoveRegMask(medt_phone3.Text);

                //Address
                supplier.district = edt_district.Text;
                supplier.zipCode = medt_zipCode.Text;
                supplier.streetName = edt_street.Text;
                supplier.homeType = edt_homeType.Text;
                supplier.complement = edt_complement.Text;
                supplier.dateOfCreation = Convert.ToDateTime(lbl_CreationDate.Text);
                supplier.dateOfLastUpdate = DateTime.Now;
                Cities city = TakeCity(edt_city.Text);
                supplier.city = city;
                supplier.houseNumber = edt_houseNumber.Text;

                return supplier;
            }
            else return null;
        }

        public void PopulateCamps(Suppliers supplier)
        {
            SetFormForSuppliers();
            //Suppliers
            edt_stateInscription.Text = supplier.stateInscription;
            edt_socialReason.Text = supplier.socialReason;

            //Personal
            edt_id.Value = supplier.id;
            edt_Name.Text = supplier.name;
            edt_email.Text = supplier.email;
            medt_regNumber.Text = supplier.registrationNumber.ToString();

            //Address
            edt_city.Text = supplier.city.cityName;
            edt_StateFU.Text = supplier.city.state.fedUnit;
            edt_complement.Text = supplier.complement;
            medt_zipCode.Text = supplier.zipCode;
            edt_countryAcronym.Text = supplier.city.state.country.countryAcronym;
            edt_district.Text = supplier.district;
            edt_homeType.Text = supplier.homeType;
            edt_houseNumber.Text = supplier.houseNumber;
            edt_street.Text = supplier.streetName;

            //Phone Numbers
            medt_phone1.Text = supplier.phoneNumber1;
            medt_phone2.Text = supplier.phoneNumber2;
            medt_phone3.Text = supplier.phoneNumber3;

            //Phone classification
            cbox_phone1.SelectedItem = supplier.phoneClass1.phoneClass;
            if (supplier.phoneClass2 != null)
            {
                cbox_phone2.SelectedItem = supplier.phoneClass2.phoneClass;
            }
            if (supplier.phoneClass3 != null)
            {
                cbox_phone3.SelectedItem = supplier.phoneClass3.phoneClass;
            }
        }

        public override bool CheckPeopleCamps()
        {
            bool status = true;
            status = base.CheckPeopleCamps();
            if (status)
            {
                if (!Utilities.HasOnlyDigits(Utilities.RemoveRegMask(edt_stateInscription.Text), "State Inscription"))
                {
                    edt_stateInscription.Focus();
                    return false;
                }
                else if (!Utilities.HasOnlyLetters(edt_socialReason.Text, "Social Reason"))
                {
                    edt_socialReason.Focus();
                    return false;
                }
                else if (!Validator.IsCnpj(medt_regNumber.Text))
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
            return status;
        }

        public override void UnlockCamps()
        {
            base.UnlockCamps();
            edt_stateInscription.Enabled = true;
            edt_socialReason.Enabled = true;
        }

        public override void LockCamps()
        {
            base.LockCamps();
            edt_stateInscription.Enabled = false;
            edt_socialReason.Enabled = false;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_stateInscription.Clear();
            edt_socialReason.Clear();
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
