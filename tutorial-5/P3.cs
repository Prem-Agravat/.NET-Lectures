using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P3
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the number at " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}