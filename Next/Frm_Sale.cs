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
        }

        private Products product = new Products();
        private Products_Controller _PController = new Products_Controller();

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
            edt_totalCost.Value = 0;
            edt_amount.Value = 1;

            edt_subtotal.Value = 0;
            edt_discountPerc.Value = 0;
            edt_totalCost.Value =0;

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
            NewSale();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Save
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
            int amount = 1;
            decimal totalValue = (decimal)product.salePrice * edt_amount.Value;
            if (edt_productId.Value != 0) 
            {
                DGV_SaleProducts.Rows.Add(
                    product.id,
                    product.productName,
                    amount,
                    product.salePrice,
                    totalValue);

                CalculateSubTotal();
            }
        }

        public void CalculateSubTotal() //Percorre a DGV, calculando o valor total de cada item, adicionando no Sub-Total
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in  DGV_SaleProducts.Rows)
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
            else if ( edt_barCode.Value <= 1 )
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
            if (edt_productId.Value > 1)
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
            edt_UNCost.Value =(decimal) prod.salePrice;
        }

        private Products SearchItemByName()
        {
            try
            {
                return _PController.FindItemName(edt_productName.Text);
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
                return _PController.FindItemId(Convert.ToInt32(edt_productId.Value));
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
            value = value - (value * (edt_discountPerc.Value/100));
            edt_total.Value = value;
        }

        public void ProceedWithSale() //To do: Abre form de adicionar condição de pagamento para completar a venda
        {

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
                ProceedWithSale();
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
            SearchProduct();
            AddProductToDGV();
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
                edt_payConditionDiscount.Value = (decimal) payCondition.discountPerc;
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
    }
}
