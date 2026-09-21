using System;
using System;

namespace printdataf

{

    class Rearrangecode

    {

        static void Main(string[] args)

        {
            int[] arr = new int[5];
            int sum = 0;


            for (int i = 0; i < 5; i++)

            {


                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);

                


            }

            for (int i = 0; i < 5; i++)

            {

                sum = sum + arr[i];

            }

            Console.WriteLine("Sum of Elements : {0}", sum);

            

            

            Console.Read();

        }



    }

}