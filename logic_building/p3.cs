using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building
{
    internal class p3
    {
        public void pattern3(int n)
        {
            int a=1;
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a);
                    a++;
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] args)
        {
            p3 p = new p3();
            p.pattern3(5);

        }
    }
}
