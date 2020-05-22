using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class DrofsnarContent_Repository
    {
         
        public int AnalyzeLives(string[] NewGame)
        {
            int score = 5000;
            int lives = 3;
            foreach (string birdsObtained in NewGame)
            {

                if (birdsObtained == "Bird")
                {
                    score = score + 10;
                }
                else if (birdsObtained == "CrestedIbis")
                {
                    score = score + 100;
                }
                else if (birdsObtained == "GreatKiskudee")
                {
                    score = score + 300;
                }
                else if (birdsObtained == "RedCrossbill")
                {
                    score = score + 500;
                }
                else if (birdsObtained == "Red-neckedPhalarope")
                {
                    score = score + 700;
                }
                else if (birdsObtained == "EveningGrosbeak")
                {
                    score = score + 1000;
                }
                else if (birdsObtained == "GreaterPrairieChicken")
                {
                    score = score + 2000;
                }
                else if (birdsObtained == "IcelandGull")
                {
                    score = score + 3000;
                }
                else if (birdsObtained == "Orange-belliedParrot")
                {
                    score = score + 5000;
                }
                else if (birdsObtained == "VulnerableBirdHunter")
                {

                    while (lives == 3)
                    {

                    }
                }
                else if (birdsObtained == "InvincibleBirdHunter")
                {
                    lives = lives - 1;
                }
                else if (score >= 10000)
                {
                    lives = lives + 1;
                }
                else if (score >= 20000)
                {
                    lives = lives + 1;
                }
                else if (score >= 30000)
                {
                    lives = lives + 1;
                }
                else if (score >= 40000)
                {
                    lives = lives + 1;
                }
                else if (score >= 50000)
                {
                    lives = lives + 1;
                }
                else if (score >= 60000)
                {
                    lives = lives + 1;
                }
            }
            return lives;
        }
        public int AnalyzeScore(string[] NewGame)
        {
            int score = 5000;
            int lives = 3;
            foreach (string birdsObtained in NewGame)
            {
                
                if (birdsObtained == "Bird")
                {
                    score = score + 10;
                }
                else if (birdsObtained == "CrestedIbis")
                {
                    score = score + 100;
                }
                else if (birdsObtained == "GreatKiskudee")
                {
                    score = score + 300;
                }
                else if (birdsObtained == "RedCrossbill")
                {
                    score = score + 500;
                }
                else if (birdsObtained == "Red-neckedPhalarope")
                {
                    score = score + 700;
                }
                else if (birdsObtained == "EveningGrosbeak")
                {
                    score = score + 1000;
                }
                else if (birdsObtained == "GreaterPrairieChicken")
                {
                    score = score + 2000;
                }
                else if (birdsObtained == "IcelandGull")
                {
                    score = score + 3000;
                }
                else if (birdsObtained == "Orange-belliedParrot")
                {
                    score = score + 5000;
                }
                else if (birdsObtained == "VulnerableBirdHunter")
                {
                    
                    while (lives == 3)
                    {

                    }
                }
                else if (birdsObtained == "InvincibleBirdHunter")
                {
                    lives = lives - 1;
                }
                else if (score >= 10000)
                {
                    lives = lives + 1;
                }
                else if (score >= 20000)
                {
                    lives = lives + 1;
                }
                else if (score >= 30000)
                {
                    lives = lives + 1;
                }
                else if (score >= 40000)
                {
                    lives = lives + 1;
                }
                else if (score >= 50000)
                {
                    lives = lives + 1;
                }
                else if (score >= 60000)
                {
                    lives = lives + 1;
                }
            }
            return score;
            
        }

    }
}
