using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Student21
    {
        protected int roll_no;
        protected string name;

        public Student21(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
    }
    class Studentdetails : Student21
    {
        private int age;
        public Studentdetails(int age,int roll_no, string name) 
            : base(roll_no, name)
        {
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    internal class P21
    {
        public static void Main(string[] args) {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Studentdetails s = new Studentdetails(20,5,"Prem");
            s.Display();
            Console.ReadLine();
        }
    }
}
