using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class StudentDetails {
        public int enrollNo { get; set; }
        public string name { get; set; }
    }
    internal class P12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat_Prem");
            StudentDetails s1 = new StudentDetails();

           Console.WriteLine("Enter Enrollment Number: ");
            s1.enrollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name: ");
            s1.name = Console.ReadLine();

            Console.WriteLine("Student Details:");
            Console.WriteLine("Enrollment Number: " + s1.enrollNo);
            Console.WriteLine("Student Name: " + s1.name);
        }
    }
}
