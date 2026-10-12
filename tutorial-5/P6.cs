using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P6
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 30, 40, 50 };

            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else
                {
                    min = arr[i];
                }


            }
            Console.WriteLine("Maximum value in the array is: " + max);
            Console.WriteLine("Minimum value in the array is: " + min);
        }
    }
}
