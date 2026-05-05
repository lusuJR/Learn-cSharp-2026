
/*
 * Struct Instances vs. Class Instances
Because classes are reference types, a variable of a class object holds a reference to the address of the object on the managed heap. 
If a second variable of the same type is assigned to the first variable, then both variables refer to the object at that address.
 */

using System;

namespace Example_2_Class_Instances
{
    class Program
    {
        static void Main()
        {
            Person person1 = new("Amina", 6);
            Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes.
            person2.Name = "Rosemarie";
            person2.Age = 16;

            Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}");
            Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");
        }
    }
}
