using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Students
    {
        static int count = 0;
        public Students()
        {
            count++;
        }
        public static void Display()
        {
            Console.WriteLine("Count is :"+count);
        }
    }
    internal class P19
    {

        public static void Main(String[] args) {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Students s = new Students();
            Students s1 = new Students();
            Students s2 = new Students();
            Students s3 = new Students();
            Students.Display();
        }

    }
}
