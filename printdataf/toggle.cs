using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class toggle
    {
        static void Main(string[] args)
        {
            string name, result = "";
            Console.WriteLine("enter a string to convert to toggle case: ");
            name = Console.ReadLine();

            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLetter(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
                
            }
            Console.WriteLine("toggle case converted:" + result);
            Console.WriteLine();
        }
    }
}
