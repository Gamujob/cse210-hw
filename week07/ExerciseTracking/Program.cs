using System;

internal class Program
{
  private static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>
    {
      new Running(DateTime.Now, 30, 3.0),
      new Cycling(DateTime.Now, 45, 12.0),
      new Swimming(DateTime.Now, 40, 20)
    };

    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.GetSummary());
    }
  }
}