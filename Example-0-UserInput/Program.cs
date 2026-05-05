using System;

namespace Example_0_UserInput
{
    class Program
    {
        static void Main() 
        {
            // Ask for username
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine() ?? "Unknown";

            // Display username
            Console.WriteLine($"Username: {userName}");

            // Ask for age with validation
            Console.Write("Enter your age: ");
            string inputAge = Console.ReadLine()!;

            int age;

            // Validate input (prevents crash)
            while (!int.TryParse(inputAge, out age) || age <= 0)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
                inputAge = Console.ReadLine()!;
            }

            // Display age
            Console.WriteLine($"Age: {age}");

            Console.WriteLine("\nRegistration successful!");
        }
    }
}