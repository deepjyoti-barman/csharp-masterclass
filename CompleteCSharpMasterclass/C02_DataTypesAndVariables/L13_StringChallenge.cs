using System;

namespace C02_DataTypesAndVariables
{
    public class L13_StringChallenge
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string input = Console.ReadLine();
            
            Console.WriteLine("Enter a character to search:");
            char searchInput = Console.ReadLine()[0];
            
            // IndexOf(): Returns the index of the character from the string if it exists else returns -1
            int searchIndex = input.IndexOf(searchInput);

            Console.WriteLine($"Index of character '{searchInput}' in string is {searchIndex}");
        }
    }
}