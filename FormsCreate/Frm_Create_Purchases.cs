﻿using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Authorization;
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
        public Frm_Create_Purchases()
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
            DGV_PurchasesProducts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_PurchasesProducts.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void SetUser(Users user)
        {
            edt_userId.Value = user.id;
            edt_userName.Text = user.userLogin;
            User = user;
        }

        public Users User { get; set; }
        private readonly Products_Controller _pController = new Products_Controller();
        private readonly Purchases_Controller _controller = new Purchases_Controller();
        private readonly PurchaseItems_Controller _pIController = new PurchaseItems_Controller();
        private Purchases BackupPurchase = null;
        private bool ValidatedBill = false;
        public string _cancelMotive { get; set; }

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
                    edt_prodUnd.Text = product.UND;
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
            decimal insurance = 0;
            decimal extraExp = 0;
            decimal transportFee = 0;
            if (edt_transportFee.Value > 0)
            {
                transportFee = edt_transportFee.Value;
            }
            if (edt_extraExpenses.Value > 0)
            {
                extraExp = edt_extraExpenses.Value;
            }
            if (edt_insurance.Value > 0)
            {
                insurance = edt_insurance.Value;
            }
            decimal totalCost = 1;
            if (DGV_PurchSummary.Rows[0].Cells["PurchTotal"].Value != null && (decimal)DGV_PurchSummary.Rows[0].Cells["PurchTotal"].Value > 0)
            {
                totalCost = Convert.ToDecimal(DGV_PurchSummary.Rows[0].Cells["PurchTotal"].Value);
            }

            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                if (row != null)
                {                                       
                    var product = _pController.FindItemId(Convert.ToInt32(row.Cells["ProdId"].Value));
                    int itemQtd = Convert.ToInt32(row.Cells["ProdQtd"].Value);
                    decimal originCost = product.stock * product.productCost;
                    decimal prodTotalCost = (decimal)row.Cells["ProdTotalValue"].Value;
                    decimal newCost = (decimal)row.Cells["ProdNewBaseUnCost"].Value;

                    decimal weight = prodTotalCost / totalCost;
                    decimal totalExtraRat = 0;
                    if (insurance == 0 && extraExp == 0 && transportFee == 0)
                    {
                        totalExtraRat = weight;
                    }
                    else
                    {
                        totalExtraRat = weight * (insurance + extraExp + transportFee);
                    }                    
                    decimal weightedAvg = newCost + (totalExtraRat / itemQtd);

                    row.Cells["ProdWeightedAvg"].Value = Math.Round(weightedAvg, 8);                   
                }
            }
        }


        public void AddProductToDGV()
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
                    product.UND,
                    amount,
                    discountCash,
                    newUnCost,
                    ((newUnCost * amount) - discountCash),
                    product.stock,
                    purchPerc,
                    newUnCost
                    );
                ClearProductCamps();
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

        private void ClearProductCamps()
        {
            edt_prodId.Value = 0;
            edt_prodDiscCash.Value = 0;
            edt_prodBarCode.Value = 0;
            edt_prodQtd.Value = 1;
            edt_prodTotal.Value = 0;
            edt_prodUnCost.Value = 0;
            edt_prodUnd.Text = string.Empty;
            edt_productName.Text = string.Empty;
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
                edt_billModel.Enabled = false;
                edt_billNumber.Enabled = false;
                edt_billSeries.Enabled = false;
                gbox_supplier.Enabled = false;
                gbox_products.Enabled = true;
                gbox_payCond.Enabled = true;
                gbox_info.Enabled = true;

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
            if (edt_prodId.Value > 1)
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
                            status = _controller.SaveItem(purchase, billsToPay);
                            if (status)
                            {
                                string caption = "Registro criado.";
                                string message = "Compra criada com sucesso";

                                MessageBoxIcon icon = MessageBoxIcon.Information;
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show(message, caption, buttons, icon);
                                Populated(false);
                            }
                        }
                        UnlockCamps();
                    }
                    else if (btn_new.Text == "Cancelar Compra")
                    {
                        if (CheckInstalmentsForCancel())
                        {
                            string caption = "Confirme o cancelamento.";
                            string message = "Deseja cancelar a compra?";

                            MessageBoxIcon icon = MessageBoxIcon.Question;
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
                            if (dialogResult == DialogResult.Yes)
                            {
                                purchase.CancelledDate = DateTime.Now.Date;
                                check_Active.Checked = false;
                                check_Cancelled.Checked = true;
                                status = _controller.CancelPurchase(purchase);
                                if (status)
                                {
                                    MessageBox.Show("Compra cancelada com sucesso.");
                                }
                            }
                            if (status)
                            {
                                LockCamps();
                            }
                        }
                        else
                        {
                            string caption = "Erro ao cancelar Compra.";
                            string message = "Uma ou mais parcelas já foram pagas, não é possível cancelar.";

                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons, icon);
                        }

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool CheckInstalmentsForCancel()
        {
            bool status = true;
            var obj = this.GetObject();
            BillsToPay_Controller btpController = new BillsToPay_Controller();
            var bills = btpController.FindItemId(obj.BillNumber, obj.BillModel, obj.BillSeries, obj.Supplier.id);
            if (bills != null)
            {
                foreach (var b in bills)
                {
                    if (b.PaidDate.HasValue || b.CancelledDate.HasValue)
                    {
                        status = false;
                    }
                }
            }
            if (!status)
            {
                string caption = "Erro ao cancelar Compra.";
                string message = "Uma ou mais parcelas já foram pagas, não é possível cancelar.";

                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
            }
            return status;
        }

        private void SetFormToEdit()
        {
            var edit = "Cancelar Compra";
            btn_new.Text = edit;
            lbl_new.Text = edit;
            btn_new.Enabled = true;
            btn_Close.Enabled = true;
            btn_Save.Enabled = false;
        }

        public virtual void Populated(bool populated)
        {
            if (populated)
            {
                this.LockCamps();
                this.SetFormToEdit();
                gbox_status.Enabled = false;
                gbox_supplier.Enabled = false;
            }
            else if (!populated)
            {
                this.UnlockCamps();
                this.ClearCamps();
                gbox_status.Enabled = true;
            }
        }

        private Purchases GetObject()
        {
            Purchases obj = new Purchases();
            Suppliers_Controller _sController = new Suppliers_Controller();
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            Users_Controller users_Controller = new Users_Controller();
            obj.PaymentCondition = _pCController.FindItemId(Convert.ToInt32(edt_payCondId.Value));
            obj.User = users_Controller.FindItemId(Convert.ToInt32(edt_userId.Value));
            obj.Supplier = _sController.FindItemId( Convert.ToInt32(edt_supplierId.Value));
            obj.Freight_Cost = Convert.ToDecimal(edt_transportFee.Value);

            obj.EmissionDate = dateTime_emissionDate.Value;
            obj.ExtraExpenses = Convert.ToDecimal(edt_extraExpenses.Value);
            obj.InsuranceCost = Convert.ToDecimal(edt_insurance.Value);
            obj.ArrivalDate = dateTime_ArrivalDate.Value;
            obj.Status = 0;
            obj.BillNumber = Convert.ToInt32(edt_billNumber.Value);
            obj.BillModel = Convert.ToInt32(edt_billModel.Value);
            obj.BillSeries = Convert.ToInt32(edt_billSeries.Value);
            obj.PurchasedItems = GetDGVList(obj.BillNumber, obj.BillModel, obj.BillSeries, obj.Supplier.id);
            obj.Total_Cost = this.GetTotalCost(obj.PurchasedItems, obj.ExtraExpenses, obj.InsuranceCost);
            obj.CancelledMotive = txt_cancelMot.Text;
            return obj;
        }

        private decimal GetTotalCost(List<PurchaseItems> purchasedItems, decimal extraExpenses, decimal insuranceCost)
        {
            var totalCost = extraExpenses + insuranceCost;
            decimal itemTotalCost = 0;
            foreach (var item in purchasedItems)
            {
                itemTotalCost += (item.Quantity * item.NewBaseUnCost) - item.DiscountCash;
            }
            return totalCost + itemTotalCost;
        }

        public List<PurchaseItems> GetDGVList(int billNum, int billMod, int bSer, int supId)
        {
            var list = new List<PurchaseItems>();
            foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
            {
                PurchaseItems item = new PurchaseItems();
                item.BillNumberId = billNum;
                item.BillModelId = billMod;
                item.BillSeriesId = supId;
                item.SupplierId = supId;
                item.Product = _pController.FindItemId(Convert.ToInt32(row.Cells["ProdId"].Value));
                item.PreUnCost = item.Product.productCost;
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
            btn_new.Enabled = false;
            btn_findSupplier.Enabled = false;
            btn_Save.Enabled = false;
            btn_Close.Enabled = false;
            gbox_User.Enabled = false;
            gbox_products.Enabled = false;
            gbox_billInfo.Enabled = false;
            gbox_info.Enabled = false;
            btn_Save.Enabled = false;
            btn_new.Enabled = false;
            btn_FindSup.Enabled = false;
            btn_findSupplier.Enabled = false;
            gbox_cancelReason.Enabled = false;
            txt_cancelMot.Enabled = false;
        }

        private void UnlockCamps()
        {
            gbox_info.Enabled = true;
            gbox_date.Enabled = true;
            btn_new.Enabled = true;
            btn_findSupplier.Enabled = true;
            btn_Save.Enabled = true;
            btn_Close.Enabled = true;
            gbox_User.Enabled = true;
            gbox_products.Enabled = true;
            gbox_billInfo.Enabled = true;
            btn_Save.Enabled = true;
            btn_new.Enabled = true;
            btn_FindSup.Enabled = true;
            btn_findSupplier.Enabled = true;
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
            DGV_PurchSummary.Rows.Add(0, 0);
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
            edt_insurance.Value = 0;
        }

        public void PopulateCamps(Purchases purchase)
        {
            Populated(true);
            SetFormToEdit();
            PopulateDGV(purchase);
            PopulateSupplier(purchase.Supplier);
            PopulateStatusInfo(purchase);
            PopulatePaymentInfo(purchase);

            PaymentConditions_Controller payCondController = new PaymentConditions_Controller();
            var payCond = payCondController.FindItemId(Convert.ToInt32(edt_payCondId.Value));
            SetBillInstalmentsToDGV();
            SetSummary(); 
            if (purchase.CancelledDate.HasValue)
            {
                SetFormToCancelled(purchase.CancelledMotive);
                LockCamps();
            }
        }

        private void SetFormToCancelled(string motive)
        {
            LockCamps();
            btn_new.Enabled = true;
            btn_new.Visible = false;
            gbox_supplier.Enabled = false;
            gbox_cancelReason.Visible = true;
            gbox_cancelReason.Enabled = false;
            txt_cancelMot.Text = motive;
        }

        public void PopulatePaymentCondition(PaymentConditions payCondition)
        {
            edt_payCondId.Value = payCondition.id;
            edt_payCondName.Text = payCondition.conditionName;
            SetBillInstalmentsToDGV();
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
                    item.Product.id,
                    item.Product.productName,
                    item.Product.UND,
                    item.Quantity,
                    item.DiscountCash,
                    item.NewBaseUnCost,
                    item.NewBaseUnCost * item.Quantity,
                    item.PurchasePercentage,
                    item.WeightedCostAverage
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
            else if (check_Cancelled.Checked && ValidateCancelMotive())
            {
                return true;
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
                    PopulatePaymentCondition(supplier.PaymentCondition);
                }
            }
            formSuppliers.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (btn_new.Text != "Cancelar Compra")
            {
                ClearCamps();
            }
            else
            {
                if (Authentication.Authenticate(User.AccessLevel, 3))
                {
                    if (gbox_cancelReason.Visible == false && CheckInstalmentsForCancel())
                    {
                        gbox_cancelReason.Visible = true;
                        gbox_cancelReason.Enabled = true;
                        txt_cancelMot.Enabled = true;
                        MessageBox.Show("Digite o motivo de cancelamento.");
                    }
                    else if (gbox_cancelReason.Visible == true)
                    {
                        if (txt_cancelMot.Text.Trim().Length > 5)
                        {
                            Save();
                        }
                        else 
                        {
                            MessageBox.Show("Motivo de cancelamento deve ter mais de 5 caracteres.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não possui autorização para cancelar compras.");
                }
            }
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
                    SetBillInstalmentsToDGV();
                }
            }
            formPayCondition.Close();
        }

        public void SetBillInstalmentsToDGV()
        {
            DGV_Instalments.Rows.Clear();
            if (edt_billModel.Value > 0)
            {
                decimal totalCost = GetTotalCost();
                PaymentConditions_Controller payCondController = new PaymentConditions_Controller();
                var payCond = payCondController.FindItemId(Convert.ToInt32(edt_payCondId.Value));
                foreach (BillsInstalments bill in payCond.BillsInstalments)
                {
                    decimal instalmentCost = (totalCost * bill.ValuePercentage) / 100;
                    DGV_Instalments.Rows.Add(
                        bill.InstalmentNumber.ToString(),
                        bill.TotalDays.ToString(),
                        bill.ValuePercentage.ToString(),
                        bill.PaymentMethod.paymentMethod,
                        instalmentCost.ToString("#.##")
                        );
                }
            }
        }

        private decimal GetTotalCost()
        {
            decimal totalCost = 0;
            if (DGV_PurchasesProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
                {
                    totalCost += Convert.ToDecimal(row.Cells["ProdTotalValue"].Value);
                }
                if (edt_extraExpenses.Value > 0)
                {
                    totalCost += edt_extraExpenses.Value;
                }
                if (edt_insurance.Value > 0)
                {
                    totalCost += edt_insurance.Value;
                }
                if (edt_transportFee.Value > 0)
                {
                    totalCost += edt_transportFee.Value;
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
                gbox_supplier.Enabled = true;
                edt_billSeries.Enabled = true;
                edt_billNumber.Enabled = true;
                edt_billModel.Enabled = true;
                gbox_products.Enabled = false;
                gbox_payCond.Enabled = false;
                gbox_billInfo.Enabled = false;
            }
        }

        private void SetSummary()
        {
            DGV_PurchSummary.Rows.Clear();
            decimal extra = edt_extraExpenses.Value;
            decimal insur = edt_insurance.Value;
            decimal transFee = edt_transportFee.Value;
            decimal subTotal = GetSubTotal();
            decimal total = GetTotalCost();
            DGV_PurchSummary.Rows.Add(
                subTotal,
                total
                );
        }

        private decimal GetSubTotal()
        {
            decimal subTotal = 0;
            if (DGV_PurchasesProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_PurchasesProducts.Rows)
                {
                    subTotal = (decimal)row.Cells["ProdTotalValue"].Value;
                }
            }
            return subTotal;
        }

        private void edt_transportFee_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();
        }

        private void edt_extraExpenses_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();
        }

        private void edt_insurance_ValueChanged(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Cancelled.Checked = false;
                medt_CancelDate.Text = string.Empty;
                gbox_cancelReason.Visible = false;
            }
        }

        private void check_Cancelled_CheckedChanged(object sender, EventArgs e)
        {
            if ( check_Cancelled.Checked)
            {
                check_Active.Checked = false;
                medt_CancelDate.Text = DateTime.Now.ToString();
                gbox_cancelReason.Visible = true;
            }
        }

        private bool ValidateCancelMotive()
        {
            if (txt_cancelMot.Text == string.Empty || txt_cancelMot.Text.Length < 5)
            {
                string message = "Motivo de cancelamento deve ser inserido com o mínimo de 5 caractéres.";
                string caption = "Item obrigatório.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            _cancelMotive = txt_cancelMot.Text;
            return true;
        }

        private void gbox_supplier_Leave(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0 
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }

        private void edt_prodUnCost_Leave(object sender, EventArgs e)
        {
            CalcProdTotal();
        }

        private void CalcProdTotal()
        {
            if (edt_prodQtd.Value > 0 && edt_prodUnCost.Value > 0)
            {
                edt_prodTotal.Value = edt_prodQtd.Value * edt_prodUnCost.Value;
            }
        }

        private void edt_prodQtd_Leave(object sender, EventArgs e)
        {
            CalcProdTotal();
        }

        private void gbox_cancelReason_Leave(object sender, EventArgs e)
        {
            ValidateCancelMotive();
        }

        private void btn_checkBill_Click(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }

        private void edt_transportFee_Leave(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();

        }

        private void edt_insurance_Leave(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();
        }

        private void edt_extraExpenses_Leave(object sender, EventArgs e)
        {
            SetSummary();
            CalculateSetNewUnCost();
            SetBillInstalmentsToDGV();
        }

        private void edt_billNumber_Leave(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }

        private void edt_billModel_Leave(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }

        private void edt_billSeries_Leave(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }

        private void gbox_billInfo_Leave(object sender, EventArgs e)
        {
            if (edt_billModel.Value != 0
                && edt_billNumber.Value != 0
                && edt_billSeries.Value != 0
                && edt_supplierId.Value != 0)
            {
                ValidateBill();
            }
        }
    }
}
