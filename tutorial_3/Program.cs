using System;

namespace tutorial_3
{
    internal class Program
    {
        class prog1
        {
            int enroll_no;
            string name;
            string branch;

            public void Student(int eno, string n, string b)
            {
                enroll_no = eno;
                name = n;
                branch = b;
            }
            public void Display()
            {
                
                Console.WriteLine("-------------Student Detaile----------------");
                Console.WriteLine("Enroll number is: " + enroll_no);
                Console.WriteLine("Name is: " + name);
                Console.WriteLine("Branch is: " + branch);
            }

        }

        public static void Main(String[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.WriteLine("Enter Enrollment No.:");
            int enroll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Branch:");
            string branch = Console.ReadLine();
            prog1 s = new prog1();
            s.Student(enroll_no, name, branch);
            s.Display();
        }

    }
    
        
}