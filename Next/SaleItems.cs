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
            Products product = new Products();
            Sales Sale = new Sales();
        }

        public Sales Sale { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }
        public double value { get; set; }
        public double totalValue { get; set; }
        public double productCost { get; set; }
        public double ItemDiscountCash { get; set; }
        public double ItemDiscountPerc { get; set; }
    }
}
