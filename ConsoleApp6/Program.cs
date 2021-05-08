using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public delegate void Func(string text);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = new Func((cls.Space));
            funcDell += cls.Reverse;
            Run run = new Run();
            run.RunFunc(funcDell, str);

        }
    }
}
