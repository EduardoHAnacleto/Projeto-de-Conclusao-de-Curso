﻿using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
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

namespace ProjetoEduardoAnacletoWindowsForm1.MasterDetails
{
    public partial class MasterDetails_Sales : Form
    {
        public MasterDetails_Sales()
        {
            InitializeComponent();
            edt_saleId.Controls[0].Visible = false;
            edt_clientId.Controls[0].Visible = false;
            edt_UserId.Controls[0].Visible = false;
        }

        Sales_Controller SalesController = new Sales_Controller();
        Users_Controller UsersController = new Users_Controller();
        Clients_Controller ClientsController = new Clients_Controller();

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_SearchPayCond_Click(object sender, EventArgs e)
        {
            var frmPaymentConditions = new Frm_Find_PaymentConditions();
            frmPaymentConditions.ShowDialog();
            if (!frmPaymentConditions.ActiveControl.ContainsFocus)
            {
                var payConditions = frmPaymentConditions.GetObject();
                if (payConditions != null)
                {
                    edt_payCondition.Text = payConditions.conditionName;
                }
                frmPaymentConditions.Close();
                FilterByPaymentCondition(payConditions.conditionName);
            }
        }

        private void FilterByPaymentCondition(string cond)
        {
            if (edt_payCondition.Text.Length > 0)
            {
                edt_payCondition.Enabled = false;
                PopulateDGVSales();
                foreach (DataGridViewRow item in DGV_Sales.Rows)
                {
                    if (item.Cells["SalePayCond"].Value.ToString() != cond)
                    {
                        item.Dispose();
                    }
                }
                edt_payCondition.Enabled = true;
            }
        }

        private void btn_ClearClientFilters_Click(object sender, EventArgs e)
        {
            PopulateDGVClients();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateDGVSales()
        {
            DGV_Sales.Rows.Clear();
            DGV_Sales.DataSource = SalesController.PopulateDGV();
            SaleStatusToString();
        }

        private void PopulateDGVClients()
        {
            DGV_Clients.Rows.Clear();
            DGV_Clients.DataSource = ClientsController.PopulateDGV();
            ClientTypeToString();
        }

        private void btn_findSale_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (edt_saleId.Value > 0)
            {
                PopulateDGVSales();
                foreach (DataGridViewRow item in DGV_Sales.Rows)
                {
                    if (Convert.ToInt32(item.Cells["SaleId"].Value) == Convert.ToInt32(edt_saleId.Value))
                    {
                        row = item;
                        DGV_Sales.Rows.Clear();
                        DGV_Sales.Rows.Add(row);
                        break;
                    }
                }
            }
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(edt_UserId.Value) > 0)
            {
                PopulateDGVSales();
                foreach (DataGridViewRow item in DGV_Sales.Rows)
                {
                    if (Convert.ToInt32(item.Cells["SaleUserId"].Value) != Convert.ToInt32(edt_UserId.Value))
                    {
                        item.Dispose();
                    }
                }
            }
        }

        private void btn_ClearSaleFilters_Click(object sender, EventArgs e)
        {
            PopulateDGVSales();
        }

        private void dateTime_DateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_DateFilter.Value != dateTime_DateFilter.MinDate)
            {

            }
        }

        private void rbtn_ActiveStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ActiveStatus.Checked)
            {
                rbtn_CancelledStatus.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["Status"].ToString() != "ACTIVE")
                    {
                        row.Dispose();
                    }
                }
            }
        }

        private void rbtn_CancelledStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_CancelledStatus.Checked)
            {
                rbtn_ActiveStatus.Checked = false;
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (row.Cells["Status"].ToString() != "FALSE")
                    {
                        row.Dispose();
                    }
                }
            }
        }

        private void rbtn_LegalClients_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_LegalClients.Checked)
            {
                rbtn_Natural.Checked = false;
                foreach (DataGridViewRow row in DGV_Clients.Rows)
                {
                    if (row.Cells["ClientType"].ToString() != "LEGAL")
                    {
                        row.Dispose();
                    }
                }
            }
        }

        private void rbtn_Natural_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Natural.Checked)
            {
                rbtn_LegalClients.Checked = false;
                foreach (DataGridViewRow row in DGV_Clients.Rows)
                {
                    if (row.Cells["ClientType"].ToString() != "NATURAL")
                    {
                        row.Dispose();
                    }
                }
            }
        }

        private void ClientTypeToString()
        {
            if (DGV_Clients.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Clients.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ClientType"].Value) == 1)
                    {
                        row.Cells["ClientType"].Value = "NATURAL";
                    }
                    else
                    {
                        row.Cells["ClientType"].Value = "LEGAL";
                    }
                }
            }
        }

        private void SaleStatusToString()
        {
            if (DGV_Sales.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Sales.Rows)
                {
                    if (Convert.ToInt32(row.Cells["SaleStatus"].Value) == 1)
                    {
                        row.Cells["SaleStatus"].Value = "ACTIVE";
                    }
                    else
                    {
                        row.Cells["SaleStatus"].Value = "CANCELLED";
                    }
                }
            }
        }

        private void btn_SelectClient_Click(object sender, EventArgs e)
        {
            FilterByClient();
        }

        public void FilterByClient()
        {
            bool foundClient = FindClientDGV();
            if (foundClient)
            {
                if (DGV_Sales.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGV_Sales.Rows)
                    {
                        if (row.Cells["SaleClientName"].Value.ToString() != edt_clientName.Text)
                        {
                            row.Dispose();
                        }
                    }
                }
            }
        }

        private bool FindClientDGV()
        {
            bool foundClient = false;
            if (edt_clientId.Value > 0)
            {
                if (DGV_Clients.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGV_Clients.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["ClientId"].Value) == Convert.ToInt32(edt_clientId.Value))
                        {
                            row.Selected = true;
                            return true;
                        }
                    }
                }
            }
            else if (!string.IsNullOrWhiteSpace(edt_clientName.Text))
            {
                if (DGV_Clients.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGV_Clients.Rows)
                    {
                        if (row.Cells["ClientName"].Value.ToString() == edt_clientName.Text)
                        {
                            row.Selected = true;
                            return true;
                        }
                    }
                }
            }
            if (!foundClient)
            {
                if (Utilities.AskToFind())
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
                            foundClient = true;
                        }
                    }
                    formClient.Close();
                    if (foundClient)
                    {
                        FilterSaleByFoundClient();
                    }
                }
            }
            return false;
        }

        private void FilterSaleByFoundClient()
        {
            foreach (DataGridViewRow row in DGV_Clients.Rows)
            {
                if (row.Cells["ClientName"].Value.ToString() == edt_clientName.Text)
                {
                    row.Selected = true;
                }
            }
        }

        private void btn_FindClient_Click(object sender, EventArgs e)
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
                }
            }
            FilterSaleByFoundClient();
        }
    }
}
