using System;

namespace Example_0_If_Else
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. BASIC IF STATEMENT
            // ===============================
            Console.WriteLine("=== Basic If ===");

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }

            // ===============================
            // 2. IF...ELSE
            // ===============================
            Console.WriteLine("\n=== If...Else ===");

            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            // ===============================
            // 3. IF...ELSE IF...ELSE
            // ===============================
            Console.WriteLine("\n=== If...Else If...Else ===");

            int marks = 75;

            if (marks >= 80)
            {
                Console.WriteLine("Distinction");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Pass");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Supplementary");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // ===============================
            // 4. NESTED IF
            // ===============================
            Console.WriteLine("\n=== Nested If ===");

            bool hasID = true;
            bool hasTicket = false;

            if (hasID)
            {
                if (hasTicket)
                {
                    Console.WriteLine("Entry allowed");
                }
                else
                {
                    Console.WriteLine("No ticket");
                }
            }
            else
            {
                Console.WriteLine("No ID");
            }

            // ===============================
            // 5. REAL-WORLD LOGIN EXAMPLE
            // ===============================
            Console.WriteLine("\n=== Login System ===");

            string username = "admin";
            string password = "1234";

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

            // ===============================
            // 6. USER INPUT EXAMPLE
            // ===============================
            Console.WriteLine("\n=== User Input ===");

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cannot vote");
            }

            // ===============================
            // 7. SHORT IF (TERNARY)
            // ===============================
            Console.WriteLine("\n=== Ternary If ===");

            string result = userAge >= 18 ? "Adult" : "Minor";
            Console.WriteLine(result);

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nIf...Else examples completed.");
        }
    }
}