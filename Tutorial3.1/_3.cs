using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial3._1
{
    class LibraryAccount
    {
        private int issuedBooks;

        public void IssueBook()
        {
            issuedBooks++;
        }

        public void ReturnBook()
        {
            if (issuedBooks > 0)
                issuedBooks--;
        }

        public void Display()
        {
            Console.WriteLine("Issued Books: " + issuedBooks);
        }
    }
    internal class _3
    {
        static void Main()
        {
            Console.WriteLine("Agravat Prem_25SOECE13042");
            LibraryAccount a1 = new LibraryAccount();
            LibraryAccount a2 = new LibraryAccount();

            a1.IssueBook();
            a1.IssueBook();
            a1.ReturnBook();

            a2.IssueBook();

            Console.WriteLine("Account 1:");
            a1.Display();

            Console.WriteLine("Account 2:");
            a2.Display();
        }
    }
}
