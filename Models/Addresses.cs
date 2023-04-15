using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoEduardoAnacletoWindowsForm1.Models.Employees;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Addresses : Identifications
    {
        public Addresses()
        {
            Cities city = new Cities();
        }

        public enum HomeType
        {
            House = 1,
            Appartment = 2
        }

        public string streetName { get; set; }
        public string district { get; set; }
        public string houseNumber { get; set; }
        public HomeType homeType { get; set; }
        public string complement { get; set; }
        public string zipCode { get; set; }
        public Cities city { get; set; }

        public Addresses Clone(string streetName, string district, string houseNumber, HomeType homeType, string complement,
            string zipCode, Cities city)
        {
            Addresses address = new Addresses();
            address.streetName = streetName;
            address.district = district;
            address.houseNumber = houseNumber;
            address.homeType = homeType;
            address.complement = complement;
            address.zipCode = zipCode;
            address.city = city;

            return address;
        }
    }
}
