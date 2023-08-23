using NUnit.Framework.Constraints;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Find_Countries : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        private Countries_Controller controller = new Countries_Controller();

        public Frm_Find_Countries()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }


        public Countries GetObject() //OK -Cria um OBJ a partir dos campos - OK
        {
            Countries country = new Countries();
            if (edt_id.Value == 0)
            {
                country = controller.FindItemName(edt_countryName.Text);
                return country;
            }
            if (edt_id.Value > 0)
            {
                country = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                return country;
            }
            else
                return null;
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
            else if (Utilities.HasOnlyLetters(edt_countryName.Text, "Nome do País"))
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
            else if (Utilities.HasOnlyLetters(edt_acronym.Text, "Sigla"))
            {
                SearchByAcronym();
            }
            else
            {
                Utilities.MsgboxCantSearch();
            }
        }

        public void PopulateCamps(Countries country)
        {
            edt_id.Text = country.id.ToString();
            edt_countryName.Text = country.countryName;
            edt_acronym.Text = country.countryAcronym;
            edt_phonePrefix.Text = country.countryPhonePrefix;
            edt_currency.Text = country.countryCurrency;
        }
        
        private void btn_Search_Click(object sender, EventArgs e) //OK -Chama SearchItem apos validacao - OK
        {
            SearchObject();
        }

        public void SearchByAcronym() //OK -Procura item pelo campo ACRONYM e popula,
        {
            bool found = false;
            for (int i = 0; i < DGV_Countries.Rows.Count - 1 ; i++)
            {
                if (DGV_Countries.Rows[i].Cells["CountryAcronym"].Value.ToString() == edt_acronym.Text)
                {
                    DGV_Countries.Rows[i].Selected = true;
                    PopulateFromDGV();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                if (Utilities.AskToCreate())
                {
                    NewObject();
                }
            }
        }


        public Countries SearchItemByName()  //OK -Procura o Item no banco - Se achar, tras para campos e muda o btn_Search.Text para SELECT
        {
            try
            {
                return controller.FindItemName(edt_countryName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Countries SearchItemById()  //OK -Procura o Item ID no banco - Se achar, tras para campos e muda o btn_Search.Text para SELECT
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

        private void edt_countryName_KeyPress(object sender, KeyPressEventArgs e) //OK -Ao pressionar ENTER no edt_name, ativa Search
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();            
            }
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Countries.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null) 
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Countries.Rows.Add();
                    for (int k = 0; k < dr.Table.Columns.Count-2; k++) 
                    {
                        var x = dr.Table.Columns.Count;
                        if (dr[k] != null)
                        {
                                DGV_Countries.Rows[i].Cells[k].Value = dr[k].ToString();
                        }
                    }
                    i++;
                }
            }
        }

        public override void NewPopulatedForm()  //Ok - Abre form create populada com o item selecionado
        {
            Frm_Create_Countries formCountry = new Frm_Create_Countries();
            formCountry.Populated(true);
            formCountry.PopulateCamps(GetObject());
            formCountry.ShowDialog();
        }

        private void DGV_Countries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPopulatedForm();
        }

        public override void NewObject()
        {
            Frm_Create_Countries formCreateCountries = new Frm_Create_Countries();
            formCreateCountries.SetNewId();
            formCreateCountries.ShowDialog();
            SetDataSourceToDGV();
        }

        private void btn_Select_Click_1(object sender, EventArgs e)
        {
            SelectObject();
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

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            DataGridViewRow row = null;
            try
            {
                row = DGV_Countries.SelectedRows[0];
            }
            catch { }
            if (row != null)
            {
                edt_id.Text = DGV_Countries.SelectedCells[0].Value.ToString();
                edt_countryName.Text = DGV_Countries.SelectedCells[1].Value.ToString();
                edt_acronym.Text = DGV_Countries.SelectedCells[2].Value.ToString();
                edt_phonePrefix.Text = DGV_Countries.SelectedCells[3].Value.ToString();
                edt_currency.Text = DGV_Countries.SelectedCells[4].Value.ToString();
            }

        }

        private void DGV_Countries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFromDGV();
        }

        private void edt_id_KeyPress(object sender, KeyPressEventArgs e) //OK - Procura por ID quando ENTER é pressionado no campo
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void DGV_Countries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                PopulateFromDGV();
                NewPopulatedForm();
            }        
        }

        private void edt_acronym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }

        }

    }
}
