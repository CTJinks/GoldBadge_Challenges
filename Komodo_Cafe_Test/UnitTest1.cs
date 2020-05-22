using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Cafe_Test
{
    [TestClass]
    public class UnitTest1
    {
        private List<MenuContent> _contentDirectory = new List<MenuContent>();
        [TestMethod]
        public bool AddContentToDirectory(MenuContent item)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(item);
            bool wasAdded = _contentDirectory.Count == startingCount + 1;
            return wasAdded;
        }
    }
}
