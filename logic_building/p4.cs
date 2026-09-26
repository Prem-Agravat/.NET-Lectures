using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building
{
    internal class p4
    {
        public void pattern4(int n)
        {
            int a = 1;
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i != 1)
                {
                    a += i;
                }
                t = a;
                for (int j = 1; j <=i; j--)
                {
                    Console.Write(t);
                    t = t - 1;
                }
                Console.WriteLine();
            }

        }
        public static void Main(String[] args)
        {
            p4 p = new p4();
            p.pattern4(5);

        }
    }
}
