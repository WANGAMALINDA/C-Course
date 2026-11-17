Console.WriteLine("Hello");        // string literal - uses double quotes
Console.WriteLine('H');            // char literal - uses single quote for ONE character
Console.WriteLine(42);             // int literal - just a number
Console.WriteLine(3.14);           // decimal literal - needs the decimal point
Console.WriteLine(true);           // bool literal - true or false

//example of variable declaration and initialization
string myName = "John";           // string variable
int myAge = 30;                   // int variable
char myInitial = 'J';             // char variable
bool isStudent = true;            // bool variable
decimal myGPA = 3.75m;            // decimal variable (note the 'm' suffix for decimal literals)

Console.WriteLine(myName);
Console.WriteLine(myAge);
Console.WriteLine(myInitial);
Console.WriteLine(isStudent);
Console.WriteLine(myGPA);

var name = "Alice";           // C# sees a string, so name is string
var age = 25;                 // C# sees a whole number, so age is int
var price = 19.99;            // C# sees a decimal, so price is double