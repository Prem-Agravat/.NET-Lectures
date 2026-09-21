using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class t2_10
    {
        static int MatSearch(int[,] mat, int n, int m, int x)
        {
            int row = 0;
            int col = m - 1;
            while (row < n && col >= 0)
            {
                if (mat[row, col] == x)
                {
                    return 1;
                }
                else if (mat[row, col] > x)
                {
                    col--;
                }
                else
                    row++;
            }
            return 0;
            
        }
        public static void Main(String[] args) 
        {
            int[,] mat = { { 3, 30, 38 }, { 52, 52, 54 }, { 57, 60, 69 } };
            int result = MatSearch(mat, 3, 3, 50) ;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
