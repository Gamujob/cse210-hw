public class PromptGenerator
{
  public List<string> _prompts;
  public Random random = new Random();

  public string GetRandomPrompt()
  {
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
}