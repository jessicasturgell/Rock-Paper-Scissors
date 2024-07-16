Main();

void Main()
{
    int playerScore = 0;
    int opponentScore = 0;
    
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerScore} | Computer: {opponentScore} |");
    Console.WriteLine("---------------------------");
    string playerChoice = PlayerThrow();
    Console.WriteLine("VS");
    string opponentChoice = OpponentThrow();
    ScoreCalc(playerChoice, opponentChoice);

}

void ScoreCalc(string playerChoice, string opponentChoice)
{
    if (playerChoice == opponentChoice)
    {
        Console.WriteLine("Tie!");
    };
    
    if (playerChoice == "1" && opponentChoice == "2" || playerChoice == "2" && opponentChoice == "3" || playerChoice == "3" && opponentChoice == "1")
    {
        Console.WriteLine("Opponent wins!");
    };

    if (playerChoice == "2" && opponentChoice == "1" || playerChoice == "3" && opponentChoice == "2" || playerChoice == "1" && opponentChoice == "3")
    {
        Console.WriteLine("Player wins!");
    };
};

string OpponentThrow()
{
    List<string> throws = new List<string>
    {
        "1",
        "2",
        "3"
    };
    
    Random r = new Random();
    int genRand = r.Next(throws.Count);
    string opponentChoice = throws[genRand];
    if (opponentChoice == "1")
    {
        Rock();
    };
    if (opponentChoice == "2")
    {
        Paper();
    };
    if (opponentChoice == "3")
    {
        Scissors();
    };

    return opponentChoice;
}

string PlayerThrow()
{
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.Write("\nMake a choice: ");
    string playerChoice = Console.ReadLine();
    while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3" )
    {
        Console.WriteLine("\nInvalid input! Choose 1, 2, or 3 and try again.");
        Console.WriteLine("\nWhat would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");
        Console.Write("\nMake a choice: ");
        playerChoice = Console.ReadLine();
    }

    if (playerChoice == "1")
    {
        Rock();
    }
    if (playerChoice == "2")
    {
        Paper();
    }
    if (playerChoice == "3")
    {
        Scissors();
    }

    return playerChoice;
}

void Rock()
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
}

void Paper()
{
Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
}

void Scissors()
{
Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
}