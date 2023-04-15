using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Models
{
    public class Employees: People
    {
        public Employees()
        {
            People person = new People();
        }

        public People Person { get; set; }
        public string jobRole { get; set; }
        public double baseSalary { get; set; }
        public int weeklyHours { get; set; }
        public int jobStatus { get; set; }
        public DateTime startDate { get; set; } //admissionDate
        // public DateTime endDate { get; set; }  //dismissedDate

        // public Nullable<DateTime> endDate { get; set; }
        public DateTime? endDate { get; set; }

    }
}
