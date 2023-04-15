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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //Test Access
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
            
        }
    }
}
