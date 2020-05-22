using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    public class MenuContent_Repo
    {
        private List<MenuContent> _contentDirectory = new List<MenuContent>();
        public bool AddContentToDirectory(MenuContent item)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(item);
            bool wasAdded = _contentDirectory.Count == startingCount + 1;
            return wasAdded;
        }
        public List<MenuContent> GetContents()
        {
            return _contentDirectory;
        }
        public MenuContent GetContentByName(string mealName)
        {
            foreach (MenuContent content in _contentDirectory)
            {
                if (content.MealName.ToLower() == mealName.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public bool RemoveContentByName(string mealName)
        {
            MenuContent content = GetContentByName(mealName);
            if (content == null)
            {
                Console.WriteLine("there are no meals currently with that name");
                return false;
            }
            else
            {
                _contentDirectory.Remove(content);
                return true;
            }
        }
    }
}
