using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    public partial class Frm_Find_PaymentConditions : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_PaymentConditions()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        PaymentConditions_Controller controller = new PaymentConditions_Controller();

        public override void NewObject()
        {
            Frm_Create_PaymentConditions formCreatePayCond = new Frm_Create_PaymentConditions();
            formCreatePayCond.SetNewId();
            formCreatePayCond.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public PaymentConditions GetObject()
        {
            BillsInstalments_Controller _BIController = new BillsInstalments_Controller();
            PaymentConditions obj = new PaymentConditions();
            obj = controller.FindItemName(edt_payCond.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
            }
            if (obj != null)
            {
                List<BillsInstalments> list = new List<BillsInstalments>();
                list = _BIController.FindInstalments(obj.id);
                obj.BillsInstalments = list;
            }
            return obj;
        }

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            DataGridViewRow row = null;
            try
            {
                row = DGV_PayConditions.SelectedRows[0];
            }
            catch { }
            if (row.Cells[0].Value != null)
            {
                edt_id.Text = row.Cells["ID_PayCond"].Value.ToString();
                edt_payCond.Text = row.Cells["PaymentCondition"].Value.ToString();
            }
        }

        public void PopulateCamps(PaymentConditions obj)
        {
            edt_id.Text = obj.id.ToString();
            edt_payCond.Text = obj.conditionName;
        }

        public override void NewPopulatedForm()  //Ok - Abre form create populada com o item selecionado
        {
            var formPayCond = new Frm_Create_PaymentConditions();

            formPayCond.PopulateCamps(GetObject());
            formPayCond.Populated(true);
            formPayCond.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void SelectObject()
        {
            var obj = GetObject();
            if (obj != null)
            {
                if (hasFather)
                {
                    base.item = obj;
                    this.Hide();
                }
                else
                {
                    NewPopulatedForm();
                    SetDataSourceToDGV();
                }
            }
            else
            {
                Utilities.IsNotSelected(obj, "The Row");
            }
        }

        public override void SetDataSourceToDGV() //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_PayConditions.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_PayConditions.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        var x = dr.Table.Columns.Count;
                        if (dr[k] != null)
                        {
                            DGV_PayConditions.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        public override void SearchObject()
        {
            if (edt_id.Value >= 2)
            {
                var obj = SearchItemById();
                if (obj != null)
                {
                    PopulateCamps(obj);
                }
                else
                {
                    if (Utilities.AskToCreate())
                    {
                        NewObject();
                    }
                }
            }
            else if (Utilities.HasOnlyLetters(edt_payCond.Text, "Payment Condition"))
            {
                var obj = SearchItemByName();
                if (obj != null)
                {
                    PopulateCamps(obj);
                }
                else
                {
                    if (Utilities.AskToCreate())
                    {
                        NewObject();
                    }
                }
            }
            else
            {
                Utilities.MsgboxCantSearch();
            }
        }

        public PaymentConditions SearchItemByName()
        {
            try
            {
                return controller.FindItemName(edt_payCond.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PaymentConditions SearchItemById()
        {
            try
            {
                return controller.FindItemId(Convert.ToInt32(edt_id.Text));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }

        private void DGV_PayConditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_PayConditions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_PayConditions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
            //SearchObject();
            NewPopulatedForm();
        }
    }
}
