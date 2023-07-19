using ProjetoEduardoAnacletoWindowsForm1.Controllers;
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

        public static List<BillsToReceive> MakeBills(Sales sale)
        {
            PaymentConditions_Controller condController = new PaymentConditions_Controller();
            DateTime emDate = DateTime.Now;
            List<BillsToReceive> list = new List<BillsToReceive>();
            int i = 0;
            PaymentConditions cond = condController.FindItemId(sale.PaymentConditionId);
            int instalmentQtd = cond.BillsInstalments.Count;

            foreach (BillsInstalments instalments in cond.BillsInstalments)
            {
                BillsToReceive bill = new BillsToReceive();
                bill.InstalmentNumber = instalments.InstalmentNumber;
                bill.PaidDate = null;
                bill.IsPaid = false;
                if (cond.BillsInstalments[i].TotalDays == 0) //Se a primeira parcela for na hora ou a vista, considera pago
                {
                    bill.IsPaid = true;
                    bill.PaidDate = emDate;
                    i++;
                }              
                bill.Client = sale.Client;
                bill.Sale = sale;
                bill.EmissionDate = emDate;
                bill.DueDate = emDate.AddDays(instalments.TotalDays);
                bill.InstalmentValue = instalments.ValuePercentage * sale.TotalValue;
                bill.PaymentMethod = instalments.PaymentMethod;
                bill.InstalmentsQtd = instalmentQtd;

                list.Add(bill);
            }
            return list;
        }

    }
}
