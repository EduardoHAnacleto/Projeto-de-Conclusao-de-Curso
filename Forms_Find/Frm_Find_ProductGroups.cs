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
    public partial class Frm_Find_ProductGroups : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_ProductGroups()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private ProductGroups_Controller controller = new ProductGroups_Controller();

        public ProductGroups GetObject()
        {
            ProductGroups obj = new ProductGroups();
            obj = controller.FindItemName(edt_productGroupName.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                return obj;
            }
            else 
                return obj;
        }

        public ProductGroups SearchItemByName() //Ok
        {
            try
            {
                return controller.FindItemName(edt_productGroupName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProductGroups SearchItemById() //Ok
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

        private void edt_productGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void edt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_ProdGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_ProdGroups_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPopulatedForm();
        }

        private void DGV_ProdGroups_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }
        }

        public override void NewPopulatedForm() //Ok
        {
            Frm_Create_ProductGroups formPGroup = new Frm_Create_ProductGroups();
            formPGroup.PopulateCamps(GetObject());
            formPGroup.ShowDialog();
        }

        public override void NewObject() //Ok -Abrir Novo Form CREATE, quando fechar, atualizará o DGV
        {
            Frm_Create_ProductGroups formPGroup = new Frm_Create_ProductGroups();
            formPGroup.SetNewId();
            formPGroup.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_ProdGroups.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_ProdGroups.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 3; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_ProdGroups.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        public override void PopulateFromDGV() //Ok
        {
            DataGridViewRow row = null;
            try
            {
                row = DGV_ProdGroups.SelectedRows[0];
            }
            catch { }
            if (row.Cells[0].Value != null)
            {
                edt_id.Text = row.Cells["PGroupId"].Value.ToString();
                edt_productGroupName.Text = row.Cells["PGroupName"].Value.ToString();
            }

        }

        public void PopulateCamps(ProductGroups pGroup)
        {
            edt_id.Text = pGroup.id.ToString();
            edt_productGroupName.Text = pGroup.productGroup;
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
            else if (Utilities.HasOnlyLetters(edt_productGroupName.Text, "Grupo de Produtos"))
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
