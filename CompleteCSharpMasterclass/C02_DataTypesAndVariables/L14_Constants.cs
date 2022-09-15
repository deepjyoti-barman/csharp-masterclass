using System;

namespace C02_DataTypesAndVariables
{
    public class L14_Constants
    {
        // Constants as fields
        const double PI = 3.14159265359;
        const int WEEKS = 52, MONTHS = 12;
        const string BIRTHDAY = "04-12-1992";
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be '{BIRTHDAY}'");
        }
    }
}

/*
NOTE:
- C# Cheatsheet (concise): https://cheatography.com/laurence/cheat-sheets/c/
- C# Cheatsheet (large): https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf
*/ 