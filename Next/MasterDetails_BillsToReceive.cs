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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public partial class MasterDetails_BillsToReceive : Form
    {

        public MasterDetails_BillsToReceive()
        {
            InitializeComponent();
            edt_clientId.Controls[0].Visible = false;
            edt_saleNumber.Controls[0].Visible = false;
        }

        People_Controller clientController = new People_Controller();
        BillsToReceive_Controller billsController = new BillsToReceive_Controller();

        public void SearchClient()
        {
            People person = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(edt_clientId.Text))
                {
                    person = clientController.FindItemId(edt_clientId.Text);
                }
                else if (!string.IsNullOrWhiteSpace(edt_clientName.Text))
                {
                    person = clientController.FindItemName(edt_clientName.Text);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (person.id != 0)
                {
                    edt_clientId.Text = person.id.ToString();
                    edt_clientName.Text = person.name;
                }
            }
        }

        private void btn_searchClient_Click(object sender, EventArgs e) //Procura PERSON(Client) e Popula nos campos
        {
            SearchClient();
        }

        private void edt_clientName_KeyPress(object sender, KeyPressEventArgs e) //Chama Utilities para verificar se ENTER foi pressionado -> Busca Client
        {
            if (Utilities.EnterSearch(e))
            {
                SearchClient();
            }
        }

        public void SelectRowByClient()
        {
            string clientName = DGV_Clients.SelectedRows[0].Cells["NameClient"].Value.ToString();
            foreach (DataGridViewRow row in DGV_BillsToReceive.Rows)
            {
                if (row.Cells["ClientName"].Value.ToString() != clientName)
                {
                    DGV_BillsToReceive.Rows.Remove(row);
                }
            }
        }

        private void DGV_Clients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowByClient();
        }


        private void btn_ClearOrder_Click(object sender, EventArgs e)
        {
            ClearOrderby();
        }

        public void SetDataSourceToDGV() 
        {
            //
            DGV_BillsToReceive.Rows.Clear();
            DGV_BillsToReceive.Dispose();
        }


            public void ClearOrderby() //Tira todos Check do GroupBox Orderby
        {
            foreach (Control ctrl in gbox_orderBy.Controls)
            {
                CheckBox cb = (CheckBox)ctrl;
                cb.Checked = false;
            }
        }

        private void checkboxSelect(string selectedCB) //Check o estado de todos checkBox do GroupBox
        {
            foreach (Control ctrl in gbox_orderBy.Controls)
            {
                if (ctrl.Name != selectedCB)
                {
                    CheckBox cb = (CheckBox)ctrl;
                    cb.Checked = false;
                }
            }
        }

        private void check_emissionDate_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
           // DGV_BillsToReceive.
        }
        private void check_value_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
        }
        private void check_dueDate_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
        }
        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
        }
        private void check_paidOff_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
        }

        private void dueDate_bills_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
