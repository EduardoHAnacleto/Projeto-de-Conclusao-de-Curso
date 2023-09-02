using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms;
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
    public partial class MasterDetails_SaleProducts : Form
    {
        public MasterDetails_SaleProducts()
        {
            InitializeComponent();
            PopulateSalesDGV();
            User.id = 2;
        }

        private Users User { get; set; } = new Users();
        private Sales_Controller _saleController = new Sales_Controller();
        private SaleItems_Controller _siController = new SaleItems_Controller();

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PopulateSalesDGV()
        {
            DGV_Sales.Rows.Clear();
            DataTable dt = _saleController.PopulateDGV();
            Clients_Controller cController = new Clients_Controller();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var saleId = dr["ID_SALE"].ToString();
                    var client = cController.FindItemId(Convert.ToInt32(dr["CLIENT_ID"])).name;
                    var userId = dr["user_id"].ToString();
                    decimal saleValue = Convert.ToDecimal(dr["sale_total_value"]);
                    var dateCreation = (Convert.ToDateTime(dr["date_creation"])).ToShortDateString();
                    DateTime? cancelDate = null;
                    if (dr["sale_cancel_date"] != DBNull.Value)
                    {
                        cancelDate = Convert.ToDateTime(dr["sale_cancel_date"]);
                    }
                    DGV_Sales.Rows.Add(
                        saleId,
                        client,
                        userId,
                        saleValue,
                        dateCreation,
                        cancelDate);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            PopulateSalesDGV();
            DGV_SaleProducts.Rows.Clear();
        }

        private void DGV_Sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateSaleProducts();
        }

        public void PopulateSaleProducts()
        {
            if (DGV_Sales.SelectedRows[0] != null)
            {
                DGV_SaleProducts.Rows.Clear();
                var list = _siController.FindSaleId(Convert.ToInt32(DGV_Sales.SelectedRows[0].Cells["SaleId"].Value));
                foreach (SaleItems item in list)
                {
                    DGV_SaleProducts.Rows.Add(
                        item.Product.id,
                        item.Product.productName,
                        item.Quantity,
                        item.ItemDiscountCash,
                        item.ProductValue,
                        item.TotalValue);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchSale();
        }

        private void SearchSale()
        {
            PopulateSalesDGV();
            if (edt_clientName.Text != string.Empty)
            {
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["SaleClientName"].Value.ToString() != edt_clientName.Text)
                    {
                        DGV_Sales.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSalesDGV();
            if (rbtn_active.Checked)
            {
                rbtn_cancelled.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["SaleCancelDate"].Value.ToString() != string.Empty)
                    {
                        DGV_Sales.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_cancelled_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSalesDGV();
            if (rbtn_cancelled.Checked)
            {
                rbtn_active.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["SaleCancelDate"].Value.ToString() == string.Empty)
                    {
                        DGV_Sales.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_DateCreation_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSalesDGV();
            if (rbtn_DateCreation.Checked)
            {
                rbtn_cancelDate.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (Convert.ToDateTime(row.Cells["SaleDateCreation"].Value) < dateTime_filter.Value)
                    {
                        DGV_Sales.Rows.Remove(row);
                    }
                }
            }
        }

        private void rbtn_cancelDate_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSalesDGV();
            if (rbtn_cancelDate.Checked)
            {
                rbtn_DateCreation.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["SaleCancelDate"].Value.ToString() == string.Empty ||
                        (Convert.ToDateTime(row.Cells["SaleCancelDate"].Value) < dateTime_filter.Value))
                    {
                        DGV_Sales.Rows.Remove(row);
                    }
                }
            }
        }

        private void btn_SelectSale_Click(object sender, EventArgs e)
        {
            if (DGV_Sales.SelectedRows[0].Cells["SaleId"].Value.ToString() != string.Empty)
            {
                Frm_Sale frmSale = new Frm_Sale(User);
                Sales sale = _saleController.FindItemId(Convert.ToInt32(DGV_Sales.SelectedRows[0].Cells["SaleId"].Value));
                frmSale.PopulateCamps(sale);
                frmSale.ShowDialog();
                PopulateSalesDGV();
            }
        }
    }
}
