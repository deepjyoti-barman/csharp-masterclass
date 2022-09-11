using System;

namespace C02_DataTypesAndVariables
{
    internal class L02_int_float_double
    {
        public static void Main(string[] args)
        {
            int num1;               // Declaring a variable
            num1 = 13;              // Assigning a value to a variable
            Console.WriteLine(num1);
            
            // Declaring and initialize a variable in one go
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " = " + sum);
            
            // Chain assignment
            double num3, num4;
            num3 = num4 = 5.14;
            Console.WriteLine(num3 + " / " + num4 + " = " + num3 / num4);
            
            // Calculation between different data types
            double div = num3 / num1;
            // int div = num3 / num1;   // Not possible, explicit casting required
            Console.WriteLine(num3 + " / " + num1 + " = " + div);
        }
    }
}