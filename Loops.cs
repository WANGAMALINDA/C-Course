//Programs become more useful when they can automate repetitive tasks. Instead of writing the same code over and over, you can use a loop to repeat a block of code automatically.

//The for loop (known number of repetitions)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//The while loop (unknown number of repetitions)
int count = 0;
while (count < 5)
{
    Console.WriteLine(count);
    count++;
}
//A while loop checks its condition before each iteration. If the condition is always true, the loop never stops. This behavior is called an infinite loop, and it freezes your program.

//The do-while loop (unknown number of repetitions)
int attempts = 0;
do
{
    attempts++;
    Console.WriteLine($"Attempt number {attempts}");
}
while (attempts < 3);

//The foreach loop (iterates through a collection)
string[] fruits = { "apple", "banana", "cherry" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

//The break statement can be used to exit a loop early
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break; // Exit the loop when i is 5
    }
    Console.WriteLine(i);
}

//The continue statement can be used to skip the current iteration and move to the next one
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i); // This will only print odd numbers
}