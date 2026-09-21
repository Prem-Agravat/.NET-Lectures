using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class oddeven
    {
        public static void print()
        {
            int number;

        Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The Number is Even");

            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            Console.ReadLine();
        }
        
    }
}
