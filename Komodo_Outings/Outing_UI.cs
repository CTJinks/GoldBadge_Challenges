using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Outings
{
    class Outing_UI
    {
        public readonly Outing_Repo outing_Repo = new Outing_Repo();
        public void Run()
        {
            SeedOutingList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of your selection:\n"+
                    "1. Display all outings\n" +
                    "2. Add an outing\n"+
                    "3. Calculations\n");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        DisplayAllOutings();
                        Console.ReadKey();
                        break;
                    case "2":
                        AddOuting();
                        Console.ReadKey();
                        break;
                    case "3":
                        Calculations();
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void Calculations()
        {
            Console.Clear();
            Console.WriteLine("GOLF COSTS     BOWLING COSTS     PARK COSTS     CONCERT COSTS     TOTAL COSTS");
            List<Outing> listOfOutings = outing_Repo.GetOutings();
            double golfCost = 0;
            double bowlingCost = 0;
            double parkCost = 0;
            double concertCost = 0;
            foreach (Outing outing in listOfOutings)
            {
                if (outing.EventType == EventType.Golf)
                {
                    golfCost = golfCost + outing.CostOfEvent;
                }
                if (outing.EventType == EventType.Bowling)
                {
                    bowlingCost = bowlingCost + outing.CostOfEvent;
                }
                if (outing.EventType == EventType.Amusement_Park)
                {
                    parkCost = parkCost + outing.CostOfEvent;
                }
                if (outing.EventType == EventType.Concert)
                {
                    concertCost = concertCost + outing.CostOfEvent;
                }
            }
            double totalCost = golfCost + bowlingCost + parkCost + concertCost;
            string golfCostDisplay = Convert.ToString(golfCost);
            string bowlingCostDisplay = Convert.ToString(bowlingCost);
            string parkCostDisplay = Convert.ToString(parkCost);
            string concertCostDisplay = Convert.ToString(concertCost);
            string totalCostDisplay = Convert.ToString(totalCost);
            Console.WriteLine(String.Format("{0,-14} {1,-17} {2,-14} {3,-17} {4}", golfCostDisplay, bowlingCostDisplay, parkCostDisplay, concertCostDisplay, totalCostDisplay));
        }
        public void AddOuting()
        {
            Console.Clear();
            Console.WriteLine("What type of outing are you wanting to create?\n" +
                "1. Golf\n"+
                "2. Bowling\n"+
                "3. Amusement Park\n"+
                "4. Concert\n"+
                "Enter the number of your selection:");
            string selection = Console.ReadLine();
            EventType eventType = new EventType();
            switch (selection)
            {
                case "1":
                    eventType = EventType.Golf;
                    break;
                case "2":
                    eventType = EventType.Bowling;
                    break;
                case "3":
                    eventType = EventType.Amusement_Park;
                    break;
                case "4":
                    eventType = EventType.Concert;
                    break;
            }
            Console.WriteLine("Enter the number of people attending:");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of the event: (MM DD YYYY)");
            DateTime dateOfOuting = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the total cost per person:");
            double costPerPerson = Convert.ToDouble(Console.ReadLine());
            Outing newOuting = new Outing(eventType, numberOfPeople, dateOfOuting, costPerPerson);
            outing_Repo.AddOutingToDirectory(newOuting);
            Console.WriteLine("outing has been added");
        }
        public void DisplayAllOutings()
        {
            Console.Clear();
            Console.WriteLine("TYPE            # OF PEOPLE    DATE           COST PER PERSON    COST OF EVENT");
            List<Outing> listOfOutings = outing_Repo.GetOutings();
            foreach(Outing outing in listOfOutings)
            {
                DisplayOuting(outing);
            }
        }
        public void DisplayOuting(Outing outing)
        {
            string format = "MMM d yyyy";
            Console.WriteLine(String.Format("{0,-15} {1,-14} {2,-14} {3,-18} {4}", outing.EventType, outing.NumberOfPeople, outing.DateOfOuting.ToString(format), outing.CostPerPerson, outing.CostOfEvent));
        }
        private void SeedOutingList()
        {
            Outing outingOne = new Outing(EventType.Golf, 32, new DateTime(2020,04,23), 13.50);
            outing_Repo.AddOutingToDirectory(outingOne);
        }
    }
}
