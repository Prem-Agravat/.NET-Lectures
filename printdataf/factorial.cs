using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class factorial
    {
        public static void factoriaal()
        {
            int number, fact = 1;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + fact);
            Console.ReadLine();
        }
    }
}
