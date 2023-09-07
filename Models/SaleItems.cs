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
        public decimal ProductValue { get; set; }
        public decimal TotalValue { get; set; }
        public decimal ProductCost { get; set; }
        public decimal ItemDiscountCash { get; set; }
    }
}
