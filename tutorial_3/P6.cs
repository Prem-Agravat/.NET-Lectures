using System;

namespace tutorial_3

{

    class Line

    {

        private double length;   // Length of a line

        public Line()

        {

            //………………………………Missing statement-1……………………………….// 
            Console.WriteLine("Object Creating value of length = 10");

            //………………………………Missing statement-2……………………………….// 
            length = 10;
        }



        public void setLength(double len)
        {

            //………………………………Missing statement-3……………………………….//
            length = len;



        }

        public double getLength()

        {

            //………………………………Missing statement-4……………………………….//
            return length;

        }

    }



    class P6

    {

        static void Main(string[] args)

        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());
            line.setLength(6);
            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }

}