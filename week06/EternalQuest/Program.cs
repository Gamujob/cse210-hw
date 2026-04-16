using System;

internal class Program
{
  private static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            
        }
    }
}