//A List<T> is a resizable, ordered collection of values that all share the same type. Unlike an array, a list can grow or shrink while your program runs, which makes it a good fit when you don't know the exact number of items ahead of time.

//Using a String List
List<string> colors = new List<string> { "red", "green", "blue" };

Console.WriteLine(colors.Count); // Output: 3
colors.Add("yellow");            // Adds "yellow" to the end
Console.WriteLine(colors.Count); // Output: 4
Console.WriteLine();

colors.Remove("red");            // Removes "red"
colors[0] = "purple";            // Replaces "green" with "purple"

foreach (string color in colors)
{
    Console.WriteLine(color);
}


//Using an Integer List
List<int> scores = new List<int> { 95, 82, 76, 91 };

foreach (int score in scores)
{
    Console.WriteLine(score);
}