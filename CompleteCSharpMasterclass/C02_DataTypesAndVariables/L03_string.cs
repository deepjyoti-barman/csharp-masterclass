using System;

namespace C02_DataTypesAndVariables
{
    public class L03_string
    {
        public static void Main(string[] args)
        {
            string myName = "Dennis";
            string message = "My name is " + myName;
            
            Console.WriteLine(message);

            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            string lcMessage = message.ToLower();
            Console.WriteLine(lcMessage);
        }
    }
}