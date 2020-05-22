using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.People
{
    public class Customer : Person
    {
        public bool IsPremium { get; set; }
        public bool IsKaren { get; set; }
        public bool IsSubscribedToEmails { get; set; }
        public int CustomerId { get; }
        public void SpeakToManager()
        {
            Console.WriteLine("um... excuse me");
        }
    }
}
