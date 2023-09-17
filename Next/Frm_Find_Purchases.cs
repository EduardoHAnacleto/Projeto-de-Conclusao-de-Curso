using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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
    public partial class Frm_Find_Purchases : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Purchases()
        {
            InitializeComponent();
            PopulateDGVPurchases();
            edt_id.Visible = false;
            lbl_id.Visible = false;
        }

        private Users _user = new Users();

        Purchases_Controller _controller = new Purchases_Controller();

        public void SetUser(Users user)
        {
            _user = user;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (DGV_Purchases.Rows.Count > 1)
            {
                SearchPurchase();
            }
        }

        private void PopulateDGVPurchases()
        {
            Suppliers_Controller supController = new Suppliers_Controller();
            DGV_Purchases.Rows.Clear();
            DataTable dt = _controller.PopulateDGV();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var billNum = Convert.ToInt32(dr["billNumber"]);
                    var billMod = Convert.ToInt32(dr["billModel"]);
                    var billSer = Convert.ToInt32(dr["billSeries"]);
                    var supplierName = supController.FindItemId(Convert.ToInt32(dr["supplier_id"])).name;

                    var idUser = Convert.ToInt32(dr["user_id"]);
                    var totalValue = Convert.ToDecimal(dr["purchase_TotalCost"]);
                    var emissionDate = Convert.ToDateTime(dr["emissionDate"]);
                    string cancelDate = null;
                    if (dr["cancelledDate"] != DBNull.Value)
                    {
                        cancelDate = Convert.ToDateTime(dr["cancelledDate"]).Date.ToShortDateString();
                    }

                    DGV_Purchases.Rows.Add(
                        billNum,
                        billMod,
                        billSer,
                        supplierName,
                        idUser,
                        totalValue,
                        emissionDate.ToShortDateString(),
                        cancelDate
                        );
                }
            }
        }

        private void SearchPurchase()
        {
            bool foundStatus = false;
            foreach (DataGridViewRow row in DGV_Purchases.Rows)
            {
                if (!(row.Cells["billNumber"].Value.ToString() == edt_billNumber.Value.ToString()) &&
                    !(row.Cells["billModel"].Value.ToString() == edt_billModel.Value.ToString()) &&
                    !(row.Cells["billSeries"].Value.ToString() == edt_billSeries.Value.ToString()))
                {
                    DGV_Purchases.Rows[row.Index].Selected = true;
                    foundStatus = true;
                    break;
                }
            }
            if (!foundStatus)
            {
                MessageBox.Show("Compra não encontrada.");
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
                    NewPopulatedForm(obj);
                    SetDataSourceToDGV();
                }
            }
            else
            {
                Utilities.IsNotSelected(obj, "A Linha");
            }
        }

        private void NewPopulatedForm(Purchases obj)
        {
            Frm_Create_Purchases frmPurchases = new Frm_Create_Purchases(obj.User);
            frmPurchases.PopulateCamps(obj);
            frmPurchases.Populated(true);
            frmPurchases.ShowDialog();
        }

        private Purchases GetObject()
        {          
            if (DGV_Purchases.SelectedRows[0] != null)
            {
                Suppliers_Controller supController = new Suppliers_Controller();
                var obj = new Purchases();
                var bModel = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillModel"].Value);
                var bNumber = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillNumber"].Value);
                var bSeries = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillSeries"].Value);
                var supplierId = supController.FindItemName(DGV_Purchases.SelectedRows[0].Cells["PurchaseSupplierName"].Value.ToString()).id;
                obj = _controller.FindItemId(bModel, bNumber, bSeries, supplierId);
                return obj;
            }
            return null;
        }

        public override void NewObject()
        {
            Frm_Create_Purchases frmCreatePurchases = new Frm_Create_Purchases(_user);
            frmCreatePurchases.Populated(false);
            frmCreatePurchases.ShowDialog();
            this.SetDataSourceToDGV();
        }
    }
}
