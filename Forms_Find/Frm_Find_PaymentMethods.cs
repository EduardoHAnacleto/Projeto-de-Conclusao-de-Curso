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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms_Find
{
    public partial class Frm_Find_PaymentMethods : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_PaymentMethods()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private PaymentMethods_Controller controller = new PaymentMethods_Controller();

        public PaymentMethods GetObject()
        {
            PaymentMethods method = new PaymentMethods();
            if (edt_id.Value <2)
            {
                method = controller.FindItemName(edt_paymentMethod.Text);
                return method;
            }
            if (edt_id.Value > 2)
            {
                method = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                return method;
            }
            else
                return null;
        }

        private PaymentMethods SearchItemByName() //Ok
        {
            try
            {
                return controller.FindItemName(edt_paymentMethod.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private PaymentMethods SearchItemById() //Ok
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


        private void edt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        public void PopulateCamps(PaymentMethods method)
        {
            edt_id.Text = method.id.ToString();
            edt_paymentMethod.Text = method.paymentMethod;
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
            else if (Utilities.HasOnlyLetters(edt_paymentMethod.Text, "Payment Method"))
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

        private void edt_paymentMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_PayMethods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_PayMethods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_PayMethods_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            newPopulatedForm();
        }

        private void newPopulatedForm() //Ok
        {
            Frm_Create_PaymentMethods formPayMethod = new Frm_Create_PaymentMethods();
            formPayMethod.PopulateCamps(GetObject());
            formPayMethod.ShowDialog();
        }

        public override void NewObject() //Ok -Abrir Novo Form CREATE, quando fechar, atualizará o DGV
        {
            Frm_Create_PaymentMethods formPayMethod = new Frm_Create_PaymentMethods();
            formPayMethod.SetNewId();
            formPayMethod.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_PayMethods.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_PayMethods.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_PayMethods.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
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

        public override void NewPopulatedForm()
        {
            Frm_Create_PaymentMethods formPayMethod = new Frm_Create_PaymentMethods();
            formPayMethod.Populated(true);
            formPayMethod.PopulateCamps(GetObject());
            formPayMethod.ShowDialog();
        }

        public override void PopulateFromDGV() //Ok
        {
            edt_id.Text = DGV_PayMethods.SelectedCells[0].Value.ToString();
            edt_paymentMethod.Text = DGV_PayMethods.SelectedCells[1].Value.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
