using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Find_States : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {

        public Frm_Find_States()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private States_Controller controller = new States_Controller();

        public States GetObject() //OK -Cria um OBJ a partir dos campos - OK
        {
            Countries_Controller sController = new Countries_Controller();
            var obj = new States();
            obj = controller.FindItemName(edt_stateName.Text);
            if (obj == null)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                if (obj != null)
                {
                    obj.country = sController.FindItemId(obj.country.id);
                }
            }
            return obj;
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
            else if (Utilities.HasOnlyLetters(edt_stateName.Text, "Nome do Estado") && !String.IsNullOrWhiteSpace(edt_stateName.Text))
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
            else if (Utilities.HasOnlyLetters(edt_FU.Text,"Unidade de Federação"))
            {
                if (!SearchItemByFU())
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

        public virtual void UpdateColumnItem()
        {
            var cController = new Countries_Controller();
            foreach (DataGridViewRow dr in DGV_States.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    var country = cController.FindItemId(Convert.ToInt32(dr.Cells["StateCountryName"].Value));
                    dr.Cells["StateCountryName"].Value = country.countryName;
                }

            }
        }

        public void PopulateCamps(States state)
        {
            edt_id.Text = state.id.ToString();
            edt_stateName.Text = state.stateName;
            edt_FU.Text = state.fedUnit;
        }

        public bool SearchItemByFU() //- Ok
        {
            bool status = false;
            for (int i = 0; i < DGV_States.Rows.Count - 1; i++)
            {
                if (DGV_States.Rows[i].Cells["StateFederationUnit"].Value.ToString() == edt_FU.Text)
                {
                    DGV_States.Rows[i].Selected = true;
                    PopulateFromDGV();
                    return status = true;
                }
            }
            return status;
        }

        private void edt_stateName_KeyPress(object sender, KeyPressEventArgs e) //OK -Chama do Master, se apertou Enter, entao pesquisa no banco o item
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        public override void SetDataSourceToDGV() //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_States.Rows.Clear();
            DGV_States.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_States.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count - 2; k++)
                    {
                        if (dr[k] != null)
                        {
                            DGV_States.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
            UpdateColumnItem();
        }

        public States SearchItemByName()  //OK -Procura o Item no banco - Se achar, tras para campos e muda o btn_Search.Text para SELECT
        {
            try
            {
                return controller.FindItemName(edt_stateName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public States SearchItemById()  //OK -Procura o Item ID no banco - Se achar, tras para campos e muda o btn_Search.Text para SELECT
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

        private void edt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void edt_FU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_States_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void DGV_States_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPopulatedForm();
        }

        private void DGV_States_KeyPress(object sender, KeyPressEventArgs e) //-Ok
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }
        }

        public override void NewPopulatedForm() //Ok
        {
            Frm_Create_States formState = new Frm_Create_States();
            formState.Populated(true);
            formState.PopulateCamps(GetObject());
            formState.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            if (DGV_States.SelectedCells[0].Value != null)
            {
                edt_id.Value = Convert.ToInt32( DGV_States.SelectedCells[0].Value.ToString());
                edt_stateName.Text = DGV_States.SelectedCells[1].Value.ToString();
                edt_FU.Text = DGV_States.SelectedCells[2].Value.ToString();
            }

        }

        public override void NewObject() //Abrir Novo Form CREATE, quando fechar, atualizará o DGV
        {
            Frm_Create_States frmCreateStates = new Frm_Create_States();
            frmCreateStates.SetNewId();
            frmCreateStates.ShowDialog();
            SetDataSourceToDGV();
        }

        public void ClearCamps()
        {
            edt_FU.Text = string.Empty;
            edt_stateName.Text = string.Empty;
            edt_FU.Text = string.Empty;
        }

        private void edt_id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchObject();
        }
    }
}
