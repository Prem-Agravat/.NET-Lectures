using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class students
    {
        private int enroll;
        private string name;

        public students(int e,string n)
        {
            enroll = e;
            name = n;
        }
        public void Display() { 
            Console.WriteLine("Enrollment No. is " + enroll);
            Console.WriteLine("Name is " + name);
        }
    }
    internal class P7
    {
        public static void Main(string[] args) { 
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.WriteLine("Enter Enrollment No. :");
            int enroll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            students s = new students(enroll, name);
            s.Display();
            Console.ReadLine();
        }
    }
}
