using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        Journal myjournal = new Journal();
        
        while (choice != 5)
        {
            
            Console.WriteLine("Please select of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                promptGenerator._prompts = new List<string>
                {
                    "If I had something to do today, what could it be?",
                    "What was the best part of my day?",
                    "What should I plan to do tomorrow?",
                    "What should I practice during the course of my day?",
                    "What is the most important thing I should always do everyday?"
                };

                Console.WriteLine(promptGenerator.GetRandomPrompt());
                Console.Write("> ");
                string input = Console.ReadLine();
                DateTime theCurrentNow = DateTime.Now;
                string dateText = theCurrentNow.ToShortDateString();

                Entry entry = new Entry();
                entry._entryText = input;
                entry._date = dateText;
                entry._promptText = promptGenerator.GetRandomPrompt();

                myjournal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                myjournal.DisplayAll();
            }

            else if (choice == 3)
            {
                // string filename = "myfile.txt";
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string date = parts[0];
                    string prompt = parts[1];
                    string textEntries = parts[2];
                    // Console.WriteLine($"Date: {date} - Prompts: {prompt}");
                    // Console.WriteLine(textEntries);
                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = prompt;
                    entry._entryText = textEntries;
                    
                    myjournal.AddEntry(entry);
                }
            }

            else if (choice == 4)
            {
                // string filename = "myFile.txt";
                Console.Write("What is the file name: ");
                string filename = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(filename))
                {
                    myjournal.SaveToFile(filename);
                    Console.WriteLine($"Saved to {filename}");
                }

                else
                {
                    Console.WriteLine("Invalid file");
                }
            }

            else if (choice == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid Response, please check the options and try again");
            }
            Console.WriteLine("");
        }
    }
}