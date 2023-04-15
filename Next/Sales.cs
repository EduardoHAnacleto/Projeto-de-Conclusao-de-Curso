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
            BillsToReceive billsToReceive = new BillsToReceive();
            List<SaleItems> saleItems = new List<SaleItems>();
            People client = new People();
            Users user = new Users();
        }

        public Users user { get; set; }
        public People client { get; set; }
        public DateTime cancelDate { get; set; }
        public BillsToReceive BillToReceive { get; set; }
        public DateTime emissionDate { get; set; }
        public double totalCost { get; set; }
        public double totalValue { get; set; }
        public List<SaleItems> saleItems { get; set; }
        public double saleDiscountCash { get; set; }
        public double saleDiscountPerc { get; set; }
        public int totalItemsQuantity { get; set;}
    }
}
