using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class BillsToPay : Identifications
    {
        public BillsToPay()
        {
            Suppliers Supplier = new Suppliers();
            PaymentMethods PaymentMethod = new PaymentMethods();
            Purchases Purchase = new Purchases();
            PaymentConditions PaymentCondition = new PaymentConditions();
        }

        public int BillNumber { get; set; }
        public int BillSeries { get; set; }
        public int BillModel { get; set; }
        public double TotalValue { get; set; }
        public int InstalmentNumber { get; set; }

        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public DateTime? PaidDate { get; set; }

        //public int PurchaseId { get; set; }
        public Purchases Purchase { get; set; }
        public Suppliers Supplier { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public PaymentConditions PaymentCondition { get; set; }

        public static List<BillsToPay> MakeBills(Purchases purchase, PaymentConditions condition)
        {
            List<BillsToPay> list = new List<BillsToPay>();
            int i = 0;
            PaymentConditions cond = condition;
            int instalmentQtd = cond.BillsInstalments.Count;

            foreach (BillsInstalments instalments in cond.BillsInstalments)
            {
                BillsToPay bill = new BillsToPay();
                bill.PaymentCondition = cond;
                bill.BillNumber = purchase.BillNumber;
                bill.BillModel = purchase.BillModel;
                bill.BillSeries = purchase.BillSeries;
                bill.InstalmentNumber = instalments.InstalmentNumber;
                bill.PaidDate = null;
                bill.Status = 0;
                bill.Supplier = purchase.Supplier;
                bill.Purchase = purchase;
                bill.EmissionDate = purchase.EmissionDate;
                bill.DueDate = purchase.EmissionDate.AddDays(instalments.TotalDays);
                bill.TotalValue = ((instalments.ValuePercentage / 100) * purchase.Total_Cost) + (cond.paymentFees/ cond.BillsInstalments.Count);
                bill.PaymentMethod = instalments.PaymentMethod;

                list.Add(bill);
            }
            return list;
        }


    }
}
