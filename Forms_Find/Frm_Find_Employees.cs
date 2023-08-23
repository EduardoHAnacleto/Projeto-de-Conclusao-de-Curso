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
    public partial class Frm_Find_Employees : ProjetoEduardoAnacletoWindowsForm1.Forms_Find.Frm_Find_People
    {
        public Frm_Find_Employees()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private Employees_Controller controller = new Employees_Controller();

        public override void NewObject()  //ok
        {
            Frm_Create_Employees frmCreateEmployee = new Frm_Create_Employees();
            frmCreateEmployee.SetNewId();
            frmCreateEmployee.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public Employees GetObject() //ok
        {
            Employees obj = new Employees();
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

        public override void PopulateFromDGV() //ok
        {
            var row = DGV_People.SelectedRows[0];
            Employees employee = new Employees();
            employee = controller.FindItemId(Convert.ToInt32(row.Cells["IdPerson"].Value));
            edt_id.Value = employee.id;
            edt_Name.Text = employee.name;
            medt_regNumber.Text = employee.registrationNumber;
        }

        public override void NewPopulatedForm()  //Ok - Abre form create populada com o item selecionado
        {
            Frm_Create_Employees formEmployee = new Frm_Create_Employees();
            formEmployee.PopulateCamps(GetObject());
            formEmployee.Populated(true);
            formEmployee.LockCamps();
            formEmployee.ShowDialog();
        }

        public override void SelectObject() //ok
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

        public override void SetDataSourceToDGV() //ok
        {
            DGV_People.Rows.Clear();
            DGV_People.Columns["InfoPerson"].HeaderText = "Status";
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_People.Rows.Add();
                        DGV_People.Rows[i].Cells["IdPerson"].Value = dr["id_employee"].ToString();
                        DGV_People.Rows[i].Cells["NamePerson"].Value = dr["employee_name"].ToString();
                        DGV_People.Rows[i].Cells["InfoPerson"].Value = dr["employee_status"].ToString();
                    }
                    i++;
                }
            }
            UpdateColumnItem();
        }

        public void PopulateCamps(Employees obj) //ok
        {
            edt_id.Text = obj.id.ToString();
            edt_Name.Text = obj.name;
            medt_regNumber.Text = obj.registrationNumber;
        }

        public override void SearchObject() //Ok
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
            else if (!String.IsNullOrWhiteSpace(edt_Name.Text))
            {
                if (Utilities.HasOnlyLetters(edt_Name.Text, "Nome do funcionário"))
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
            }
            else if (Utilities.RemoveRegMask(medt_regNumber.Text) != String.Empty)
            {
                if (Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_regNumber.Text), "Número de Registro"))
                {
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
            }
            else
            {
                Utilities.MsgboxCantSearch();
            }           
        }

        public Employees SearchItemByName() //Ok
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

        public Employees SearchItemById() //ok
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

        public Employees SearchItemByRN() //ok
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

        private void edt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                SearchObject();
            }
        }

        private void medt_regNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        public void UpdateColumnItem()
        {
            foreach (DataGridViewRow dr in DGV_People.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (dr.Cells["InfoPerson"].Value.ToString() == "1")
                    {
                        dr.Cells["InfoPerson"].Value = "ATIVO";
                    }
                    else
                        if (dr.Cells["InfoPerson"].Value.ToString() == "0")
                    {
                        dr.Cells["InfoPerson"].Value = "INATIVO";
                    }

                }
            }
        }
    }
}
