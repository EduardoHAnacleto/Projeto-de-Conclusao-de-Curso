using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoEduardoAnacletoWindowsForm1.Models.Addresses;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class People : Identifications
    {
        public People()
        {
            Cities city = new Cities();
            PhoneClassifications phoneClass1 = new PhoneClassifications();
            PhoneClassifications phoneClass2 = new PhoneClassifications();
            PhoneClassifications phoneClass3 = new PhoneClassifications();
        }

        public string name { get; set; }
        public int gender { get; set; }
        public int age { get; set; }
        public string registrationNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string streetName { get; set; }
        public string district { get; set; }
        public string houseNumber { get; set; }
        public string homeType { get; set; }
        public string complement { get; set; }
        public string zipCode { get; set; }
        public Cities city { get; set; }

        public string phoneNumber1 { get; set; }
        public string phoneNumber2 { get; set; }
        public string phoneNumber3 { get; set; }
        public PhoneClassifications phoneClass1 { get; set; }
        public PhoneClassifications phoneClass2 { get; set; }
        public PhoneClassifications phoneClass3 { get; set; }

    }
}
