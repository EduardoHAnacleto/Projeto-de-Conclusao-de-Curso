using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Purchases : Identifications
    {
        public int Status { get; set; }
        public DateTime EmissionDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime? CancelledDate { get; set; }

        public double Freight_Cost { get; set; }
        public double Total_Cost { get; set; }
        public double ExtraExpenses { get; set; }
        public double InsuranceCost { get; set; }
        public int BillNumber { get; set; }
        public int BillSeries { get; set; }
        public int BillModel { get; set; }

        public PaymentConditions PaymentCondition { get; set; }
        public Users User { get; set; }
        public List<PurchaseItems> PurchasedItems { get; set; }
        public Suppliers Supplier { get; set; }

        public Purchases()
        {
            Suppliers Supplier = new Suppliers();
            List<PurchaseItems> PurchasedItems = new List<PurchaseItems>();
            Users User = new Users();
            PaymentConditions PaymentCondition = new PaymentConditions();
        }
    }
}
