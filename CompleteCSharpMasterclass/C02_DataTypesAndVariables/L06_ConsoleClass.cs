using System;

namespace C02_DataTypesAndVariables
{
    internal class L06_ConsoleClass
    {
        public static void Main(string[] args)
        {
            // Prints and keeps the cursor on the same line 
            Console.Write("Hello world");
            
            // Prints and puts the cursor in the next line
            Console.WriteLine("Welcome Dj");
            
            // Takes a single input of type string and returns the ASCII value of that input
            Console.WriteLine("\nEnter any letter:");
            int asciiValue = Console.Read();
            Console.WriteLine("\nASCII value = {0}", asciiValue);
            
            // Takes a string or integer input and returns it as the output value
            Console.WriteLine("\nEnter a string and press enter:");
            string inputStr = Console.ReadLine();
            Console.WriteLine($"You have entered {inputStr}");

            // Takes a single input of type string and it returns the key info
            Console.ReadKey();
        }
    }
}