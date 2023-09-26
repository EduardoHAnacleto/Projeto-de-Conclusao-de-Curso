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
        public decimal paymentFees { get; set; }
        public decimal fineValue { get; set; }
        public decimal discountPerc { get; set; }
        public int instalmentQuantity { get; set; }
        public List<BillsInstalments> BillsInstalments { get; set; }

        public static decimal CalcValue(decimal value, PaymentConditions cond, DateTime dueDate)
        {
            int instalmentQtd = cond.BillsInstalments.Count();
            decimal feePerInst = 0;
            decimal discount = 0;
            decimal fine = 0;
            if (cond.paymentFees > 0)
            {
                feePerInst = cond.paymentFees / instalmentQtd;
            }
            if (dueDate < DateTime.Now.Date)
            {
                fine = cond.fineValue;
            }
            else if (dueDate > DateTime.Now.Date)
            {
                discount = cond.fineValue;
            }
            return value + feePerInst + discount + fine;
        }
    }
}
