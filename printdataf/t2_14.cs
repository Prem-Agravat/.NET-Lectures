using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printdataf
{
    internal class t2_14
    {
        public static void Main(String[] args)
        {
            int phy,maths,chem;
            Console.WriteLine("Enter marks of Math:");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Phy:");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Chem");
            chem = Convert.ToInt32(Console.ReadLine());

            int total = maths + phy + chem;
            int mathPhy = maths + phy;

            if ((maths >= 65 && phy >= 55 && chem >= 50 && total >= 100) || (maths >= 65 && phy >= 55 && mathPhy >= 140))
            {
                Console.WriteLine("The candidate eligible for admission");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission");
         }
    }
}
