using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Products : Identifications
    {
        public Products()
        {
            Brands brand = new Brands();
            ProductGroups productGroup = new ProductGroups();
        }

        public string productName { get; set; }
        public double productCost { get; set; }
        public double salePrice { get; set; }
        public int stock { get; set; }
        public long BarCode { get; set; }
        public Brands brand { get; set; }
        public ProductGroups productGroup { get; set; }
    }
}
