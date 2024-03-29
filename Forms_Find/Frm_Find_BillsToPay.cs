﻿using ProjetoEduardoAnacletoWindowsForm1.Authorization;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public partial class Frm_Find_BillsToPay : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_BillsToPay(Users user)
        {
            InitializeComponent();
            edt_billModel.Controls[0].Visible = false;
            edt_billNumber.Controls[0].Visible = false;
            edt_billSeries.Controls[0].Visible = false;
            DGV_BillsToPay.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGV_BillsToPay.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.SetDataSourceToDGV();
            SetUser(user);
        }

        private void SetUser(Users user)
        {
            _User = user;
        }

        public Users _User { get; private set; }
        private readonly BillsToPay_Controller _controller = new BillsToPay_Controller();

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToPay.Rows.Count>1)
            {
                SearchBill();
            }
        }

        private void SearchBill()
        {
            bool foundStatus = false;
            foreach (DataGridViewRow row in DGV_BillsToPay.Rows) 
            {
                if ( (row.Cells["billNumber"].Value.ToString() == edt_billNumber.Value.ToString() ) &&
                    (row.Cells["billModel"].Value.ToString() == edt_billModel.Value.ToString() ) &&
                    (row.Cells["billSeries"].Value.ToString() == edt_billSeries.Value.ToString() ) )
                {
                    DGV_BillsToPay.Rows[row.Index].Selected = true;
                    foundStatus = true;
                    break;
                }
            }
            if (!foundStatus)
            {
                MessageBox.Show("Conta não encontrada.");
            }
        }

        private BillsToPay GetObject()
        {
            if (DGV_BillsToPay.SelectedRows[0] != null)
            {
                Suppliers_Controller supController = new Suppliers_Controller();
                int billNumber = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["BillNumber"].Value);
                int billSeries = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billSeries"].Value);
                int billModel = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billModel"].Value);
                int instalmentNumber = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["InstalmentNumber"].Value);
                int supplierId = supController.FindItemName(DGV_BillsToPay.SelectedRows[0].Cells["SupplierName"].Value.ToString()).id;
                BillsToPay obj = _controller.FindItemId(billNumber, billModel, billSeries, instalmentNumber, supplierId);
                return obj;
            }
            return null;            
        }

        public override void SelectObject()
        {
            try
            {
                var obj = GetObject();
                if (obj != null)
                {
                    if (hasFather)
                    {
                        base.item = obj;
                        this.Hide();
                    }
                    else
                    {
                        NewPopulatedForm(obj, "Check");
                        SetDataSourceToDGV();
                    }
                }
                else
                {
                    Utilities.IsNotSelected(obj, "Conta");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        public void NewPopulatedForm(BillsToPay obj, string formFunc)
        {
            
            Frm_Create_BillsToPay frmCreateBillsToPay = new Frm_Create_BillsToPay(formFunc, obj, _User);
            frmCreateBillsToPay.ShowDialog();
            this.SetDataSourceToDGV();
        }

        public override void SetDataSourceToDGV() //Cria DataTable, chama Controller para trazer o DataTable e colocar na DGV como DataSource, linka db com DGV
        {
            DGV_BillsToPay.Rows.Clear();
            PaymentConditions_Controller pcController = new PaymentConditions_Controller();
            Suppliers_Controller supController = new Suppliers_Controller();
            DataTable dt = this._controller.PopulateDGV();
            if (dt != null)
            {
                PaymentMethods_Controller metController = new PaymentMethods_Controller();
                foreach (DataRow dr in dt.Rows)
                {
                    var supplier = supController.FindItemId(Convert.ToInt32(dr["supplier_id"]));
                    var billNum = Convert.ToInt32(dr["billNumber"]);
                    var billModel = Convert.ToInt32(dr["billModel"]);
                    var billSeries = Convert.ToInt32(dr["billSeries"]); 
                    var instalmentNumber = Convert.ToInt32(dr["instalmentNumber"]);
                    var emissionDate = Convert.ToDateTime(dr["emissionDate"]).ToShortDateString();
                    var dueDate = Convert.ToDateTime(dr["dueDate"].ToString()).ToShortDateString();
                    var status = string.Empty;
                    var paymentMethod = metController.FindItemId(Convert.ToInt32(dr["payMethod_id"]));

                    var totalValue = (decimal)dr["BillValue"];
                    //var paymentCondition = _controller.FindItemId(billNum, billModel, billSeries, instalmentNumber, supplier.id).PaymentCondition;
                    //string instalmentValue = (totalValue * (paymentCondition.BillsInstalments[instalmentNumber-1].ValuePercentage / 100)).ToString("#.##");

                    if (dr["paidDate"] == DBNull.Value && dr["date_cancelled"] == DBNull.Value)
                    {
                        status = "ATIVO";
                    }
                    else if (dr["paidDate"] != DBNull.Value)
                    {
                        status = "PAGO";
                    }
                    else if (dr["date_cancelled"] != DBNull.Value)
                    {
                        status = "CANCELADO";
                    }
                    DGV_BillsToPay.Rows.Add(
                        supplier.id,
                        supplier.name,
                        paymentMethod.id,
                        paymentMethod.paymentMethod,
                        billNum,
                        billModel,
                        billSeries,
                        instalmentNumber,
                        //instalmentValue,
                        totalValue,
                        emissionDate,
                        dueDate,
                        status);                     
                }
            }
        }

        public override void NewObject()
        {
            string formFunc = "New";
            Frm_Create_BillsToPay frmCreateBillsToPay = new Frm_Create_BillsToPay(formFunc, null, _User);
            frmCreateBillsToPay.ShowDialog();
            this.SetDataSourceToDGV();
        }

        private void SetPaidBill_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToPay.Rows.Count > 0)
            {
                var obj = GetObject();
                if (obj.PaidDate != null || DGV_BillsToPay.SelectedRows[0].Cells["isPaid"].Value.ToString() == "PAGO")
                {
                    string message = "Conta já foi paga.";
                    string caption = "Não é possível alterar a parcela.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, icon);
                }
                else if (obj.CancelledDate != null || DGV_BillsToPay.SelectedRows[0].Cells["isPaid"].Value.ToString() == "CANCELADO")
                {
                    string message = "Está conta já foi cancelada.";
                    string caption = "Não é possível alterar a parcela.";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, icon);
                }
                else if (RightInstalment())
                {
                    NewPopulatedToPayForm();
                }
            }
        }

        private bool RightInstalment()
        {
            var billNumber = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["BillNumber"].Value);
            var billModel = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billModel"].Value);
            var billSeries = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["billSeries"].Value);
            var supplierId = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["SupplierId"].Value);
            var instalmentNum = Convert.ToInt32(DGV_BillsToPay.SelectedRows[0].Cells["InstalmentNumber"].Value);
            var obj = _controller.FindItemId(billNumber, billModel, billSeries, supplierId);
            if (instalmentNum > 1)
            {
                for (int i = 0; i < instalmentNum-1; i++)
                {
                    if (obj[i].CancelledDate.HasValue) //Confirmar
                    {
                        string message = "As contas referente a essa nota foram canceladas, não é possível alterar.";
                        string caption = "Não é possível alterar a parcela.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, icon);
                        return false;
                    }
                    else if (!obj[i].PaidDate.HasValue)
                    {
                        string message = "Existem parcelas anteriores referente a essa compra em aberto.";
                        string caption = "Não é possível alterar essa parcela.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, icon);
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool AskToPay()
        {
            string message = $"Deseja baixar essa nota?";
            string caption = "Confirmação.";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        private void btn_CancelBill_Click(object sender, EventArgs e)
        {
            if (DGV_BillsToPay.Rows.Count > 1)
            {
                if (Authentication.Authenticate(_User.AccessLevel, 3))
                {
                    if (AbleToCancel())
                    {
                        NewPopulatedToCancelForm();
                    }
                }
            }
        }

        private bool AbleToCancel()
        {
            var obj = GetObject();
            if (obj != null)
            {
                var list = _controller.FindItemId(obj.BillNumber, obj.BillModel, obj.BillSeries, obj.Supplier.id);
                for (int i = 0; i < obj.InstalmentNumber; i++)
                {
                    if (list[i].PaidDate != null || list[i].PaidDate.HasValue)
                    {
                        string message = "Não é possível cancelar essa conta pois já existem notas pagas relacionadas a essa compra.";
                        string caption = "Conta já paga.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        Utilities.Msgbox(message, caption, buttons, icon);
                        return false;
                    }
                    else if (list[i].CancelledDate != null || list[i].CancelledDate.HasValue)
                    {
                        string message = "Conta já cancelada.";
                        string caption = "Conta cancelada.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        Utilities.Msgbox(message, caption, buttons, icon);
                        return false;
                    }
                }
                if (list[0].BillModel > 0)
                {
                        string message = "Não é possível cancelar contas relacionadas a compras, cancelamento deve ser feito pelo formulário de Compras.";
                        string caption = "Conta relacionada com Compra.";
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        Utilities.Msgbox(message, caption, buttons, icon);
                        return false;

                }
                return true;
            }
            else return false;
        }

        private void NewPopulatedToPayForm()
        {
            var obj = GetObject();
            if (obj != null)
            {
                string formFunc = "Pay";
                Frm_Create_BillsToPay frmBillsToReceive = new Frm_Create_BillsToPay(formFunc, obj, _User);
                frmBillsToReceive.ShowDialog();
                SetDataSourceToDGV();
            }
            else
            {
                Utilities.IsNotSelected(obj, "Conta");
            }
        }

        private void NewPopulatedToCancelForm()
        {
            var obj = GetObject();
            if (obj != null)
            {
                string formFunc = "Cancel";
                Frm_Create_BillsToPay frmBillsToReceive = new Frm_Create_BillsToPay(formFunc, obj, _User);
                frmBillsToReceive.ShowDialog();
                SetDataSourceToDGV();
            }
            else
            {
                Utilities.IsNotSelected(obj, "Conta");
            }
        }
    }
}
