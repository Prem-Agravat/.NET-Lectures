using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building.Array
{
    internal class bubblesort
    {
        public static void Main(String[] args)
        {
            int[] arr = {5,4,3,2,1};
            int n = arr.Length;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
