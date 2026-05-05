using System;

namespace Example_0_Operators
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. ARITHMETIC OPERATORS
            // ===============================
            int a = 10;
            int b = 3;

            Console.WriteLine("=== Arithmetic Operators ===");
            Console.WriteLine(a + b);   // Addition → 13
            Console.WriteLine(a - b);   // Subtraction → 7
            Console.WriteLine(a * b);   // Multiplication → 30
            Console.WriteLine(a / b);   // Division → 3 (integer division)
            Console.WriteLine(a % b);   // Modulus → 1 (remainder)

            // ===============================
            // 2. ASSIGNMENT OPERATORS
            // ===============================
            Console.WriteLine("\n=== Assignment Operators ===");
            int x = 5;
            x += 2;  // x = x + 2 → 7
            x -= 1;  // x = x - 1 → 6
            x *= 3;  // x = x * 3 → 18
            x /= 2;  // x = x / 2 → 9
            x %= 4;  // x = x % 4 → 1
            Console.WriteLine(x);

            // ===============================
            // 3. COMPARISON OPERATORS
            // ===============================
            Console.WriteLine("\n=== Comparison Operators ===");
            Console.WriteLine(a == b);  // Equal → false
            Console.WriteLine(a != b);  // Not equal → true
            Console.WriteLine(a > b);   // Greater than → true
            Console.WriteLine(a < b);   // Less than → false
            Console.WriteLine(a >= b);  // Greater or equal → true
            Console.WriteLine(a <= b);  // Less or equal → false

            // ===============================
            // 4. LOGICAL OPERATORS
            // ===============================
            Console.WriteLine("\n=== Logical Operators ===");
            bool isLoggedIn = true;
            bool isAdmin = false;

            Console.WriteLine(isLoggedIn && isAdmin); // AND → false
            Console.WriteLine(isLoggedIn || isAdmin); // OR → true
            Console.WriteLine(!isLoggedIn);           // NOT → false

            // ===============================
            // 5. INCREMENT / DECREMENT
            // ===============================
            Console.WriteLine("\n=== Increment / Decrement ===");
            int num = 5;

            Console.WriteLine(num++); // Post-increment → prints 5, then becomes 6
            Console.WriteLine(++num); // Pre-increment → becomes 7, prints 7
            Console.WriteLine(num--); // Post-decrement → prints 7, then becomes 6
            Console.WriteLine(--num); // Pre-decrement → becomes 5, prints 5

            // ===============================
            // 6. CONDITIONAL (TERNARY) OPERATOR
            // ===============================
            Console.WriteLine("\n=== Ternary Operator ===");
            int age = 18;
            string result = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine(result);

            // ===============================
            // 7. NULL-COALESCING OPERATOR
            // ===============================
            Console.WriteLine("\n=== Null-Coalescing Operator ===");
            string name = null;
            string displayName = name ?? "Guest"; // If null, use "Guest"
            Console.WriteLine(displayName);

            // ===============================
            // 8. TYPE OPERATORS
            // ===============================
            Console.WriteLine("\n=== Type Operators ===");
            object obj = "Hello";

            Console.WriteLine(obj is string); // true → checks type

            string text = obj as string; // safe casting
            Console.WriteLine(text);

            // ===============================
            // 9. BITWISE OPERATORS
            // ===============================
            Console.WriteLine("\n=== Bitwise Operators ===");
            int m = 5;  // 0101
            int n = 3;  // 0011

            Console.WriteLine(m & n); // AND → 0001 → 1
            Console.WriteLine(m | n); // OR  → 0111 → 7
            Console.WriteLine(m ^ n); // XOR → 0110 → 6
            Console.WriteLine(~m);    // NOT → invert bits

            // ===============================
            // 10. SHIFT OPERATORS
            // ===============================
            Console.WriteLine("\n=== Shift Operators ===");
            Console.WriteLine(m << 1); // Left shift → 1010 → 10
            Console.WriteLine(m >> 1); // Right shift → 0010 → 2

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nAll operator examples completed.");
        }
    }
}