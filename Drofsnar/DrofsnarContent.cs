using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class GamePlayed
    {
        public string[] Game { get; set; }
        public GamePlayed(string[] game)
        {
            Game = game;
        }
        
    }
    public class DrofsnarScore
    {
        public int birdTally { get; set; }
        public int ibisTally { get; set; }
        public int kiskudeeTally { get; set; }
        public int crossbillTally { get; set; }
        public int phalaropeTally { get; set; }
        public int grosbeakTally { get; set; }
        public int chickenTally { get; set; }
        public int gullTally { get; set; }
        public int parrotTally { get; set; }
        public int hunterFirst { get; set; }
        public int hunterSecond { get; set; }
        public int hunterThird { get; set; }
        public int hunterFourth { get; set; }
    }
}
