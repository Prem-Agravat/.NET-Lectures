using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Student20
    {
        private int roll_no;
        private string name;

        public Student20(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Student roll number is: "+ roll_no);
            Console.WriteLine("Student Name is: "+  name);
        }
    }
    internal class P20
    {
        public static void Main(string[] args) {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Student20 s = new Student20(5,"PREM");
            s.Display();
            Console.ReadLine();
        }
    }
}
