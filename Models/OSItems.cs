using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public class OSItems : Identifications
    {
        public OSItems()
        {
            List<Products> LProducts = new List<Products>();
            ServiceOrders ServiceOrder = new ServiceOrders();
        }

        public ServiceOrders ServiceOrder { get; set; }
        public List<Products> LProducts { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public double TotalValue { get; set; }
        public double ProductCost { get; set; }
        public double ItemDiscountCash { get; set; }
        public double ItemDiscountPerc { get; set; }
    }
}
