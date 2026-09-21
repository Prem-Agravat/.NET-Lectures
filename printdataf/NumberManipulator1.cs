using System;


namespace printdataf

{

   class TestOut

    {

      public int getValues(out int x, out int y, out int z )

      {
            int sum;
          Console.WriteLine("Enter the first value: ");
          x = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the second value: ");

          y = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());
            sum = x + y + z;

          return sum;

      }

   }

 class NumberManipulator1

    {

      static void Main(string[] args)

      {

            TestOut n = new TestOut();

         /* local variable definition */

         int a , b, c, sum;

        

         /* calling a function to get the values */

         sum = n.getValues(out a, out b, out c);

 

         Console.WriteLine("After method call, value of a : {0}", a);

         Console.WriteLine("After method call, value of b : {0}", b);

         Console.WriteLine("After method call, value of c : {0}", c);

         Console.WriteLine("Sum : {0}", sum);
      }

   }

}