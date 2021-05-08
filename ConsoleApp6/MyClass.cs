using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class MyClass
    {
        public void Space(string text)
        {
            char[] new_text = new char[text.Length + text.Length - 1];
            for (int i = 0, i2 = 0; i < text.Length; i++, i2++)
            {
                new_text[i2] = text[i];
                if (i + 1 != text.Length)
                {
                    i2++;
                    new_text[i2] = '_';
                }
            }
            for (int i = 0; i < new_text.Length; i++)
            {
                Console.Write(new_text[i]);
            }
            Console.WriteLine();
        }
        public void Reverse(string text)
        {
            char[] new_text = new char[text.Length];
            for (int i = 0, i2 = text.Length - 1; i < text.Length; i++, i2--)
            {
                new_text[i] = text[i2];
            }
            for (int i = 0; i < new_text.Length; i++)
            {
                Console.Write(new_text[i]);
            }
            Console.WriteLine();
        }
    }
}
