using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tutorial1
{
    internal class numcon
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("enter a number: ");
            number = Console.ReadLine();
            if (number.Length >= 5) ;
            {
                string result = number.Substring(0, number.Length - 5) + "XXXXX";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
