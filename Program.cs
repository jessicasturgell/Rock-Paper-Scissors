Main();

void Main()
{
    int playerScore = 0;
    int opponentScore = 0;
    
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerScore} | Computer: {opponentScore} |");
    Console.WriteLine("---------------------------");
    PlayerThrow();
    Console.WriteLine("VS");
    OpponentThrow();

}

void OpponentThrow()
{
    List<string> throws = new List<string>
    {
        "1",
        "2",
        "3"
    };
    
    Random r = new Random();
    int genRand = r.Next(throws.Count);
    string throwResult = throws[genRand];
    if (throwResult == "1")
    {
        Rock();
    };
    if (throwResult == "2")
    {
        Paper();
    };
    if (throwResult == "3")
    {
        Scissors();
    };
}

void PlayerThrow()
{
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.Write("\nMake a choice: ");
    string answer = Console.ReadLine();
    while (answer != "1" && answer != "2" && answer != "3" )
    {
        Console.WriteLine("\nInvalid input! Choose 1, 2, or 3 and try again.");
        Console.WriteLine("\nWhat would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");
        Console.Write("\nMake a choice: ");
        answer = Console.ReadLine();
    }

    if (answer == "1")
    {
        Rock();
    }
    if (answer == "2")
    {
        Paper();
    }
    if (answer == "3")
    {
        Scissors();
    }
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