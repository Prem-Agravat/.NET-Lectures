using System;
using System.Collections.Generic;
using System.Text;

namespace logic_building
{
    internal class pattern123
    {
        public void p1(int n) { 
            for(int i =1;i <=n; i++)
            {
                for(int j =1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] args)
        {
            pattern123 p = new pattern123();
            p.p1(5);
        }
    }

    
}
