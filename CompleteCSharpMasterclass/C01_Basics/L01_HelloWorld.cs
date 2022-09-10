using System;

namespace C01_Basics
{
    internal class L01_HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//.NET Framework 6.0 / C# 9.0 or above equivalent code
// Using top-level statements
// Console.WriteLine("Hello World!");

/*
NOTE:
- System is a namespace. A namespace has a bunch classes.
- Main() method is the entry point of any C# program.
- static keyword is used because we are not creating any object to run the Main() method.
- void keyword is used to indicate that Main() method is not returning values. 
*/
