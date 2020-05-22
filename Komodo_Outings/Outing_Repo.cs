using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Outings
{
    class Outing_Repo
    {
        private List<Outing> _outingDirectory = new List<Outing>();
        public bool AddOutingToDirectory(Outing outing)
        {
            int startingCount = _outingDirectory.Count;
            _outingDirectory.Add(outing);
            bool wasAdded = _outingDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public List<Outing> GetOutings()
        {
            return _outingDirectory;
        }
    }
}
