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
            edt_amount.Controls[0].Visible = false;
            edt_barCode.Controls[0].Visible = false;
            edt_payConditionDiscount.Controls[0].Visible = false;
            edt_payConditionFees.Controls[0].Visible = false;
            edt_payConditionFine.Controls[0].Visible = false;
            edt_payConditionQnt.Controls[0].Visible = false;
            edt_payConditionId.Controls[0].Visible = false;
            edt_productId.Controls[0].Visible = false;
            edt_ProdDiscCash.Controls[0].Visible = false;
            edt_ProdUnValue.Controls[0].Visible = false;
            edt_totalPValue.Controls[0].Visible = false;
            DGV_SaleProducts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_SaleProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_SaleProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_SaleProducts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_SaleProducts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_Instalments.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SetUser(user);
        }

        public Sales Sale { get; private set; }
        private Sales BackupSale = new Sales();
        private Products product = null;
        private Products_Controller _pController = new Products_Controller();
        private Sales_Controller _controller = new Sales_Controller();
        private BillsToReceive_Controller _BTRController = new BillsToReceive_Controller();
        //private BillsInstalments_Controller _billsController = null;

        public void SetSale(Sales sale)
        {
            Sale = sale;
        }

        public void SetUser(Users user)
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
            edt_totalPValue.Value = 0;
            edt_amount.Value = 1;

            edt_totalPValue.Value = 0;

            edt_payCondition.Text = string.Empty;
            edt_payConditionDiscount.Value = 0;
            edt_payConditionFees.Value = 0;
            edt_payConditionFine.Value = 0;
            edt_payConditionId.Value = 0;
            edt_payConditionQnt.Value = 0;
            gbox_Status.Enabled = false;

            DGV_SaleProducts.Rows.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (btn_new.Text == "F5")
            {
                NewSale();
            }
            else if (btn_new.Text == "Cancelar")
            {
                medt_CancelDate.Text = DateTime.Now.ToString();
                this.Save();
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
                    PopulatePaymentCondition(client.PaymentCondition);
                }
            }
            formClient.Close();
        }

        public bool CheckEqualDGVProduct(int prodId, int amount, decimal discountCash, decimal totalValue)
        {
            foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
            {
                if ((int)row.Cells[0].Value == prodId)
                {
                    if ((decimal)row.Cells["ItemDiscountCash"].Value == discountCash)
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
            decimal totalValue = (decimal)edt_totalPValue.Value;

            if (!CheckEqualDGVProduct(product.id, amount, discountCash, totalValue))
            {
                DGV_SaleProducts.Rows.Add(
                    product.id,
                    product.productName,
                    amount,
                    discountCash,
                    product.salePrice,
                    totalValue);
            }

            CalculateSubTotal();
        }

        public void UpdateDGVSummary(decimal subtotal, decimal total)
        {
            if (DGV_SaleSummary.Rows.Count == 0)
            {
                DGV_SaleSummary.Rows.Add();
            }
            if (DGV_SaleSummary.Rows.Count == 1)
            {
                DGV_SaleSummary.Rows[0].Cells["SaleSubTotal"].Value = subtotal;
                DGV_SaleSummary.Rows[0].Cells["SaleTotal"].Value = total;
            }

        }

        public void CalculateSubTotal() //Percorre a DGV, calculando o valor total de cada item, adicionando no Sub-Total
        {
            decimal subtotal = 0;
            decimal total = 0;
            if (DGV_SaleProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
                {
                    subtotal += Convert.ToDecimal(row.Cells["ProductTotalValue"].Value);
                    total += Convert.ToDecimal(row.Cells["ProductTotalValue"].Value) - Convert.ToDecimal(row.Cells["ProductDiscoutCash"].Value);
                }
                DGV_SaleSummary.Rows[0].Cells["SaleSubTotal"].Value = subtotal;
                UpdateDGVSummary(subtotal, total);
            }
            else
            {
                UpdateDGVSummary(subtotal,total);
            }
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
            edt_ProdUnValue.Value = (decimal)prod.salePrice;
            CalcTotalProdValue();
            CalculateSubTotal();
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

        public bool ConfirmSale(Sales sale) //To do: Abre form de adicionar condição de pagamento para completar a venda
        {
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            PaymentConditions obj = _pCController.FindItemId(sale.PaymentCondition.id);
            string caption = "Confirme a venda.";
            string message = "Cliente : "
                             + sale.Client.name
                             + Environment.NewLine
                             + "Condição de pagamento : "
                             + obj.conditionName
                             + Environment.NewLine
                             + "Sub-Total : "
                             + DGV_SaleSummary.Rows[0].Cells["SaleSubTotal"].Value.ToString()
                             + Environment.NewLine
                             + "Total : "
                             + DGV_SaleSummary.Rows[0].Cells["SaleTotal"].Value.ToString()
                             + Environment.NewLine
                             + "Confirmar a venda?";

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

        public void PopulatePaymentCondition(PaymentConditions payCondition)
        {
            edt_payCondition.Text = payCondition.conditionName;
            edt_payConditionDiscount.Value = (decimal)payCondition.discountPerc;
            edt_payConditionFees.Value = (decimal)payCondition.paymentFees;
            edt_payConditionFine.Value = (decimal)payCondition.fineValue;
            edt_payConditionQnt.Value = payCondition.instalmentQuantity;
            edt_payConditionId.Value = payCondition.id;
            SetBillInstalmentsToDGV(payCondition.id);
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
                    DGV_Instalments.Rows[i].Cells["InstalmentDays"].Value = item.TotalDays.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentPercentage"].Value = item.ValuePercentage.ToString();
                    DGV_Instalments.Rows[i].Cells["InstalmentMethod"].Value = item.PaymentMethod.paymentMethod.ToString();
                    i++;
                }
            }
        }

        private void Frm_Sale_KeyPress(object sender, KeyPressEventArgs e)
        {
            HotkeyPressed(e);
        }

        private void DGV_SaleProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateSubTotal();
        }

        private void btn_SearchPayCondition_Click(object sender, EventArgs e)
        {
            SearchPaymentCondition();
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
                            sale.dateOfCreation = DateTime.Now;
                            status = _controller.SaveItem(sale);
                            if (status)
                            {
                                int saleId = _controller.GetLastId();
                                List<BillsToReceive> billsToReceiveList = new List<BillsToReceive>();
                                billsToReceiveList = BillsToReceive.MakeBills(sale,saleId);
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
                    else if (btn_new.Text == "Cancelar")
                    {
                        var cancelledSale = _controller.FindItemId(Sale.id);
                        if (CheckInstalmentsForCancel(cancelledSale.id))
                        {
                            string caption = "Confirme o cancelamento.";
                            string message = "Deseja cancelar a compra?";

                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
                            if (dialogResult == DialogResult.Yes)
                            {

                                cancelledSale.CancelDate = DateTime.Now.Date;
                                check_Active.Checked = false;
                                check_Cancelled.Checked = true;
                                //sale.id = Sale.id;
                                status = _controller.CancelSale(cancelledSale);
                                if (status)
                                {
                                    status = _BTRController.CancelBills(sale.id);
                                    if (status)
                                    {
                                        //foreach (var item in cancelledSale.SaleItems)
                                        //{
                                        //    _pController.RestoreStock(item.Product.id, item.Quantity);
                                        //}
                                        LockCamps();
                                    }

                                }
                            }
                            else
                            {
                                btn_new.Enabled = true;
                            }

                        }
                        else
                        {
                            string caption = "Erro ao cancelar Venda.";
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

        public bool CheckInstalmentsForCancel(int saleId)
        {
            var obj = this.GetObject();
            var bills = _BTRController.FindSaleId(saleId);
            if (bills != null)
            {
                foreach (var b in bills)
                {
                    if (b.PaidDate.HasValue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private Sales GetObject()
        {
            DateTime emissionDate = DateTime.Now;
            Sales sale = new Sales();
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            int idSale = _controller.BringNewId();

            sale.User = this.GetUser();
            sale.Client = this.GetClient();
            sale.TotalValue = Convert.ToDecimal(DGV_SaleSummary.Rows[0].Cells["SaleTotal"].Value);
            sale.PaymentCondition = pcController.FindItemId((int)edt_payConditionId.Value);
            if (check_Active.Checked)
            {
                sale.CancelDate = null;
            }
            else
            {
                sale.CancelDate = DateTime.Today;
            }

            sale.SaleItems = this.GetSaleItems(idSale);
            sale.TotalCost = this.GetTotalCost(sale.SaleItems);
            sale.TotalItemsQuantity = DGV_SaleProducts.Rows.Count;

            return sale;
        }

        private decimal GetTotalCost(List<SaleItems> list)
        {
            decimal totalCost = 0;
            foreach (SaleItems item in list)
            {
                totalCost += item.ProductCost;
            }
            return totalCost;
        }

        private List<SaleItems> GetSaleItems(int idSale)
        {
            List<SaleItems> list = new List<SaleItems>();
            foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
            {
                SaleItems saleItem = new SaleItems();
                saleItem.id = idSale;
                saleItem.Product = _pController.FindItemId((int)row.Cells["IdProduct"].Value);
                saleItem.Quantity = Convert.ToInt32(row.Cells["QuantityProduct"].Value);
                saleItem.ProductValue = Convert.ToDecimal(row.Cells["UnValueProduct"].Value);
                saleItem.TotalValue = Convert.ToDecimal(row.Cells["ProductTotalValue"].Value);
                saleItem.ProductCost = saleItem.Product.productCost;
                saleItem.ItemDiscountCash = Convert.ToDecimal(row.Cells["ProductDiscoutCash"].Value);

                list.Add(saleItem);
            }
            return list;
        }

        private List<BillsToReceive> GetBillToReceive(decimal totalValue, DateTime emissionDate) //To do??
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
            var edit = "Cancelar";
            btn_new.Text = edit;
            lbl_new.Text = edit;
            btn_new.Enabled = true;
            btn_Save.Enabled = false;
            btn_FindClient.Enabled = false;
            medt_CancelDate.Visible = true;
            lbl_CancelDate.Visible = true;
        }

        public void PopulateCamps(Sales sale)
        {
            Sale = sale;
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            Populated(true);
            SetFormToEdit();
            PopulateUser(sale);
            PopulateClient(sale);
            PopulatePaymentCondition(sale);
            PopulateDGV(sale);
            PopulateDate(sale);
            PopulateBillsDGV(pcController.FindItemId(Convert.ToInt32(edt_payConditionId.Value)).BillsInstalments);
            CalculateSubTotal();
            PopulateStatus(sale);
        }

        public void PopulateStatus(Sales sale)
        {
            if (sale.CancelDate.HasValue)
            {
                check_Active.Checked = false;
                check_Cancelled.Checked = true;
                medt_CancelDate.Text = sale.CancelDate.ToString();
                lbl_new.Visible = false;
                btn_new.Visible = false;
                btn_FindClient.Visible = false;
                lbl_findClient.Visible = false;
                btn_Save.Visible = false;
                lbl_Save.Visible = false;
            }
            
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

        public void PopulateClient(Sales sale)
        {
            edt_clientId.Value = sale.Client.id;
            edt_clientName.Text = sale.Client.name;
            medt_registrationNumber.Text = sale.Client.registrationNumber;
        }

        public void PopulatePaymentCondition(Sales sale)
        {
            PaymentConditions_Controller _pCController = new PaymentConditions_Controller();
            PaymentConditions obj = _pCController.FindItemId(sale.PaymentCondition.id);
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
                var totalValue = item.ProductValue * item.Quantity;
                DGV_SaleProducts.Rows.Add(
                    item.Product.id,
                    item.Product.productName,
                    item.Quantity,
                    item.ItemDiscountCash,
                    item.ProductValue,
                    totalValue
                    );
            }
        }

        private void ClearCamps()
        {
            edt_amount.Value = 0;
            edt_barCode.Value = 0;
            edt_productId.Value = 0;
            edt_productName.Text = string.Empty;
            edt_clientId.Value = 0;
            edt_clientName.Text = string.Empty;
            medt_registrationNumber.Text = string.Empty;
            edt_payCondition.Text = string.Empty;
            edt_payConditionFees.Text = string.Empty;
            edt_payConditionFine.Text = string.Empty;
            edt_payConditionId.Value = 0;
            medt_date.Text = DateTime.Now.ToString();
            DGV_SaleProducts.Rows.Clear();
            DGV_Instalments.Rows.Clear();
            edt_ProdDiscCash.Value = 0;
            edt_ProdUnValue.Value = 0;
            edt_totalPValue.Value = 0;
            medt_CancelDate.Visible = false;
            lbl_CancelDate.Visible = false;
        }

        private void UnlockCamps()
        {
            edt_amount.Enabled = true;
            edt_barCode.Enabled = true;
            edt_productId.Enabled = true;
            edt_productName.Enabled = true;
            DGV_SaleProducts.Enabled = true;
            btn_FindProduct.Enabled = true;
            btn_AddProduct.Enabled = true;
            btn_FindClient.Enabled = true;
            btn_SearchPayCondition.Enabled = true;
            btn_new.Enabled = true;
            btn_Save.Enabled = true;
            edt_ProdDiscCash.Enabled = true;
            btn_Close.Enabled = true;
            btn_DeleteItem.Enabled = true;
            btn_find.Enabled = true;
        }

        private void LockCamps()
        {
            edt_amount.Enabled = false;
            edt_barCode.Enabled = false;
            edt_productId.Enabled = false;
            edt_productName.Enabled = false;
            edt_ProdDiscCash.Enabled = false;
            DGV_SaleProducts.Enabled = false;
            btn_FindProduct.Enabled = false;
            btn_AddProduct.Enabled = false;
            btn_FindClient.Enabled = false;
            btn_SearchPayCondition.Enabled = false;
            btn_new.Enabled = false;
            btn_Save.Enabled = false;
            btn_DeleteItem.Enabled = false;
            btn_find.Enabled = false;
            
        }

        private bool CheckCamps()
        {

            if (DGV_SaleProducts.Rows.Count == 0)
            {
                string message = "Venda deve possuir ao menos 1 item.";
                string caption = "Lista de produtos está vazia.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
            else if (edt_payConditionId.Value <= 0)
            {
                string message = "Condição de pagamento deve ser selecionada.";
                string caption = "Condição de pagamento inválida.";
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
                    string message = "Cliente deve ser selecionado.";
                    string caption = "Cliente inválido.";
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
            edt_ProdDiscCash.Value = 0;
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
                    decimal totalValue = (decimal)prod.salePrice;

                    if (!CheckEqualDGVProduct(product.id, amount, discountCash, totalValue))
                    {
                        DGV_SaleProducts.Rows.Add(
                            prod.id,
                            prod.productName,
                            amount,
                            prod.productCost,
                            discountCash,
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
                string caption = "Deseja apagar o produto da venda?";
                string message = "Apagar Produto : "
                                 + Environment.NewLine
                                 + DGV_SaleProducts.SelectedRows[0].Cells["NameProduct"].Value.ToString()
                                 + Environment.NewLine
                                 + " "
                                 + Environment.NewLine
                                 + "      Apagar?";

                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    DGV_SaleProducts.Rows.RemoveAt(DGV_SaleProducts.SelectedRows[0].Index);
                    CalculateSubTotal();
                }
            }
        }

        private void check_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Active.Checked)
            {
                check_Cancelled.Checked = false;
            }
        }

        private void check_Cancelled_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Cancelled.Checked)
            {
                check_Active.Checked = false;
            }
        }

        private void btn_CancelSale_Click(object sender, EventArgs e)
        {

        }
    }
}
