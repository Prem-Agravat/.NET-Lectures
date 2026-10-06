using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_5
{
    internal class P5
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 20, 40, 50 };
            
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 1) Console.WriteLine(arr[i]+ " is a duplicate element in the array."+count);
            }
        }
    }
}
