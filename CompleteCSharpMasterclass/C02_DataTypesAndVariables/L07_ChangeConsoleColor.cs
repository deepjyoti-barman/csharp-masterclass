using System;

namespace C02_DataTypesAndVariables
{
    internal class L07_ChangeConsoleColor
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Yellow;
            // Console.Clear();         // Clears the console buffer and corresponding console window of display information.
            Console.WriteLine("Wish you a very happy Monday");
        }
    }
}