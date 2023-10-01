using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Find_Brands : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {


        public Frm_Find_Brands()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }
        
        Users user = null;
        private Brands_Controller controller = new Brands_Controller();

        //public Brands GetObject()  //Ok - Cria um OBJ a partir dos campos
        //{
        //    Brands obj = new Brands();
        //    if (edt_id.Value == 0)
        //    {
        //        obj = controller.FindItemName(edt_BrandName.Text);
        //        return obj;
        //    }
        //    if (edt_id.Value > 0)
        //    {
        //        obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
        //        return obj;
        //    }
        //    else
        //        return null;
        //}

        public Brands GetObject()  //Ok - Cria um OBJ a partir dos campos
        {
            Brands obj = new Brands();
            obj = controller.FindItemName(edt_BrandName.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
            }
            return obj;        
        }

        public void PopulateCamps(Brands brand)
        {
            edt_id.Text = brand.id.ToString();
            edt_BrandName.Text = brand.brandName;
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
            else if (Utilities.HasOnlyLetters(edt_BrandName.Text, "Marca"))
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

        public override void NewObject()
        {
            Frm_Create_Brands form_create_brand = new Frm_Create_Brands();
            form_create_brand.SetNewId();
            form_create_brand.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public Brands SearchItemByName() //Ok
        {
            try
            {
                return controller.FindItemName(edt_BrandName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Brands SearchItemById() //Ok
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

        private void edt_BrandName_KeyPress(object sender, KeyPressEventArgs e) //Ok Chama do Master, se apertou Enter, entao pesquisa no banco o item
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_Brands_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //Quando faz Double Click na CELL do DGV, Tras INFO pros Campos
        {
            PopulateFromDGV();
            NewPopulatedForm();
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
            Frm_Create_Brands formBrand = new Frm_Create_Brands();
            formBrand.Populated(true);
            formBrand.PopulateCamps(GetObject());
            formBrand.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Brands.Rows.Clear();
            DGV_Brands.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Brands.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_Brands.Rows[i].Cells[k].Value = dr[k].ToString();
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

        private void DGV_Brands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        public override void PopulateFromDGV() //Ok
        {
            DataGridViewRow row = null;
            try
            {
                row = DGV_Brands.SelectedRows[0];
            }
            catch { }
            if (row.Cells[0].Value != null)
            {
                edt_id.Text = row.Cells["BrandId"].Value.ToString();
                edt_BrandName.Text = row.Cells["BrandName"].Value.ToString();
            }
        }

        private void DGV_Brands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
