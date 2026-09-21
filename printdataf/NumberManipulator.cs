using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    class Number
    {
        public void Swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x= y; 
            y = temp;
        }
    }
     class NumberManipulator
    {
        static void Main(string[] args)
        {
            Number no = new Number();
            int a, b;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: a = {0}, b = {1}", a, b);
           
            no.Swap(ref a, ref b);
            Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
        }
    }

    
}
