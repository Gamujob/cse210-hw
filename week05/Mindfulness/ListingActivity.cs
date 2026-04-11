public class ListingActivity:Activity
{
  private int _count;
  private List<string> _prompts;
  public ListingActivity(string name, string description, int duration, int count, List<string> prompts):base(name, description, duration)
  {
    _count = count;
    _prompts = prompts;
  }
  public void Run()
  {
    DisplayStartingMessage();

    string input_duration = Console.ReadLine();
    _duration = int.Parse(input_duration);

    Console.Clear();
    Console.WriteLine("\nGet ready...");
    ShowSpinner(5);

    string prompt = GetRandomPrompt();
    Console.WriteLine();
    Console.WriteLine("List as many responses as you can to the following prompt: ");
    Console.WriteLine($"--- {prompt} ---");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.WriteLine();
    
    List<string> response = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    
    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string input = Console.ReadLine();
      response.Add(input);
    }

    _count = response.Count;
    Console.WriteLine($"You listed {_count} items");

    DisplayEndingMessage();
  }
  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
  public List<string> GetListFromUser()
  {
    List<string> userList = new List<string>();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string input = Console.ReadLine();
      userList.Add(input);
    }

    // _count = userList.Count;
    return userList;
  }
}