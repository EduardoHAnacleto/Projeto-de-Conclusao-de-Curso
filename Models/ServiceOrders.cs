using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class ServiceOrders : Identifications
    {
        public ServiceOrders()
        {
            People client = new People();
            //List<Products> products = new List<Products>();
        }

        public DateTime oSDateTime { get; set; }
        public string equipment { get; set; }
       // public List<Products> products { get; set; }   ?????????
        public People client { get; set; }
        public Services service { get; set; }
        public double oSTotalValue { get; set; }
        public string extraDetails { get; set; }

    }
}
