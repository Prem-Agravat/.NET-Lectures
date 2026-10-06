using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P2
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number at " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
