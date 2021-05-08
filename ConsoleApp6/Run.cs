using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Run
    {
        public void RunFunc(Func funcDell, string text)
        {
            Console.Clear();
            funcDell.Invoke(text);
        }
    }
}
