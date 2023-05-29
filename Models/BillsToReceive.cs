using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class BillsToReceive : Identifications
    {

        public BillsToReceive()
        {
            Clients Client = new Clients();
            PaymentMethods PaymentMethod = new PaymentMethods();
            Sales Sale = new Sales();
        }

        public bool IsPaid { get; set; }
        public Clients Client { get; set; }
        public Sales Sale { get; set; }
        public PaymentMethods PaymentMethod { get; set; }    
        public int InstalmentNumber { get; set; }
        public int InstalmentsQtd { get; set; }
        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public double InstalmentValue { get; set; }


    }
}
