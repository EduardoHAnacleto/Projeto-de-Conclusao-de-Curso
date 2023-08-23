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
    public partial class Frm_Create_States : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {

        public Frm_Create_States()
        {
            InitializeComponent();
        }

        private States_Controller controller = new States_Controller();
        States auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public States GetObject()
        {
            States state = new States();
            state.id = Convert.ToInt32(edt_id.Value);
            state.stateName = edt_stateName.Text;
            state.fedUnit = edt_FU.Text;
            Countries country = this.TakeCountry(Convert.ToInt32(edt_countryId.Text));
            state.country = country;
            return state;
        }

        public override bool CheckCamps()
        {
            if (Utilities.HasOnlySpaces(edt_stateName.Text, "Nome do Estado"))
            {
                edt_stateName.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyLetters(edt_FU.Text, "Unidade de Federação"))
            {
                edt_FU.Focus();
                return false;
            }
            else if (edt_FU.Text.Length>3 || edt_FU.Text.Length<2)
            {
                string message = "Unidade de Federação deve ter 2 ou 3 caractéres";
                string caption = "Campo inválido.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message,caption,buttons,icon);
                edt_FU.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(edt_countryId.Text, "País"))
            {
                btn_SearchCountry.Focus();
                return false;
            }
            else return true;
        }

        public override void LockCamps()  //Bloqueia Campos
        {
            edt_stateName.Enabled = false;
            edt_country.Enabled = false;
            edt_FU.Enabled = false;
            btn_SearchCountry.Enabled = false;
        }

        public override void UnlockCamps()   //Desbloqueia Campos
        {
            edt_stateName.Enabled = true;
            edt_FU.Enabled = true;
            edt_stateName.Enabled = true;
            btn_SearchCountry.Enabled = true;
        }

        public override void ClearCamps()  //Limpa Campos
        {
            base.ClearCamps();
            edt_countryId.Text = String.Empty;
            edt_country.Text = String.Empty;
            edt_FU.Text = String.Empty;
            edt_stateName.Text = String.Empty;
        }

        public void SearchCountry()
        {
            Countries country = new Countries();
            Frm_Find_Countries formCountry = new Frm_Find_Countries();
            formCountry.hasFather = true;
            formCountry.SetDataSourceToDGV();
            formCountry.ShowDialog();
            if (!formCountry.ActiveControl.ContainsFocus)
            {
                if (country != null)
                {
                    country = formCountry.GetObject();
                    edt_country.Text = country.countryName;
                    edt_countryId.Text = country.id.ToString();
                    formCountry.Close();
                }
            }
        }

        private void btn_SearchCountry_Click(object sender, EventArgs e) //Abre Frm_Find_Countries
        {
            SearchCountry();
        }

        public Countries TakeCountry(int id)
        {
            Countries country = new Countries();
            Countries_DAO _DAO = new Countries_DAO();
            country = _DAO.SelectFromDb(id);
            return country;
        }

        public void PopulateCountry(Countries country)
        {
            edt_countryId.Text = country.id.ToString();
            edt_country.Text = country.countryName;
        }

        public void PopulateCamps(States state)
        {
            edt_stateName.Text = state.stateName;
            edt_id.Value = state.id;
            edt_FU.Text =  state.fedUnit;
            edt_countryId.Text = state.country.id.ToString();
            edt_country.Text = state.country.countryName;
            lbl_CreationDate.Text = state.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = state.dateOfLastUpdate.ToShortDateString();
        }

        public void EnterSearchCountryId(KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                Countries country = new Countries();
                country = controller.FindCountryItemId(Convert.ToInt32(edt_countryId.Text));
                edt_countryId.Text = country.id.ToString();
                edt_country.Text = country.countryName;
            }
        }

        public void EnterSearchCountryName(KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                Countries country = new Countries();
                country = controller.FindCountryNameId(edt_country.Text);
                edt_countryId.Text = country.id.ToString();
                edt_country.Text = country.countryName;
            }
        }



        private void edt_countryId_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterSearchCountryId(e);
        }

        private void edt_country_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterSearchCountryName(e);
        }

        //

        public override void Save() // Save
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    if (btn_Edit.Text == "&Alterar")
                    {
                        controller.SaveItem(this.GetObject());
                        ClearCamps();
                        Populated(false);
                    }
                    else if (btn_Edit.Text == "Cancelar")
                    {
                        this.controller.UpdateItem(GetObject());
                        btn_Edit.Text = "&Alterar";
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
            if (btn_Edit.Text == "&Alterar")
            {
                UnlockCamps();
                btn_Edit.Text = "Cancelar";
                btn_NewSave.Enabled = true;
                btn_SelectDelete.Enabled = true;
                auxObj = GetObject();
            }
            else if (btn_Edit.Text == "Cancelar")
            {
                btn_Edit.Text = "&Alterar";
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
                    btn_Edit.Text = "&Alterar";
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
