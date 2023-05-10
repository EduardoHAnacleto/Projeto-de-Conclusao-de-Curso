using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.MasterDetails
{
    public partial class MasterDetails_Sales : Form
    {
        public MasterDetails_Sales()
        {
            InitializeComponent();
            edt_saleId.Controls[0].Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
