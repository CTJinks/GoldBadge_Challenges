using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    
    public enum VehicleType { Car, Truck, Van, Suv, Motorcycle, Hovercraft, Spacecraft}
    public enum Makes { }
    public class Vehicle
    {
        public string Make { get; set; } = "none";
        public string Model { get; set; }
        public double Mileage { get; set; } = 0.0;
        public VehicleType TypeOfVehicle { get; set; }
        public Vehicle()
        {
            Console.WriteLine("Vehicle created!");
        }

        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }


    }
    public class Person
    {
        //Backing Field
        public string FirstName { get; set; }

        //public string LastName { get; set; }

        //backing field
        private string _lastName;
        //property
        public string LastName
        {
            get { return _lastName.ToUpper();  }
            set {
                string newName = value + "fffff";
                _lastName = newName; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.24;
                int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return years;
            }
        }
    }
}


