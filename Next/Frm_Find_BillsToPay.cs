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

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Find_BillsToPay : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_BillsToPay()
        {
            InitializeComponent();
            edt_billModel.Controls[0].Visible = false;
            edt_billNumber.Controls[0].Visible = false;
            edt_billPage.Controls[0].Visible = false;
            edt_billSeries.Controls[0].Visible = false;
            this.SetDataSourceToDGV();
        }

        private readonly BillsToPay_Controller _controller = new BillsToPay_Controller();

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToPay.Rows.Count>1)
            {
                SearchBill();
            }
        }

        private void SearchBill()
        {
            bool foundStatus = false;
            foreach (DataGridViewRow row in DGV_BillsToPay.Rows) 
            {
                if ( !(row.Cells["billNumber"].Value.ToString() == edt_billNumber.Value.ToString() ) &&
                    !(row.Cells["billModel"].Value.ToString() == edt_billModel.Value.ToString() ) &&
                    !(row.Cells["billSeries"].Value.ToString() == edt_billSeries.Value.ToString() ) &&
                    !(row.Cells["billPage"].Value.ToString() == edt_billPage.Value.ToString() ))
                {
                    DGV_BillsToPay.Rows[row.Index].Selected = true;
                    foundStatus = true;
                    break;
                }
            }
            if (!foundStatus)
            {
                MessageBox.Show("Bills not found.");
            }
        }

        private BillsToPay GetObject()
        {
            int billNumber = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billNumber"].Value);
            int billSeries = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billSeries"].Value);
            int billPage = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billPage"].Value);
            int billModel = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billModel"].Value);
            int instalmentNumber = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["instalmentNumber"].Value);
            BillsToPay obj = _controller.FindItemId(billNumber,billModel,billSeries,billPage,instalmentNumber);
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
                Utilities.IsNotSelected(obj, "The Row");
            }
        }

        public override void NewPopulatedForm()
        {
            Frm_Create_BillsToPay frmCreateBillsToPay = new Frm_Create_BillsToPay();
            frmCreateBillsToPay.PopulateCamps(this.GetObject());
            frmCreateBillsToPay.Populated(true);
            frmCreateBillsToPay.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_BillsToPay.Rows.Clear();
            DataTable dt = this._controller.PopulateDGV();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var supplierId = dr["supplier_id"].ToString();
                    var billNum = dr["billNumber"].ToString();
                    var billModel = dr["billModel"].ToString();
                    var billSeries = dr["billSeries"].ToString(); 
                    var billPage = dr["billPage"].ToString();
                    var instalmentNumber = dr["instalmentNumber"].ToString();
                    var dueDate = Convert.ToDateTime(dr["dueDate"].ToString()).ToShortDateString();
                    var isPaid = dr["isPaid"].ToString();
                    if (isPaid == "0")
                    {
                        isPaid = "ACTIVE";
                    }
                    else
                    {
                        isPaid = "PAID";
                    }
                    DGV_BillsToPay.Rows.Add(supplierId, billNum,billModel,billSeries,billPage,instalmentNumber,dueDate,isPaid);                     
                }
            }
        }

        public override void NewObject()
        {
            Frm_Create_BillsToPay frmCreateBillsToPay = new Frm_Create_BillsToPay();
            frmCreateBillsToPay.Populated(false);
            frmCreateBillsToPay.ShowDialog();
            this.SetDataSourceToDGV();
        }
    }
}
