using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.People
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; }
        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.24;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
            
        }
    }
}
