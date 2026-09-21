using System;
using System.Collections.Generic;
using System.Text;

namespace string_manipulation
{
    internal class palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if(rev == str)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            
        }  

    }

}
