using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P4
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }

            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
