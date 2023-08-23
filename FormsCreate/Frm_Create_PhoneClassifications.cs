using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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
    public partial class Frm_Create_PhoneClassifications : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_PhoneClassifications()
        {
            InitializeComponent();
        }

        private PhoneClassifications_Controller controller = new PhoneClassifications_Controller();
        PhoneClassifications auxObj = null;

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override void LockCamps()  //Bloqueia Campos
        {
            edt_phoneClassification.Enabled = false;
        }

        public override void UnlockCamps()   //Desbloqueia Campos
        {
            edt_phoneClassification.Enabled = true;
        }

        public override void ClearCamps()  //Limpa Campos
        {
            base.ClearCamps();
            edt_phoneClassification.Text = String.Empty;
        }


        public void PopulateCamps(PhoneClassifications phoneClassification)
        {
            edt_id.Value = phoneClassification.id;
            edt_phoneClassification.Text = phoneClassification.phoneClass;
            lbl_CreationDate.Text = phoneClassification.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = phoneClassification.dateOfLastUpdate.ToShortDateString();
        }

        public PhoneClassifications GetObject()  //Cria um OBJ a partir dos campos
        {
            PhoneClassifications phoneClassification = new PhoneClassifications();
            phoneClassification.id = Convert.ToInt32(edt_id.Value);
            phoneClassification.phoneClass = edt_phoneClassification.Text;

            return phoneClassification;
        }




        public override bool CheckCamps() //Validacao de campos
        {
            if (!Utilities.HasOnlyLetters(edt_phoneClassification.Text, "Nome da classificação de telefone"))
            {
                edt_phoneClassification.Focus();
                return false;
            }
            else return true;
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


