using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    //Base class
    class student {
        public string course { get; set; }
        public string department { get; set; }

        public void DisplayStudentDetails() { 
            Console.WriteLine("Student Details:"); 
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Department: " + department);
        }
    }
    //Derived class
    class Person : student {
        public string name { get; set; }
        public int Age { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + Age);
        }
    }

    internal class P15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Person p = new Person();
            Console.WriteLine("Enter Name of Person: ");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter Age of Person: ");
            p.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Course: ");
            p.course = Console.ReadLine();
            Console.WriteLine("Enter Student Department: ");
            p.department = Console.ReadLine();

            p.DisplayPersonDetails();
            p.DisplayStudentDetails();


        }

    }
}
