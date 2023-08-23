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
    public partial class Frm_Find_Clients : ProjetoEduardoAnacletoWindowsForm1.Forms_Find.Frm_Find_People
    {
        public Frm_Find_Clients()
        {
            InitializeComponent();
            this.SetDataSourceToDGV();
        }

        private Clients_Controller controller = new Clients_Controller();

        public Clients GetObject()
        {
            Clients obj = new Clients();
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
            Frm_Create_Clients formClient = new Frm_Create_Clients();
            formClient.PopulateCamps(GetObject());
            formClient.Populated(true);
            formClient.LockCamps();
            formClient.ShowDialog();
            this.SetDataSourceToDGV();
        }

        //public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DSGV como DataSource, linka db com DGV
        //{
        //    DGV_People.Rows.Clear();
        //    DataTable dt = this.controller.PopulateDGV();
        //    if (dt != null)
        //    {
        //        int i = 0;
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            DGV_People.Rows.Add();
        //            for (int k = 0; k < 3; k++)
        //            {
        //                if (dr[k] != null)
        //                {
        //                    DGV_People.Rows[i].Cells[k].Value = dr[k].ToString();
        //                }
        //            }
        //            i++;
        //        }
        //    }
        //    UpdateColumnItem();
        //}

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DSGV como DataSource, linka db com DGV
        {
            DGV_People.Rows.Clear();
            DataTable dt = this.controller.PopulateDGV();
            if (dt != null)
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0] != null)
                    {
                        DGV_People.Rows.Add();
                        DGV_People.Rows[i].Cells["IdPerson"].Value = dr["id_client"].ToString();
                        DGV_People.Rows[i].Cells["NamePerson"].Value = dr["client_name"].ToString();
                        DGV_People.Rows[i].Cells["InfoPerson"].Value = dr["client_type"].ToString();
                    }                                           
                    i++;
                }
            }
           UpdateColumnItem();
        }


        public override void NewObject()
        {
            Frm_Create_Clients frmCreateClient = new Frm_Create_Clients();
            frmCreateClient.SetNewId();
            frmCreateClient.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void PopulateFromDGV() //Popula os campos baseado na Row Selecionada do DGV
        {
            var row = DGV_People.SelectedRows[0];
            Clients client = new Clients();
            client = controller.FindItemId(Convert.ToInt32(row.Cells["IdPerson"].Value));
            edt_id.Value = client.id;
            edt_Name.Text = client.name;
            medt_regNumber.Text = client.registrationNumber;
        }

        public void PopulateCamps(Clients obj)
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
            else if (Utilities.HasOnlyLetters(edt_Name.Text, "Nome do Cliente") && !String.IsNullOrWhiteSpace(edt_Name.Text))
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
            else if (Utilities.HasOnlyDigits(Utilities.RemoveRegMask(medt_regNumber.Text),"Número de Registro")) 
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
       
        public Clients SearchItemByName()
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

        public Clients SearchItemById()
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

        public Clients SearchItemByRN()
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
                Utilities.IsNotSelected(obj, "A linha");
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
                        dr.Cells["InfoPerson"].Value = "Físico";
                    }
                    else
                        if (dr.Cells["InfoPerson"].Value.ToString() == "2")
                    {
                        dr.Cells["InfoPerson"].Value = "Jurídico";
                    }

                }
            }
        }

    }
}
    