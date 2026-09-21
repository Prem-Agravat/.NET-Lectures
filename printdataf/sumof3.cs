using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class sumof3
    {
        public static void sum() {
            int a, b, c, sum , sub, mul,div;
            Console.WriteLine("Enter Number 1:");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Enter Number 2:");
            string str1 = Console.ReadLine();
            b = Convert.ToInt32(str1);

            Console.WriteLine("Enter Number 3:");
            string str2 = Console.ReadLine();
            c = Convert.ToInt32(str2);

            sum = a + b + c;
            sub = a - b - b;
            mul = a * b * c;
            div = a / b / c;
            Console.WriteLine("Sum of 3 number is:" + sum);
            Console.WriteLine("Subtraction of 3 number is:" + sub);
            Console.WriteLine("Muliplication of 3 number is:" + mul);
            Console.WriteLine("division of 3 number is:" + div);
        }
    }
}
