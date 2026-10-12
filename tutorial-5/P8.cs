using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P8
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 30, 40, 50 };
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("Array in descending order:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }  
}
