using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace tutorial_5
{
    internal class P10
    {
        public static void Main()
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter row size:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column size:");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[r,c];
            int[,] matrix2 = new int[r,c];
            int[,] result = new int[r,c];
            for(int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Enter the element at position [" + i + "][" + j + "] for first matrix:");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Enter the element at position [" + i + "][" + j + "] for second matrix:");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Addition of 2 matrices");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(result[i, j] + " ");
                }
            }
        }
    }
}
