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
        public DateTime? ArrivalDate { get; set; }

        public double Freight_Cost { get; set; }
        public double Total_PurchaseValue { get; set; }
        public double Total_Cost { get; set; }
        public double ExtraExpenses { get; set; }
        public double DiscountPerc { get; set; }
        public double DiscountCash { get; set; }
        public double InsuranceCost { get; set; }

        public Users User { get; set; }
        public PaymentConditions PayCondition { get; set; }
        public List<PurchaseItems> PurchasedItems { get; set; }
        public Suppliers Supplier { get; set; }
        public List<BillsToPay> BillToPay { get; set; }

        public Purchases()
        {
            PaymentConditions PayConditon = new PaymentConditions();
            Suppliers Supplier = new Suppliers();
            List<BillsToPay> BillToPay = new List<BillsToPay>();
            List<PurchaseItems> PurchasedItems = new List<PurchaseItems>();
            Users User = new Users();
        }
    }
}
