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
    public partial class Frm_Find_Products : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Products()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private Products_Controller controller = new Products_Controller();

        public Products GetObject()
        {
            ProductGroups_Controller gController = new ProductGroups_Controller();
            Brands_Controller bController = new Brands_Controller();
            Products obj = new Products();
            obj = controller.FindItemName(edt_productName.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                if (obj != null)
                {
                    obj.productGroup = gController.FindItemId(obj.productGroup.id);
                    obj.brand = bController.FindItemId(obj.brand.id);
                }
            }
            return obj;
        }

        public virtual void UpdateColumnItem()
        {
            ProductGroups_Controller gController = new ProductGroups_Controller();
            Brands_Controller bController = new Brands_Controller();
            foreach (DataGridViewRow dr in DGV_Products.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    var pGroup = gController.FindItemId(Convert.ToInt32(dr.Cells["DGVProductGroup"].Value));
                    dr.Cells["DGVProductGroup"].Value = pGroup.productGroup;
                    var brand = bController.FindItemId(Convert.ToInt32(dr.Cells["DGVProductBrand"].Value));
                    dr.Cells["DGVProductBrand"].Value = brand.brandName;
                }
            }
        }

        private Products SearchItemByName()
        {
            try
            {
                return controller.FindItemName(edt_productName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Products SearchItemById()
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

        private void edt_productName_KeyPress(object sender, KeyPressEventArgs e)
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

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            DataGridViewRow row = null;
            try
            {
                row = DGV_Products.SelectedRows[0];
            }
            catch { }
            if (row.Cells[0].Value != null)
            {
                edt_id.Value = Convert.ToInt32(row.Cells["DGVIdProduct"].Value);
                edt_productName.Text = row.Cells["DGVProductName"].Value.ToString();
            }
        
        }

        public override void NewPopulatedForm()
        {
            Frm_Create_Products formProduct = new Frm_Create_Products();
            formProduct.Populated(true);
            formProduct.PopulateCamps(GetObject());
            formProduct.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void NewObject()
        {
            Frm_Create_Products formProduct = new Frm_Create_Products();
            formProduct.SetNewId();
            formProduct.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Products.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Products.Rows.Add();
                    //for (int k = 0; k < dr.Table.Columns.Count - 4; k++)
                    //{
                    //    if (dr[k] != null)
                    //    {
                    //        DGV_Products.Rows[i].Cells[k].Value = dr[k].ToString();
                    //    }
                    //}
                    DGV_Products.Rows[i].Cells["DGVIdProduct"].Value = dr["id_product"].ToString();
                    DGV_Products.Rows[i].Cells["DGVProductName"].Value = dr["product_name"].ToString();
                    DGV_Products.Rows[i].Cells["DGVProductValue"].Value = dr["product_sale_price"].ToString();
                    DGV_Products.Rows[i].Cells["DGVProductGroup"].Value = dr["product_group_id"].ToString();
                    DGV_Products.Rows[i].Cells["DGVProductBrand"].Value = dr["brand_id"].ToString();
                    DGV_Products.Rows[i].Cells["DGVProductStock"].Value = dr["stock"].ToString();
                    i++;
                }
            }
            UpdateColumnItem();
        }

        private void DGV_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_Products_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPopulatedForm();
        }

        private void DGV_Products_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
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
            else if (!Utilities.HasOnlySpaces(edt_productName.Text, "Nome do Produto"))
            {
                var obj = SearchItemByName();
                if (obj != null)
                {
                    PopulateCamps(obj);
                }
            }
            else
            {
                if (Utilities.AskToCreate())
                {
                    NewObject();
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
                Utilities.IsNotSelected(obj, "A Linha");
            }
        }

        public void PopulateCamps(Products prod)
        {
            edt_id.Text = prod.id.ToString();
            edt_productName.Text = prod.productName;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
