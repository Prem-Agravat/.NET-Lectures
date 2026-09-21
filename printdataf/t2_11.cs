using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class t2_11
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1 ,4 };
            Console.WriteLine("Number occuring once:");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++) { 
                    if(arr[i] == arr[j])
                        count++;
                }
                if (count == 1)
                    Console.WriteLine(arr[i] + "");
            }
            Console.ReadLine();
        }
    }
}
