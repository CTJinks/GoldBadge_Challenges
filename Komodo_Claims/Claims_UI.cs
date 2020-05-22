using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    class Claims_UI
    {
        public readonly Claims_Repository _repo = new Claims_Repository();
        public void Run()
        {
            SeedClaimsList();
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
                        "1. Show All Claims\n" +
                        "2. Take Care of Next Claim\n" +
                        "3. Enter a New Claim"
                    );
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        ShowAllClaims();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void AddNewClaim()
        {
            Console.Clear();
            Console.WriteLine("Enter an ID:");
            int claimId  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a claim type:\n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft");
            string typeChoice = Console.ReadLine();
            ClaimType claimType = new ClaimType();
            switch (typeChoice)
            {
                case "1":
                    claimType = ClaimType.Car;
                    break;
                case "2":
                    claimType = ClaimType.Home;
                    break;
                case "3":
                    claimType = ClaimType.Theft;
                    break;
            }
            Console.WriteLine("Enter description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter claim amount:");
            double claimAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter date of incident:");
            DateTime dateOfIncident = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter date of claim:");
            DateTime dateOfClaim = Convert.ToDateTime(Console.ReadLine());
            Claim newClaim = new Claim(claimId, claimType, description, claimAmount, dateOfIncident, dateOfClaim);
            _repo.AddClaimToDirectory(newClaim);

        }
        public void TakeCareOfNextClaim()
        {  
            Console.Clear();
            _repo.FirstClaim();
        }
        public void ShowAllClaims()
        {
            Console.Clear();
            Console.WriteLine("ID TYPE DESCRIPTION       AMOUNT    ACCIDENT DATE        CLAIM DATE       VALID");
            Queue<Claim> listOfContent = _repo.GetClaims();
            foreach (Claim content in listOfContent)
            {
                DisplayClaim(content);
            }
        }
        public void DisplayClaim(Claim item)
        {
            Console.WriteLine($"{item.ClaimId} {item.ClaimType} {item.Description} {item.ClaimAmount} {item.DateOfIncident} {item.DateOfClaim} {item.IsValid}");
        }
        private void SeedClaimsList()
        {
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00, new DateTime(2018,4,25), new DateTime(2018,4,27));
            _repo.AddClaimToDirectory(claimOne);
        }
    }
}
