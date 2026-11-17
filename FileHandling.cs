 string greet = File.WriteAllText("greeting.txt", "Hello, world!\n");

string content = File.ReadAllText("greeting.txt");

Console.WriteLine(content);