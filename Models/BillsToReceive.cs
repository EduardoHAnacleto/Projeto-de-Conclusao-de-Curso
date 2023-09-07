using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class BillsToReceive : Identifications
    {

        public BillsToReceive()
        {
            Clients Client = new Clients();
            PaymentMethods PaymentMethod = new PaymentMethods();
            Sales Sale = new Sales();
            PaymentConditions PaymentCondition = new PaymentConditions();
    }

        public bool IsPaid { get; set; }
        public Clients Client { get; set; }
        public Sales Sale { get; set; }
        public PaymentMethods PaymentMethod { get; set; }    
        public int InstalmentNumber { get; set; }
        public int InstalmentsQtd { get; set; }
        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal InstalmentValue { get; set; }
        public PaymentConditions PaymentCondition { get; set; }

        public static List<BillsToReceive> MakeBills(Sales sale, int saleId)
        {
            PaymentConditions_Controller condController = new PaymentConditions_Controller();
            DateTime emDate = DateTime.Now;
            List<BillsToReceive> list = new List<BillsToReceive>();
            PaymentConditions cond = condController.FindItemId(sale.PaymentCondition.id);
            int instalmentQtd = cond.BillsInstalments.Count;

            foreach (BillsInstalments instalments in cond.BillsInstalments)
            {
                BillsToReceive bill = new BillsToReceive();
                bill.PaymentCondition = cond;
                bill.InstalmentNumber = instalments.InstalmentNumber;
                bill.PaidDate = null;
                bill.IsPaid = false;           
                bill.Client = sale.Client;
                bill.Sale = sale;
                bill.Sale.id = saleId;
                bill.EmissionDate = emDate;
                bill.DueDate = emDate.AddDays(instalments.TotalDays);
                bill.InstalmentValue = ((instalments.ValuePercentage/100) * sale.TotalValue) + (cond.paymentFees / cond.BillsInstalments.Count);
                bill.PaymentMethod = instalments.PaymentMethod;
                bill.InstalmentsQtd = instalmentQtd;

                list.Add(bill);
            }
            return list;
        }

    }
}
