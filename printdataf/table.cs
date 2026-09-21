using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class table
    {
        public static void printtable() {
            int number;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(number + " * " + i + " = " + (number*i));
                i++;
            }
            Console.ReadLine();
        }
    }
}

