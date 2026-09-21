using System;
abstract class Account
{
    // Store account amount
    protected double amount;

    // Constructor to set amount
    public Account(double amount)
    {
        this.amount = amount;
    }

    // Abstract method
    public abstract void CalculateInterest();
}

// Saving Account class
class SavingAccount : Account
{
    // Constructor
    public SavingAccount(double amount) : base(amount) { }

    // Calculate saving account interest
    public override void CalculateInterest()
    {
        Console.WriteLine("Saving Account Interest = " + (amount * 4 / 100));
    }
}

// Current Account class
class CurrentAccount : Account
{
    // Constructor
    public CurrentAccount(double amount) : base(amount) { }

    // Calculate current account interest
    public override void CalculateInterest()
    {
        Console.WriteLine("Current Account Interest = " + (amount * 2 / 100));
    }
}
class P23
{
    public static void Main()
    {
        Console.WriteLine("25SOECE13042_Agravat Prem");
        // Create Saving Account object
        SavingAccount a = new SavingAccount(10000);

        // Calculate saving account interest
        a.CalculateInterest();

        // Create Current Account object
        CurrentAccount b = new CurrentAccount(10000);

        // Calculate current account interest
        b.CalculateInterest();

        Console.Read();
    }
}