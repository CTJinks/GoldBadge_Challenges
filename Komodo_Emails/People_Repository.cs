using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Emails
{
    class People_Repository
    {
        private List<People> _peopleDirectory = new List<People>();
        public bool AddPersonToDirectory(People person)
        {
            int startingCount = _peopleDirectory.Count;
            _peopleDirectory.Add(person);
            bool wasAdded = _peopleDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public List<People> GetPeople()
        {
            return _peopleDirectory;
        }
        public People GetPersonByName(string name)
        {
            foreach (People person in _peopleDirectory)
            {
                if (person.Name == name)
                {
                    return person;
                }
            }
            return null;
        }
        public bool RemovePersonByName(string name)
        {
            People person = GetPersonByName(name);
            if(name == null)
            {
                Console.WriteLine("no person with this name was found");
                return false;
            }
            else
            {
                _peopleDirectory.Remove(person);
                return true;
            }
        }
    }
}
