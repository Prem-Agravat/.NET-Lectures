using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class uppercase
    {
        static void Main(string[] args)
        {
            String name;
            Console.Write("Enter name to convert to uppercase: ");
            name = Console.ReadLine();
            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.ReadLine();
        }
}
}
