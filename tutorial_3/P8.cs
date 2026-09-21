using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Student
    {
        private int enroll,age;
        private string name,course;

        public Student(int e, string n,string c,int a)
        {
            enroll = e;
            name = n;
            course = c;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.WriteLine("Student Details");
            Console.WriteLine("Enrollment No. is " + enroll);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Course is " + course);
            Console.WriteLine("Age is " + age);
        }
    }
    internal class P8
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Enrollment No. :");
            int enroll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name :");
            string name = Console.ReadLine();
            Console.Write("Enter Course :");
            string course = Console.ReadLine();
            Console.Write("Enter Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Student s = new Student(enroll, name, course, age);
            s.Display();
            Console.ReadLine();
        }
    }
}
