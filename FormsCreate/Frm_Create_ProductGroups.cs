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
    public partial class Frm_Create_ProductGroups : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_ProductGroups()
        {
            InitializeComponent();
        }

        private ProductGroups_Controller controller = new ProductGroups_Controller();
        ProductGroups auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override bool CheckCamps()
        {
            if (!Utilities.HasOnlyLetters(edt_productGroupName.Text,"Product Group name"))
            {
                edt_productGroupName.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyLetters(edt_groupDescription.Text, "Group description"))
            {
                edt_groupDescription.Focus();
                return false;
            }
            else return true;
        }

        public override void LockCamps()
        {
            edt_productGroupName.Enabled = false;
            edt_groupDescription.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_productGroupName.Enabled = true;
            edt_groupDescription.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_productGroupName.Text = string.Empty;
            edt_groupDescription.Text = string.Empty;
        }

        public ProductGroups GetObject()
        {
            ProductGroups pGroup = new ProductGroups();
            pGroup.id = Convert.ToInt32(edt_id.Value);
            pGroup.productGroup = edt_productGroupName.Text;
            pGroup.description = edt_groupDescription.Text;
            pGroup.dateOfCreation = DateTime.Now;
            pGroup.dateOfLastUpdate = DateTime.Now;
            return pGroup;
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public void PopulateCamps(ProductGroups pGroup)
        {
            Populated(true);
            edt_id.Value = pGroup.id;
            edt_productGroupName.Text = pGroup.productGroup;
            edt_groupDescription.Text = pGroup.description;
            lbl_CreationDate.Text = pGroup.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = pGroup.dateOfLastUpdate.ToShortDateString();
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
