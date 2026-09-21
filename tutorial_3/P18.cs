using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{

    class employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee salary slip");
        }
    }
    class permanentemployee : employee
    {
        public override void GenerateSalarySlip()
        {
            double hra = Salary * 0.20;
            double da = Salary * 0.10 ;
            double netSalary = Salary + hra + da;
            Console.WriteLine("Permanent Employee:");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class contractemployee : employee
    {
        public override void GenerateSalarySlip()
        {
            Console.WriteLine("Contract Employee");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Net Salary: " + Salary);
        }
    }
    internal class P18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            employee emp;
            emp = new permanentemployee();

            emp.Name ="Rahul";
            emp.Salary = 30000;
            emp.GenerateSalarySlip();
            emp = new contractemployee();
            emp.Name = "Priya";
            emp.Salary = 30000;
            emp.GenerateSalarySlip();
            Console.ReadLine();

        }
    }
}
