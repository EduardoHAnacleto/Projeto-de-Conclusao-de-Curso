using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
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
    public partial class Frm_Create_Users : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Users()
        {
            InitializeComponent();
            edt_idEmployee.Controls[0].Visible = false;
            edt_id.Enabled = false;
            SetNewId(); //?
        }

        private Users_Controller controller = new Users_Controller();
        Users auxObj = null;

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void SetNewId()
        {
            edt_id.Value =  controller.BringNewId();
        }

        public void UnlockUser()
        {
            btn_Search.Enabled = true;
            edt_userLogin.Enabled = true;
            cbox_levelAccess.Enabled = true;
        }

        public void LockUser()
        {
            btn_Search.Enabled = false;       
            edt_userLogin.Enabled = false;
            cbox_levelAccess.Enabled = false;
        }

        public void SearchEmployee()
        {
            Frm_Find_Employees formEmployee = new Frm_Find_Employees();
            formEmployee.hasFather = true;
            formEmployee.ShowDialog();
            if (!formEmployee.ActiveControl.ContainsFocus)
            {
                Employees employee = new Employees();
                employee = formEmployee.GetObject();
                if (employee != null)
                {
                    edt_employeeName.Text = employee.name;
                    edt_idEmployee.Value = employee.id;
                }
            }
            formEmployee.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        public Employees TakeEmployee(int id)
        {
            Employees employee = new Employees();
            Employees_Controller _Controller = new Employees_Controller();
            employee = _Controller.FindItemId(id);
            return employee;
        }

        public Users GetObject()
        {
            Users user = new Users();
            user.id = Convert.ToInt32(edt_id.Value);
            user.userLogin = edt_userLogin.Text;
            user.userPassword = medt_userPassword.Text;
            Employees employee = this.TakeEmployee(Convert.ToInt32(edt_idEmployee.Text));
            user.employee = employee ;
            return user;
        }

        public override bool CheckCamps() //Validacao de campos
        {
            if (!Utilities.HasOnlyLetters(edt_userLogin.Text, "Login de Usuário") || String.IsNullOrWhiteSpace(edt_userLogin.Text))
            {
                edt_userLogin.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(medt_userPassword.Text, "Senha do Usuário"))
            {
                medt_userPassword.Focus();
                return false;
            }
            else if (Utilities.HasOnlySpaces(medt_userPassword.Text, "Repita a Senha"))
            {
                medt_repeatPassword.Focus();
                return false;
            }
            else if (medt_userPassword.Text != medt_repeatPassword.Text)
            {
                string message = "Senha e o campo de repetir senha devem ser o mesmo.";
                string caption = "Senha incorreta.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                medt_userPassword.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_levelAccess.Text, "Nível de Acesso"))
            {
                cbox_levelAccess.Focus();
                return false;
            }
            else return true;
        }

        public void PopulateCamps(Users user)
        {
            edt_employeeName.Text = user.name;
            edt_id.Value = user.id;
            edt_userLogin.Text = user.userLogin;
            medt_userPassword.Text = user.userPassword;
            medt_repeatPassword.Text = user.userPassword;
            cbox_levelAccess.SelectedItem = user.AccessLevel;
            lbl_CreationDate.Text = user.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = user.dateOfLastUpdate.ToShortDateString();
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
