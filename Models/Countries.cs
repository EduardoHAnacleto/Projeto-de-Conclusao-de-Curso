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


        public Countries Clone(string name, string acronym, string phonePrefix, string currency)
        {
            Countries country = new Countries();
            country.countryName = name;
            country.countryAcronym = acronym;
            country.countryPhonePrefix = phonePrefix;
            country.countryCurrency = currency;

            return country;
        }

    }
}
