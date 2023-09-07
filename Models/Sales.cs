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
//            List<BillsToReceive> BillToReceive; 
            List<SaleItems> SaleItems; 
            Clients Client;
            Users User;
        }

        public PaymentConditions PaymentCondition { get; set; }
        public Users User { get; set; }
        public Clients Client { get; set; }
        public DateTime? CancelDate { get; set; }
        //public List<BillsToReceive> BillToReceive { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalValue { get; set; }
        public List<SaleItems> SaleItems { get; set; }
        public int TotalItemsQuantity { get; set;}
    }
}
