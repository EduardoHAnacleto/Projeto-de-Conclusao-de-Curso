using ProjetoEduardoAnacletoWindowsForm1.Authorization;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    public partial class Frm_UserControl_Login : UserControl
    {
        public Frm_UserControl_Login()
        {
            InitializeComponent();

        }

        public Users _User = new Users();

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Authentication.LogUser(edt_login.Text, edt_secret.Text))
                {
                    Users_Controller userController = new Users_Controller();
                    _User = userController.LogUser(edt_login.Text, edt_secret.Text);
                    this.Hide();
                }
                else
                {
                    string message = "Usuário não encontrado.";
                    string caption = "Login inválido.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    Utilities.Msgbox(message, caption, buttons, icon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();           
        }
    }
}
