
public class ReflectingActivity:Activity
{
  private List<string> _prompts;
  private List<string> _questions;
  public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions):base(name, description, duration)
  {
    _prompts = prompts;
    _questions = questions;
  }
  public void Run()
  {
    DisplayStartingMessage();

    string input = Console.ReadLine();
    _duration = int.Parse(input);

    Console.Clear();
    Console.WriteLine("\nGet ready...");
    ShowSpinner(5);

    Console.WriteLine();
    Console.WriteLine("Consider the following prompt: ");
    Console.WriteLine($"\n-----{GetRandomPrompt()}-----");
    Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");
    Console.ReadLine();
    Console.WriteLine("Now Ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    
    Console.Clear();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      Console.Write(GetRandomQuestion());

      ShowSpinner(8);
      Console.WriteLine();
    }

    DisplayEndingMessage();
  }
  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
  public string GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(_questions.Count);
    return _questions[index];
  }
  public void DisplayPrompt()
  {
    Console.WriteLine(GetRandomPrompt());
  }
  public void DisplayQuestions()
  {
    Console.WriteLine(GetRandomQuestion());
  }
}