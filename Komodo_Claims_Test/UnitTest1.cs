using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Claims_Test
{
    public enum ClaimType { Car, Home, Theft }

    [TestClass]
    public class Claim
    {
        public int ClaimId { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                TimeSpan DaysSinceIncident = DateOfClaim.Subtract(DateOfIncident);
                TimeSpan ValidClaimDate = DateOfIncident.AddDays(30).Subtract(DateOfIncident);
                int Days = TimeSpan.Compare(DaysSinceIncident, ValidClaimDate);
                if (Days == 0 || Days == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Claim(int claimId, ClaimType claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimId = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
    [TestClass]
    public class Claims_Repository
    {
        private Queue<Claim> _claimDirectory = new Queue<Claim>();
        public bool AddClaimToDirectory(Claim item)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Enqueue(item);
            bool wasAdded = _claimDirectory.Count == startingCount + 1;
            return wasAdded;
        }
    }
}
