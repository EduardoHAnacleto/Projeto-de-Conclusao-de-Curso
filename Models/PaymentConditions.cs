using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class PaymentConditions : Identifications
    {
        public PaymentConditions()
        {
            List<BillsInstalments> BillsInstalments = new List<BillsInstalments>();
        }
        public string conditionName { get; set; }
        public double paymentFees { get; set; }
        public double fineValue { get; set; }
        public double discountPerc { get; set; }
        public int instalmentQuantity { get; set; }
        public List<BillsInstalments> BillsInstalments { get; set; }


    }
}
