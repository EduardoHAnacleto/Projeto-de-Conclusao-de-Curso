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
            medt_date.Text = DateTime.Now.ToString();
        }

        private readonly Products_Controller _pController = new Products_Controller();

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
    }
}
