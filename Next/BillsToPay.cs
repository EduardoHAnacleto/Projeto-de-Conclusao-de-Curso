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
            Suppliers suppliers = new Suppliers();
            PaymentMethods paymentForms = new PaymentMethods();
        }

        public int billNumber { get; set; }
        public string billSeries { get; set; }
        public string billModel { get; set; }
        public int billInstalmentNumber { get; set; }
        public DateTime dueDate { get; set; }
        public double totalValue { get; set; }
        public int isPaid { get; set; }
        public Suppliers supplier { get; set; }
        public PaymentMethods paymentMethod { get; set; }

    }
}
