using System;

namespace C02_DataTypesAndVariables
{
    public class L09_ImplicitExplicitConversion
    {
        public static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;
            
            // Cast double to int (explicit conversion)
            myInt = (int)myDouble;
            Console.WriteLine($"myInt = {myInt}");
            
            // Cast byte to int (implicit conversion)
            sbyte byteNum = 101;
            long longNum = byteNum;
            Console.WriteLine($"longNum = {longNum}");
            
            // Type conversion
            // Conversion of double to string
            string myDoubleString = myDouble.ToString();
            Console.WriteLine($"myDoubleString = {myDoubleString}");
            
            // Conversion of bool to string
            // NOTE: bool to int/long/float etc. conversion not possible
            bool isEnabled = true;
            string myBoolString = isEnabled.ToString();
            Console.WriteLine($"myBoolString = {myBoolString}");
        }
    }
}