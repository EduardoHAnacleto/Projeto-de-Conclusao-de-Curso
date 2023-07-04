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
using static System.Windows.Forms.AxHost;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Cities : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        private Cities_Controller controller = new Cities_Controller();
        Cities auxObj = null;

        public Frm_Create_Cities()
        {
            InitializeComponent();
            //controller = new Cities_Controller();
            //InitiateForm();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public Cities GetObject()
        {
            Cities city = new Cities();
            city.id = Convert.ToInt32(edt_id.Value);
            city.cityName = edt_cityName.Text;
            city.cityPhonePrefix = edt_phonePrefix.Text;
            States state = this.TakeState(Convert.ToInt32(edt_stateId.Text));
            city.state = state;
            return city;
        }

        public States TakeState(int id)
        {
            States state = new States();
            States_Controller _Controller = new States_Controller();
            state = _Controller.FindItemId(id);
            return state;
        }

        public override void LockCamps()
        {
            edt_cityName.Enabled = false;
            edt_phonePrefix.Enabled = false;
            btn_SearchState.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_cityName.Enabled = true;
            edt_phonePrefix.Enabled = true;
            btn_SearchState.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_cityName.Text = string.Empty;
            edt_phonePrefix.Text = string.Empty; 
            edt_state.Text = string.Empty;
            edt_stateId.Text = string.Empty;
        }

        public void PopulateCamps(Cities city)
        {
            edt_cityName.Text = city.cityName;
            edt_id.Value = city.id;
            edt_phonePrefix.Text = city.cityPhonePrefix.ToString();
            edt_state.Text = city.state.stateName.ToString();
            edt_stateId.Text = city.state.id.ToString();
            lbl_CreationDate.Text = city.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = city.dateOfLastUpdate.ToShortDateString();
        }

        public void EnterSearchId(KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                States state = new States();
                state = controller.FindStateItemId(Convert.ToInt32(edt_id.Text));
                edt_stateId.Text = state.id.ToString();
                edt_state.Text = state.stateName;
            }
        }

        public void EnterSearchName(KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                States state = new States();
                state = controller.FindStateNameId(edt_state.Text);
                edt_stateId.Text = state.id.ToString();
                edt_state.Text = state.stateName;
            }
        }

        private void edt_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterSearchName(e);
        }

        private void edt_stateId_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterSearchId(e);
        }

        public override bool CheckCamps() //Validacao de campos
        {
            if (!Utilities.HasOnlyLetters(edt_cityName.Text, "City name")) 
            {
                edt_cityName.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(edt_phonePrefix.Text, "Phone Prefix"))
            {
                edt_phonePrefix.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(edt_stateId.Text, "State"))
            {
                btn_SearchState.Focus();
                return false;
            }
            else return true;
        }

        public void SearchState()
        {
            Frm_Find_States formState = new Frm_Find_States();
            formState.hasFather = true;
            formState.ShowDialog();
            if (!formState.ActiveControl.ContainsFocus)
            {
                    States state = new States();
                    state = formState.GetObject();
                    if (state != null)
                    {
                    edt_state.Text = state.stateName;
                    edt_stateId.Text = state.id.ToString();
                    }

                

            }
            formState.Close();
        }

        private void btn_SearchState_Click(object sender, EventArgs e)
        {
            SearchState();
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
