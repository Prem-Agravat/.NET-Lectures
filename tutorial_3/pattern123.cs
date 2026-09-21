using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{

    internal class pattern123
    {
        public void p1(int a)
        {
            for (int i = 1;i <= a; i++) {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Main(String[] args)
        {
            pattern123 p = new pattern123();
            p.p1(10);
        }
    }
}
