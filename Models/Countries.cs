using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Countries : Identifications
    {
        public Countries()
        {

        }

        public string countryName { get; set; }
        public string countryAcronym { get; set; }
        public string countryPhonePrefix { get; set; }
        public string countryCurrency { get; set; }

    }
}
