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
            PaymentMethods paymentMethod = new PaymentMethods();
            PaymentConditions paymentCondition = new PaymentConditions();
        }

        public int InstalmentNumber { get; set; }
        public int totalDays { get; set; }
        public double valuePercentage { get; set; }
        public PaymentMethods paymentMethod { get; set; }
        public PaymentConditions paymentCondition { get; set; }
    }
}
