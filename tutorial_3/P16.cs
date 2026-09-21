using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{

    class Employee1 {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public double BasicSalary { get; set; }
    }
    class PermanentEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double hra = 0.2 * BasicSalary;
            double da = 0.1 * BasicSalary;
            double netSalary = BasicSalary + hra + da;
            Console.WriteLine("Permanent Employee:");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;
           
            Console.WriteLine("Contract Employee:");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
    internal class P16
    {
        public static void Main(string[] args) { 
            Console.WriteLine("25SOECE13042_Agravat Prem");
            PermanentEmployee p = new PermanentEmployee();
            p.EmployeeId = 101;
            p.Name = "Rahul";
            p.BasicSalary = 50000;

            p.CalculateSalary();

            ContractEmployee c = new ContractEmployee();
            c.EmployeeId = 102;
            c.Name = "Priya";
            c.BasicSalary = 30000;

            c.CalculateSalary();

            Console.Read();
        }
    }
}
