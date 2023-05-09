using ProjetoEduardoAnacletoWindowsForm1.Next;
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
            Clients Client = new Clients();
            List<OSItems> OSItems = new List<OSItems>();
            Services Service = new Services();
            Users User = new Users();
        }

        public Users User { get; set; }
        public List<OSItems> OSItems { get; set; }   
        public Clients Client { get; set; }
        public Services Service { get; set; }
        public double OSTotalValue { get; set; }
        public string ExtraDetails { get; set; }
        public double ServiceCost { get; set; }
        public double ServiceDiscountCash { get; set; }
        public double ServiceDiscountPerc { get; set; }
        public DateTime? CompleteDate { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
