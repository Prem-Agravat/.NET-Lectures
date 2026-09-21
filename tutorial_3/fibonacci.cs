using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace tutorial_3
{
    internal class fibonacci
    {
        public void fibo(int no)
        {
            int first = 0;
            int second = 1;
            int sum = 0;
            for(int i = 0; i < no; i++) {
                sum = first + second;
                Console.WriteLine(sum);
                first = sum;
                sum = second;
            }
            Console.WriteLine(sum);
        }

    
        public static void Main(String[] args)
        {
            fibonacci f = new fibonacci();
            f.fibo(5);
        }

    }
}
