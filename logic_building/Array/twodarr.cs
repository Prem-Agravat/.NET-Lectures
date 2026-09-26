using System;

namespace logic_building.Array
{
    internal class twodarr
    {
        public static void Main(String[] args)
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 1, 2, 3 },
                { 1, 2, 3 }
            };

            int[,] b =
            {
                { 1, 2 },
                { 1, 2 },
                { 1, 2 }
            };

            int[,] result = new int[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    int sum = 0;

                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}