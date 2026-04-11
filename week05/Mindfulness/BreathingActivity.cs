public class BreathingActivity:Activity
{
  public BreathingActivity(string name, string description, int duration):base(name, description, duration)
  {
    
  }
  public void Run()
  {
    DisplayStartingMessage();

    string input = Console.ReadLine();
    _duration = int.Parse(input);

    Console.Clear();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    Console.WriteLine("\nGet ready...");
    ShowSpinner(5);

    while (DateTime.Now < endTime)
    {
      Console.WriteLine();
      Console.Write("\nBreath in...");
      ShowCountDown(4);

      Console.Write("\nNow breath out...");
      ShowCountDown(4);

    }

    DisplayEndingMessage();
  }
}