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
    public partial class Frm_Create_Countries : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Countries() 
        {
            InitializeComponent();

        }

        private Countries_Controller controller = new Countries_Controller();
        Countries auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void LockCamps()  //Bloqueia Campos
        {
            edt_countryName.Enabled = false;
            edt_acronym.Enabled = false;
            edt_currency.Enabled = false;
            edt_phonePrefix.Enabled = false;
        }

        public override void UnlockCamps()   //Desbloqueia Campos
        {
            edt_countryName.Enabled = true;
            edt_acronym.Enabled = true;
            edt_currency.Enabled = true;
            edt_phonePrefix.Enabled = true;
        }

        public override void ClearCamps()  //Limpa Campos
        {
            base.ClearCamps();
            edt_countryName.Text = String.Empty;
            edt_acronym.Text = String.Empty;
            edt_currency.Text = String.Empty;
            edt_phonePrefix.Text = String.Empty;
        }


        public Countries GetObject() //Cria um OBJ a partir dos campos
        {
            Countries country = new Countries();
            country.id = Convert.ToInt32(edt_id.Value);
            country.countryName = edt_countryName.Text;
            country.countryAcronym = edt_acronym.Text;
            country.countryPhonePrefix = edt_phonePrefix.Text;
            country.countryCurrency = edt_currency.Text;
            return country;
        }


        public override bool CheckCamps() //Validacao de campos
        {
            if ( !Utilities.HasOnlyLetters(edt_countryName.Text, "Country name") )
            {
                edt_countryName.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyLetters(edt_acronym.Text, "Acronym"))
            {
                edt_acronym.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_phonePrefix.Text,"Phone Prefix"))
            {
                edt_phonePrefix.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_currency.Text, "Currency"))
            {
                edt_currency.Focus();
                return false;
            }
            else return true;
        }

        public void PopulateCamps(Countries country)
        {
            edt_countryName.Text = country.countryName;
            edt_id.Value = country.id;
            edt_acronym.Text = country.countryAcronym;
            edt_currency.Text = country.countryCurrency;
            edt_phonePrefix.Text = country.countryPhonePrefix;
            lbl_CreationDate.Text = country.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = country.dateOfLastUpdate.ToShortDateString();
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
            if (CheckCamps())
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
