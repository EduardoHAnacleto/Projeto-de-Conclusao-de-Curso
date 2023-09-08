using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class MasterDetails_PurchasesProducts : Form
    {
        public MasterDetails_PurchasesProducts(Users user)
        {
            InitializeComponent();
            _user = user;
            PopulateDGVPurchases();
        }

        private readonly Users _user = new Users();
        private Purchases_Controller _controller = new Purchases_Controller();
        private Suppliers_Controller _supController = new Suppliers_Controller();

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchSupplier();
        }

        private void SearchSupplier()
        {
            Frm_Find_Suppliers FrmFindSupplier = new Frm_Find_Suppliers();
            FrmFindSupplier.hasFather = true;
            FrmFindSupplier.ShowDialog();
            if (!FrmFindSupplier.ActiveControl.ContainsFocus)
            {
                Suppliers supplier = new Suppliers();
                supplier = FrmFindSupplier.GetObject();
                if (supplier != null)
                {
                    edt_supplierName.Text = supplier.name;
                    FilterBySupplier(supplier.name);
                }
                FrmFindSupplier.Close();
            }
        }

        private void FilterBySupplier(string supplierName)
        {
            PopulateDGVPurchases();
            foreach (DataGridViewRow row in DGV_Purchases.Rows)
            {
                if (row.Cells["PurchaseSupplierName"].Value.ToString() != supplierName)
                {
                    DGV_Purchases.Rows.Remove(row);
                }
            }
        }

        private void PopulateDGVPurchases()
        {
            DGV_Purchases.Rows.Clear();
            DataTable dt = _controller.PopulateDGV();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var billNum = Convert.ToInt32(dr["billNumber"]);
                    var billMod = Convert.ToInt32(dr["billModel"]);
                    var billSer = Convert.ToInt32(dr["billSeries"]);
                    var supplierName = _supController.FindItemId(Convert.ToInt32(dr["supplier_id"])).name;

                    var idUser = Convert.ToInt32(dr["user_id"]);
                    var totalValue = Convert.ToDecimal(dr["purchase_TotalCost"]);
                    var emissionDate = Convert.ToDateTime(dr["emissionDate"]);
                    DateTime? cancelDate = null;
                    if (dr["cancelledDate"] != DBNull.Value)
                    {
                        cancelDate = Convert.ToDateTime(dr["cancelledDate"]);
                    }

                    DGV_Purchases.Rows.Add(
                        billNum,
                        billMod,
                        billSer,
                        supplierName,
                        idUser,
                        totalValue,
                        emissionDate,
                        cancelDate
                        );
                }
            }
        }

        private void btn_SelectPurchase_Click(object sender, EventArgs e)
        {
            NewPopulatedPurchase();
        }

        private Purchases GetPurchase()
        {
            if (DGV_Purchases.SelectedRows[0] != null)
            {
                int billNum = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillNumber"].Value);
                int billMod = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillModel"].Value);
                int billSer = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillSeries"].Value);
                int supplierId = _supController.FindItemName(DGV_Purchases.SelectedRows[0].Cells["PurchaseSupplierName"].Value.ToString()).id;

                var purchase = _controller.FindItemId(billMod, billNum, billSer, supplierId);
                return purchase;
            }
            return null;
        }

        private void NewPopulatedPurchase()
        {
            var purchase = GetPurchase();
            if (purchase != null)
            {
                Frm_Create_Purchases frmPurchase = new Frm_Create_Purchases(_user);
                frmPurchase.PopulateCamps(purchase);
                frmPurchase.Populated(true);
                frmPurchase.ShowDialog();
                PopulateDGVPurchases();
            }
        }
    
        private void PopulateDGVProducts()
        {
            var purchase = GetPurchase();
            if (purchase != null)
            {
                DGV_PurchaseProducts.Rows.Clear();
                foreach (var obj in purchase.PurchasedItems)
                {
                    DGV_PurchaseProducts.Rows.Add(
                        obj.Product.id,
                        obj.Product.productName,
                        obj.Quantity,
                        obj.DiscountCash,
                        obj.NewBaseUnCost,
                        obj.WeightedCostAverage,
                        obj.NewBaseUnCost*obj.Quantity
                        );
                }
            }
        }

        private void DGV_Purchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDGVProducts();
        }

        private void rbtn_cancelled_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
            if (rbtn_cancelled.Checked)
            {
                rbtn_active.Checked = false;
                foreach (DataGridViewRow row in DGV_Purchases.Rows)
                {
                    if (row.Cells["PurchaseCancelDate"].Value == null)
                    {
                        DGV_Purchases.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
            if (rbtn_active.Checked)
            {
                rbtn_cancelled.Checked = false;
                foreach (DataGridViewRow row in DGV_Purchases.Rows)
                {
                    if (row.Cells["PurchaseCancelDate"].Value != null)
                    {
                        DGV_Purchases.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_DateCreation_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
            if (rbtn_DateCreation.Checked)
            {
                rbtn_cancelDate.Checked = false;
                foreach (DataGridViewRow row in DGV_Purchases.Rows)
                {
                    if (Convert.ToDateTime(row.Cells["PurchaseDateCreation"].Value) < dateTime_filter.Value)
                    {
                        DGV_Purchases.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_cancelDate_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
            if (rbtn_cancelDate.Checked)
            {
                rbtn_DateCreation.Checked = false;
                foreach (DataGridViewRow row in DGV_Purchases.Rows)
                {
                    if (row.Cells["SaleCancelDate"].Value == null ||
                        (Convert.ToDateTime(row.Cells["PurchaseDateCreation"].Value) < dateTime_filter.Value))
                    {
                        DGV_Purchases.Rows.Remove(row);
                    }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
