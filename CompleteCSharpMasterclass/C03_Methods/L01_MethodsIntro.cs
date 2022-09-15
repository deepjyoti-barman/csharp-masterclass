using System;

namespace C03_Methods
{
    internal class L01_MethodsIntro
    {
        // Example of a method that takes two arguments and returns an integer value
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
        }
    }
}

/*
NOTE:
- A method is a code block that contains a series of statements. A program causes the statements
to be executed by calling the method and specifying any required method arguments. In C#, every 
executed instruction is performed in the context of a method. The Main method is the entry point 
for every C# application and it is called by the common language runtime (CLR) when the program is started.
- Syntax:
<access_specifier> <return_type> <method_name> (parameter_list)
{
    <method_body>
}
- <access_specifier>: This determines the visibility of a variable or a method from another class.
- <return_type>:  − A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.
- <method_name>: Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.
- <parameter_list>: Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
- <method_body>: This contains the set of instructions needed to complete the required activity.
*/