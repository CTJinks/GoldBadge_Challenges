using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class ProgramUI
    {

        public readonly DrofsnarContent_Repository _repo = new DrofsnarContent_Repository();
        string[] gameOne = { "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "InvincibleBirdHunter", "EveningGrosbeak", "GreaterPrairieChicken", "VulnerableBirdHunter", "VulnerableBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "IcelandGull", "CrestedIbis", "GreatKiskudee", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "RedCrossbill", "Red-neckedPhalarope", "InvincibleBirdHunter", "VulnerableBirdHunter", "Orange-belliedParrot", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "VulnerableBirdHunter" };
        public GamePlayed NewGame
        {
            get { return new GamePlayed(gameOne); }
        }
        public void RunGame()
        {

            var returnScore =_repo.AnalyzeScore(NewGame.Game);
            var returnLives = _repo.AnalyzeLives(NewGame.Game);
            Console.WriteLine("Score: " + returnScore);
            Console.WriteLine("Lives: " + returnLives);
            Console.ReadKey();
        }


        /*string cheese = "stringcheese";

        public void Method()
        {
            GamePlayed game = new GamePlayed(gameOne);
        }*/
    }
}
