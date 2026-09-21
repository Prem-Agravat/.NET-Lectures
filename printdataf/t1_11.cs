using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class t1_11
    {
        static void Main(string[] args)
        {
            string name;
            char gender;
            Console.WriteLine("Enter your name: ");
            name= Console.ReadLine();

            Console.WriteLine("Enter a Gender (M/F): ");
            gender = Convert.ToChar(Console.ReadLine());

            if(gender == 'M' || gender == 'm'){
                Console.WriteLine("Mr. " + name);
            }
            else if(gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
              Console.ReadLine();
        }
    }
}
