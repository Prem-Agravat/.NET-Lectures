using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Agravat Prem (25SOECE13042)");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();









        }
    }

}








