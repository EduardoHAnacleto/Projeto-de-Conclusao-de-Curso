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
    public partial class Frm_Find_Suppliers : ProjetoEduardoAnacletoWindowsForm1.Forms_Find.Frm_Find_People
    {
        public Frm_Find_Suppliers()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private Suppliers_Controller controller = new Suppliers_Controller();

        public Suppliers GetObject()
        {
            Suppliers obj = new Suppliers();
            if (edt_id.Value == 0)
            {
                obj = controller.FindItemName(edt_Name.Text);
                return obj;
            }
            if (edt_id.Value > 0)
            {
                obj = controller.FindItemId(Convert.ToInt32(edt_id.Value));
                return obj;
            }
            else
                return null;
        }

        public override void NewPopulatedForm()  //Ok - Abre form create populada com o item selecionado
        {
            Frm_Create_Suppliers formCreateSuppliers = new Frm_Create_Suppliers();
            formCreateSuppliers.PopulateCamps(GetObject());
            formCreateSuppliers.Populated(true);
            formCreateSuppliers.LockCamps();
            formCreateSuppliers.ShowDialog();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DSGV como DataSource, linka db com DGV
        {
            DGV_People.Rows.Clear();
            DGV_People.Columns["InfoPerson"].HeaderText = "Razão Social";
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_People.Rows.Add();
                        DGV_People.Rows[i].Cells["IdPerson"].Value = dr["id_supplier"].ToString();
                        DGV_People.Rows[i].Cells["NamePerson"].Value = dr["supplier_name"].ToString();
                        DGV_People.Rows[i].Cells["InfoPerson"].Value = dr["supplier_social_reason"].ToString();
                    }
                    i++;
                }
            }
        }


        public override void NewObject()
        {
            Frm_Create_Suppliers formCreateSuppliers = new Frm_Create_Suppliers();
            formCreateSuppliers.SetNewId();
            formCreateSuppliers.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            var row = DGV_People.SelectedRows[0];
            Suppliers supplier = new Suppliers();
            supplier = controller.FindItemId(Convert.ToInt32(row.Cells["IdPerson"].Value));
            edt_id.Value = supplier.id;
            edt_Name.Text = supplier.name;
            medt_regNumber.Text = supplier.registrationNumber;
        }

        public void PopulateCamps(Suppliers obj)
        {
            edt_id.Text = obj.id.ToString();
            edt_Name.Text = obj.name;
            medt_regNumber.Text = obj.registrationNumber;
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
            else if (Utilities.HasOnlyLetters(edt_Name.Text, "Nome do Fornecedor") && !String.IsNullOrWhiteSpace(edt_Name.Text))
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
            else if (Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_regNumber.Text), "Número de Registro"))
            {
                var x = Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_regNumber.Text), "Número de Registro");
                var obj = SearchItemByRN();
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

        public Suppliers SearchItemByName()
        {
            try
            {
                return controller.FindItemName(edt_Name.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Suppliers SearchItemById()
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

        public Suppliers SearchItemByRN()
        {
            try
            {
                return controller.FindItemByRN(Utilities.RemoveRegMask(medt_regNumber.Text));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
    }
}
