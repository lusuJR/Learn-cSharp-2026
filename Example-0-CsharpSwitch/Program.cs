using System;

namespace Example_0_CsharpSwitch
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BASIC SWITCH STATEMENT
            // ===============================
            Console.WriteLine("=== Basic Switch ===");

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // ===============================
            // 2. SWITCH WITH USER INPUT
            // ===============================
            Console.WriteLine("\n=== User Input ===");

            Console.Write("Enter a number (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Option 1");
                    break;

                case 2:
                    Console.WriteLine("You selected Option 2");
                    break;

                case 3:
                    Console.WriteLine("You selected Option 3");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            // ===============================
            // 3. SWITCH WITH STRING
            // ===============================
            Console.WriteLine("\n=== Switch with String ===");

            Console.Write("Enter role (admin/user): ");
            string role = Console.ReadLine()?.ToLower();

            switch (role)
            {
                case "admin":
                    Console.WriteLine("Full access granted");
                    break;

                case "user":
                    Console.WriteLine("Limited access granted");
                    break;

                default:
                    Console.WriteLine("Unknown role");
                    break;
            }

            // ===============================
            // 4. GROUPING CASES
            // ===============================
            Console.WriteLine("\n=== Grouped Cases ===");

            int month = 12;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Summer (SA)");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("Other season");
                    break;
            }

            // ===============================
            // 5. MODERN SWITCH (EXPRESSION)
            // ===============================
            Console.WriteLine("\n=== Switch Expression ===");

            int marks = 75;

            string result = marks switch
            {
                >= 80 => "Distinction",
                >= 60 => "Pass",
                >= 50 => "Supplementary",
                _ => "Fail"
            };

            Console.WriteLine(result);

            // ===============================
            // 6. MENU SYSTEM (REAL-WORLD)
            // ===============================
            Console.WriteLine("\n=== Menu System ===");

            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");

            Console.Write("Select option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Balance: R5000");
                    break;

                case 2:
                    Console.WriteLine("Deposit selected");
                    break;

                case 3:
                    Console.WriteLine("Withdraw selected");
                    break;

                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nSwitch examples completed.");
        }
    }
}