using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P7
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = {1,3, 10, 20, 30, 40, 50,5 };
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];
            int e = 0, o = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 ==0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }


            }
            Console.WriteLine("Even Elements:");
            for(int i = 0; i < e; i++)
            {
                Console.WriteLine(even[i] + " ");
            }

            Console.WriteLine("Odd Elements:");
            for(int i = 0; i < o; i++)
            {
                Console.WriteLine(odd[i] + " ");
            }
        }
    }
}
