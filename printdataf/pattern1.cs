using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class pattern1
    {
        static void Main(string[] args)
        {
            int term, number;
            int sum = 0;
            int current = 0;

            Console.WriteLine("Enter a term: ");
            term = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= term; i++)
            {
                current = current * 10 + number;
                Console.Write(current + " ");
                sum += current;

                if(i < term)
                    Console.Write(" + ");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
