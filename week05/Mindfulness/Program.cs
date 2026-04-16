using System;
using System.Diagnostics;
using System.Xml.Serialization;

internal class Program
{
  private static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the meanu: ");
            string userInput = Console.ReadLine();
            choice  = int.Parse(userInput);
            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.", 0);
                
                Console.Clear();
                activity.Run();
            }

            else if (choice == 2)
            {
                Console.Clear();
                List<string> prompts = new List<string>()
                {
                    "Think of a time when you did something really difficult.",
                    "Think of the time you helped someone in a bad situation.",
                    "Think of a time when you wanted to visit a new place you had never visited before and later you visited."
                };
                List<string> questions = new List<string>()
                {
                  "How did you feel later after it was complete? ",
                  "What is your favorite thing about this experience? ",
                  "Do you feel like going back to the same situation? ",
                  "Do you feel like telling it to someone how the experiece was? "
                };
                ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10, prompts, questions);
                activity.Run();
            }
            else if (choice == 3)
            {
                Console.Clear();
                List<string> prompts = new List<string>()
                {
                    "What things have made you to feel happiness in this week?",
                    "When have you felt the Holy Ghost this month? ",
                    "What things are you grateful with which God has done for you? "
                };
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10, 0, prompts);
                activity.Run();
            }
            Console.Clear();
        }
    }
}