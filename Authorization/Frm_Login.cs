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

namespace ProjetoEduardoAnacletoWindowsForm1.Authorization
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        public Users _User = new Users();
        public bool LoggedIn { get; set; } = false;

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Authentication.LogUser(edt_login.Text, edt_secret.Text))
                {
                    Users_Controller userController = new Users_Controller();
                    _User = userController.LogUser(edt_login.Text, edt_secret.Text);
                    if (_User != null)
                    {
                        Users usuario = _User;
                        LoggedIn = true;
                        this.Hide();
                    }
                }
                else
                {
                    string message = "Usuário não encontrado.";
                    string caption = "Login falhou.";
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

        public Users GetLoggedUser()
        {
            return _User;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
