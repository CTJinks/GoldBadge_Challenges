using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodod_Insurance_Test
{
    [TestClass]
    public class Badges
    {
        public int BadgeId { get; }
        public string[] Doors { get; set; }
        public Badges(int badgeId, string[] doors)
        {
            BadgeId = badgeId;
            Doors = doors;
        }
    }
}
