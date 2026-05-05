using System;

namespace Example_0_CSharpForLoop
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BASIC FOR LOOP
            // ===============================
            Console.WriteLine("=== Basic For Loop ===");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Count: " + i);
            }

            // ===============================
            // 2. COUNTDOWN LOOP
            // ===============================
            Console.WriteLine("\n=== Countdown ===");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Countdown: " + i);
            }

            // ===============================
            // 3. SUM OF NUMBERS
            // ===============================
            Console.WriteLine("\n=== Sum Example ===");

            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                sum += i; // Add each number
            }

            Console.WriteLine("Total sum: " + sum);

            // ===============================
            // 4. EVEN NUMBERS
            // ===============================
            Console.WriteLine("\n=== Even Numbers ===");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // Print even numbers
                }
            }

            // ===============================
            // 5. USER INPUT LOOP
            // ===============================
            Console.WriteLine("\n=== User Input Loop ===");

            Console.Write("How many students? ");
            int students = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= students; i++)
            {
                Console.Write($"Enter mark for student {i}: ");
                int mark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Student {i} mark: {mark}");
            }

            // ===============================
            // 6. MULTIPLICATION TABLE
            // ===============================
            Console.WriteLine("\n=== Multiplication Table ===");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            // ===============================
            // 7. NESTED FOR LOOP
            // ===============================
            Console.WriteLine("\n=== Nested Loop ===");

            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nFor loop examples completed.");
        }
    }
}