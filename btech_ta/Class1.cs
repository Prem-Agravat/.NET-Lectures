using System;
using System.Collections.Generic;
using System.Text;

namespace btech_ta
{
    abstract class Employee //blueprint or template
    {

        //it does not have any return type explicitly
        //must hae same name as class name
        //public test() { }
        // public Employee() { }

        abstract public void Show();//abstract method
        //abstract
        //highlighs the feaatures only
        //abstract keyword used with class and method
        //you cannot create object of abstract class
        //within abstract class you can put data members,abstract methods,concrete methods(non-abstraact),constructors,etc..
        //you can use abstract class as a parent class
        //all the abstract methods must be implemented in the child class
        //all the abstract method are implicitly virtual
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
        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Salary: " + Salary);
        }
        public void Check()
        {
            Console.WriteLine("Check method from Employee class");
        }
    }
    interface IA
    {
        void Test1();
    }

    interface IB
    {
        void Test1();
        void Test2();

    }
    //interface  
    
    interface ITest
    {
        void Testing();
    }
    class RegularEmployee : Employee,ITest //Level-1
    {
        public void Testing()
        {
            Console.WriteLine("Testing method from ITest interface");
        }
        //Data Members: from this class: 5
        //Data Members: from base class(Employee): 3

        //Properties: from this class: 0
        //Properties: from base class(Employee): 1

        //Methods: from this class: 0
        //Methods: from base class(Employee): 3
        private double Basic;
        private double HRA;
        private double DA;
        private double PF;
        private double PT;
        public override void Show()
        {
            Console.WriteLine("Show method from RegularEmployee class");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("PT: " + PT);
        }

        public new void Check()
        {
            Console.WriteLine("Check method from RegularEmployee class");
        }
    }
    internal class Class1
    {
        public static void Main(string[] args)
        {
           /*  Employee e1 = new Employee();
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


            Employee e3 = new Employee();
            e3.Display();  //Employee
            e3.Check();  //Employee
            Console.WriteLine("--------------------------------------------------");*/

            RegularEmployee e4 = new RegularEmployee();
            e4.Display();  //RegularEmployee
            e4.Check();  //RegularEmployee
            e4.Show();
            Console.WriteLine("--------------------------------------------------");

            Employee e5 = new RegularEmployee();
            e5.Display();  //RegularEmployee
            e5.Check();  //Employee
            Console.WriteLine("--------------------------------------------------");

            Console.Read();
        }
    }
}
