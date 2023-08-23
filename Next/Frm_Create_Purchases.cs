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
            edt_prodDiscCash.Controls[0].Visible = false;
            edt_billModel.Controls[0].Visible = false;
            edt_billNumber.Controls[0].Visible = false;
            edt_billSeries.Controls[0].Visible = false;
            edt_payCondId.Controls[0].Visible = false;
            medt_date.Text = DateTime.Now.ToString();
            dateTime_ArrivalDate.Text = DateTime.Today.ToString();
            dateTime_emissionDate.Text = DateTime.Today.ToString();
            User = user;
            SetUser(User);
        }

        private void SetUser(Users user)
        {
            edt_userId.Value = user.id;
            edt_userName.Text = user.name;
        }

        private readonly Users User;
        private readonly Products_Controller _pController = new Products_Controller();
        private readonly Purchases_Controller _controller = new Purchases_Controller();
        private readonly PurchaseItems_Controller _pIController = new PurchaseItems_Controller();
        private Purchases BackupPurchase = null;
        private bool ValidatedBill = true;

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
                    var prodDisc = Convert.ToDecimal(row.Cells["ProdDiscountCash"].Value);

                    var percFee = prodPurchPerc * transportFee;
                    var newUnCost = (percFee/100) + (prodNewBaseUnCost - prodDisc);
                    var weightedAverage = ((prodCurStock * prodCurCost) + ( prodQtd * newUnCost)) 
                                                    / (prodCurStock + prodQtd);
                    row.Cells["ProdWeightedAvg"].Value = Math.Round(weightedAverage,8);                   
                }
            }

        }

        public void AddProductToDGV() 
        {
            if (ValidatedBill)
            {
                ValidateBill();
            }
            if (ValidatedBill)
            {
                Products product = GetProduct();
                int amount = (int)edt_prodQtd.Value;
                decimal purchPerc = 0;
                decimal newUnCost = edt_prodUnCost.Value;
                decimal discountCash = edt_prodDiscCash.Value;
                bool validated = (discountCash < newUnCost);
                if (!FindEqualDGVProduct(product.id) && validated)
                {
                    DGV_PurchasesProducts.Rows.Add(
                        product.id,
                        product.productName,
                        amount,
                        product.productCost,
                        discountCash,
                        newUnCost,
                        product.salePrice,
                        product.stock,
                        purchPerc,
                        newUnCost
                        );
                }
                if (!validated)
                {
                    string message = "Desconto não pode ser maior que o valor do produto";
                    string caption = "Valor de desconto inválido.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    edt_prodDiscCash.Focus();
                }
                else
                {
                    CalculateSetDGVPurchasePerc();
                    CalculateSetNewUnCost();
                }
            }
        }

        private bool FindBill()
        {
            int bNum = (int)edt_billNumber.Value;
            int bMod = (int)edt_billModel.Value;
            int bSer = (int)edt_billSeries.Value;
            int supId = (int)edt_supplierId.Value;
            if (_controller.FindItemId(bMod, bNum, bSer, supId) != null)
            {
                ValidatedBill = true;
                return true;
            }
            else
            {
                ValidatedBill = false;
                return false;
            }
        }

        private void ValidateBill()
        {
            if (!FindBill())
            {
                gbox_billInfo.Enabled = false;
                gbox_supplier.Enabled = false;
            }
            else
            {
                string message = "Nota já cadastrada.";
                string caption = "Nota já cadastrada.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                gbox_billInfo.Focus();
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (edt_prodId.Value >= 1)
            {
                AddProductToDGV();
                SetSummary();
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
                        var billsToPay = BillsToPay.MakeBills(purchase, purchase.PaymentCondition);
                        if (billsToPay != null)
                        {
                            
                            status = _controller.SaveItem(purchase);
                            if (status)
                            {
                                foreach (PurchaseItems item in purchase.PurchasedItems)
                                {
                                    item.BillNumberId = purchase.BillNumber;
                                    item.BillModelId = purchase.BillModel;
                                    item.BillSeriesId = purchase.BillSeries;
                                    item.SupplierId = purchase.Supplier.id;
                                    status = _pIController.SaveItem(item);
                                    status = _pController.UpdatePriceNStock(item.Product.id, item.Quantity, item.WeightedCostAverage);
                                    if (!status)
                                    {
                                        break;
                                    }
                                }
                                if (status)
                                {
                                    var _billsToPayController = new BillsToPay_Controller();
                                    foreach (BillsToPay bill in billsToPay) 
                                    {
                                        status = _billsToPayController.SaveItem(bill);
                                        if (!status) { break; }
                                    }
                                }
                                if (status)
                                {
                                    Populated(false);
                                }
                            }
                        }
                        UnlockCamps();
                    }
                    else if (btn_new.Text == "Cancelar")
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


        private void SetFormToEdit()
        {
            var edit = "&Alterar";
            var del = "Apagar";
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
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            obj.PaymentCondition = _pCController.FindItemId(Convert.ToInt32(edt_payCondId.Value));
            obj.User = User;
            obj.Supplier = _sController.FindItemId( Convert.ToInt32(edt_supplierId.Value));
            obj.Freight_Cost = Convert.ToDouble(edt_transportFee.Value);
            obj.PurchasedItems = GetDGVList(obj.id);
            obj.EmissionDate = dateTime_emissionDate.Value;
            obj.ExtraExpenses = Convert.ToDouble(edt_extraExpenses.Value);
            obj.InsuranceCost = Convert.ToDouble(edt_insurance.Value);
            obj.ArrivalDate = dateTime_ArrivalDate.Value;
            obj.Status = 0;
            obj.BillNumber = Convert.ToInt32(edt_billNumber.Value);
            obj.BillModel = Convert.ToInt32(edt_billModel.Value);
            obj.BillSeries = Convert.ToInt32(edt_billSeries.Value);
            obj.Total_Cost = this.GetTotalCost(obj.PurchasedItems, obj.ExtraExpenses, obj.InsuranceCost);
            return obj;
        }

        private double GetTotalCost(List<PurchaseItems> purchasedItems, double extraExpenses, double insuranceCost)
        {
            var totalCost = extraExpenses + insuranceCost;
            decimal itemTotalCost = 0;
            foreach (var item in purchasedItems)
            {
                itemTotalCost += (item.Quantity * item.NewBaseUnCost) - item.DiscountCash;
            }
            return totalCost + Convert.ToDouble(itemTotalCost);
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
                item.DiscountCash = Convert.ToDecimal(row.Cells["ProdDiscountCash"].Value);
                item.NewBaseUnCost = Convert.ToDecimal(row.Cells["ProdNewBaseUnCost"].Value);
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
            gbox_billInfo.Enabled = false;
            gbox_options.Enabled = false;
        }

        private void UnlockCamps()
        {
            gbox_date.Enabled = true;
            gbox_options.Enabled = true;
            gbox_User.Enabled = true;
            gbox_products.Enabled = true;
            gbox_billInfo.Enabled = true;
            gbox_options.Enabled = true;
        }

        private void ClearCamps()
        {
            edt_billModel.Value = 0;
            edt_billNumber.Value = 0;
            edt_billSeries.Value = 0;
            edt_supplierId.Value = 0;
            edt_supplierName.Text = string.Empty;

            DGV_Instalments.Rows.Clear();
            DGV_PurchSummary.Rows.Clear();
            DGV_PurchasesProducts.Rows.Clear();

            edt_payCondId.Value = 0;
            edt_payCondName.Text = string.Empty;
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
            PopulatePaymentInfo(purchase);
        }

        private void PopulatePaymentInfo(Purchases purchase)
        {
            edt_billModel.Value = purchase.BillModel;
            edt_billNumber.Value = purchase.BillNumber;
            edt_billSeries.Value = purchase.BillSeries;
            edt_payCondId.Value = purchase.PaymentCondition.id;
            edt_payCondName.Text = purchase.PaymentCondition.conditionName;
        }

        private void PopulateStatusInfo(Purchases purchase)
        {
            edt_transportFee.Value = (decimal)purchase.Freight_Cost;
            edt_extraExpenses.Value = (decimal)purchase.ExtraExpenses;
            edt_insurance.Value = (decimal)purchase.InsuranceCost;
            dateTime_ArrivalDate.Text = purchase.ArrivalDate.ToShortDateString();
            dateTime_emissionDate.Text = purchase.EmissionDate.ToShortDateString();
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
                    item.DiscountCash,
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
                string message = "Lista de produtos devem ter ao menos 1 item.";
                string caption = "Lista de produtos está vazia.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (edt_supplierId.Value <= 0)
            {
                string message = "Compra deve possuir um fornecedor.";
                string caption = "Fornecedor não inserido.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (edt_billModel.Value == 0 | edt_billNumber.Value == 0 | edt_billSeries.Value == 0 | edt_payCondId.Value == 0)
            {
                string message = "Condição de pagamento deve ser inserida.";
                string caption = "Condição de pagamento inválida.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (dateTime_ArrivalDate.Value == dateTime_ArrivalDate.MinDate)
            {
                string message = "Data de entrada não foi selecionada.";
                string caption = "Data de entrada inválida.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (dateTime_emissionDate.Value == dateTime_emissionDate.MinDate)
            {
                string message = "Data de emissão não foi selecionada.";
                string caption = "Data de emissão inválida.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (dateTime_emissionDate.Value > DateTime.Today) 
            {
                string message = "Data de emissão não pode ser maior que hoje.";
                string caption = "Data de emissão inválida.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (dateTime_ArrivalDate.Value > DateTime.Today | dateTime_ArrivalDate.Value < dateTime_emissionDate.Value)
            {
                string message = "Data de entrada deve ser maior ou menor que a Data de Emissão.";
                string caption = "Data de entrada inválida.";
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
                _controller.DeleteItem(BackupPurchase.BillModel, BackupPurchase.BillNumber, BackupPurchase.BillSeries, BackupPurchase.Supplier.id);
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_FindPayCond_Click(object sender, EventArgs e)
        {
            SearchPaymentCondition();
        }

        public void SearchPaymentCondition()
        {
            Frm_Find_PaymentConditions formPayCondition = new Frm_Find_PaymentConditions();
            formPayCondition.hasFather = true;
            formPayCondition.ShowDialog();
            if (!formPayCondition.ActiveControl.ContainsFocus)
            {
                PaymentConditions payCondition = new PaymentConditions();
                payCondition = formPayCondition.GetObject();
                if (payCondition != null)
                {
                    edt_payCondName.Text = payCondition.conditionName;
                    edt_payCondId.Value = (decimal)payCondition.id;
                    SetBillInstalmentsToDGV(payCondition);
                }
            }
            formPayCondition.Close();
        }

        public void SetBillInstalmentsToDGV(PaymentConditions payCond) //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_Instalments.Rows.Clear();
            decimal totalCost = GetTotalCost();
            foreach (BillsInstalments bill in payCond.BillsInstalments)
            {
                decimal instalmentCost = totalCost * (Convert.ToDecimal(bill.ValuePercentage) / 100);
                DGV_Instalments.Rows.Add(
                    bill.InstalmentNumber.ToString(),
                    bill.TotalDays.ToString(),
                    bill.ValuePercentage.ToString(),
                    bill.PaymentMethod.paymentMethod,
                    instalmentCost
                    );
            }
        }

        private decimal GetTotalCost()
        {
            decimal totalCost = 0;
            if (DGV_PurchasesProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
                {
                    totalCost += Convert.ToDecimal(row.Cells["ProdQtd"].Value) * Convert.ToDecimal(row.Cells["ProdNewBaseUnCost"].Value);
                }
            }
            return totalCost;
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            SetSummary();
        }

        public void RemoveItem()
        {
            if (DGV_PurchasesProducts.Rows.Count > 0)
            {
                DGV_PurchasesProducts.Rows.Remove(DGV_PurchasesProducts.SelectedRows[0]);
            }
            if (DGV_PurchasesProducts.Rows.Count == 0)
            {
                gbox_billInfo.Enabled = true;
                gbox_supplier.Enabled = true;
            }
        }

        private void SetSummary()
        {
            DGV_PurchSummary.Rows.Clear();
            decimal subTotal = 0;
            decimal total = 0;
            decimal extra = edt_extraExpenses.Value;
            decimal insur = edt_insurance.Value;
            decimal transFee = edt_transportFee.Value;
            subTotal += GetTotalCost();
            total = subTotal + extra + insur + transFee;
            DGV_PurchSummary.Rows.Add(
                subTotal,
                total
                );
        }

        private void edt_transportFee_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
        }

        private void edt_extraExpenses_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
        }

        private void edt_insurance_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
        }
    }
}
