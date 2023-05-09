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
            PaymentConditions Condition = new PaymentConditions();
            BillsInstalments BillInstalment = new BillsInstalments();
        }

        public bool IsPaid { get; set; }
        public Clients Client { get; set; }
        public PaymentConditions Condition { get; set; }    
        public int InstalmentNumber { get; set; }
        public int InstalmentsQtd { get; set; }
        public DateTime EmissionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public double InstalmentValue { get; set; }


    }
}
