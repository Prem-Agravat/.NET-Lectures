using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace tutorial_5
{
    internal class P9
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter the position of the element to delete:");

            int pos = Convert.ToInt32(Console.ReadLine());
            for(int i = pos - 1; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("Array after deleting element at position " + pos + ":");
            for(int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}