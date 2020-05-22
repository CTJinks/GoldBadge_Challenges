using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    class Claims_Repository
    {
        private Queue<Claim> _claimDirectory = new Queue<Claim>();
        
        public bool AddClaimToDirectory(Claim item)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Enqueue(item);
            bool wasAdded = _claimDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public Queue<Claim> GetClaims()
        {
            return _claimDirectory;
        }
        public bool FirstClaim()
        {
            var nextClaim = _claimDirectory.Dequeue();
            Console.WriteLine("ID TYPE DESCRIPTION       AMOUNT    ACCIDENT DATE        CLAIM DATE       VALID");
            Console.WriteLine(nextClaim.ClaimId + " " + nextClaim.ClaimType + " " + nextClaim.Description + " " + nextClaim.ClaimAmount + " " + nextClaim.DateOfIncident + " " + nextClaim.DateOfClaim + " " + nextClaim.IsValid + "\nDo you want to deal with this claim now(y/n)?");
            string yesOrNo = Console.ReadLine();
            switch (yesOrNo)
            {
                case "y":
                case "Y":
                case "Yes":
                case "yes":
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;
                case "N":
                case "n":
                case "No":
                case "no":
                    _claimDirectory.Enqueue(nextClaim);
                    Console.WriteLine("Claim will be put back at the top of the list \n Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
            return true;
        }
    }
}
