using System;
using System.IO;
using System.Collections.Generic;

internal class Program
{
  private static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines("scripture.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                scriptures.Add(new Scripture(reference, text));
            }
            else
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                scriptures.Add(new Scripture(reference, text));
            }

        }
        // PICK THE RANDOM SCRIPTURE
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Scripture scripture = new Scripture(reference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            // hide 3 words each time
            scripture.HideRandomWords(3); 
        }
    }
}