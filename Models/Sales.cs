using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Sales : Identifications
    {
        public Sales()
        {
            List<BillsToReceive> BillToReceive = new List<BillsToReceive>();
            List<SaleItems> SaleItems = new List<SaleItems>();
            Clients Client = new Clients();
            Users User = new Users();
        }

        public Users User { get; set; }
        public Clients Client { get; set; }
        public DateTime? CancelDate { get; set; }
        public List<BillsToReceive> BillToReceive { get; set; }
        public double TotalCost { get; set; }
        public double TotalValue { get; set; }
        public List<SaleItems> SaleItems { get; set; }
        public double SaleDiscountCash { get; set; }
        public double SaleDiscountPerc { get; set; }
        public int TotalItemsQuantity { get; set;}
    }
}
