using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    public partial class Frm_Find_People : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        //private People_Controller controller = new People_Controller();

        public Frm_Find_People()
        {
            InitializeComponent();
            DGV_People.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void DGV_People_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_People_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_People_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }
        }

        private void DGV_People_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
            NewPopulatedForm();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
