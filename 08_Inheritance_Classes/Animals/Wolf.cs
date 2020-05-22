using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Wolf : Animals
    {
        public Wolf()
        {
            HasTail = true;
            DietType = DietType.Carnivore;
            Console.WriteLine("This is the wolf constructor");
        }
        public double ClawLength { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("AWOOOOOOOOOOO");
        }
    } 
    
    public class Dog : Wolf
    {
        public Dog()
        {
            Console.WriteLine("this is a dog constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("BARK");
        }
    }
}
