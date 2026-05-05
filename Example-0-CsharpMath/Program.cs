using System;

namespace CSharpMathDemo
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BASIC MATH OPERATIONS
            // ===============================
            Console.WriteLine("=== Basic Math ===");

            int a = 10;
            int b = 3;

            Console.WriteLine(Math.Max(a, b)); // Returns the largest value → 10
            Console.WriteLine(Math.Min(a, b)); // Returns the smallest value → 3

            // ===============================
            // 2. ABSOLUTE VALUE
            // ===============================
            Console.WriteLine("\n=== Absolute Value ===");

            int negativeNumber = -25;
            Console.WriteLine(Math.Abs(negativeNumber)); // Converts to positive → 25

            // ===============================
            // 3. POWER AND SQUARE ROOT
            // ===============================
            Console.WriteLine("\n=== Power & Square Root ===");

            Console.WriteLine(Math.Pow(2, 3)); // 2^3 → 8
            Console.WriteLine(Math.Sqrt(64));  // √64 → 8

            // ===============================
            // 4. ROUNDING METHODS
            // ===============================
            Console.WriteLine("\n=== Rounding ===");

            double number = 5.67;

            Console.WriteLine(Math.Round(number));  // Round → 6
            Console.WriteLine(Math.Floor(number));  // Down → 5
            Console.WriteLine(Math.Ceiling(number)); // Up → 6

            // ===============================
            // 5. CONSTANT VALUES
            // ===============================
            Console.WriteLine("\n=== Constants ===");

            Console.WriteLine(Math.PI); // 3.14159...
            Console.WriteLine(Math.E);  // Euler's number

            // ===============================
            // 6. TRIGONOMETRIC FUNCTIONS
            // ===============================
            Console.WriteLine("\n=== Trigonometry ===");

            double angle = Math.PI / 4; // 45 degrees in radians

            Console.WriteLine(Math.Sin(angle)); // Sine
            Console.WriteLine(Math.Cos(angle)); // Cosine
            Console.WriteLine(Math.Tan(angle)); // Tangent

            // ===============================
            // 7. RANDOM NUMBERS
            // ===============================
            Console.WriteLine("\n=== Random Numbers ===");

            Random random = new Random();

            Console.WriteLine(random.Next());        // Any positive integer
            Console.WriteLine(random.Next(1, 10));   // Between 1 and 9

            // ===============================
            // 8. SIGN FUNCTION
            // ===============================
            Console.WriteLine("\n=== Sign ===");

            Console.WriteLine(Math.Sign(-10)); // -1 (negative)
            Console.WriteLine(Math.Sign(0));   // 0 (zero)
            Console.WriteLine(Math.Sign(10));  // 1 (positive)

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nAll math examples completed.");
        }
    }
}