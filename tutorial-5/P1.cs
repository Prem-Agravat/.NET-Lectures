using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P1
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 30, 50, 70, 60, 40 };
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number at "+i+":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
