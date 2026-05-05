using System;

namespace Example_0_CSharpArrays
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. DECLARING AN ARRAY
            // ===============================
            Console.WriteLine("=== Declaring Arrays ===");

            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine(numbers[0]); // First element → 10
            Console.WriteLine(numbers[1]); // Second element → 20

            // ===============================
            // 2. ARRAY LENGTH
            // ===============================
            Console.WriteLine("\n=== Array Length ===");

            Console.WriteLine(numbers.Length); // Total elements → 5

            // ===============================
            // 3. LOOP THROUGH ARRAY (FOR)
            // ===============================
            Console.WriteLine("\n=== For Loop ===");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // ===============================
            // 4. FOREACH LOOP
            // ===============================
            Console.WriteLine("\n=== Foreach Loop ===");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // ===============================
            // 5. MODIFY ARRAY
            // ===============================
            Console.WriteLine("\n=== Modify Array ===");

            numbers[0] = 100; // Change first value
            Console.WriteLine(numbers[0]);

            // ===============================
            // 6. USER INPUT INTO ARRAY
            // ===============================
            Console.WriteLine("\n=== User Input ===");

            Console.Write("How many students? ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[size];

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nStudent Marks:");

            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            // ===============================
            // 7. FIND MAX VALUE
            // ===============================
            Console.WriteLine("\n=== Max Value ===");

            int max = marks[0];

            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }

            Console.WriteLine("Highest mark: " + max);

            // ===============================
            // 8. SUM AND AVERAGE
            // ===============================
            Console.WriteLine("\n=== Sum & Average ===");

            int sum = 0;

            foreach (int mark in marks)
            {
                sum += mark;
            }

            double average = (double)sum / marks.Length;

            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + average);

            // ===============================
            // 9. STRING ARRAY
            // ===============================
            Console.WriteLine("\n=== String Array ===");

            string[] names = { "Alex", "Sarah", "John" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nArray examples completed.");
        }
    }
}