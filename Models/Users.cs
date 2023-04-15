using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Users : Employees
    {
        public Users()
        {
            Employees employee = new Employees();
        }

        public Employees employee { get; set; }
        public string userLogin { get; set; }
        public string userPassword { get; set; }
        public int AccessLevel { get; set; }
    }
}
