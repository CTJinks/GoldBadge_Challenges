using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.People
{
    public class Student : Person
    {
        public double ScoreOne { get; set; }
        public double ScoreTwo { get; set; }
        public double ScoreThree { get; set; }
        public double Grade
        {
            get
            {
                double gradeAvg = (ScoreOne + ScoreThree + ScoreThree)/3;
                return gradeAvg;
            }
        }
        public void SetScoreOne(int scoreOne)
        {
            ScoreOne = scoreOne;
        }
        public void SetScoreTwo(int scoreTwo)
        {
            ScoreTwo = scoreTwo;
        }
        public void SetScoreThree(int scoreThree)
        {
            ScoreThree = scoreThree;
        }
    }
}
