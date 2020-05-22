using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UI_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole console = new RealConsole();
            Program_UI ui = new Program_UI(console);
            ui.Run();
        }
    }
}
