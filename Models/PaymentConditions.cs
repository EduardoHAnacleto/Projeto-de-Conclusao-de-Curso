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
                feePerInst = cond.paymentFees / 100;
            }
            if (dueDate.Date < DateTime.Now.Date)
            {
                fine = cond.fineValue/100;
            }
            else if (dueDate.Date > DateTime.Now.Date)
            {
                discount = cond.discountPerc/100;
            }
            return value + ( value * feePerInst) - (discount * value) + (fine * value);
        }
    }
}
