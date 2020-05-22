using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    class Insurance_UI
    {
        public readonly Badge_Repo badge_Repo = new Badge_Repo();
        public void Run()
        {
            SeedBadgeList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "enter the number of your selection:\n" +
                    "1. create a new badge\n" +
                    "2. update a badge\n" +
                    "3. list all badges and door access");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        CreateNewBadge();
                        Console.ReadKey();
                        break;
                    case "2":
                        UpdateBadge();
                        Console.ReadKey();
                        break;
                    case "3":
                        ShowAllBadges();
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void CreateNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Enter a Badge ID:");
            int badgeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter accessible doors:");
            string accessibleDoors = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add(accessibleDoors);
            string[] newBadgeDoors = list.ToArray();
            Badges newBadge = new Badges(badgeId, newBadgeDoors);
            badge_Repo.AddBadgeToDirectory(newBadge);
            Console.WriteLine("Badge has been created! Press any key to continue");
        }
        public void UpdateBadge()
        {
            Console.Clear();
            Dictionary<int, string[]> listOfContent = badge_Repo.GetBadges();
            Console.WriteLine("please enter the badge ID of the badge you want to update:");
            int badgeId = Convert.ToInt32(Console.ReadLine());
            if (listOfContent.TryGetValue(badgeId, out string[] value))
            {
                Console.WriteLine(badgeId + " has access to these doors: " + value);
                Console.WriteLine("What would you like to do?\n" +
                    "1. Remove a door\n" +
                    "2. Add a Door");
                string updateInput = Console.ReadLine();
                switch (updateInput)
                {
                    case "1":
                        listOfContent[badgeId] = RemoveADoor(value);
                        break;
                    case "2":
                        listOfContent[badgeId] = AddDoor(value);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: no badges with this ID were found. Press any key to continue");
            }

        }
        public string[] AddDoor(string[] value)
        {
            Console.WriteLine("Enter the door you would like to add:");
            string doorToAdd = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add(doorToAdd);
            string[] newDoors = list.ToArray();
            var myList = new List<string>();
            myList.AddRange(value);
            myList.AddRange(newDoors);
            string[] newValue = myList.ToArray();
            Console.WriteLine("Door has been added. Press any key to continue");
            return newValue;
        }
        public string[] RemoveADoor(string[] value)
        {
            Console.WriteLine("Enter the door you would like to remove:");
            string doorToRemove = Console.ReadLine();
            string [] newValue = value.Where(val => val != doorToRemove).ToArray();
            Console.WriteLine("Door has been removed. Press any key to continue");
            return newValue;
        }
        public void ShowAllBadges()
        {
            Console.Clear();
            Console.WriteLine("BADGE-ID     ACESSIBLE-DOORS");
            Dictionary<int, string[]> listOfContent = badge_Repo.GetBadges();
            for (int i = 0; i < listOfContent.Count; i++)
            {
                Console.WriteLine("{0}        {1}", listOfContent.Keys.ElementAt(i), string.Join(" ", listOfContent.Values.ElementAt(i)));
            }
            Console.WriteLine("Press any key to continue");
        }
        private void SeedBadgeList()
        {

            Badges badgeOne = new Badges(12345, new string[] { "A4" });
            Badges badgeTwo = new Badges(22345, new string[] {"A1","A4","B1","B2"});
            Badges badgeThree = new Badges(32345, new string[] { "A4", "A5" });
            badge_Repo.AddBadgeToDirectory(badgeOne);
            badge_Repo.AddBadgeToDirectory(badgeTwo);
            badge_Repo.AddBadgeToDirectory(badgeThree);
        }
    }
}
