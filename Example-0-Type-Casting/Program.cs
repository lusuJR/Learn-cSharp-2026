
/*
 * In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
 
 */

using System;

namespace Example_0_Type_Casting
{
    class Program
    {
       static void Main()
        {
            int myInt = 11;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            int myNumInt = 4;
            double myNumberDouble = myNumInt;       // Automatic casting: int to double

            Console.WriteLine(myNumInt);      // Outputs 9
            Console.WriteLine(myNumberDouble);   // Outputs 9

            double Price = 4.13;
            int myIntPrice = (int)Price;    // Manual casting: double to int

            Console.WriteLine(Price);   // Outputs 9.78
            Console.WriteLine(myIntPrice);      // Outputs 9
        } 
    }
}