using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace btech_ta
{

    internal class collection
    {

        public static void Main(String[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }

}
