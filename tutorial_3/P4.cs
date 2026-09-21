using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    internal class P4
    {
        class Student
        {
            // Private fields
            private int id;
            private string name;
            // Properties
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            // Default constructor
            public Student()
            {
                id = 0;
                name = "Unknown";
            }
            // Parameterized constructor
            public Student(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void Display()
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Name: " + name);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("25SOECE13042_Agravat Prem");
                Student obj1 = new Student(1, "Prem");
                Student obj2 = new Student(2, "Meet");
                Student obj3 = new Student(3, "Om");
                Student obj4 = new Student(4, "Ramanshu");
                Student obj5 = new Student(5, "Parth");
                obj1.Display();
                obj2.Display();
                obj3.Display();
                obj4.Display();
                obj5.Display();

                Console.ReadLine();
            }

        }
    }
}
