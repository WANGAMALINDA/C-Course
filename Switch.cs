//The switch statement chooses one section of code to execute from a list of possible switch sections. The selected switch section is chosen based on a pattern match with the statement's match expression.
string fruit = "apple";

switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
//Example 2

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
//The switch statement can also be used with pattern matching. In this example, the switch statement is used to determine the type of the object and execute the corresponding code block.
object obj = 42;

switch (obj)
{
    case int i when i > 0:
        Console.WriteLine($"Object is a positive integer: {i}");
        break;

    case string s when s.Length > 0:
        Console.WriteLine($"Object is a non-empty string: {s}");
        break;

    case null:
        Console.WriteLine("Object is null.");
        break;

    default:
        Console.WriteLine("Object is of an unknown type.");
        break;
}

//Switch test

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Collections;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");