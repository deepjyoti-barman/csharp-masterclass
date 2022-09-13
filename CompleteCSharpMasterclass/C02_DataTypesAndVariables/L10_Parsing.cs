using System;

namespace C02_DataTypesAndVariables
{
    public class L10_Parsing
    {
        public static void Main(string[] args)
        {
            // Pasting string to int
            // string myString = "15a";     // Raises a FormatException, can be handled with try-catch or TryParse() method
            string myString = "15";
            string mySecondString = "13";
            
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int result = num1 + num2;
            
            Console.WriteLine($"result = {result}");
        }
    }
}