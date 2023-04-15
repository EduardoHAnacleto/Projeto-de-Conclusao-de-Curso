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
        public Purchases()
        {
            PaymentConditions payConditon = new PaymentConditions();
            Suppliers suppliers = new Suppliers();
            BillsToPay billToPay = new BillsToPay();
            List<PurchaseItems> purchase_items = new List<PurchaseItems>();
        }

        public int status { get; set; }
        public DateTime emissionDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public double freight_Cost { get; set; }
        public double total_PurchaseValue { get; set; }
        public double total_Cost { get; set; }
        public double expenses { get; set; }
        public double discount { get; set; }
        public double insurance { get; set; }
        public PaymentConditions payCondition { get; set; }
        public List<PurchaseItems> purchase_items { get; set; }
        public Suppliers supplier { get; set; }
        public BillsToPay billToPay { get; set; }

    }
}
