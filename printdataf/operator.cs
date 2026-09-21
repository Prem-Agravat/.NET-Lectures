using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class @operator
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------Arithmetic Operations--------");
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));

            Console.WriteLine("--------Relational Operations--------");
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a > b: " + (a > b));

            Console.WriteLine("--------Logical Operators--------");
            Console.WriteLine("a>b && a<b: " + (a > b && a < b));
            Console.WriteLine("a>b || a<b: " + (a > b || a < b));
            Console.ReadLine();
        }
    }
}
