using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public string Name
        {
            get
            {
                return GetType().Name;
            }
        }

        public bool Peeled { get; set; } = false;

        public string Peel()
        {
            Peeled = true;
            return "dont slip on it";
        }
    }
}
