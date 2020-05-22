using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Outings
{
    public enum EventType {Golf, Bowling, Amusement_Park, Concert}
    class Outing
    {
        public EventType EventType { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime DateOfOuting { get; set; }
        public double CostPerPerson { get; set; }
        public double CostOfEvent { 
            get{
                double cost = Convert.ToDouble(NumberOfPeople) * CostPerPerson;
                return cost;
            }
        }
        public Outing(EventType eventType, int numberOfPeople, DateTime dateOfOuting, double costOfPerson)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            DateOfOuting = dateOfOuting;
            CostPerPerson = costOfPerson;
        }
    }
}
