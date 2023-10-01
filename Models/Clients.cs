using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Clients : People
    {
        public Clients()
        {
            People person = new People();
        }

        public People person { get; set; }
        public int clientType { get; set; }
        public PaymentConditions PaymentCondition { get; set; }
    }
}
