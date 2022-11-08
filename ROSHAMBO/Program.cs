﻿using System.Net.Http.Headers;
using ROSHAMBO;

RockPlayer theRock = new RockPlayer("The Rock");
RandomPlayer theRando = new RandomPlayer("The Wiffer");
HumanPlayer player1 = new HumanPlayer("Player 1");
bool play = true;


//Start the Game!
Console.WriteLine("Welcome to Rock Paper Scissors!\r\n");
Console.WriteLine("Enter your name::\r\n");
CheckPlayerName(Console.ReadLine()!);


while (play)
{
    try
    {
        Console.WriteLine($"Would you like to play against {theRock.Name} or {theRando.Name} (r/w)?: \r\n");
        string player2 = Console.ReadLine().Trim().ToLower();
        bool isValid = player2 == "r" || player2 == "w";

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


void CheckPlayerName(string name)
{
    if (name != "Player 1")
    {
        player1.Name = name;
    }
}


string PlayGame(string opponent)
{
    Console.WriteLine("Rock, paper, or scissors ? (R / P / S)");
    string userPlay = Console.ReadLine()!.Trim().ToLower();

    bool isValid = userPlay == "r" || userPlay == "p" || userPlay == "s";

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


    if (opponent == "r")
    {
        player1.Roshambo = player1.GenerateRoshambo();
        theRock.Roshambo = theRock.GenerateRoshambo();
        Console.WriteLine($"{player1.Name.ToUpper()}: {player1.Roshambo.ToString()}");
        Console.WriteLine($"{theRock.Name.ToUpper()}: {theRock.Roshambo.ToString()}");
        var resultsR = CheckOutcome(player1.Roshambo.ToString(), theRock.Roshambo.ToString());
        return resultsR;
    }

    player1.Roshambo = player1.GenerateRoshambo();
    theRando.Roshambo = theRando.GenerateRoshambo();
    Console.WriteLine($"{player1.Name.ToUpper()}: {player1.Roshambo.ToString()}");
    Console.WriteLine($"{theRando.Name.ToUpper()}: {theRando.Roshambo.ToString()}");
    var resultsW = CheckOutcome(player1.Roshambo.ToString(), theRock.Roshambo.ToString());
    return resultsW;
}


string CheckOutcome(string player1, string computerPlayer)
{
    if (player1 == "Rock" && computerPlayer == "Paper")
    {
        return "You Lose! Paper Covers Rock";
    }

    if (player1 == "Rock" && computerPlayer == "Scissors")
    {
        return "You Win! Rock smashes scissors";
    }

    if (player1 == "Paper" && computerPlayer == "Rock")
    {
        return "You Win! Paper Covers Rock";
    }

    if (player1 == "Paper" && computerPlayer == "Scissors")
    {
        return "You Lose! Scissors cuts paper";
    }

    if (player1 == "Scissors" && computerPlayer == "Rock")
    {
        return "You Lose! Rock smashes scissors!";
    }

    if (player1 == "Scissors" && computerPlayer == "Paper")
    {
        return "You Win! Scissors cuts paper";
    }


    return "You Draw!";
}