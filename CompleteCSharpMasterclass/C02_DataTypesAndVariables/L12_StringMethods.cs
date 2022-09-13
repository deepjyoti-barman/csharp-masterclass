using System;

namespace C02_DataTypesAndVariables
{
    public class L12_StringMethods
    {
        public static void Main(string[] args)
        {
            // string is an object of the System.String class
            // In programming string means sequence of characters
            string firstName = "Dennis";
            string lastName = "Panjuta";
            string fullName = string.Concat("", firstName, " ", lastName, "");
            
            Console.WriteLine(firstName.Substring(2));
            Console.WriteLine(firstName.Substring(2, 3));
            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('e'));
            Console.WriteLine(String.IsNullOrWhiteSpace(fullName));
            
            // String.Format() is used to insert the object or variable value inside any string
            // With the String.Format() we can replace the value in the specified format
            // Syntax: String.Format("any string {index}", object);
            var name = "Dennis";
            string sentence = String.Format("My name is {0}", name);
            Console.WriteLine(sentence);
        }
    }
}

/*
NOTE:
- SubString(startIndex, length): Used to get the substring from the string, starting from the specified index
- ToLower(): Used to convert the string to lowercase
- ToUpper(): Used to convert the string to uppercase
- Trim(): Used to trim all leading and trailing white space from the string
- IndexOf(String): Used to get the first occurrence of the string or character inside the string
- IsNullOrEmpty(): Returns true if the string is either null or empty else returns false
- IsNullOrWhiteSpace(): Returns true if the string is either null or is blank else returns false 
*/