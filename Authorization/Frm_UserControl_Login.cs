using ProjetoEduardoAnacletoWindowsForm1.Authorization;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
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

        private Authentication _Authentication = new Authentication();
        private Users _User = new Users();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Authentication.LogUser(edt_login.Text, edt_secret.Text))
                {
                    this.Hide();
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
