using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    class Badge_Repo
    {
        private Dictionary<int, string[]> _badgeDirectory = new Dictionary<int, string[]>();
        public bool AddBadgeToDirectory(Badges item)
        {
            int startingCount = _badgeDirectory.Count;
            _badgeDirectory.Add(item.BadgeId, item.Doors);
            bool wasAdded = _badgeDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public Dictionary<int, string[]> GetBadges()
        {
            return _badgeDirectory;
        }
        
    }
}
