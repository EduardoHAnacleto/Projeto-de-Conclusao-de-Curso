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
    public partial class Frm_Find_Services : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Services()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private Services_Controller controller = new Services_Controller();

        public Services GetObject()
        {
            Services obj = new Services();
            obj = controller.FindItemName(edt_serviceDescription.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                return obj;
            }
            else
                return obj;
        }

        public Services SearchItemByName() //Ok
        {
            try
            {
                return controller.FindItemName(edt_serviceDescription.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Services SearchItemById() //Ok
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

        public override void NewPopulatedForm() //Ok
        {
            Frm_Create_Services formPGroup = new Frm_Create_Services();
            formPGroup.Populated(true);
            formPGroup.PopulateCamps(GetObject());
            formPGroup.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void NewObject() //Ok -Abrir Novo Form CREATE, quando fechar, atualizará o DGV
        {
            Frm_Create_Services frmCreatePGroup = new Frm_Create_Services();
            frmCreatePGroup.SetNewId();
            frmCreatePGroup.ShowDialog();
            SetDataSourceToDGV();
        }

        public override void PopulateFromDGV() //Ok
        {
            var row = DGV_Services.SelectedRows[0];
            edt_id.Text = row.Cells["ServiceId"].Value.ToString();
            edt_serviceDescription.Text = row.Cells["ServiceDescription"].Value.ToString();
        }

        public void PopulateCamps(Services service)
        {
            edt_id.Text = service.id.ToString();
            edt_serviceDescription.Text = service.descriptionService;
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
            else if (Utilities.HasOnlyLetters(edt_serviceDescription.Text, "Descrição do Serviço"))
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

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Services.Rows.Clear();
            DGV_Services.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Services.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Services.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_Services.Rows[i].Cells[k].Value = dr[k].ToString();
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

        private void edt_serviceDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_Services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_Services_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPopulatedForm();
        }

        private void DGV_Services_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }
        }

        private void DGV_Services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
