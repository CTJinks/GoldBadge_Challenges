using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_UI_Refactor
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
    }
}
