using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class States : Identifications
    {
        public States()
        {
            Countries country = new Countries();
        }

        public string stateName { get; set; }
        public Countries country { get; set; }
        public string fedUnit { get; set; }

    }
}
