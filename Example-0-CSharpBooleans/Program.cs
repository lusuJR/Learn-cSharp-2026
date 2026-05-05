using System;

namespace Example_0_CSharpBooleans
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. DECLARING BOOLEAN VARIABLES
            // ===============================
            Console.WriteLine("=== Boolean Variables ===");

            bool isActive = true;
            bool isLoggedIn = false;

            Console.WriteLine(isActive);     // true
            Console.WriteLine(isLoggedIn);   // false

            // ===============================
            // 2. BOOLEAN EXPRESSIONS
            // ===============================
            Console.WriteLine("\n=== Boolean Expressions ===");

            int a = 10;
            int b = 5;

            Console.WriteLine(a > b);   // true
            Console.WriteLine(a < b);   // false
            Console.WriteLine(a == b);  // false
            Console.WriteLine(a != b);  // true

            // ===============================
            // 3. IF STATEMENT WITH BOOLEAN
            // ===============================
            Console.WriteLine("\n=== If Statement ===");

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            // ===============================
            // 4. BOOLEAN WITH LOGICAL OPERATORS
            // ===============================
            Console.WriteLine("\n=== Logical Operators ===");

            bool hasUsername = true;
            bool hasPassword = false;

            // AND (both must be true)
            Console.WriteLine(hasUsername && hasPassword); // false

            // OR (at least one true)
            Console.WriteLine(hasUsername || hasPassword); // true

            // NOT (reverse)
            Console.WriteLine(!hasUsername); // false

            // ===============================
            // 5. REAL-WORLD LOGIN EXAMPLE
            // ===============================
            Console.WriteLine("\n=== Login Example ===");

            string username = "admin";
            string password = "1234";

            bool isValidUser = username == "admin";
            bool isValidPassword = password == "1234";

            if (isValidUser && isValidPassword)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }

            // ===============================
            // 6. BOOLEAN FROM USER INPUT
            // ===============================
            Console.WriteLine("\n=== User Input ===");

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            bool isAdult = userAge >= 18;

            Console.WriteLine("Are you an adult? " + isAdult);

            // ===============================
            // 7. TERNARY WITH BOOLEAN
            // ===============================
            Console.WriteLine("\n=== Ternary Operator ===");

            string result = isAdult ? "You can vote" : "You cannot vote";
            Console.WriteLine(result);

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nBoolean examples completed.");
        }
    }
}