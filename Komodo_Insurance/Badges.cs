using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
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
