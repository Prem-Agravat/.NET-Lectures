using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial1
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Agravat Prem (25SOECE13042)");
            Console.WriteLine();
            Console.Write("Enter a Number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            Console.ReadLine();
        }

    }
}
