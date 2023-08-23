using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Products : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Products()
        {
            InitializeComponent();
            PopulateProductGroupsComboBox();
            PopulateBrandsComboBox();
            edt_stock.Controls[0].Visible = false;
            edt_productCost.Controls[0].Visible = false;
        }

        private Products_Controller controller = new Products_Controller();
        Products auxObj = null;

        public override int BringNewId() // Tras novo ID para o Form
        {
            return controller.BringNewId();
        }

        public override void SetNewId()
        {
            edt_id.Value = controller.BringNewId();
        }

        public override bool CheckCamps()
        {
            if (Utilities.HasOnlySpaces(edt_productName.Text, "Nome do Produto"))
            {
                edt_productName.Focus();
                return false;
            }
            else if (!Utilities.IsDouble(edt_productSalePrice.Text, "Preço de Venda"))
            {
                edt_productSalePrice.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_brands.SelectedItem, "Marca"))
            {
                cbox_brands.Focus();
                return false;
            }
            else if (Utilities.IsNotSelected(cbox_ProductGroup.SelectedItem, "Grupo de Produto"))
            {
                cbox_ProductGroup.Focus();
                return false;
            }
            else if (!Utilities.HasOnlyDigits((edt_barCode.Text), "Código de Barras") || Utilities.HasOnlySpaces(edt_barCode.Text,"Código de Barras"))
            {
                edt_barCode.Focus();
                return false;
            }
            else if (Convert.ToDecimal(edt_productCost.Text) > Convert.ToDecimal(edt_productSalePrice.Text))
            {
                string message = "Valor de venda deve ser maior que o de custo.";
                string caption = "Campo inválido.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                Utilities.Msgbox(message, caption, buttons, icon);
                edt_productSalePrice.Focus();
                return false;
            }
            else return true;
        }

        public override void LockCamps()
        {
            edt_productCost.Enabled = false;
            edt_productName.Enabled = false;
            edt_productSalePrice.Enabled = false;
            cbox_brands.Enabled = false;
            cbox_ProductGroup.Enabled = false;
            //edt_stock.Enabled = false;
            btn_SearchBrand.Enabled = false;
            btn_SearchPGroup.Enabled = false;
            edt_barCode.Enabled = false;
            edt_ProfitPerc.Enabled = false;
        }

        public override void UnlockCamps()
        {
            edt_productCost.Enabled = true;
            edt_productName.Enabled = true;
            edt_productSalePrice.Enabled = true;
            cbox_brands.Enabled = true;
            cbox_ProductGroup.Enabled = true;
            //edt_stock.Enabled = true;
            btn_SearchBrand.Enabled = true;
            btn_SearchPGroup.Enabled = true;
            edt_barCode.Enabled = true;
            edt_ProfitPerc.Enabled = true;
        }

        public override void ClearCamps()
        {
            base.ClearCamps();
            //     edt_productCost.Clear();
            edt_productName.Clear();
            edt_productSalePrice.Clear();
            cbox_brands.SelectedIndex = 0;
            cbox_ProductGroup.SelectedIndex = 0;
            edt_stock.Value = 0;
            edt_barCode.Clear();
            edt_ProfitPerc.Value = 0;
        }

        public void PopulateCamps(Products product)
        {
            edt_id.Value = product.id;
            edt_productName.Text = product.productName;
            edt_productCost.Text = product.productCost.ToString("0.00");
            edt_productSalePrice.Text = product.salePrice.ToString("0.00");
            edt_stock.Value = product.stock;
            lbl_CreationDate.Text = product.dateOfCreation.ToShortDateString();
            lbl_LastUpdate.Text = product.dateOfLastUpdate.ToShortDateString();
            cbox_brands.SelectedItem = product.brand.brandName;
            cbox_ProductGroup.SelectedItem = product.productGroup.productGroup;
            edt_barCode.Text = product.BarCode.ToString();
            edt_ProfitPerc.Value = (decimal) (product.salePrice / product.productCost) * 100;
        }

        public Products GetObject()
        {
            Products product = new Products();
            product.id = Convert.ToInt32(edt_id.Value);
            product.productName = edt_productName.Text;
            product.productCost = Convert.ToDouble(edt_productCost.Text);
            product.salePrice = Convert.ToDouble(edt_productSalePrice.Text);
            product.stock = Convert.ToInt32(edt_stock.Value);
            product.BarCode = Convert.ToInt64(edt_barCode.Text);

            ProductGroups pGroups = this.TakePGroup(cbox_ProductGroup.SelectedItem.ToString());
            product.productGroup = pGroups;

            Brands brand = this.TakeBrand(cbox_brands.SelectedItem.ToString());
            product.brand = brand;

            return product;
        }

        public ProductGroups TakePGroup(string name)
        {
            ProductGroups pGroups = new ProductGroups();
            ProductGroups_Controller groups_Controller = new ProductGroups_Controller();
            pGroups = groups_Controller.FindItemName(name);
            return pGroups;
        }

        public Brands TakeBrand(string name)
        {
            var brand = new Brands();
            Brands_Controller brand_controller = new Brands_Controller();
            brand = brand_controller.FindItemName(name);
            return brand;

        }

        public void SearchProductGroup()
        {
            Frm_Find_ProductGroups FrmFindProductGroups = new Frm_Find_ProductGroups();
            FrmFindProductGroups.hasFather = true;
            FrmFindProductGroups.ShowDialog();
            PopulateProductGroupsComboBox();
            if (FrmFindProductGroups.item != null)
            {
                var aux = (ProductGroups)FrmFindProductGroups.item;
                cbox_ProductGroup.SelectedItem = aux.productGroup;
            }
        }

        private void btn_SearchPGroup_Click(object sender, EventArgs e)
        {
            SearchProductGroup();
        }

        private void btn_SearchBrand_Click(object sender, EventArgs e)
        {
            SearchBrand();
        }

        public void SearchBrand()
        {
            Frm_Find_Brands FrmFindBrands = new Frm_Find_Brands();
            FrmFindBrands.hasFather = true;
            FrmFindBrands.ShowDialog();
            PopulateBrandsComboBox();
            if (FrmFindBrands.item != null)
            {
                var aux = (Brands)FrmFindBrands.item;
                cbox_brands.SelectedItem = aux.brandName;
            }
        }

        public void PopulateBrandsComboBox() //Popula os itens dos PhoneClassification ComboBox
        {
            cbox_brands.Items.Clear();
            ComboBox comboBox = new ComboBox();
            Brands_Controller pController = new Brands_Controller();
            DataTable dt = pController.PopulateDGV();
            cbox_brands.DataSource = dt.DataSet; //???
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr.ItemArray[1].ToString());
            }
            foreach (string text in comboBox.Items)
            {
                cbox_brands.Items.Add(text);
            }
        }

        public void PopulateProductGroupsComboBox() //Popula os itens dos PhoneClassification ComboBox
        {
            cbox_ProductGroup.Items.Clear();
            ComboBox comboBox = new ComboBox();
            ProductGroups_Controller pController = new ProductGroups_Controller();
            DataTable dt = pController.PopulateDGV();
            //cbox_ProductGroup.DataSource = dt.DataSet; //???
            //cbox_phone1.
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr.ItemArray[1].ToString());
            }
            foreach (string text in comboBox.Items)
            {
                cbox_ProductGroup.Items.Add(text);
            }
        }

        //

        public override void Save() // Save
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    if (btn_Edit.Text == "&Alterar")
                    {
                        controller.SaveItem(this.GetObject());
                        ClearCamps();
                        Populated(false);
                    }
                    else if (btn_Edit.Text == "Cancelar")
                    {
                        this.controller.UpdateItem(GetObject());
                        btn_Edit.Text = "&Alterar";
                        btn_NewSave.Enabled = false;
                        btn_SelectDelete.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public override void EditObject() //EditObject
        {
            if (btn_Edit.Text == "&Alterar")
            {
                UnlockCamps();
                btn_Edit.Text = "Cancelar";
                btn_NewSave.Enabled = true;
                btn_SelectDelete.Enabled = true;
                auxObj = GetObject();
            }
            else if (btn_Edit.Text == "Cancelar")
            {
                btn_Edit.Text = "&Alterar";
                LockCamps();
                btn_SelectDelete.Enabled = false;
                btn_NewSave.Enabled = false;
                this.PopulateCamps(auxObj);
            }
        }

        public override void DeleteObject() //DeleteObject
        {
            if (CheckCamps())
            {
                LockCamps();
                try
                {
                    controller.DeleteItem(Convert.ToInt32(this.edt_id.Value));
                    this.ClearCamps();
                    this.edt_id.Value = this.BringNewId();
                    btn_SelectDelete.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_Edit.Text = "&Alterar";
                    Populated(false);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            UnlockCamps();
        }
        
        public void CalculateProfit()
        {
            var profit = Convert.ToDecimal(edt_productCost.Value) * ((edt_ProfitPerc.Value/100)+1);
            edt_productSalePrice.Text = profit.ToString("0.##");
        }

        private void edt_ProfitPerc_ValueChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }
    }
}