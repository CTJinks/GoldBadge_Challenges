using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Emails
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(150, Console.WindowHeight);
            Email_List_UI ui = new Email_List_UI();
            ui.Run();
        }
    }
}
