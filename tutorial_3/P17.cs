using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Shape
    {
        public double area;
        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of Shape");
        }
    }
    class Circle : Shape {
        public override void CalculateArea()
        {
            double radius = 5;
            area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle is " + area);
        }
    }
    class Rectangle : Shape {
        public override void CalculateArea()
        {
            double length = 10;
            double width = 20;
            area = length * width;
            Console.WriteLine("Area of Rectangle is "+ area);
        }
    }
    class Triangle : Shape {
        public override void CalculateArea()
        {
            double b = 5;
            double h = 5;
            area = 0.5 * b * h;
            Console.WriteLine("Area of Triangle is " + area);
        }
    }
    internal class P17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Shape s;
            s = new Circle();
            s.CalculateArea();

            s = new Rectangle();
            s.CalculateArea();

            s = new Triangle();
            s.CalculateArea();

            Console.ReadLine();
        }
    }
}
