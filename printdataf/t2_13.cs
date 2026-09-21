using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class t2_13
    {
        public static void Main(String[] args)
        {
            int amount;
            Console.Write("Enter ammount:");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10 ,5,2,1};
            foreach (int note in notes) {
                int count = amount / note;
                Console.WriteLine("Note of Rs. {0}={1} ", note, count);
                amount = amount % note;

            }
            Console.ReadLine();
            
        }
    }
}
