using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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
    public partial class Frm_Find_PhoneClassifications : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_PhoneClassifications()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }
        private PhoneClassifications_Controller controller = new PhoneClassifications_Controller();


        public PhoneClassifications GetObject()  //Ok - Cria um OBJ a partir dos campos
        {
            PhoneClassifications obj = new PhoneClassifications();
            obj = controller.FindItemName(edt_PhoneClassification.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
            }
            return obj;
        }

        private PhoneClassifications SearchItemByName() //Ok
        {
            try
            {
                return controller.FindItemName(edt_PhoneClassification.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private PhoneClassifications SearchItemById() //Ok
        {
            try
            {
                return controller.FindItemId(Convert.ToInt32(edt_id.Value));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void edt_PhoneClassificationName_KeyPress(object sender, KeyPressEventArgs e) //Ok Chama do Master, se apertou Enter, entao pesquisa no banco o item
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_PhoneClassification_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //Quando faz Double Click na CELL do DGV, Tras INFO pros Campos
        {
            newPopulatedForm();
        }

        private void newPopulatedForm() //Ok
        {
            Frm_Create_PhoneClassifications formPhoneClassification = new Frm_Create_PhoneClassifications();
            formPhoneClassification.PopulateCamps(GetObject());
            formPhoneClassification.ShowDialog();
        }

        public override void NewObject() //Ok -Abrir Novo Form CREATE, quando fechar, atualizará o DGV
        {
            Frm_Create_PhoneClassifications frmCreatePhoneClassification = new Frm_Create_PhoneClassifications();
            frmCreatePhoneClassification.SetNewId();
            frmCreatePhoneClassification.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_PhoneClassification.Rows.Clear();
            DGV_PhoneClassification.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_PhoneClassification.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_PhoneClassification.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        private void edt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_PhoneClassification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        public override void PopulateFromDGV() //Ok
        {
            edt_id.Text = DGV_PhoneClassification.SelectedCells[0].Value.ToString();
            edt_PhoneClassification.Text = DGV_PhoneClassification.SelectedCells[1].Value.ToString();
        }

        private void DGV_PhoneClassification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_PhoneClassification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        public void PopulateCamps(PhoneClassifications phoneClass)
        {
            edt_id.Text = phoneClass.id.ToString();
            edt_PhoneClassification.Text = phoneClass.phoneClass;
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
            else if (Utilities.HasOnlyLetters(edt_PhoneClassification.Text, "Classificação de Telefone"))
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
                        this.SetDataSourceToDGV();
                    }
                }
            }
            else
            {
                Utilities.MsgboxCantSearch();
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
                Utilities.IsNotSelected(obj, "A Linha");
            }
        }

        public override void NewPopulatedForm()
        {
            Frm_Create_PhoneClassifications formPhoneClass = new Frm_Create_PhoneClassifications();
            formPhoneClass.Populated(true);
            formPhoneClass.PopulateCamps(GetObject());
            formPhoneClass.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
