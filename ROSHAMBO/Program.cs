using ROSHAMBO;

RockPlayer theRock = new RockPlayer("The Rock");
RandomPlayer theRandom = new RandomPlayer("Kevin Hart");
HumanPlayer player1 = new HumanPlayer("");
bool play = true;


//Start the Game!
Console.WriteLine("Welcome to Rock Paper Scissors!\r\n");
Console.WriteLine("Enter your name::\r\n");
CheckPlayerName(Console.ReadLine()!);


while (play)
{
    try
    {
        Console.WriteLine($"Would you like to play against {theRock.Name} or {theRandom.Name} (r/k)?: \r\n");
        string player2 = Console.ReadLine()!.Trim().ToLower();
        bool isValid = player2 is "r" or "k";

        if (isValid)
        {
            string roshambo = PlayGame(player2);
            Console.WriteLine(roshambo);
            play = PlayAgain();
        }
        else
        {
            Console.WriteLine("Your have entered an invalid player to play against!\r\n");
            play = PlayAgain();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Your have entered an invalid player to play against!\r\n");
        play = PlayAgain();
    }
}

Environment.Exit(0);


//Methods

bool PlayAgain()
{
    Console.WriteLine("Play again? (y/n):");
    string userPlayAgain = Console.ReadLine()!.Trim().ToLower();
    if (userPlayAgain == "y")
    {
        return true;
    }

    return false;
}


void CheckPlayerName(string player1Name)
{
    if (player1Name != "")
    {
        player1.Name = player1Name;
    }
    else
    {
        player1.Name = "player 1";
    }

}


string PlayGame(string opponent)
{
    Console.WriteLine("Rock, paper, or scissors ? (R / P / S)");
    string userPlay = Console.ReadLine()!.Trim().ToLower();

    bool isValid = userPlay is "r" or "p" or "s";

    if (isValid)
    {
        switch (userPlay)
        {
            case "r":
                player1.Roshambo = Roshambo.Rock;
                break;
            case "p":
                player1.Roshambo = Roshambo.Paper;
                break;
            default:
                player1.Roshambo = Roshambo.Scissors;
                break;
        }
    }
    else
    {
        return $"You Did Not enter a valid Option {userPlay}";
    }

    if (opponent == "r")
    {
        player1.Roshambo = player1.GenerateRoshambo();
        theRock.Roshambo = theRock.GenerateRoshambo();
        Console.WriteLine($"{player1.Name}: {player1.Roshambo.ToString()}");
        Console.WriteLine($"{theRock.Name}: {theRock.Roshambo.ToString()}");
        var resultsR = CheckOutcome(player1.Roshambo.ToString(), player1.Name, theRock.Roshambo.ToString(), theRock.Name);
        return resultsR;
    }

    player1.Roshambo = player1.GenerateRoshambo();
    theRandom.Roshambo = theRandom.GenerateRoshambo();
    Console.WriteLine($"{player1.Name.ToUpper()}: {player1.Roshambo.ToString()}");
    Console.WriteLine($"{theRandom.Name.ToUpper()}: {theRandom.Roshambo.ToString()}");
    var resultsW = CheckOutcome(player1.Roshambo.ToString(), player1.Name, theRandom.Roshambo.ToString(), theRandom.Name);
    return resultsW;
}


string CheckOutcome(string player1, string player1Name, string computerPlayer, string computerPlayerName)
{
    if (player1 == "Rock" && computerPlayer == "Paper")
    {
        return $"{computerPlayerName} wins!!";
    }

    if (player1 == "Rock" && computerPlayer == "Scissors")
    {
        return $"{player1Name} ins!";
    }
    if (player1 == "Rock" && computerPlayer == "Rock")
    {
        return "Draw!";
    }

    if (player1 == "Paper" && computerPlayer == "Rock")
    {
        return $"{player1Name} wins!";
    }

    if (player1 == "Paper" && computerPlayer == "Scissors")
    {
        return $"{computerPlayerName} wins!";
    }

    if (player1 == "Paper" && computerPlayer == "Paper")
    {
        return "Draw!";
    }

    if (player1 == "Scissors" && computerPlayer == "Rock")
    {
        return $"{computerPlayerName} wins!]";
    }

    if (player1 == "Scissors" && computerPlayer == "Paper")
    {
        return $"{player1Name} wins!";
    }


    return "Draw!";
}