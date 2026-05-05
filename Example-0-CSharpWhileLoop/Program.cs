using System;

namespace Example_0_CSharpWhileLoop
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BASIC WHILE LOOP
            // ===============================
            Console.WriteLine("=== Basic While Loop ===");

            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine("Count: " + i);
                i++; // increment to avoid infinite loop
            }

            // ===============================
            // 2. USER INPUT LOOP
            // ===============================
            Console.WriteLine("\n=== User Input Loop ===");

            Console.Write("Enter a number (0 to exit): ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine("You entered: " + number);

                Console.Write("Enter another number (0 to exit): ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            // ===============================
            // 3. VALIDATION LOOP
            // ===============================
            Console.WriteLine("\n=== Validation Loop ===");

            int age = -1;

            while (age <= 0)
            {
                Console.Write("Enter a valid age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Valid age entered: " + age);

            // ===============================
            // 4. LOGIN ATTEMPT SYSTEM
            // ===============================
            Console.WriteLine("\n=== Login Attempts ===");

            string username = "";
            string password = "";

            int attempts = 0;

            while ((username != "admin" || password != "1234") && attempts < 3)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                attempts++;

                if (username != "admin" || password != "1234")
                {
                    Console.WriteLine("Invalid credentials. Try again.");
                }
            }

            if (attempts == 3)
            {
                Console.WriteLine("Account locked.");
            }
            else
            {
                Console.WriteLine("Login successful.");
            }

            // ===============================
            // 5. COUNTER WITH SUM
            // ===============================
            Console.WriteLine("\n=== Sum Example ===");

            int sum = 0;
            int count = 1;

            while (count <= 5)
            {
                sum += count; // add numbers
                count++;
            }

            Console.WriteLine("Total sum: " + sum);

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nWhile loop examples completed.");
        }
    }
}