using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_RepoPattern__Repository
{
    public class Program_UI
    {
        public readonly StreamingContentRepository _repo = new StreamingContentRepository();
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
                        "1. Show all streaming content\n" +
                        "2. find streaming content by title\n" +
                        "3. add new streaming content\n" +
                        "4. remove streaming content\n" +
                        "5. exit\n" +
                        "6. add Danny Devito\n" +
                        "7. add Samuel L Jackson\n" +
                        "8. start a watch party\n" +
                        "9. Make every movie better"

                    );

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        ShowAllContents();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        ShowContentByTitle();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "3":
                        AddNewContent();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "4":
                        RemoveContentFromDirectory();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "5":
                        continueToRun = false;
                        Console.WriteLine("goodbye!!");
                        Thread.Sleep(1000);
                        break;
                    case "6":
                        AddDevito();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "7":
                        AddJackson();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "8":
                        StartWatchParty();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    case "9":
                        MakeEveryMovieBetter();
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void MakeEveryMovieBetter()
        {
            Console.Clear();
            Console.WriteLine("blah blah");
            _repo.UpdateAllContent();
            Console.WriteLine("Done");
        }
        private void StartWatchParty()
        {
            Console.Clear();
            Console.WriteLine("Enter your name");
            string yourName = Console.ReadLine();
            Console.WriteLine("Enter other friends");
            string friendsNames = Console.ReadLine();
            WatchParty newParty = new WatchParty(yourName, friendsNames);
            Console.WriteLine($"You({newParty.YourName}) and your friends({newParty.FriendsNames}) are now in a party");
            Console.WriteLine("What movie would you like to watch?");
            string title = Console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("no content found");
            }
            else
            {
                Console.WriteLine("Your party is now watching " + content.Title);
            }

        }
        private void AddJackson()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("no content found");
            }
            else
            {
                content.Actors = content.Actors + ", and Samuel L Jackson";
                content.Description = content.Description + " and snakes and motha ****** planes!";
                Console.WriteLine("Samuel L Jackson was Added");
            }
        }
        private void AddDevito()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("no content found");
            }
            else
            {
                content.Actors = content.Actors + ", and Danny Devito";
                Console.WriteLine("Danny Devito was Added");
            }
        }
        private void RemoveContentFromDirectory()
        {
            Console.Clear();
            Console.WriteLine("Enter a title you wish to remove:");
            string title = Console.ReadLine();
            _repo.RemoveContentByTitle(title);

        }
        private void AddNewContent()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            Console.WriteLine("enter a description");
            string description = Console.ReadLine();
            Console.WriteLine("enter star rating 1-5");
            double starRating = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("select a maturity rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n");
            string maturityRatingChoice = Console.ReadLine();
            MaturityRating maturityRating;
            switch (maturityRatingChoice)
            {
                case "1":
                    maturityRating = MaturityRating.G;
                    break;
                case "2":
                    maturityRating = MaturityRating.PG;
                    break;
                case "3":
                    maturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    maturityRating = MaturityRating.R;
                    break;
                default:
                    maturityRating = MaturityRating.U;
                    break;
            }
            Console.WriteLine("Select the Genre:\n"+
                "1. Drama\n" +
                "2. Sci-fi\n" +
                "3. Action\n");
            string genreInput = Console.ReadLine();
            int genreId = Convert.ToInt32(genreInput);
            GenreType genreType = (GenreType)genreId;
            Console.WriteLine("Enter Important Actors:");
            string actors = Console.ReadLine();
            StreamingContent newContent = new StreamingContent(title, description, starRating, maturityRating, genreType, actors);
            _repo.AddContentToDirectory(newContent);
            
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content == null)
            {
                Console.WriteLine("no content found");
            }
            else
            {
                DisplayContent(content);
            }
        }
        public void ShowAllContents()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }
        public void DisplayContent(StreamingContent item)
        {
            Console.WriteLine($"{item.Title} - ({item.StarRating} stars, {item.Genre}) \n--Description: {item.Description} \n--Actors: {item.Actors}");
        }
        private void SeedContentList()
        {
            StreamingContent princessMononoke = new StreamingContent("Princess Mononoke", "Japanese Animation", 5.0, MaturityRating.R, GenreType.Action, "Gillian Anderson, Billy Crudup");
            StreamingContent starWars = new StreamingContent("Star Wars", "Classic space adventure", 5.0, MaturityRating.PG_13, GenreType.SciFi, "Mark Hamill, Carey Fishcer, Harrison Ford");
            StreamingContent starTrek = new StreamingContent("Star Trek", "Classic space TV adventure", 5.0, MaturityRating.PG, GenreType.SciFi, "William Shatner, Leonard Nimoy");
            StreamingContent beingJohnMalkovich = new StreamingContent("Being John Malkovich", "Charlie Kauffman and Spike Jonze Movie", 3.8, MaturityRating.R, GenreType.Drama, "John Cusack, John Malkovich");
            StreamingContent lionKing = new StreamingContent("The Lion King", "Disney Animation", 4.5, MaturityRating.G, GenreType.Drama,"James Earl Jones, Matthew Broderick");
            _repo.AddContentToDirectory(lionKing);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(princessMononoke);
            _repo.AddContentToDirectory(beingJohnMalkovich);
            _repo.AddContentToDirectory(starTrek);


        }
    }
}
