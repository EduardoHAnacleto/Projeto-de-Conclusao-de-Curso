using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Brands : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {

        public Frm_Create_Brands()
        {
            InitializeComponent();
        }

        Brands_Controller controller = new Brands_Controller();
        Brands auxObj = null;

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void LockCamps() 
        {
            edt_BrandName.Enabled = false;
        }
        
        public override void UnlockCamps()   
        {
             edt_BrandName.Enabled = true;
        }

        public override void ClearCamps()  
        {
            base.ClearCamps();
            edt_BrandName.Text = String.Empty;
        }

        public void PopulateCamps(Brands brand)
        {
            Populated(true);
            edt_id.Value = brand.id;
            edt_BrandName.Text = brand.brandName;
            lbl_CreationDate.Text = brand.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = brand.dateOfLastUpdate.ToShortDateString();
        }

        public Brands GetObject()  
        {
            Brands brand = new Brands();
            brand.id = Convert.ToInt32(edt_id.Value);
            brand.brandName = edt_BrandName.Text;
            return brand;
        }

        public override bool CheckCamps() //Validacao de campos
        {
            if (string.IsNullOrWhiteSpace(edt_BrandName.Text))
            {
                string message = "Brand Name text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_BrandName.Focus();
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
