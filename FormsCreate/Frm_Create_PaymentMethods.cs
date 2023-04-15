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
    public partial class Frm_Create_PaymentMethods : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_PaymentMethods()
        {
            InitializeComponent();
        }

        private PaymentMethods_Controller controller = new PaymentMethods_Controller();
        PaymentMethods auxObj = null;

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public PaymentMethods GetObject()
        {
            PaymentMethods method = new PaymentMethods();
            method.id = Convert.ToInt32(edt_id.Value);
            method.paymentMethod = edt_paymentMethod.Text;
            method.dateOfCreation = DateTime.Now;
            method.dateOfLastUpdate = DateTime.Now;
            return method;
        }

        public override void LockCamps()
        {
            edt_paymentMethod.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_paymentMethod.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            edt_paymentMethod.Clear();
        }

        public void PopulateCamps(PaymentMethods method)
        {
            edt_id.Value = method.id;
            edt_paymentMethod.Text = method.paymentMethod;
            lbl_CreationDate.Text = method.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = method.dateOfLastUpdate.ToShortDateString();
        }

        public override bool CheckCamps()
        {
            if (!Utilities.HasOnlyLetters(edt_paymentMethod.Text, "Payment Method"))
            {
                edt_paymentMethod.Focus();
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
