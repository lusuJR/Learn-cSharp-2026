using System;

namespace Example_0_CSharpBreakandContinue
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BREAK STATEMENT
            // ===============================
            Console.WriteLine("=== Break Example ===");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // Exit loop when i = 5
                }

                Console.WriteLine(i);
            }

            // ===============================
            // 2. CONTINUE STATEMENT
            // ===============================
            Console.WriteLine("\n=== Continue Example ===");

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue; // Skip number 3
                }

                Console.WriteLine(i);
            }

            // ===============================
            // 3. BREAK WITH WHILE LOOP
            // ===============================
            Console.WriteLine("\n=== Break with While ===");

            int count = 1;

            while (count <= 10)
            {
                if (count == 6)
                {
                    break; // Stop loop early
                }

                Console.WriteLine(count);
                count++;
            }

            // ===============================
            // 4. CONTINUE WITH WHILE LOOP
            // ===============================
            Console.WriteLine("\n=== Continue with While ===");

            int num = 0;

            while (num < 5)
            {
                num++;

                if (num == 2)
                {
                    continue; // Skip 2
                }

                Console.WriteLine(num);
            }

            // ===============================
            // 5. REAL-WORLD LOGIN EXAMPLE (BREAK)
            // ===============================
            Console.WriteLine("\n=== Login System (Break) ===");

            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Enter PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());

                if (pin == 1234)
                {
                    Console.WriteLine("Access granted");
                    break; // Stop attempts once correct
                }
                else
                {
                    Console.WriteLine("Incorrect PIN");
                }
            }

            // ===============================
            // 6. SKIP INVALID INPUT (CONTINUE)
            // ===============================
            Console.WriteLine("\n=== Skip Invalid Input ===");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter number {i}: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < 0)
                {
                    Console.WriteLine("Negative number skipped");
                    continue; // Skip processing
                }

                Console.WriteLine("Accepted: " + input);
            }

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nBreak and Continue examples completed.");
        }
    }
}