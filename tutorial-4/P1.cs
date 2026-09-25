using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_4
{
    class Employee
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;

        public Employee(int emp_code, string emp_name, string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;
        }
        public void CalculatePay()
        {
            double hra = 0.1 * basicPay;
            double da = 0.2 * basicPay;
            double netSalary = basicPay + hra + da;
            Console.WriteLine("Employee Code        :" + emp_code);
            Console.WriteLine("Employee Name        :" + emp_name);
            Console.WriteLine("Employee Designation :" + designation);
            Console.WriteLine("Basic Salary         :" + basicPay);
        }

    }
    internal class P1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            Employee e1 = new Employee(101, "Prem agravat", "Frontend developer", 60000);
            e1.CalculatePay();
            Employee e2 = new Employee(102, "Ramanshu", "Backend developer", 50000);
            e2.CalculatePay();
            Employee e3 = new Employee(103, "Dev", "Full Stack developer", 60000);
            e3.CalculatePay();

        }
    }
}
