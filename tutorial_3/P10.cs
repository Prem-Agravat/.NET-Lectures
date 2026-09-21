using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Employee {
        private int id;
        private string name;
        private double basicSalary;
        private double netSalary;

        public Employee(int id, string name, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            CalculateNetSalary();
        }

        public void CalculateNetSalary()
        {
            double hra =basicSalary * 0.20; 
            double da = basicSalary * 0.10;  
            netSalary = basicSalary + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
    internal class P10
    {
        public static void Main(string[] args) {

            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.WriteLine("Enter Employee ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary:");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Employee e = new Employee(id,name,basicSalary);
            e.Display();
            Console.Read();

        }
    }
}
