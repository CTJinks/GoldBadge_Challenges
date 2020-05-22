using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe_Test
{
    [[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MenuContent
    {
        public int MealNum { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double MealPrice { get; set; }
        public MenuContent() { }
        public MenuContent(int mealNum, string mealName, string description, string ingredients, double mealPrice)
        {
            MealNum = mealNum;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            MealPrice = mealPrice;
        }
    }
