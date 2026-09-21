using System;
namespace tutorial_3
{
    class Product
    {
        int pcode;

        string pname, mname;
        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }
        public void Display()
        {
            Console.WriteLine("Product Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }
    public class P3
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3) { 
            
                Console.WriteLine("Syntax Error");

                return;
            }
            int pcd = Convert.ToInt32(args[0]);
            string pnm = args[1];
            string mnm = args[2];
            Product p = new Product(pcd, pnm, mnm);
            p.Display();
            Console.Read();
        }
    }
}