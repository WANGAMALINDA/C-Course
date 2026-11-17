//Creating an array of integers
int[] numbers = new int[5]; // Declare an array of 5 integers
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//Creating an array of integers
int[] scores = { 95, 82, 76, 91 };

// Creating an array of strings
string[] fruits = { "apple", "banana", "cherry" }; 

//Accessing array elements
Console.WriteLine(numbers[0]); // Output: 1
Console.WriteLine(numbers[1]); // Output: 2
Console.WriteLine(numbers[2]); // Output: 3
Console.WriteLine(numbers[3]); // Output: 4
Console.WriteLine(numbers[4]); // Output: 5
Console.WriteLine();

//Accessing array elements
Console.WriteLine(fruits[0]); // Output: apple
Console.WriteLine(fruits[1]); // Output: banana
Console.WriteLine(fruits[2]); // Output: cherry
Console.WriteLine();

//Iterating through an array using a foreach loop
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine();

foreach (int score in scores)
{
    Console.WriteLine(score);
}

