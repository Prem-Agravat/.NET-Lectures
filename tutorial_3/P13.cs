using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class StudentDetail
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public double CalculateBill()
        {
            return price * quantity;
        }
        public void Display()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("Product ID: " + prodId);
            Console.WriteLine("Product Name: " + prodName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total Bill Amount: " + CalculateBill());
        }
    }
    internal class P13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            StudentDetail s1 = new StudentDetail();
            Console.WriteLine("Enter Product ID: ");
            s1.prodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name: ");
            s1.prodName = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            s1.price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            s1.quantity = Convert.ToInt32(Console.ReadLine());
            s1.Display();
        }
    }
}
