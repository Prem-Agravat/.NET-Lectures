using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class Employe
    {

        public void EmpStatus()
        {
            Console.WriteLine("Employee is Working");
        }
    }
    class Department : Employe
    {
        //new keywork will hide the methong of the parent class
        public new void EmpStatus()
        {
            Console.WriteLine("Employee is Not Working");
        }
    }
    internal class P22
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Department d = new Department();
            d.EmpStatus();
        }
    }
}
