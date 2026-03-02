using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        do
        {
            int guessNumber = 0;
            int guessCount = 0;

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            while (magicNumber != guessNumber)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guessCount += 1;
            }
            Console.WriteLine($"It took {guessCount} guesses! ");
            Console.WriteLine();
            Console.Write("Would you like to play again? (yes or no): ");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
            
        } while (playAgain == "yes");
        Console.WriteLine("Thank you for playing the game!");
    }
}