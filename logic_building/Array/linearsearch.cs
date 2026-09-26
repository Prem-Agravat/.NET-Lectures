using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building.Array
{
    internal class linearsearch
    {
        public static void Main(String[] args) {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the number to search:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("Number found at index: " + i);
                    break;
                }
            }
        }
    }
}
