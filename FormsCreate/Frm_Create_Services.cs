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
    public partial class Frm_Create_Services : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Services()
        {
            InitializeComponent();
        }

        private Services_Controller controller = new Services_Controller();
        Services auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override bool CheckCamps()
        {
            if (Utilities.HasOnlySpaces(edt_serviceDescription.Text, "Descrição do Serviço"))
            {
                edt_serviceDescription.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(edt_serviceValue.Text, "Valor do serviço"))
            {
                edt_serviceValue.Focus();
                return false;
            }
            else return true;
        }

        public override void LockCamps()
        {
            edt_serviceDescription.Enabled = false;
            edt_serviceValue.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_serviceDescription.Enabled = true;
            edt_serviceValue.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_serviceDescription.Text = string.Empty;
            edt_serviceValue.Text = string.Empty;
        }

        public Services GetObject()
        {
            Services service = new Services();
            service.id = Convert.ToInt32(edt_id.Value);
            service.descriptionService = edt_serviceDescription.Text;
            service.serviceValue = Convert.ToDouble(edt_serviceValue.Text);
            return service;
        }

        public void PopulateCamps(Services service)
        {
            edt_id.Value = service.id;
            edt_serviceDescription.Text = service.descriptionService;
            edt_serviceValue.Text = service.serviceValue.ToString();
            lbl_CreationDate.Text = service.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = service.dateOfLastUpdate.ToShortDateString();
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
