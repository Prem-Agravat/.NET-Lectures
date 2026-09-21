using System;

namespace Lab3
{
    class P25
    {
        static void Main()
        {
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Remove unnecessary spaces
            password = password.Trim();

            Console.WriteLine("Password Details");
            Console.WriteLine("-------------------------");

            // Display password length
            Console.WriteLine("Password Length : " + password.Length);

            // Validate password length
            if (password.Length < 8)
            {
                Console.WriteLine("Password must contain at least 8 characters.");
            }
            else
            {
                Console.WriteLine("Password Length is Valid.");

                // Check for special character
                if (password.Contains("@") ||
                    password.Contains("#") ||
                    password.Contains("$"))
                {
                    Console.WriteLine("Special Character : Available");
                }
                else
                {
                    Console.WriteLine("Special Character : Not Available");
                }

                // Convert password to uppercase
                Console.WriteLine("Uppercase Password : " + password.ToUpper());

                // Convert password to lowercase
                Console.WriteLine("Lowercase Password : " + password.ToLower());

                // Replace @ with #
                string modifiedPassword = password.Replace("@", "#");

                Console.WriteLine("Modified Password  : " + modifiedPassword);
            }

            Console.Read();
        }
    }
}