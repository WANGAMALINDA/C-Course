//The if statement
int total = 17;

if (total >= 15)
{
    Console.WriteLine("You win!");
}

//The if - else statement
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//The if - else if - else statement
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else if (total >= 10)
{
    Console.WriteLine("You get a consolation prize.");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//Nested if statements
if (total >= 10)
{
    if (total >= 15)
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("You get a consolation prize.");
    }
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//Using && (all conditions must be met)
if (total >= 10 && total <= 20)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//Using || (at least one condition must be met)
if (total < 10 || total > 20)
{
    Console.WriteLine("Sorry, you lose.");
}
else
{
    Console.WriteLine("You win!");
}

//Combining operators
if ((total >= 10 && total <= 20) || total == 25)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}