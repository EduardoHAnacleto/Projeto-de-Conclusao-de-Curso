using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PurchaseItems : Identifications
    {
        public PurchaseItems()
        {
            Products product = new Products();
        }

        public int purchase_id { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }
        public double value { get; set; }
        public double discount { get; set; }
        public double totalValue { get; set; }
    

    }
}
