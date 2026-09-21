using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Employees {
        private double salary;
        public void SetSalary(double amount)
        {
            if (amount > 0)
            {
                salary = amount;
            }
            else {
                Console.WriteLine("Invalid Salary");
            }
        }

        public double GetSalary() { return salary; }

    }

   
    internal class P14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Employees e1 = new Employees();
            Console.WriteLine("Enter Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            e1.SetSalary(salary);
            Console.WriteLine("Employee Salary: " + e1.GetSalary());
            Console.Read();
        }
    }
}
