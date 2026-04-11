public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;
  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }
  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session? ");
    // string input = Console.ReadLine();
    // _duration = int.Parse(input);
    
  }
  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("\nWell done!!");
    ShowSpinner(4);
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
    ShowSpinner(4);
  }
  public void ShowSpinner(int seconds)
  {
    string[] spinner = {"|", "/", "-", "\\"};

    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    int i = 0;
    while (DateTime.Now < endTime)
    {
      Console.Write(spinner[i]);
      Thread.Sleep(200);

      Console.Write("\b \b");

      i = (i + 1)% spinner.Length;
    }
  }
  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}