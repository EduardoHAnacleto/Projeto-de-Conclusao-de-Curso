using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class BillsToPay : Identifications
    {
        public BillsToPay()
        {
            Suppliers Supplier = new Suppliers();
            PaymentMethods PaymentMethod = new PaymentMethods();
            Purchases Purchase = new Purchases();
        }

        public int BillNumber { get; set; }
        public int BillSeries { get; set; }
        public int BillModel { get; set; }
        public int BillPage { get; set; }
        public double TotalValue { get; set; }
        public int InstalmentNumber { get; set; }
        public int InstalmentsQtd { get; set; }

        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public int IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }

        //public int PurchaseId { get; set; }
        public Purchases Purchase { get; set; }
        public Suppliers Supplier { get; set; }
        public PaymentMethods PaymentMethod { get; set; }


    }
}
