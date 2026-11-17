//Use conversion to convert a string to an integer

//Convert.ToInt32()	int	Convert.ToInt32("42")	42
//Convert.ToDecimal()	decimal	Convert.ToDecimal("19.99")	19.99m
//Convert.ToDouble()	double	Convert.ToDouble("3.14")	3.14
//Convert.ToString()	string	Convert.ToString(42)	"42"

Console.Write("Enter your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);
int nextYear = age + 1;
Console.WriteLine($"Next year you'll be {nextYear}");

//To convert between numeric types (like decimal to int), use a cast by placing the target type in parentheses
decimal gpa = 3.75m;
int gpaInt = (int)gpa;  // Converts 3.75m to 3
Console.WriteLine($"Your GPA as an integer is {gpaInt}");