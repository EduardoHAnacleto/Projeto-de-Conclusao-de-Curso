using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    public partial class Frm_Find_Master : Form
    {
        public Frm_Find_Master()
        {
            InitializeComponent();
            edt_id.Controls[0].Visible = false;
        }

        public void Exit()
        {
            Close();
        }

        public virtual void SelectObject()
        {
            //
        }

        public virtual void NewObject()
        {
            //
        }

        public virtual void SearchObject()
        {
            //
        }

        public virtual void NewPopulatedForm()
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            SelectObject();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            NewObject();
        }

        public virtual void SetDataSourceToDGV()
        {

        }

        public virtual void PopulateFromDGV()
        {

        }


        public bool hasFather = false;
        public Object item = null;

        private void edt_id_ValueChanged(object sender, EventArgs e)
        {
            if ( edt_id.Value < 0)
            {
                edt_id.Value = 0;
            }
        }
    }
}
