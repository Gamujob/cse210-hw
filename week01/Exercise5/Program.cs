using System;

internal class Program
{
  private static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResults(userName, squareNumber);
    }

  private static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

  private static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

  private static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNum = int.Parse(number);
        return userNum;
    }

  private static int SquareNumber(int favoriteNum)
    {
        int squareNum = favoriteNum * favoriteNum;
        return squareNum;
    }

  private static void DisplayResults(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}