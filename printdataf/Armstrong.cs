using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int number, result = 0, original, remainder;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            original = number;
            while (number != 0)
            {
                remainder = number % 10;
                result += remainder * remainder * remainder;
                number /= 10;
            }
            if (result == original)
                Console.WriteLine("This is an Armstrong number.");
            else
                Console.WriteLine("This is not an Armstrong number.");
            Console.ReadLine();
        }
    }
}
