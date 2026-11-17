// C# helps you organize code with namespaces, and reuse code from other files and libraries with the using directive.

using System.Text;

StringBuilder builder = new StringBuilder();

builder.Append("Hello, ");
builder.Append("World!");
Console.WriteLine(builder.ToString());

//A namespace groups related classes and methods under a shared name, which helps you avoid naming collisions as your project grows.

namespace MathUtilities
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

