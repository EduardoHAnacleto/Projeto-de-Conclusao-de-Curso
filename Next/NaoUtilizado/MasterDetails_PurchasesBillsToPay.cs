using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
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
    public partial class MasterDetails_PurchasesBillsToPay : Form
    {
        public MasterDetails_PurchasesBillsToPay(Users user)
        {
            InitializeComponent();
            _user = user;
            PopulateDGVPurchases();
        }

        private readonly Users _user = new Users();
        Purchases_Controller _controller = new Purchases_Controller();
        BillsToPay_Controller _btpController = new BillsToPay_Controller();

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
                    DateTime? cancelDate = null;
                    if (dr["cancelledDate"] != DBNull.Value)
                    {
                        cancelDate = Convert.ToDateTime(dr["cancelledDate"]).Date ;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchSupplier();
        }

        private Purchases GetPurchase()
        {
            Suppliers_Controller supController = new Suppliers_Controller();
            if (DGV_Purchases.SelectedRows[0] != null)
            {
                int billNum = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillNumber"].Value);
                int billMod = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillModel"].Value);
                int billSer = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillSeries"].Value);
                int supplierId = supController.FindItemName(DGV_Purchases.SelectedRows[0].Cells["PurchaseSupplierName"].Value.ToString()).id;

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

        private void btn_SelectPurchase_Click(object sender, EventArgs e)
        {
            NewPopulatedPurchase();
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            PopulateDGVPurchases();
        }

        private void DGV_Purchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDGVBillsToPay();
        }

        private void PopulateDGVBillsToPay()
        {
            if (DGV_Purchases.SelectedRows[0] != null)
            {
                DGV_BillsToPay.Rows.Clear();
                Suppliers_Controller supController = new Suppliers_Controller();
                var bModel = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillModel"].Value);
                var bNum = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillNumber"].Value);
                var bSeries = Convert.ToInt32(DGV_Purchases.SelectedRows[0].Cells["BillSeries"].Value);
                var supplierId = supController.FindItemName(DGV_Purchases.SelectedRows[0].Cells["PurchaseSupplierName"].Value.ToString()).id;
                var list = _btpController.FindItemId(bNum, bModel ,bSeries, supplierId);

                foreach (var item in list )
                {
                    string status = "Ativo";
                    if (item.PaidDate.HasValue)
                    {
                        status = "Pago";
                    }
                    else if (DGV_Purchases.SelectedRows[0].Cells["PurchaseCancelDate"].Value != null)
                    {
                        status = "Cancelado";
                    }
                    if ((item.DueDate.Date < DateTime.Today.Date) & 
                        (!item.PaidDate.HasValue))   
                    {
                        status = "Atrasado";
                    }

                    DGV_BillsToPay.Rows.Add(
                        item.InstalmentNumber,
                        item.PaymentCondition.conditionName,
                        item.PaymentMethod.paymentMethod,
                        item.DueDate,
                        item.TotalValue,
                        status);
                }
            }
        }

        private void DGV_Purchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDGVBillsToPay();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtn_activeBill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_activeBill.Checked)
            {
                rbtn_cancelledBills.Checked = false;
                rbtn_paidBills.Checked = false;
                if (DGV_BillsToPay.Rows.Count > 0)
                {
                    PopulateDGVBillsToPay();
                    foreach (DataGridViewRow row in DGV_BillsToPay.Rows)
                    {
                        if (row.Cells["BillStatus"].Value.ToString() != "Ativo")
                        {
                            DGV_BillsToPay.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void rbtn_paidBills_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_paidBills.Checked)
            {
                rbtn_cancelledBills.Checked = false;
                rbtn_active.Checked = false;
                if (DGV_BillsToPay.Rows.Count > 0)
                {
                    PopulateDGVBillsToPay();
                    foreach (DataGridViewRow row in DGV_BillsToPay.Rows)
                    {
                        if (row.Cells["BillStatus"].Value.ToString() != "Pago")
                        {
                            DGV_BillsToPay.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void rbtn_cancelledBills_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_cancelledBills.Checked)
            {
                rbtn_activeBill.Checked = false;
                rbtn_paidBills.Checked = false;
                if (DGV_BillsToPay.Rows.Count > 0)
                {
                    PopulateDGVBillsToPay();
                    foreach (DataGridViewRow row in DGV_BillsToPay.Rows)
                    {
                        if (row.Cells["BillStatus"].Value.ToString() != "Cancelado")
                        {
                            DGV_BillsToPay.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void rbtn_onDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_onDate.Checked)
            {
                rbtn_overdue.Checked = false;
                if (DGV_BillsToPay.Rows.Count > 0)
                {
                    PopulateDGVBillsToPay();
                    foreach (DataGridViewRow row in DGV_BillsToPay.Rows)
                    {
                        if (Convert.ToDateTime(row.Cells["DueDate"].Value) >= DateTime.Today.Date)
                        {
                            DGV_BillsToPay.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void rbtn_overdue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_overdue.Checked)
            {
                rbtn_onDate.Checked = false;
                if (DGV_BillsToPay.Rows.Count > 0)
                {
                    PopulateDGVBillsToPay();
                    foreach (DataGridViewRow row in DGV_BillsToPay.Rows)
                    {
                        if (Convert.ToDateTime(row.Cells["DueDate"].Value) < DateTime.Today.Date)
                        {
                            DGV_BillsToPay.Rows.Remove(row);
                        }
                    }
                }
            }
        }
    }
}
