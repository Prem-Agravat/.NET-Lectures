using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building.Array
{
    internal class sumofarray
    {
        public static void Main(String[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
           
        }

    }
}
