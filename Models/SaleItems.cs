using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class SaleItems : Identifications
    {
        public SaleItems()
        {
            Products Product = new Products();
        }

        public Products Product { get; set; }
        public int Quantity { get; set; }
        public double ProductValue { get; set; }
        public double TotalValue { get; set; }
        public double ProductCost { get; set; }
        public double ItemDiscountCash { get; set; }
    }
}
