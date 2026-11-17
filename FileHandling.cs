// File.WriteAllText(path, contents) writes the file and returns void,
// so it cannot be assigned to a variable. Just call it.
//File.WriteAllText("greeting.txt", "Hello, world!\n");

// File.ReadAllText(path) returns the file contents as a string.
string content = File.ReadAllText("greeting.txt");

Console.Write(content);

// File.AppendAllText(path, contents) appends the contents to the file and returns void,

// File.AppendAllText("greeting.txt", "Hello again!\n");
string newContent = File.ReadAllText("greeting.txt");
//Console.WriteLine(newContent);

//File.ReadAllLines() returns each line as a separate string in an array.

string[] lines = File.ReadAllLines("greeting.txt");

foreach (string line in lines)
{
    Console.WriteLine(line);
}
