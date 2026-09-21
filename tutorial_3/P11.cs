using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_3
{
    class BankAccount
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;

        public BankAccount(int ano,string name,double balance)
        {
            accNo = ano;
            accHolderName = name;
            accBalance = balance;
        }

        public void Deposit(double amount) { 
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        public void Withdraw(double amount)
        {
            if (amount > accBalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                accBalance -= amount;
                Console.WriteLine("Amount Withdrawn Successfully");
            }
        }

        public void Display() {
            Console.WriteLine("---------------Balance Enquiry---------------");
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Account Balance: " + accBalance);
        }
    }
    internal class P11
    {
        public static void Main(string[] args) {
            Console.WriteLine("25SOECE13042_Agravat Prem");

            BankAccount b1 = new BankAccount(12345, "Agravat Prem", 10000);
            Console.WriteLine("---------- Account - 1 Transaction ----------");
            b1.Deposit(5000);
            b1.Withdraw(2000);
            b1.Display();

            BankAccount b2 = new BankAccount(12368, "Dev Chauhan", 20000);

            Console.WriteLine("---------- Account - 2 Transaction ----------");
            b2.Deposit(2000);
            b2.Withdraw(2000);
            b2.Display();
            Console.ReadLine();


        }
    }
}
