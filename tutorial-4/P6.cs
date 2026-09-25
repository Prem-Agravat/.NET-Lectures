using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_4
{
    

    abstract class Test

    {

        public int a;

        public abstract void A();

    }



    class Example1 : Test

    {

        public override void A()

        {

            Console.WriteLine("Example1.A");

            base.a++;

        }

    }

    class Example2 : Test

    {

        public override void A()

        {

            Console.WriteLine("Example2.A");

            base.a--;

        }

    }

    class P6

    {

        static void Main()

        {
            Console.WriteLine("Agravat Prem 25SOECE13042");

            // Reference Example1 through Test type.

            Test test1 = new Example1();

            test1.A();

            // Reference Example2 through Test type.

            Test test2 = new Example2();

            test2.A();

        }

    }
}
