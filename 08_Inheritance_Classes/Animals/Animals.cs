using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public enum DietType { Herbivore, Carnivore, Omnivore}
    public abstract class Animals
    {
        public string Color { get; set; }
        public int NumberOfLegs { get; set; }
        public bool HasTail { get; set; } = false;
        public DietType DietType { get; set; }

        public Animals()
        {
            Console.WriteLine("Make an animal!");
        }

        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moves");
        }
    }
}
