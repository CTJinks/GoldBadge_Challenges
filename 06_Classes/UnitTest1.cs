using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class class_tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle vehicleOne = new Vehicle();
            vehicleOne.Make = "Ford";
            Console.WriteLine(vehicleOne.Make);
            Console.WriteLine(vehicleOne.Model);
            Console.WriteLine(vehicleOne.Mileage);

            Console.WriteLine("\n\n");

            Vehicle vehicleTwo = new Vehicle("Volkswagen", "jetta", 150000.0, VehicleType.Car);
            Console.WriteLine(vehicleTwo.Make);
        }
        [TestMethod]
        public void PersonTest()
        {
            Person someone = new Person();
            someone.FirstName = "Christian";
            someone.LastName = "Jinks";
            Console.WriteLine(someone.FullName);

            Person someoneElse = new Person();
            someoneElse.DateOfBirth = new DateTime(1996, 5, 23);

            someone.DateOfBirth = DateTime.Now;

            Console.WriteLine(someoneElse.Age);
            Console.WriteLine(someone.Age);
        }
        [TestMethod]
        public void FizzBuzz(int num)
        {
            for (int i=1; i<=num; i++)
            {
                if(i% 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 15 ==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
