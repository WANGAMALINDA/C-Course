//A method is a named, reusable block of code that runs when you call it. Methods let you write logic once and use it as many times as you need, with different inputs each time.

void GreetUser()
{
    Console.WriteLine("Hello, User!");
}

GreetUser(); // Calling the method to execute its code

//Methods can also take parameters, which are values you pass into the method to customize its behavior.

void GreetUserWithName(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

GreetUserWithName("Alice");

//You can define multple parameters in a method.
void PrintUserInfo(string name, int age)
{
    Console.WriteLine($"Name: {name}, Age: {age}");
}

PrintUserInfo("Bob", 30);

//You can give a parameter a default value by assigning it with = in the method definition. If the caller doesn't provide that argument, the default is used.

void PrintUserInfoWithDefault(string name, int age = 18)
{
    Console.WriteLine($"Name: {name}, Age: {age}");
}

PrintUserInfoWithDefault("Charlie"); 
PrintUserInfoWithDefault("David", 25);

//You can also pass arguments by name, which makes your code easier to read, especially when a method has several parameters.

void PrintUserInfoNamed(string name, int age)
{
    Console.WriteLine($"Name: {name}, Age: {age}");
}

PrintUserInfoNamed(name: "Eve", age: 22);
PrintUserInfoNamed(age: 25, name: "Frank");

//Methods can return values using the return keyword. The return type of the method is specified before the method name.

int Add(int a, int b)
{
    return a + b;
}

Console.WriteLine($"The sum is: {Add(5, 10)}");

//Returning multiple values with tuples
(double x, double y) GetCoordinates()
{
    return (10.5, 20.3);
}

var (x, y) = GetCoordinates();
Console.WriteLine($"Coordinates: ({x}, {y})");