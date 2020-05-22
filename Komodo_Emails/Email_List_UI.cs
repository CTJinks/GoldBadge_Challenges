using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Emails
{
    class Email_List_UI
    {
        public readonly People_Repository _repo = new People_Repository();
        public void Run()
        {
            SeedPeopleList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of your selection:\n" +
                    "1. create new person\n" +
                    "2. show all people\n"+
                    "3. update person\n"+
                    "4. delete person");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        AddNewPerson();
                        Console.ReadKey();
                        break;
                    case "2":
                        DisplayPeople();
                        Console.ReadKey();
                        break;
                    case "3":
                        ChangePersonType();
                        Console.ReadKey();
                        break;
                    case "4":
                        RemovePersonByName();
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void RemovePersonByName()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the person you would like to remove:");
            string name = Console.ReadLine() + " ";
            _repo.RemovePersonByName(name);
            Console.WriteLine("Press any key to continue");
        }
        public void ChangePersonType()
        {
            Console.Clear();
            Console.WriteLine("Enter the first and last name of the person you want to update:");
            string name = Console.ReadLine() + " ";
            People person = _repo.GetPersonByName(name);
            if (person == null)
            {
                Console.WriteLine("no content found");
            }
            else
            {
                Console.WriteLine("choose the type of customer you want this person to be:\n" +
                "1. Potential\n" +
                "2. Current\n" +
                "3. Past");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        person.PersonType = PersonType.Potential;
                        break;
                    case "2":
                        person.PersonType = PersonType.Current;
                        break;
                    case "3":
                        person.PersonType = PersonType.Past;
                        break;
                }
                Console.WriteLine("person has been updated");
                Console.WriteLine("Press any key to continue");
            }
        }
        public void DisplayPeople()
        {
            Console.Clear();
            Console.WriteLine("FIRST NAME     LAST NAME     CUSTOMER TYPE      EMAIL");
            List<People> listOfPeople = _repo.GetPeople();
            foreach(People people in listOfPeople)
            {
                DisplayPerson(people);
            }
            Console.WriteLine("Press any key to continue");
        }
        public void DisplayPerson(People person)
        {
            int foundS1 = person.Name.IndexOf(" ");
            int foundS2 = person.Name.LastIndexOf(" ");
            string firstName = person.Name.Remove(foundS1 + 1, foundS2 - foundS1);
            string lastName = person.Name.Remove(0, foundS1);
            Console.WriteLine(String.Format("{0,-13} {1,-14} {2,-18} {3}", firstName, lastName, person.PersonType, person.Email));
            
        }
        public void AddNewPerson()
        {
            Console.Clear();
            Console.WriteLine("What is the new person's first and last name?");
            string almostName = Console.ReadLine();
            string name = almostName + " ";
            Console.WriteLine("choose the type of customer you want this person to be:\n" +
                "1. Potential\n" +
                "2. Current\n" +
                "3. Past");
            string selection = Console.ReadLine();
            PersonType personType = new PersonType();
            switch (selection)
            {
                case "1":
                    personType = PersonType.Potential;
                    break;
                case "2":
                    personType = PersonType.Current;
                    break;
                case "3":
                    personType = PersonType.Past;
                    break;
            }
            People newPerson = new People(name, personType);
            _repo.AddPersonToDirectory(newPerson);
            Console.WriteLine("Press any key to continue");
        }
        private void SeedPeopleList()
        {
            People personOne = new People("Jake Smith ", PersonType.Potential);
            People personTwo = new People("James Smith ", PersonType.Current);
            People personThree = new People("Jane Smith ", PersonType.Past);
            _repo.AddPersonToDirectory(personOne);
            _repo.AddPersonToDirectory(personTwo);
            _repo.AddPersonToDirectory(personThree);
        }
    }
}
