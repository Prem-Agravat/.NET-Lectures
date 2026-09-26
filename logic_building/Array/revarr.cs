using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building.Array
{
    internal class revarr
    {
        public static void Main(String[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            int st = 0;
            int end = arr.Length;
            while (true){
                if (st > end)
                {
                    int temp = arr[st];
                    arr[st] = arr[end];
                    arr[end] = temp;
                    st++;
                    end--;
                }
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
