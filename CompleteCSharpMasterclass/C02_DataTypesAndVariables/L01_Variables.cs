using System;

namespace C02_DataTypesAndVariables
{
    internal class L01_Variables
    {
        static int age = 15;
        static int favNo;               // Default value 0 is assigned
        
        public static void Main(string[] args)
        {
            Console.WriteLine(age);     // 15
            age = 20;
            Console.WriteLine(age);     // 20
            Console.WriteLine(favNo);   // 0
            
            // Data types and their ranges
            // Other data types: byte which can take values from 0 to 255, uint (unsigned int), ushort (unsigned short), ulong (unsigned long)
            sbyte a = 120;              // Stands for signed byte; can store whole numbers from -128 to 127
            short b = 30000;            // Can store whole numbers from -32768 to 32767
            int c = 200000000;          // Can store whole numbers from -2147483648 to -2147483647
            long d = 900000000000000;   // Can store whole numbers from -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807
            
            float eulerNo = 2.71828f;   // Has 7-digit precision
            double pi = 3.141592;       // Has 15-digit precision
            decimal rate = 7.14928393m; // Has 28-digit precision
            
            bool isGPSEnabled = true;   // Can only have two values true or false 
            string userName = "Dennis"; // Allows multiple character literals or unicode
            char at = '@';              // Allows a single character literal or unicode
        }
    }
}

/*
NOTE:
- A variable is a container that can take a value.
- A variable must have a type.
- The type of the variable is going to tell us what kind of data it can hold.
- Example in C#: int number = 5;
- Variables can be declared outside and inside of a method.
- If we create a variable inside a method, that variable can only get used inside of this method.
- float: Mostly used in graphics libraries (high demands for processing powers)
- double: Mostly used for real world values (except money calculations)
- decimal: Mostly used in financial applications (high level of accuracy)
*/