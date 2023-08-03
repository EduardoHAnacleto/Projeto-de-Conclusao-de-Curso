using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Create_Purchases : Form
    {
        public Frm_Create_Purchases(Users user)
        {
            InitializeComponent();
            edt_prodBarCode.Controls[0].Visible = false;
            edt_prodId.Controls[0].Visible = false;
            edt_prodQtd.Controls[0].Visible = false;
            edt_prodUnCost.Controls[0].Visible = false;
            edt_transportFee.Controls[0].Visible = false;
            edt_userId.Controls[0].Visible = false;
            edt_extraExpenses.Controls[0].Visible = false;
            edt_insurance.Controls[0].Visible = false;
            edt_supplierId.Controls[0].Visible = false;
            medt_date.Text = DateTime.Now.ToString();
            User = user;
        }

        private readonly Users User;
        private readonly Products_Controller _pController = new Products_Controller();
        private readonly Purchases_Controller _controller = new Purchases_Controller();
        private readonly PurchaseItems_Controller _pIController = new PurchaseItems_Controller();
        private Purchases BackupPurchase = null;

        public void NewFormSearchProduct() //Abre form para encontrar e levar PRODUTO
        {
            Frm_Find_Products formProducts = new Frm_Find_Products();
            formProducts.hasFather = true;
            formProducts.ShowDialog();
            if (!formProducts.ActiveControl.ContainsFocus)
            {
                Products product = new Products();
                product = formProducts.GetObject();
                if (product != null)
                {
                    edt_prodId.Value = product.id;
                    edt_productName.Text = product.productName;
                    edt_productName.Text = product.productName;
                    edt_prodBarCode.Value = product.BarCode;
                }
            }
            formProducts.Close();
        }

        private void btn_FindProduct_Click(object sender, EventArgs e)
        {
            NewFormSearchProduct();
        }

        private Products GetProduct()
        {
            if (edt_prodId.Value >= 1)
            {
                return _pController.FindItemId((int)edt_prodId.Value);
            }
            else return null;
        }

        public bool FindEqualDGVProduct(int prodId)
        {
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                if ((int)row.Cells[0].Value == prodId)
                {
                    return true;
                }
            }
            return false;
        }

        private void CalculateSetDGVPurchasePerc()
        {
            int totalAmount = 0;
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                totalAmount += Convert.ToInt32(row.Cells["ProdQtd"].Value);
            }
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                row.Cells["ProdPurchPerc"].Value = Math.Round( (( Convert.ToDecimal(row.Cells["ProdQtd"].Value) / totalAmount) * 100),8);
            }
        }

        private void CalculateSetNewUnCost()
        {
            decimal transportFee = edt_transportFee.Value;
            if (transportFee <= 0)
            {
                transportFee = 1;
            }
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                if (row != null)
                {
                    var prodCurCost = Convert.ToDecimal( row.Cells["ProdCurrentUnCost"].Value);
                    var prodCurStock = Convert.ToInt32( row.Cells["ProdCurrentStock"].Value);
                    var prodPurchPerc = Convert.ToDecimal( row.Cells["ProdPurchPerc"].Value) /100;
                    var prodNewBaseUnCost = Convert.ToDecimal(row.Cells["ProdNewBaseUnCost"].Value);
                    var prodQtd = Convert.ToInt32(row.Cells["ProdQtd"].Value);

                    var percFee = prodPurchPerc * transportFee;
                    var newUnCost = (percFee/100) + prodNewBaseUnCost;
                    var weightedAverage = ((prodCurStock * prodCurCost) + ( prodQtd * newUnCost)) 
                                                    / (prodCurStock + prodQtd);
                    row.Cells["ProdWeightedAvg"].Value = Math.Round(weightedAverage,8);                   
                }
            }

        }

        private void CalculateSetNewSalePrice()
        {
            //To do
        }

        public void AddProductToDGV() 
        {
            Products product = GetProduct();
            int amount = (int)edt_prodQtd.Value;
            decimal purchPerc = 0; 
            decimal newUnCost = edt_prodUnCost.Value; 
            decimal newSalePrice = 0; 
            if (!FindEqualDGVProduct(product.id))
            {
                DGV_PurchasesProducts.Rows.Add(
                    product.id,
                    product.productName,
                    amount,
                    product.productCost,
                    newUnCost,
                    product.salePrice,
                    product.stock,
                    purchPerc,
                    newUnCost,
                    newSalePrice
                    );
            }
            CalculateSetDGVPurchasePerc();
            CalculateSetNewUnCost();
            CalculateSetNewSalePrice();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (edt_prodId.Value >= 1)
            {
                AddProductToDGV();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save() // Save
        {
            bool status = true;
            if (CheckCamps())
            {
                LockCamps();
                Purchases purchase = this.GetObject();
                try
                {
                    if (btn_new.Text == "F5")
                    {
                        var bill = AddBillsToPay(purchase);
                        if (bill != null)
                        {
                            status = _controller.SaveItem(purchase);
                            if (status)
                            {
                                int purchId = _controller.GetLastId();
                                foreach (PurchaseItems item in purchase.PurchasedItems)
                                {
                                    item.PurchaseId = purchId;
                                    status = _pIController.SaveItem(item);
                                    if (!status)
                                    {
                                        break;
                                    }
                                }
                                if (status)
                                {
                                    if (ConnectPurchaseBill(bill, purchase))
                                    {
                                        Populated(false);
                                    }
                                }
                            }
                        }
                        UnlockCamps();
                    }
                    else if (btn_new.Text == "Cancel")
                    {
                        status = _controller.UpdateItem(purchase);
                        if (status)
                        {
                            SetFormToEdit();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private bool ConnectPurchaseBill(List<BillsToPay> billList, Purchases purchase)
        {
            bool status = false;
            foreach (BillsToPay bill in billList)
            {
                status = _controller.ConnectPurchaseBill(bill, purchase);
            }
            return status;
        }

        private List<BillsToPay> AddBillsToPay(Purchases purchase)
        {
            Frm_Create_BillsToPay FrmBillsToPay = new Frm_Create_BillsToPay();
            FrmBillsToPay.PopulateFromPurchase(purchase);
            FrmBillsToPay.FromPurchase = true;
            FrmBillsToPay.ShowDialog();
            if (!FrmBillsToPay.ActiveControl.ContainsFocus)
            {
                if (FrmBillsToPay.HasSaved)
                {
                    return FrmBillsToPay._auxObjList;
                }
                else
                {
                    string message = "At least one bill must be submitted.";
                    string caption = "Bill not submitted.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    Utilities.Msgbox(message, caption, buttons, icon);
                }
            }
            return null; 
        }


        private void SetFormToEdit()
        {
            var edit = "&Edit";
            var del = "Delete";
            btn_new.Text = edit;
            lbl_new.Text = edit;
            btn_new.Enabled = true;
            btn_Save.Enabled = false;
            btn_FindSup.Enabled = false;
            btn_FindSup.Text = del;
            lbl_findsupplier.Text = del;
        }

        public virtual void Populated(bool populated)
        {
            if (populated)
            {
                this.LockCamps();
                this.SetFormToEdit();
            }
            else if (!populated)
            {
                this.UnlockCamps();
                this.ClearCamps();
            }
        }

        private Purchases GetObject()
        {
            Purchases obj = new Purchases();
            Suppliers_Controller _sController = new Suppliers_Controller();
            obj.id = _controller.BringNewId();
            obj.User = User;
            obj.Supplier = _sController.FindItemId( Convert.ToInt32(edt_supplierId.Value));
            obj.Freight_Cost = Convert.ToDouble(edt_transportFee.Value);
            obj.PurchasedItems = GetDGVList(obj.id);
            obj.EmissionDate = Convert.ToDateTime(medt_date.Text);
            obj.ExtraExpenses = Convert.ToDouble(edt_extraExpenses.Value);
            obj.InsuranceCost = Convert.ToDouble(edt_insurance.Value);
            obj.CancelledDate = null;
            obj.PaidDate = null;
            if (rbtn_Completed.Checked)
            {
                obj.ArrivalDate = dateTime_ArrivalDate.Value;
                obj.Status = 3;
            }
            else if (rbtn_Active.Checked)
            {
                obj.ArrivalDate = null;
                obj.Status = 0;
            }
            else if (rbtn_Paid.Checked)
            {
                obj.ArrivalDate = null;
                obj.Status = 1;
                obj.PaidDate = dateTime_PaidDate.Value;
            }
            else if (rbtn_Cancelled.Checked)
            {
                obj.ArrivalDate = null;
                obj.Status = 2;
                obj.CancelledDate = Convert.ToDateTime(medt_CancelDate.Text);
            }
            return obj;
        }

        public List<PurchaseItems> GetDGVList(int purchaseId)
        {
            var list = new List<PurchaseItems>();
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                PurchaseItems item = new PurchaseItems();
                item.id = purchaseId;
                item.Product = _pController.FindItemId(Convert.ToInt32(row.Cells["ProdId"].Value));
                item.Quantity = Convert.ToInt32(row.Cells["ProdQtd"].Value);
                item.NewBaseUnCost = Convert.ToDecimal(row.Cells["ProdNewBaseUnCost"].Value);
                item.TotalBaseCost = item.Quantity * item.NewBaseUnCost;
                item.PurchasePercentage = Convert.ToDecimal(row.Cells["ProdPurchPerc"].Value);
                item.WeightedCostAverage = Convert.ToDecimal(row.Cells["ProdWeightedAvg"].Value);
                list.Add(item);
            }

            return list;
        }

        private void LockCamps()
        {
            gbox_date.Enabled = false;
            gbox_options.Enabled = false;
            gbox_User.Enabled = false;
            gbox_products.Enabled = false;
        }

        private void UnlockCamps()
        {
            gbox_date.Enabled = true;
            gbox_options.Enabled = true;
            gbox_User.Enabled = true;
            gbox_products.Enabled = true;
        }

        private void ClearCamps()
        {
            edt_prodBarCode.Value = 0;
            edt_prodId.Value = 0;
            edt_prodQtd.Value = 1;
            edt_prodUnCost.Value = 0;
            edt_transportFee.Value = 0;
            medt_date.Text = DateTime.Now.ToString();
            medt_CancelDate.Text = string.Empty;
            edt_productName.Text = string.Empty;
        }

        public void PopulateCamps(Purchases purchase)
        {
            Populated(true);
            SetFormToEdit();
            PopulateDGV(purchase);
            PopulateSupplier(purchase.Supplier);
            PopulateStatusInfo(purchase);
        }

        private void PopulateStatusInfo(Purchases purchase)
        {
            dateTime_EstArrivalDate.Text = purchase.EstArrivalDate.ToShortDateString();
            edt_transportFee.Value = (decimal)purchase.Freight_Cost;
            edt_extraExpenses.Value = (decimal)purchase.ExtraExpenses;
            edt_insurance.Value = (decimal)purchase.InsuranceCost;
            if (purchase.Status == 3)
            {
                rbtn_Completed.Checked = true;
                lbl_arrivalDate.Visible = true;
                dateTime_ArrivalDate.Text = purchase.ToString();
                dateTime_ArrivalDate.Visible = true;
            }
            else if (purchase.Status == 0)
            {
                rbtn_Active.Checked = true;                
            }
            else if (purchase.Status == 1)
            {
                rbtn_Paid.Checked = true;
                lbl_paidDate.Visible = true;
                dateTime_PaidDate.Visible = true;
                dateTime_PaidDate.Value = Convert.ToDateTime(purchase.PaidDate);
            }
            else if (purchase.Status == 2)
            {
                rbtn_Cancelled.Checked = true;
                medt_CancelDate.Visible = true;
                lbl_CancelDate.Visible = true;
                medt_CancelDate.Text = purchase.CancelledDate.ToString();
            }
            medt_CancelDate.Text = purchase.dateOfCreation.ToString();
        }

        private void PopulateSupplier(Suppliers supplier)
        {
            edt_supplierId.Value = supplier.id;
            edt_supplierName.Text = supplier.name;
        }

        public void PopulateDGV(Purchases purchase)
        {
            foreach (PurchaseItems item in purchase.PurchasedItems)
            {
                DGV_PurchasesProducts.Rows.Add(
                    item.id,
                    item.Product.productName,
                    item.Quantity,
                    item.NewBaseUnCost,
                    item.NewBaseUnCost,
                    item.Product.salePrice,
                    item.Product.stock,
                    item.PurchasePercentage,
                    item.WeightedCostAverage,
                    item.Product.salePrice
                    );
            }
        }

        private bool CheckCamps()
        {
            if (DGV_PurchasesProducts.Rows.Count < 1)
            {
                string message = "Purchase must contain at least 1 item.";
                string caption = "Purchase items is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (edt_supplierId.Value <= 0)
            {
                string message = "Purchase must contain supplier.";
                string caption = "Supplier is not selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (rbtn_Completed.Checked && dateTime_ArrivalDate.Value <= dateTime_ArrivalDate.MinDate) 
            {
                string message = "Arrival date must be selected.";
                string caption = "Arival date is not selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            return true;
        }

        public void DeleteObject()
        {
            LockCamps();
            try
            {
                _controller.DeleteItem(BackupPurchase.id);
                this.ClearCamps();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_findSupplier_Click(object sender, EventArgs e)
        {
            NewFormSearchSupplier();
        }

        public void NewFormSearchSupplier() //Abre form para encontrar e levar PRODUTO
        {
            Frm_Find_Suppliers formSuppliers = new Frm_Find_Suppliers();
            formSuppliers.hasFather = true;
            formSuppliers.ShowDialog();
            if (!formSuppliers.ActiveControl.ContainsFocus)
            {
                Suppliers supplier = new Suppliers();
                supplier = formSuppliers.GetObject();
                if (supplier != null)
                {
                    edt_supplierId.Value = supplier.id;
                    edt_supplierName.Text = supplier.name;
                }
            }
            formSuppliers.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearCamps();
        }

        private void btn_FindSup_Click(object sender, EventArgs e)
        {
            NewFormSearchSupplier();
        }

        private void rbtn_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Active.Checked)
            {
                rbtn_Cancelled.Checked = false;
                rbtn_OnHold.Checked = false;
                rbtn_Completed.Checked = false;
                rbtn_Paid.Checked = false;
                dateTime_ArrivalDate.Visible = false;
                lbl_arrivalDate.Visible = false;
                lbl_CancelDate.Visible = false;
                medt_CancelDate.Visible = false;
                medt_CancelDate.Text = string.Empty;
                lbl_paidDate.Visible = false;
                dateTime_PaidDate.Visible = false;
                dateTime_PaidDate.Value = dateTime_PaidDate.MinDate;
            }
        }

        private void rbtn_Paid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Paid.Checked)
            {
                rbtn_Cancelled.Checked = false;
                rbtn_OnHold.Checked = false;
                rbtn_Completed.Checked = false;
                rbtn_Active.Checked = false;
                dateTime_ArrivalDate.Visible = false;
                lbl_arrivalDate.Visible = false;
                lbl_CancelDate.Visible = false;
                medt_CancelDate.Visible = false;
                medt_CancelDate.Text = string.Empty;
                lbl_paidDate.Visible = true;
                dateTime_PaidDate.Visible = true;
                dateTime_PaidDate.Value = DateTime.Now;
            }
        }

        private void rbtn_Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Completed.Checked)
            {
                rbtn_Cancelled.Checked = false;
                rbtn_OnHold.Checked = false;
                rbtn_Active.Checked = false;
                rbtn_Paid.Checked = false;
                dateTime_ArrivalDate.Visible = true;
                lbl_arrivalDate.Visible = true;
                lbl_CancelDate.Visible = false;
                medt_CancelDate.Visible = false;
                medt_CancelDate.Text = string.Empty;
                lbl_paidDate.Visible = false;
                dateTime_PaidDate.Visible = false;
                dateTime_PaidDate.Value = dateTime_PaidDate.MinDate;
            }
        }

        private void rbtn_OnHold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_OnHold.Checked)
            {
                rbtn_Cancelled.Checked = false;
                rbtn_Active.Checked = false;
                rbtn_Completed.Checked = false;
                rbtn_Paid.Checked = false;
                dateTime_ArrivalDate.Visible = false;
                lbl_arrivalDate.Visible = false;

                lbl_CancelDate.Visible = false;
                medt_CancelDate.Visible = false;
                medt_CancelDate.Text = string.Empty;
                lbl_paidDate.Visible = false;
                dateTime_PaidDate.Visible = false;
                dateTime_PaidDate.Value = dateTime_PaidDate.MinDate;
            }
        }

        private void rbtn_Cancelled_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Cancelled.Checked)
            {
                rbtn_Active.Checked = false;
                rbtn_OnHold.Checked = false;
                rbtn_Completed.Checked = false;
                rbtn_Paid.Checked = false;
                dateTime_ArrivalDate.Visible = false;
                lbl_arrivalDate.Visible = false;
                lbl_CancelDate.Visible = true;
                medt_CancelDate.Visible = true;
                medt_CancelDate.Text = DateTime.Now.ToString();
                lbl_paidDate.Visible = false;
                dateTime_PaidDate.Visible = false;
                dateTime_PaidDate.Value = dateTime_PaidDate.MinDate;
            }
        }
    }
}
