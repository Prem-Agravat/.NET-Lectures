using System;
using System.Collections.Generic;
using System.Text;

namespace btech_ta
{
    class Employee //blueprint or template
    {
        //it does not have any return type explicitly
        //must hae same name as class name
        public test() { }
        public Employee() { }
       
        public string Name { get; set; }
        private int age;//data member

        public string Dept { get; set; }
        private double Salary;

        public void setSalary(double salary)
        {
            this.Salary = salary;
        }
        public double getSalary()
        {
            return Salary;
        }

        public int Age//property
        {
            get//read only
            {
                return age;
            }
            set//write only
            {
                if (value >= 18)
                    age = value;
                else
                    age = -1;
            }
        }

        //method -- to work with the data members
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Prem";
            e1.Dept = "CSE";
            e1.Age = 20;
            e1.setSalary(50000);
            e1.Display();

            Employee e2 =new Employee();
            e2.Name = "Ramanshu";
            e2.Dept = "IT";
            e2.Age = 32;
            e2.setSalary(60000);
            e2.Display();
        }
    }
}
