// A simple Rock, Paper, Scissors game

Random random = new Random();
int playerScore = 0;
int computerScore = 0;

Console.WriteLine("Rock, Paper, Scissors");
Console.WriteLine("Type rock, paper, or scissors.");
Console.WriteLine("Type quit when you want to stop.");

bool playing = true;

while (playing)
{
    Console.Write("\nYour choice: ");
    string playerChoice = (Console.ReadLine() ?? "").ToLower();

    if (playerChoice == "quit")
    {
        playing = false;
        continue;
    }

    if (playerChoice != "rock" &&
        playerChoice != "paper" &&
        playerChoice != "scissors")
    {
        Console.WriteLine("That is not a valid choice.");
        continue;
    }

    int computerNumber = random.Next(1, 4);
    string computerChoice = "rock";

    if (computerNumber == 2)
    {
        computerChoice = "paper";
    }
    else if (computerNumber == 3)
    {
        computerChoice = "scissors";
    }

    Console.WriteLine($"Computer chose: {computerChoice}");

    if (playerChoice == computerChoice)
    {
        Console.WriteLine("It is a tie!");
    }
    else if ((playerChoice == "rock" && computerChoice == "scissors") ||
             (playerChoice == "paper" && computerChoice == "rock") ||
             (playerChoice == "scissors" && computerChoice == "paper"))
    {
        Console.WriteLine("You win!");
        playerScore++;
    }
    else
    {
        Console.WriteLine("Computer wins!");
        computerScore++;
    }

    Console.WriteLine($"Score: You {playerScore} - Computer {computerScore}");
}

Console.WriteLine("\nThanks for playing!");
Console.WriteLine($"Final score: You {playerScore} - Computer {computerScore}");