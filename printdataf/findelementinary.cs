using System;

namespace printdataf
{
    internal class findelementinary
    {
        public static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the number of elements in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.Write("Enter the element to find: ");
            int elementToFind = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool found = false;

            foreach (int element in arr)
            {
                if (element == elementToFind)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}