using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (percent > 92 || percent < 60)
        {
            sign = "";
        }

        Console.WriteLine($"You have got {letter}{sign}");
        if (percent >= 70)
        {
            Console.WriteLine("Congragulations! You have passed the course.");
        }
        else if (percent < 70)
        {
            Console.WriteLine("Sorry You have to try again next term.");
        }
    }
}