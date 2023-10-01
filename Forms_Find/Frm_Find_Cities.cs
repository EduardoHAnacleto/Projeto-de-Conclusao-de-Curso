using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Find_Cities : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        private Cities_Controller controller = new Cities_Controller();

        public Frm_Find_Cities()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        public Cities GetObject()
        {
            States_Controller sController = new States_Controller();
            var obj = new Cities();
            obj = controller.FindItemName(edt_cityName.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                if (obj != null)
                {
                    obj.state = sController.FindItemId(obj.state.id);
                }
            }
            return obj;
        }


        public Cities SearchItemByName()
        {
            try
            {
                return controller.FindItemName(edt_cityName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cities SearchItemById()
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

        private void edt_cityName_KeyPress(object sender, KeyPressEventArgs e)
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
                row = DGV_Cities.SelectedRows[0];
            }
            catch { }
            if (row.Cells[0].Value != null)
            {
                edt_id.Value = Convert.ToInt32(row.Cells["CityId"].Value);
                edt_cityName.Text = row.Cells["CityName"].Value.ToString();
                edt_cityPhonePrefix.Text = row.Cells["PhonePrefix"].Value.ToString();
            }

        }
    
        public override void NewPopulatedForm()
        {
            Frm_Create_Cities formCity = new Frm_Create_Cities();
            formCity.Populated(true);
            formCity.PopulateCamps(GetObject());
            formCity.ShowDialog();

        }
    
        public override void NewObject()
        {
            Frm_Create_Cities formCreateCities = new Frm_Create_Cities();
            formCreateCities.SetNewId();
            formCreateCities.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Cities.Rows.Clear();
            DGV_Cities.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Cities.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        var x = dr.Table.Columns.Count;
                        if (dr[k] != null)
                        {
                            DGV_Cities.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
            UpdateColumnItem();
        }

        public virtual void UpdateColumnItem()
        {
            var sController = new States_Controller();
            foreach (DataGridViewRow dr in DGV_Cities.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    var state = sController.FindItemId(Convert.ToInt32(dr.Cells["IdState"].Value));
                    dr.Cells["IdState"].Value = state.stateName;
                }

            }
        }

        private void DGV_Cities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_Cities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_Cities_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }
        }

        private void DGV_Cities_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
            NewPopulatedForm();
        }

        public void PopulateCamps(Cities city)
        {
            edt_id.Text = city.id.ToString();
            edt_cityName.Text = city.cityName;
            edt_cityPhonePrefix.Text = city.cityPhonePrefix;
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
            else if (Utilities.HasOnlyLetters(edt_cityPhonePrefix.Text, "Prefixo do telefone"))
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
                Utilities.IsNotSelected(obj, "A linha");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
