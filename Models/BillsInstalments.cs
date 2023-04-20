using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class BillsInstalments : Identifications
    {
        public BillsInstalments()
        {
            PaymentMethods PaymentMethod = new PaymentMethods();
        }

        public int InstalmentNumber { get; set; }
        public int TotalDays { get; set; }
        public double ValuePercentage { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
