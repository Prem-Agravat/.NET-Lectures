using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class phonenumber
    {
        static void Main(string[] args)
        {
            string phone;
            Console.WriteLine("Enter a phone number:");
            phone = Console.ReadLine();
            if (phone.Length >= 5)
            {
                string result = phone.Substring(0, phone.Length - 5) + "XXXXX";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
