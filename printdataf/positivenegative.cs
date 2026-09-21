using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class positivenegative
    {
        public static void posinega() {
            int number;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is Zero");
            }
            else
            {
                Console.WriteLine("The number is Negative");
            }
    }
}
}
