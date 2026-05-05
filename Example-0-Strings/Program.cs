using System;

namespace CSharpStringsDemo
{
    class Program
    {
        static void Main()
        {
            // ===============================
            // 1. DECLARING STRINGS
            // ===============================
            Console.WriteLine("=== Declaring Strings ===");

            string firstName = "Lusukama";
            string lastName = "Selemani";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // ===============================
            // 2. STRING CONCATENATION
            // ===============================
            Console.WriteLine("\n=== Concatenation ===");

            string fullName = firstName + " " + lastName; // Combine strings
            Console.WriteLine(fullName);

            // String interpolation (modern approach)
            Console.WriteLine($"Full Name: {firstName} {lastName}");

            // ===============================
            // 3. STRING LENGTH
            // ===============================
            Console.WriteLine("\n=== String Length ===");

            Console.WriteLine(fullName.Length); // Total characters

            // ===============================
            // 4. ACCESS CHARACTERS
            // ===============================
            Console.WriteLine("\n=== Access Characters ===");

            Console.WriteLine(fullName[0]); // First character
            Console.WriteLine(fullName[1]); // Second character

            // ===============================
            // 5. STRING METHODS
            // ===============================
            Console.WriteLine("\n=== String Methods ===");

            Console.WriteLine(fullName.ToUpper()); // Convert to uppercase
            Console.WriteLine(fullName.ToLower()); // Convert to lowercase

            // ===============================
            // 6. SEARCHING STRINGS
            // ===============================
            Console.WriteLine("\n=== Searching ===");

            Console.WriteLine(fullName.IndexOf("Selemani")); // Position of substring

            // ===============================
            // 7. SUBSTRING
            // ===============================
            Console.WriteLine("\n=== Substring ===");

            Console.WriteLine(fullName.Substring(0, 4)); // Extract "Alex"

            // ===============================
            // 8. STRING COMPARISON
            // ===============================
            Console.WriteLine("\n=== Comparison ===");

            string name1 = "Selemani";
            string name2 = "selemani";

            Console.WriteLine(name1 == name2); // Case-sensitive → false
            Console.WriteLine(name1.Equals(name2, StringComparison.OrdinalIgnoreCase)); // true

            // ===============================
            // 9. ESCAPE CHARACTERS
            // ===============================
            Console.WriteLine("\n=== Escape Characters ===");

            Console.WriteLine("Hello\nWorld");   // New line
            Console.WriteLine("Name:\tAlex");    // Tab space
            Console.WriteLine("He said \"Hi\""); // Quotes

            // ===============================
            // 10. STRING REPLACE & TRIM
            // ===============================
            Console.WriteLine("\n=== Replace & Trim ===");

            string text = "   Hello World   ";

            Console.WriteLine(text.Trim()); // Remove spaces
            Console.WriteLine(text.Replace("World", "C#")); // Replace word

            // ===============================
            // 11. SPLIT STRINGS
            // ===============================
            Console.WriteLine("\n=== Split ===");

            string sentence = "C# is powerful";

            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // ===============================
            // 12. STRING INTERPOLATION (ADVANCED)
            // ===============================
            Console.WriteLine("\n=== Interpolation ===");

            int age = 25;
            Console.WriteLine($"My name is {firstName} and I am {age} years old.");

            // ===============================
            // END
            // ===============================
            Console.WriteLine("\nAll string examples completed.");
        }
    }
}