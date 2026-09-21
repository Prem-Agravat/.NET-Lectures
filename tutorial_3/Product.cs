using System;

namespace tutorial3
{
    class Product12
    {
        int pcode;
        string pname;
        string mname;
        public Product12(int pcd, String pnm, String mnm)

        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }
        public void Display()

        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.WriteLine("Product Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }


    class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("25SOECE13042_Agravat_Prem");
            Console.WriteLine("Product Code:= 101");
            Console.WriteLine("Product Name:= Laptop");
            Console.WriteLine("Manufacturer Name:= Lenovo");
        }
    }

}