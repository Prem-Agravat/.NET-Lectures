using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building
{
    internal class p5
    {
        public void pattern5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j % 2);
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] args)
        {
            p5 p = new p5();
            p.pattern5(6);
        }
    }
}
