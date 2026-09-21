using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

internal class reversestring
{
    static void Main(String[] args)
    {
        Console.Write("Enter String");
        string str = Console.ReadLine();
        string rev = "";

        for(int i =str.Length-1; i >= 0; i--)
        {
            rev += str[i];
        }

        Console.WriteLine(rev);


    }
}
