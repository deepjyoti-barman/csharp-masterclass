using System;

namespace C02_DataTypesAndVariables
{
    public class L11_StringManipulation
    {
        public static void Main(string[] args)
        {
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";
            string company = "Microsoft";
            
            // 1. String concatenation
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
            
            // 2. String formatting
            // String formatting uses index
            Console.WriteLine("\nHello my name is {0}, I am {1} years old, I'm a {2}", name, age, job);
            
            // 3. String interpolation
            // String interpolation uses $ at the start which will allows us to write our variables like {variableName}
            Console.WriteLine($"\nHello my name is {name}, I am {age} years old\n");
            
            // 4. Verbatim strings
            // Verbatim strings start with @ and tells the compiler to take the string literally and ignore any spaces and escape characters like \n
            Console.WriteLine($@"Hello everyone I am {name},
    I work in {company} and
        I am {age} years old");
            
            // Instead of using \\ to write file paths we can use verbatim strings to make it easier
            // NOTE: If you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");
            
            // With verbatim strings even valid escape characters won't work
            Console.WriteLine(@"WOW!\n we got no power here");
        }
    }
}