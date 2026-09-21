using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    sealed class University {
        private string school_name;
        private string department_name;

        public University(string school_name, string department_name)
        {
            this.school_name = school_name;
            this.department_name = department_name;
        }

        public void Display()
        {
            Console.WriteLine("School Name: " + school_name);
            Console.WriteLine("Department Name: " + department_name);
        }

    } 
    internal class P24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            University u = new University("School of Engineering", "Computer Science");
            u.Display();
            Console.ReadLine();
        }
    }
}
