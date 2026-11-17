//User input and output

Console.Write("What is your name?: ");
string name = Console.ReadLine();

Console.Write("What is your age?: ");
string age = Console.ReadLine();

Console.WriteLine($"Hello {name}, your age is {age} years old.");

//Data types


Console.WriteLine("42" + "1");     // Text concatenation: "421"
Console.WriteLine(42 + 1);         // Math: 43