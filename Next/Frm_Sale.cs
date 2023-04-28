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
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Forms
{
    public partial class Frm_Sale : Form
    {
        public Frm_Sale()
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
        }

        private Sales BackupSale = null;
        private Products product = new Products();
        private Products_Controller _pController = new Products_Controller();
        private Sales_Controller _controller = new Sales_Controller();

        private void lbl_subTotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_subTotalPercentage_Click(object sender, EventArgs e)
        {

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
                BackupSale = this.GetObject();
                UnlockCamps();
                btn_new.Text = "Cancel";
                lbl_new.Text = "Cancel";
                btn_Save.Enabled = true;
                btn_FindClient.Enabled = true;
            }
            else if (btn_new.Text == "Cancel")
            {
                LockCamps();
                PopulateCamps(BackupSale);
                SetFormToEdit(); 
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
                    edt_UNCost.Value = (decimal)product.salePrice;
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
                    medt_registrationNumber.Text = client.registrationNumber;
                }
            }
            formClient.Close();
        }

        public void AddProductToDGV() //Pega obj produto e popula na DGV e chama CalculateSubTotal
        {
            Products product = GetProduct();
            int amount = (int)edt_amount.Value;
            decimal totalValue = (decimal)product.salePrice * edt_amount.Value;
            DGV_SaleProducts.Rows.Add(
                product.id,
                product.productName,
                product.productCost,
                amount,
                product.salePrice,
                totalValue);

            CalculateSubTotal();
        }

        public void CalculateSubTotal() //Percorre a DGV, calculando o valor total de cada item, adicionando no Sub-Total
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in DGV_SaleProducts.Rows)
            {
                subtotal += (decimal)row.Cells["ProductTotalValue"].Value;
            }
            edt_subtotal.Value = subtotal;
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
            else if (String.IsNullOrWhiteSpace(edt_clientName.Text))
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

        private void btn_FindProduct_Click(object sender, EventArgs e) //Checa se campos estão vazios, Se Sim,Abre form FIND Produtos
        {                                                             //Se não,procura obj, se nao encontrar, pergunta e quer abrir Form Find Produtos      
            if (!CheckProductCamps())                                 //Se sim, abre form Find      
            {
                NewFormSearchProduct();
            }
            else
            {
                SearchProduct();
            }
            if (product == null)
            {
                if (Utilities.AskToFind())
                {
                    NewFormSearchProduct();
                }
            }
        }

        public void PopulateProduct(Products prod) //Popula campos do produto
        {
            edt_productId.Value = prod.id;
            edt_productName.Text = prod.productName;
            edt_UNCost.Value = (decimal)prod.salePrice;
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
            string caption = "Confirm sale.";
            string message = "Client : "
                             + sale.Client.name
                             + Environment.NewLine
                             + "Payment Condition : "
                             + sale.BillToReceive[0].Condition.conditionName
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
                edt_payCondition.Text = payCondition.conditionName;
                edt_payConditionDiscount.Value = (decimal)payCondition.discountPerc;
                edt_payConditionFees.Value = (decimal)payCondition.paymentFees;
                edt_payConditionFine.Value = (decimal)payCondition.fineValue;
                edt_payConditionQnt.Value = payCondition.instalmentQuantity;
                edt_payConditionId.Value = payCondition.id;
            }
            formPayCondition.Close();
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
            if (edt_barCode.Value > 1)
            {
                PopulateProduct(_pController.FindItemBarCode((long)edt_barCode.Value));
            }
        }

        public void Save() // Save
        {
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
                            _controller.SaveItem(sale);
                            Populated(false);
                        }
                    }
                    else if (btn_new.Text == "Cancel")
                    {
                        _controller.UpdateItem(sale);
                        SetFormToEdit();
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
            sale.BillToReceive = this.GetBillToReceive(sale.TotalValue, emissionDate);
            sale.EmissionDate = emissionDate;
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
                totalCost += item.productCost;
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
                saleItem.product = _pController.FindItemId((int)row.Cells["IdProduct"].Value);
                saleItem.quantity = (int)row.Cells["QuantityProduct"].Value;
                saleItem.value = (double)row.Cells["UnValueProduct"].Value;
                saleItem.totalValue = (double)row.Cells["ProductTotalValue"].Value;
                saleItem.productCost = (double)row.Cells["ProductCost"].Value;
                list.Add(saleItem);
            }
            return list;
        }

        private List<BillsToReceive> GetBillToReceive(double totalValue, DateTime emissionDate) //To do
        {
            List<BillsToReceive> list = new List<BillsToReceive>();
            BillsToReceive bill = new BillsToReceive();
            Clients client = this.GetClient();          
            PaymentConditions Condition = GetCondition();
            int instalQtd = Condition.BillsInstalments.Count;
            int num = 1;
            foreach (BillsInstalments instalment in Condition.BillsInstalments)
            {
                bill.Condition = Condition;
                bill.IsPaid = false;
                bill.Client = client;
                bill.EmissionDate = emissionDate;
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
            PopulatePaymentCondition(sale);
            PopulateDGV(sale);
            PopulateSummary(sale);
            PopulateDate(sale);
        }

        public void PopulateDate(Sales sale) 
        {
            medt_date.Text = sale.EmissionDate.ToString();
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
            edt_subtotal.Value = (decimal) (sale.TotalValue + (sale.SaleDiscountCash) + (sale.SaleDiscountPerc * sale.TotalValue));
        }

        public void PopulateClient(Sales sale)
        {
            edt_clientId.Value = sale.Client.id;
            edt_clientName.Text = sale.Client.name;
            medt_registrationNumber.Text = sale.Client.registrationNumber;
        }

        public void PopulatePaymentCondition(Sales sale)
        {
            edt_payCondition.Text = sale.BillToReceive[0].Condition.conditionName;
            edt_payConditionDiscount.Value = (decimal) sale.BillToReceive[0].Condition.discountPerc ;
            edt_payConditionFees.Value = (decimal)sale.BillToReceive[0].Condition.paymentFees;
            edt_payConditionFine.Value = (decimal)sale.BillToReceive[0].Condition.fineValue;
            edt_payConditionId.Value = (decimal)sale.BillToReceive[0].Condition.id;
            edt_payConditionQnt.Value = (decimal)sale.BillToReceive[0].InstalmentsQtd;
        }

        public void PopulateUser(Sales sale)
        {
            edt_userId.Value = sale.User.id;
            edt_userName.Text = sale.User.name;
        }

        public void PopulateDGV(Sales sale)
        {
            foreach (SaleItems item in sale.SaleItems)
            {
                DataGridViewRow row = new DataGridViewRow();               
                row.CreateCells(DGV_SaleProducts);
                row.Cells["IdProduct"].Value = item.product.id;
                row.Cells["NameProduct"].Value = item.product.productName;
                row.Cells["ProductCost"].Value = item.productCost;
                row.Cells["QuantityProduct"].Value = item.quantity;
                row.Cells["UnValueProduct"].Value = item.value;
                row.Cells["ProductTotalValue"].Value = item.value * item.quantity;
                DGV_SaleProducts.Rows.Add(row);
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
            else if (edt_payConditionId.Value <= 1)
            {
                string message = "Payment Condition must be selected.";
                string caption = "Payment Condition not selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                return false;
            }
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

        private void edt_amount_ValueChanged(object sender, EventArgs e)
        {
            edt_totalPValue.Value = edt_amount.Value * edt_UNCost.Value;
        }
    }
}
