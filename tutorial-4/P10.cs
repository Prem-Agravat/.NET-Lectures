using System;

// User-defined exception class
class MyException : Exception
{
    // Constructor accepting exception message
    public MyException(string str) : base(str)
    {
        //Console.WriteLine("User defined exception");
    }
}

// Main client class
class P10
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Agravat Prem 25SOECE13042");

        try
        {
            // Throw user-defined exception
            throw new MyException("my exception generated.");
        }
        catch (Exception e)
        {
            // Display exception message
            Console.WriteLine("Exception caught here: " + e.Message);
        }

        // This statement executes after catch
        Console.WriteLine("LAST STATEMENT");

        Console.ReadKey();
    }
}