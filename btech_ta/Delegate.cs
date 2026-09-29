using System;
using System.Collections.Generic;
using System.Text;

namespace btech_ta
{
    //delegate declaration
    delegate void Delegate1(int x, int y);
    delegate void Delegate2(int x, int y,int z);
    class Delegate
    {
        public static void Add(int a,int b) {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Main(String[] args)
        {
            //3 ways for delegate instantiation 1. with new object 2. with delegate syntax 3, with += method name
            Delegate1 obj = new Delegate1(Add);//1 way
            obj += new Delegate1(Sub);//2 way
            obj(15, 3);
            obj += Mul;//3 way
            obj += Div;

            //invocation of delegate
           // obj(15, 3);
            //Add(15, 5);

            Console.Read();
        }
    }
}
