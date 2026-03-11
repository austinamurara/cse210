using System;

// This generates the random number once at the start
Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);

int guess = -1;

// The loop continues as long as the guess is wrong
while (guess != magicNumber)
{
    Console.Write("What is your guess? ");
    string response = Console.ReadLine();
    guess = int.Parse(response);

    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
}