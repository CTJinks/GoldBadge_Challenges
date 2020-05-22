using System;
using _08_Inheritance_Classes.Animals;
using _08_Inheritance_Classes.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Giraffe giraffe = new Giraffe();
            giraffe.Move();
            Wolf wolf = new Wolf();
            wolf.Move();
            wolf.MakeSound();
            Dog dog = new Dog();
            dog.MakeSound();
        }
        [TestMethod]
        public void PersonTest1()
        {
            Person person = new Person();
            person.SetFirstName("Summer");
            person.SetLastName("Smith");
            Console.WriteLine(person.Name);

            Student student = new Student();
            student.SetFirstName("Summer");
            student.SetLastName("Smith");
            student.SetScoreOne(2);
            student.SetScoreTwo(9);
            student.SetScoreThree(10);
            Console.WriteLine(student.Grade);

        }
        
    }
}
