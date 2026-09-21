using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class sumofarray
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[5];
            int sum = 0;
            Console.WriteLine("Enter the number of elements:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }   
    }
}
