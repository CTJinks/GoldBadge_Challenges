using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    class Menu_UI
    {
        public readonly MenuContent_Repo _repo = new MenuContent_Repo();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                        "enter the number of your selection:\n" +
                        "1. Show Full Menu\n" +
                        "2. Create New Menu Item\n" +
                        "3. Remove Menu Item" );
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        ShowAllContents();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        AddMealToDirectory();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "3":
                        RemoveContentFromDirectory();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void AddMealToDirectory()
        {
            Console.Clear();
            Console.WriteLine("Enter the new meal name:");
            string mealName = Console.ReadLine();
            Console.WriteLine("Enter the new meal number:");
            int mealNum = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the new meal description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter the new meal ingredients:");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Enter the new meal price:");
            double mealPrice = Convert.ToDouble(Console.ReadLine());
            MenuContent newContent = new MenuContent(mealNum, mealName, description, ingredients, mealPrice);
            _repo.AddContentToDirectory(newContent);
        }
        private void RemoveContentFromDirectory()
        {
            Console.Clear();
            Console.WriteLine("Enter the meal you wish to remove:");
            string mealName = Console.ReadLine();
            _repo.RemoveContentByName(mealName);
        }
        public void ShowAllContents()
        {
            Console.Clear();
            List<MenuContent> listOfContent = _repo.GetContents();

            foreach (MenuContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }
        public void DisplayContent(MenuContent item)
        {
            Console.WriteLine($"{item.MealNum} - {item.MealName} | {item.Description} \n Ingredients:({item.Ingredients}) \n Price: {item.MealPrice}");
        }
        private void SeedContentList()
        {
            MenuContent burger = new MenuContent(1, "Burger", "a delicious ground beef patty between two buns", "ground beef patty, burger bun, lettuce, ketchup, mustard", 5.50);
            MenuContent hotdog = new MenuContent(2, "Hotdog", "a hotdog in a hotdog bun with ketchup and mustard", "hotdog, hotdog bun, ketchup, mustard", 4.75); 
            MenuContent chickenSandwich = new MenuContent(3, "Chicken Sandwich", "a chicken patty between two buns", "chicken patty, burger bun, lettuce, mayo, pickles", 6.10);
            MenuContent nachos = new MenuContent(4, "Nachos", "toritlla chips topped with our melted nacho cheese and jalapenos", "tortilla chips, nacho cheese, lettuce, jalapenos", 5);
            MenuContent tacos = new MenuContent(5, "Tacos", "2 Groundbeef tacos with a side of salsa", "tacos shells, ground beef, lettuce, cheese, salsa", 5.92);
            _repo.AddContentToDirectory(burger);
            _repo.AddContentToDirectory(hotdog);
            _repo.AddContentToDirectory(chickenSandwich);
            _repo.AddContentToDirectory(nachos);
            _repo.AddContentToDirectory(tacos);
        }
    }
}
