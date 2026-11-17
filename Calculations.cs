//The data type affects how C# performs calculations

int a = 7;
int b = 2;
Console.WriteLine(a / b);        // Output: 3 (integer division truncates)

decimal c = 7m;
decimal d = 2m;
Console.WriteLine(c / d);        // Output: 3.5 (keeps the decimal)

int a = 5;
Console.WriteLine(a++);   // Output: 5 (uses old value, then increments)
Console.WriteLine(a);     // Output: 6 (a was incremented)

int b = 5;
Console.WriteLine(++b);   // Output: 6 (increments first, then uses new value)
Console.WriteLine(b);     // Output: 6