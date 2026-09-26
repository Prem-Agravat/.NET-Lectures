using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building
{
    internal class p2
    {
        public void pattern2(int n)
        {
            for(int i = 1; i <= n; i++) {
                for(int j = i; j >= 1;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            p2 p = new p2();
            p.pattern2(5);
        }
    }
}
