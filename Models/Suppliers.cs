using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Suppliers : People
    {

        public Suppliers()
        {
            People person = new People();
        }

        public People person { get; set; }
        public string socialReason { get; set; }
        public string stateInscription { get; set; }


    }
}
