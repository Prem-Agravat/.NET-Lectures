
using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial4

{

    class StaticVar

    {

        public static int num;



        public void count()

        {

            num++;

        }

//………………………………Missing statement……………………………….//      
public static int getNum()
        {

            return num;

        }

}

class P4

{

    static void Main(string[] args)

    {

        StaticVar s = new StaticVar();
            Console.WriteLine("Agravat Prem 25SOECE13042");

            s.count();

        s.count();

        s.count();

        Console.WriteLine("Variable num: {0}", StaticVar.getNum());

        Console.ReadKey();

    }

}

}