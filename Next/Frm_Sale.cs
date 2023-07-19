using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms
{
    public partial class Frm_Sale : Form
    {
        public Frm_Sale(Users user)
        {
            InitializeComponent();
            medt_date.Text = DateTime.Now.ToString();
            edt_userId.Controls[0].Visible = false;
            edt_clientId.Controls[0].Visible = false;
            edt_UNCost.Controls[0].Visible = false;
            edt_amount.Controls[0].Visible = false;
            edt_subtotal.Controls[0].Visible = false;
            edt_discountPerc.Controls[0].Visible = false;
            edt_discountCash.Controls[0].Visible = false;
            edt_barCode.Controls[0].Visible = false;
            edt_payConditionDiscount.Controls[0].Visible = false;
            edt_payConditionFees.Controls[0].Visible = false;
            edt_payConditionFine.Controls[0].Visible = false;
            edt_payConditionQnt.Controls[0].Visible = false;
            edt_payConditionId.Controls[0].Visible = false;
            edt_productId.Controls[0].Visible = false;
            edt_UNCost.Controls[0].Visible = false;
            edt_ProdDiscCash.Controls[0].Visible = false;
            edt_ProdDiscPerc.Controls[0].Visible = false;
            edt_ProdUnValue.Controls[0].Visible = false;
            edt_totalPValue.Controls[0].Visible = false;
            SetUser(user);
        }

        public Sales Sale { get; private set; }
        private Sales BackupSale = new Sales();
        private Products product = null;
        private Products_Controller _pController = new Products_Controller();
        private Sales_Controller _controller = new Sales_Controller();
        private BillsToReceive_Controller _BTRController = new BillsToReceive_Controller();
        //private BillsInstalments_Controller _billsController = null;

        private void SetSale(Sales sale)
        {
            Sale = sale;
        }

        private void SetUser(Users user)
        {
            edt_userId.Value = user.id;
            edt_userName.Text = user.name;
        }

        public void NewSale() //Limpa todos campos exceto User
        {
            medt_date.Text = DateTime.Now.ToString();
            edt_clientId.Value = 0;
            edt_clientName.Text = string.Empty;
            medt_registrationNumber.Text = string.Empty;

            edt_productId.Value = 0;
            edt_productName.Text = string.Empty;
            edt_UNCost.Value = 0;
            edt_totalPValue.Value = 0;
            edt_amount.Value = 1;

            edt_subtotal.Value = 0;
            edt_discountPerc.Value = 0;
            edt_totalPValue.Value = 0;

            edt_payCondition.Text = string.Empty;
            edt_payConditionDiscount.Value = 0;
            edt_payConditionFees.Value = 0;
            edt_payConditionFine.Value = 0;
            edt_payConditionId.Value = 0;
            edt_payConditionQnt.Value = 0;

            DGV_SaleProducts.Rows.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (btn_new.Text == "F5")
            {
                NewSale();
            }
            else if (btn_new.Text == "&Edit")
            {
                BackupSale = Sale;
                BackupSale.dateOfCreation = Convert.ToDateTime(medt_date.Text);
                UnlockCamps();
                btn_CancelSale.Visible = true;
                btn_new.Text = "Cancel";
                lbl_new.Text = "Cancel";
                btn_Save.Enabled = true;
                btn_FindClient.Enabled = true;
            }
            else if (btn_new.Text == "Cancel")
            {
                LockCamps();
                SetFormToEdit();
                PopulateCamps(BackupSale);
                btn_CancelSale.Visible = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

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
                    edt_productId.Value = product.id;
                    edt_productName.Text = product.productName;
                    edt_productName.Text = product.productName;
                    edt_barCode.Value = product.BarCode;
                    edt_UNCost.Value = (decimal)product.productCost;
                    edt_ProdUnValue.Value = (decimal)product.salePrice;
                    edt_totalPValue.Value = edt_ProdUnValue.Value;
                }
            }
            formProducts.Close();
        }

        public void SearchClient() // Abre Form para encontrar e levar Cliente
        {
            Frm_Find_Clients formClient = new Frm_Find_Clients();
            formClient.hasFather = true;
            formClient.ShowDialog();
            if (!formClient.ActiveControl.ContainsFocus)
            {
                Clients client = new Clients();
                client = formClient.GetObject();
                if (client != null)
                {
                    edt_clientId.Value = client.id;
                    edt_clientName.Text = client.name;
                    if (client.clientType == 2)
                    {
                        medt_registrationNumber.Mask = "00.000.000/0000.00";
                    }
                    else
                    {
                        medt_registrationNumber.Mask = "000.000.000-00";
                    }
                    medt_registrationNumber.Text = client.registrationNumber;
                }
            }
            formClient.Close();
        }

        public bool CheckEqualDGVProduct(int prodId, int amount, decimal discountCash, decimal discountPerc, decimal totalValue)
        {
            foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
            {
                if ((int)row.Cells[0].Value == prodId)
                {
                    if ((decimal)row.Cells["ItemDiscountCash"].Value == discountCash &&
                        (decimal)row.Cells["ItemDiscountPerc"].Value == discountPerc)
                    {
                        row.Cells["QuantityProduct"].Value = (int)row.Cells["QuantityProduct"].Value + amount;
                        row.Cells["ProductTotalValue"].Value = (decimal)row.Cells["ProductTotalValue"].Value + totalValue;
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddProductToDGV() //Pega obj produto e popula na DGV e chama CalculateSubTotal
        {
            Products product = GetProduct();
            int amount = (int)edt_amount.Value;
            decimal discountCash = (decimal)edt_ProdDiscCash.Value;
            decimal discountPerc = (decimal)edt_ProdDiscPerc.Value;
            decimal totalValue = (decimal)edt_totalPValue.Value;

            if (!CheckEqualDGVProduct(product.id, amount, discountCash, discountPerc, totalValue))
            {
                DGV_SaleProducts.Rows.Add(
                    product.id,
                    product.productName,
                    amount,
                    product.productCost,
                    discountCash,
                    discountPerc,
                    product.salePrice,
                    totalValue);
            }

            CalculateSubTotal();
        }

        public void UpdateDGVSummary()
        {
            if (DGV_SaleSummary.Rows.Count == 0)
            {
                DGV_SaleSummary.Rows.Add();
            }
            if (DGV_SaleSummary.Rows.Count == 1)
            {
                DGV_SaleSummary.Rows[0].Cells["SaleSubTotal"].Value = edt_subtotal.Value;
                DGV_SaleSummary.Rows[0].Cells["SaleDiscCash"].Value = edt_discountCash.Value;
                DGV_SaleSummary.Rows[0].Cells["SaleDiscPerc"].Value = edt_discountPerc.Value;
                DGV_SaleSummary.Rows[0].Cells["SaleTotal"].Value = edt_total.Value;
            }

        }

        public void CalculateSubTotal() //Percorre a DGV, calculando o valor total de cada item, adicionando no Sub-Total
        {
            decimal subtotal = 0;
            if (DGV_SaleProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
                {
                    subtotal += Convert.ToDecimal(row.Cells["ProductTotalValue"].Value);
                }
                edt_subtotal.Value = subtotal;
                UpdateDGVSummary();
            }
            else
            {
                ClearSummary();
            }
        }

        private void ClearSummary()
        {
            edt_subtotal.Value = 0;
            edt_discountCash.Value = 0;
            edt_discountPerc.Value = 0;
            edt_total.Value = 0;
            UpdateDGVSummary();
        }

        public bool CheckProductCamps() //Checa se os campos do produto estão vazios
        {
            if (edt_productId.Value <= 1)
            {
                return false;
            }
            else if (edt_barCode.Value <= 1)
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(edt_productName.Text))
            {
                return false;
            }
            return true;
        }

        public void SearchProduct() //tenta procurar produto por ID->Nome, se achar, chama PopulateProduct
        {
            if (edt_productId.Value >= 1)
            {
                product = SearchItemById();
                if (product != null)
                {
                    PopulateProduct(product);
                }
                else if (!String.IsNullOrWhiteSpace(edt_productName.Text))
                {
                    product = SearchItemByName();
                    if (product != null)
                    {
                        PopulateProduct(product);
                    }
                }
            }
        }

        private DataGridViewRow GetSelectLastProdRow()
        {
            DataGridViewRow row = null;
            if (DGV_SaleProducts.Rows.Count == 1)
            {
                DGV_SaleProducts.Rows[0].Selected = true;
                row = DGV_SaleProducts.Rows[0];
            }
            else if (DGV_SaleProducts.Rows.Count > 0 && DGV_SaleProducts.Rows.Count > 1)
            {
                var rowIndex = DGV_SaleProducts.Rows.Count - 1;
                DGV_SaleProducts.Rows[rowIndex].Selected = true;
                row = DGV_SaleProducts.Rows[rowIndex];
            }
            return row;
        }

        private void btn_FindProduct_Click(object sender, EventArgs e) 
        {                  
            //if (!CheckProductCamps())                                     
            //{
                NewFormSearchProduct();
            //}
            //else if (edt_productId.Value > 0)
            //{

            //    if (Convert.ToInt32(edt_productId.Value) == (Convert.ToInt32(GetSelectLastProdRow().Cells["IdProduct"].Value)))
            //    {
            //        NewFormSearchProduct();
            //    }
            //    else
            //    {
            //        SearchProduct();
            //    }
            //}
        }

        public void PopulateProduct(Products prod) //Popula campos do produto
        {
            edt_productId.Value = prod.id;
            edt_productName.Text = prod.productName;
            edt_UNCost.Value = (decimal)prod.productCost;
            edt_ProdUnValue.Value = (decimal)prod.salePrice;
            CalcTotalProdValue();
            UpdateDGVSummary();
        }

        private Products SearchItemByName()
        {
            try
            {
                return _pController.FindItemName(edt_productName.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Products SearchItemById()
        {
            try
            {
                return _pController.FindItemId(Convert.ToInt32(edt_productId.Value));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Products SearchItemByBarCode()
        {
            try
            {
                return _pController.FindItemBarCode(Convert.ToInt64(edt_barCode.Value));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CalculateFinalPrice() //Calcula valor total com desconto % e $
        {
            decimal value = 0;
            value = edt_subtotal.Value - (edt_discountCash.Value);
            value = value - (value * (edt_discountPerc.Value / 100));
            edt_total.Value = value;
        }

        public bool ConfirmSale(Sales sale) //To do: Abre form de adicionar condição de pagamento para completar a venda
        {
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            PaymentConditions obj = _pCController.FindItemId(sale.PaymentConditionId);
            string caption = "Confirm sale.";
            string message = "Client : "
                             + sale.Client.name
                             + Environment.NewLine
                             + "Payment Condition : "
                             + obj.conditionName
                             + Environment.NewLine
                             + "Sub-Total : "
                             + edt_subtotal.Value.ToString()
                             + Environment.NewLine
                             + "Discount % : "
                             + sale.SaleDiscountPerc.ToString()
                             + Environment.NewLine
                             + "Discount $ : "
                             + sale.SaleDiscountCash.ToString()
                             + Environment.NewLine
                             + "Final Sale Cost : "
                             + edt_total.Value.ToString()
                             + Environment.NewLine
                             + "Do you confirm the sale?";

            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        public void HotkeyPressed(KeyPressEventArgs e) //Faz açoes de hotkeys F5 F7 F10
        {
            if (e.KeyChar == (char)116) //F5
            {
                NewSale();
            }
            else if (e.KeyChar == (char)118) //F7
            {
                SearchClient();
            }
            else if (e.KeyChar == (char)121) //F10
            {
                Save();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            SearchClient();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (edt_productId.Value >= 1)
            {
                AddProductToDGV();
            }
        }

        private void btn_FindClient_Click(object sender, EventArgs e)
        {
            SearchClient();
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
                    edt_payCondition.Text = payCondition.conditionName;
                    edt_payConditionDiscount.Value = (decimal)payCondition.discountPerc;
                    edt_payConditionFees.Value = (decimal)payCondition.paymentFees;
                    edt_payConditionFine.Value = (decimal)payCondition.fineValue;
                    edt_payConditionQnt.Value = payCondition.instalmentQuantity;
                    edt_payConditionId.Value = payCondition.id;
                    SetBillInstalmentsToDGV(payCondition.id);
                }
            }
            formPayCondition.Close();
        }

        public void SetBillInstalmentsToDGV(int condId) //OK -Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            PaymentConditions_Controller pCController = new PaymentConditions_Controller();
            PaymentMethods_Controller pMController = new PaymentMethods_Controller();
            DGV_Instalments.Rows.Clear();
            var obj = pCController.FindItemId(condId).BillsInstalments;
            foreach (BillsInstalments bill in obj)
            {
                string method = pMController.FindItemId(Convert.ToInt32(bill.PaymentMethod.id)).paymentMethod;
                DGV_Instalments.Rows.Add(
                    bill.InstalmentNumber.ToString(),
                    bill.TotalDays.ToString(),
                    bill.ValuePercentage.ToString(),
                    method
                    );
            }
        }

        public void PopulateBillsDGV(List<BillsInstalments> bills)
        {
            DGV_Instalments.Rows.Clear();
            int i = 0;
            if (bills != null)
            {
                foreach (BillsInstalments item in bills)
                {
                    DGV_Instalments.Rows.Add();
                    DGV_Instalments.Rows[i].Cells["InstalmentNumber"].Value = item.InstalmentNumber.ToString();
                    DGV_Instalments.Rows[i].Cells["IntalmentDays"].Value = item.TotalDays.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentPercentage"].Value = item.ValuePercentage.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentPayMethod"].Value = item.PaymentMethod.paymentMethod.ToString();
                    i++;
                }
            }
        }

        private void Frm_Sale_KeyPress(object sender, KeyPressEventArgs e)
        {
            HotkeyPressed(e);
        }

        private void edt_subtotal_ValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void edt_discountPerc_ValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void edt_discountCash_ValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void DGV_SaleProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateSubTotal();
        }

        private void btn_SearchPayCondition_Click(object sender, EventArgs e)
        {
            SearchPaymentCondition();
        }

        private void edt_discountPerc_Leave(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void edt_barCode_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Save() // Save
        {
            bool status = true;
            if (CheckCamps())
            {
                LockCamps();
                Sales sale = this.GetObject();
                try
                {
                    if (btn_new.Text == "F5")
                    {
                        if (ConfirmSale(sale))
                        {
                            status = _controller.SaveItem(sale);
                            if (status)
                            {
                                List<BillsToReceive> billsToReceiveList = new List<BillsToReceive>();
                                billsToReceiveList = BillsToReceive.MakeBills(sale);
                                foreach (BillsToReceive bill in billsToReceiveList)
                                {
                                    status = _BTRController.SaveItem(bill);
                                    if (!status)
                                    {
                                        break;
                                    }
                                }
                                if (status)
                                {
                                    Populated(false);
                                }
                            }
                        }
                    }
                    else if (btn_new.Text == "Cancel")
                    {
                        status = _controller.UpdateItem(sale);
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

        public void DeleteObject()
        {
            LockCamps();
            try
            {
                _controller.DeleteItem(BackupSale.id);
                this.ClearCamps();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Sales GetObject()
        {
            DateTime emissionDate = DateTime.Now;
            Sales sale = new Sales();
            int idSale = _controller.BringNewId();

            sale.User = this.GetUser();
            sale.Client = this.GetClient();
            sale.CancelDate = null;
            sale.TotalValue = (double)edt_total.Value;
            sale.PaymentConditionId = (int)edt_payConditionId.Value;
            sale.CancelDate = null;

            sale.SaleItems = this.GetSaleItems(idSale);
            sale.TotalCost = this.GetTotalCost(sale.SaleItems);
            sale.SaleDiscountPerc = (double)edt_discountPerc.Value;
            sale.SaleDiscountCash = (double)edt_discountCash.Value;
            sale.TotalItemsQuantity = DGV_SaleProducts.Rows.Count;

            return sale;
        }

        private double GetTotalCost(List<SaleItems> list)
        {
            double totalCost = 0;
            foreach (SaleItems item in list)
            {
                totalCost += item.ProductCost;
            }
            return totalCost;
        }

        private List<SaleItems> GetSaleItems(int idSale)
        {
            List<SaleItems> list = new List<SaleItems>();
            SaleItems saleItem = new SaleItems();
            foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
            {
                saleItem.id = idSale;
                saleItem.Product = _pController.FindItemId((int)row.Cells["IdProduct"].Value);
                saleItem.Quantity = Convert.ToInt32(row.Cells["QuantityProduct"].Value);
                saleItem.ProductValue = Convert.ToDouble(row.Cells["UnValueProduct"].Value);
                saleItem.TotalValue = Convert.ToDouble(row.Cells["ProductTotalValue"].Value);
                saleItem.ProductCost = Convert.ToDouble(row.Cells["ProductCost"].Value);
                saleItem.ItemDiscountCash = Convert.ToDouble(row.Cells["ItemDiscountCash"].Value);
                saleItem.ItemDiscountPerc = Convert.ToDouble(row.Cells["ItemDiscountPerc"].Value);

                list.Add(saleItem);
            }
            return list;
        }

        private List<BillsToReceive> GetBillToReceive(double totalValue, DateTime emissionDate) //To do??
        {
            List<BillsToReceive> list = new List<BillsToReceive>();
            BillsToReceive bill = new BillsToReceive();
            Clients client = this.GetClient();
            PaymentConditions Condition = GetCondition();
            int instalQtd = Condition.BillsInstalments.Count;
            int num = 1;
            foreach (BillsInstalments instalment in Condition.BillsInstalments)
            {
                bill.PaymentMethod = instalment.PaymentMethod;
                bill.IsPaid = false;
                bill.Client = client;
                bill.dateOfCreation = emissionDate;
                bill.DueDate = emissionDate.AddDays(instalment.TotalDays);
                bill.InstalmentNumber = num;
                bill.InstalmentsQtd = instalQtd;
                bill.InstalmentValue = instalment.ValuePercentage * totalValue;
                list.Add(bill);
                num++;
            }
            return list;
        }

        private PaymentConditions GetCondition()
        {
            PaymentConditions_Controller pController = new PaymentConditions_Controller();
            return pController.FindItemId((int)edt_payConditionId.Value);
        }

        private Products GetProduct()
        {
            if (edt_productId.Value >= 1)
            {
                return _pController.FindItemId((int)edt_productId.Value);
            }
            else return null;
        }

        private Clients GetClient()
        {
            if (edt_clientId.Value >= 2)
            {
                Clients_Controller cControler = new Clients_Controller();
                return cControler.FindItemId((int)edt_clientId.Value);
            }
            else return null;
        }

        private Users GetUser()
        {
            Users_Controller uController = new Users_Controller();
            return uController.FindItemId((int)edt_userId.Value);
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

        public void SetFormToEdit()
        {
            var edit = "&Edit";
            var del = "Delete";
            btn_new.Text = edit;
            lbl_new.Text = edit;
            btn_new.Enabled = true;
            btn_Save.Enabled = false;
            btn_FindClient.Enabled = false;
            btn_FindClient.Text = del;
            lbl_findClient.Text = del;
        }

        public void PopulateCamps(Sales sale)
        {
            Populated(true);
            SetFormToEdit();
            PopulateUser(sale);
            PopulateClient(sale);
         //   PopulatePaymentCondition(sale);
            PopulateDGV(sale);
            PopulateSummary(sale);
            PopulateDate(sale);
        }

        public void PopulateDate(Sales sale)
        {
            medt_date.Text = sale.dateOfCreation.ToString();
            if (sale.CancelDate != null)
            {
                medt_date.Visible = true;
                lbl_CancelDate.Visible = true;
                medt_CancelDate.Text = sale.CancelDate.ToString();
            }
        }

        public void PopulateSummary(Sales sale)
        {
            edt_discountPerc.Value = (decimal)sale.SaleDiscountPerc;
            edt_discountCash.Value = (decimal)sale.SaleDiscountCash;
            edt_total.Value = (decimal)sale.TotalValue;
            edt_subtotal.Value = (decimal)(sale.TotalValue + (sale.SaleDiscountCash) + (sale.SaleDiscountPerc * sale.TotalValue));
        }

        public void PopulateClient(Sales sale)
        {
            edt_clientId.Value = sale.Client.id;
            edt_clientName.Text = sale.Client.name;
            medt_registrationNumber.Text = sale.Client.registrationNumber;
        }

        public void PopulatePaymentCondition(Sales sale)
        {
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            PaymentConditions obj = _pCController.FindItemId(sale.PaymentConditionId);
            edt_payCondition.Text = obj.conditionName;
            edt_payConditionDiscount.Value = (decimal)obj.discountPerc;
            edt_payConditionFees.Value = (decimal)obj.paymentFees;
            edt_payConditionFine.Value = (decimal)obj.fineValue;
            edt_payConditionId.Value = (decimal)obj.id;
            edt_payConditionQnt.Value = (decimal)obj.instalmentQuantity;
        }

        public void PopulateUser(Sales sale)
        {
            edt_userId.Value = sale.User.id;
            edt_userName.Text = sale.User.name;
        }

        public void PopulateDGV(Sales sale)
        {
            DGV_SaleProducts.Rows.Clear();
            foreach (SaleItems item in sale.SaleItems)
            {
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(DGV_SaleProducts);
                //row.Cells["IdProduct"].Value = item.Product.id;
                //row.Cells["NameProduct"].Value = item.Product.productName;
                //row.Cells["ProductCost"].Value = item.ProductCost;
                //row.Cells["QuantityProduct"].Value = item.Quantity;
                //row.Cells["ItemDiscountCash"].Value = item.ItemDiscountCash;
                //row.Cells["ItemDiscountPerc"].Value = item.ItemDiscountPerc;
                //row.Cells["UnValueProduct"].Value = item.ProductValue;
                //row.Cells["ProductTotalValue"].Value = item.ProductValue * item.Quantity;
                //DGV_SaleProducts.Rows.Add(row);
                var totalValue = item.ProductValue * item.Quantity;
                DGV_SaleProducts.Rows.Add(
                    item.Product.id,
                    item.Product.productName,
                    item.Product.productCost,
                    item.Quantity,
                    item.ItemDiscountCash,
                    item.ItemDiscountPerc,
                    item.ProductValue,
                    totalValue
                    );
            }
        }

        private void ClearCamps()
        {
            edt_amount.Value = 0;
            edt_barCode.Value = 0;
            edt_discountCash.Value = 0;
            edt_discountPerc.Value = 0;
            edt_productId.Value = 0;
            edt_productName.Text = string.Empty;
            edt_UNCost.Value = 0;
            edt_clientId.Value = 0;
            edt_clientName.Text = string.Empty;
            medt_registrationNumber.Text = string.Empty;
            edt_payCondition.Text = string.Empty;
            edt_payConditionFees.Text = string.Empty;
            edt_payConditionFine.Text = string.Empty;
            edt_payConditionId.Value = 0;
            medt_date.Text = DateTime.Now.ToString();
            DGV_SaleProducts.Rows.Clear();
        }

        private void UnlockCamps()
        {
            edt_amount.Enabled = true;
            edt_barCode.Enabled = true;
            edt_discountCash.Enabled = true;
            edt_discountPerc.Enabled = true;
            edt_productId.Enabled = true;
            edt_productName.Enabled = true;
            edt_UNCost.Enabled = true;
            DGV_SaleProducts.Enabled = true;
            btn_FindProduct.Enabled = true;
            btn_AddProduct.Enabled = true;
            btn_FindClient.Enabled = true;
            btn_SearchPayCondition.Enabled = true;
            btn_new.Enabled = true;
            btn_Save.Enabled = true;
            btn_Close.Enabled = true;
        }

        private void LockCamps()
        {
            edt_amount.Enabled = false;
            edt_barCode.Enabled = false;
            edt_discountCash.Enabled = false;
            edt_discountPerc.Enabled = false;
            edt_productId.Enabled = false;
            edt_productName.Enabled = false;
            edt_UNCost.Enabled = false;
            DGV_SaleProducts.Enabled = false;
            btn_FindProduct.Enabled = false;
            btn_AddProduct.Enabled = false;
            btn_FindClient.Enabled = false;
            btn_SearchPayCondition.Enabled = false;
            btn_new.Enabled = false;
            btn_Save.Enabled = false;
            btn_Close.Enabled = false;
        }

        private bool CheckCamps()
        {

            if (DGV_SaleProducts.Rows.Count == 0)
            {
                string message = "Sale must contain at least 1 item.";
                string caption = "Sale items is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            //else if (edt_payConditionId.Value <= 1)
            //{
            //    string message = "Payment Condition must be selected.";
            //    string caption = "Payment Condition not selected.";
            //    MessageBoxButtons buttons = MessageBoxButtons.OK;
            //    MessageBoxIcon icon = MessageBoxIcon.Error;
            //    Utilities.Msgbox(message, caption, buttons, icon);
            //    return false;
            //}
            else if (edt_subtotal.Value < 0)
            {
                string message = "Sub-Total must be 0 or higher.";
                string caption = "Sub-Total is not valid.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            if (edt_clientId.Value <= 1)
            {
                PaymentConditions_Controller pCController = new PaymentConditions_Controller();
                var payCond = pCController.FindItemId((int)edt_payConditionId.Value);
                if (payCond.BillsInstalments.Count > 1)
                {
                    string message = "Client must be selected.";
                    string caption = "Client not selected.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    Utilities.Msgbox(message, caption, buttons, icon);
                    return false;
                }
            }
            return true;
        }

        public void ClearProductCamps()
        {
            edt_productId.Value = 0;
            edt_productName.Text = string.Empty;
            edt_barCode.Value = 0;
            edt_amount.Value = 1;
            edt_UNCost.Value = 0;
            edt_ProdDiscCash.Value = 0;
            edt_ProdDiscPerc.Value = 0;
            edt_ProdUnValue.Value = 0;
            edt_totalPValue.Value = 0;
        }

        public void CalcTotalProdValue()
        {
            edt_totalPValue.Value = edt_amount.Value * edt_ProdUnValue.Value;
        }

        private void edt_amount_ValueChanged(object sender, EventArgs e)
        {
            CalcTotalProdValue();
        }

        private void DGV_SaleProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var row = e.RowIndex;
            if (DGV_SaleProducts.Rows.Count > 0)
            {
                CalculateSubTotal();
            }

        }

        public void AutoAddOneProduct()
        {
            try
            {
                Products prod = _pController.FindItemId(Convert.ToInt32(edt_productId.Value));
                if (prod != null)
                {
                    int amount = 1;
                    decimal discountCash = 0;
                    decimal discountPerc = 0;
                    decimal totalValue = (decimal)prod.salePrice;

                    if (!CheckEqualDGVProduct(product.id, amount, discountCash, discountPerc, totalValue))
                    {
                        DGV_SaleProducts.Rows.Add(
                            prod.id,
                            prod.productName,
                            amount,
                            prod.productCost,
                            discountCash,
                            discountPerc,
                            prod.salePrice,
                            totalValue);
                    }
                    ClearProductCamps();
                }
            }
            catch (Exception)
            {

            }
        }

        private void edt_barCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utilities.EnterSearch(e))
            {
                if (edt_barCode.Value > 1)
                {
                    try
                    {
                        PopulateProduct(_pController.FindItemBarCode((long)edt_barCode.Value));
                        AutoAddOneProduct();

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }


        private void DGV_SaleProducts_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateSubTotal();
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            if (DGV_SaleProducts.Rows.Count > 0)
            {
                DGV_SaleProducts.Rows.RemoveAt(DGV_SaleProducts.SelectedRows[0].Index);
                CalculateSubTotal();
            }
        }
          // TESTES //
        private SaleItems GetSaleItemsTeste(int prodId, int saleId, int qtd)
        {
            SaleItems testeitems = new SaleItems();
            Products prod1 = _pController.FindItemId(prodId);
            testeitems.Product = prod1;
            testeitems.ProductCost = prod1.productCost;
            testeitems.ItemDiscountPerc = 0;
            testeitems.ItemDiscountCash = 0;
            testeitems.Quantity = qtd;
            testeitems.ProductValue = prod1.salePrice;
            testeitems.id = saleId;
            testeitems.TotalValue = testeitems.ProductCost * testeitems.Quantity;
            testeitems.dateOfLastUpdate = DateTime.Now;
            testeitems.dateOfCreation = DateTime.Now;
            return testeitems;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            PaymentConditions cond = new PaymentConditions();
            PaymentConditions_Controller cont = new PaymentConditions_Controller();
            Users_Controller uController = new Users_Controller();
            Users user = uController.FindItemId(2);
            List<SaleItems> listaItems = new List<SaleItems>();
            Clients_Controller clientC = new Clients_Controller();
            Clients cli = new Clients();
            //
            int saleId = _controller.BringNewId();

            listaItems.Add(GetSaleItemsTeste(2, saleId, 2));
            listaItems.Add(GetSaleItemsTeste(3, saleId, 3));

            cond = cont.FindItemId(3);

            cli = clientC.FindItemId(2);
            //
            Sales sale = new Sales();

            sale.id = saleId;
            sale.PaymentConditionId = cond.id;
            sale.User = user;
            sale.SaleItems = listaItems;
            sale.Client = cli;

            sale.dateOfCreation = DateTime.Now;
            sale.dateOfLastUpdate = DateTime.Now;
            sale.CancelDate = DateTime.Now;
            sale.User = user;

            sale.SaleDiscountCash = 0;
            sale.SaleDiscountPerc = 0;
            sale.TotalValue = 4036;
            sale.TotalCost = 1500.9 + 1500.9 + 8 + 8 + 8;
            sale.TotalItemsQuantity = 5;
            PopulateCamps(sale);
            //bool status = _controller.SaveItem(sale);
            //MessageBox.Show(status.ToString());
        }

        private void btnEditTeste_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale = _controller.FindItemId(10);
            PopulateCamps(sale);
        }


    }
}
