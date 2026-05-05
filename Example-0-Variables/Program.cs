/*
 * 
 * 
 * Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false
 */

using System;

namespace Example_0_Variables
{
    class Program
    {
        static void Main()
        {
            string Name = "Lusukama  ";

            Console.WriteLine("Bonjour Mr. " +Name);

            string LastName = "Selemani";

            string FullName = Name + LastName;

            Console.WriteLine("My Full Name is : Mr. " + FullName);

            int myNum = 5;
            Console.WriteLine(myNum);

            int Num;
            Num = 15;
            Console.WriteLine(Num);

            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;

            //unchangeable and read-only
            const int luckNumber = 15;

            int x = 12;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y

            int a = 5, b = 6, c = 50;
            Console.WriteLine(a + b + c);


            int m, n, p;
            m = n = p = 20;
            Console.WriteLine(m + n + p);

            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(luckNumber);
        }
    }
}