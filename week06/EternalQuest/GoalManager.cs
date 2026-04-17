using System.Diagnostics;
using System.IO;

public class GoalManager
{
  private List<Goal> _goals = new List<Goal>();
  private int _score = 0;

  public GoalManager()
  {

  }

  public void Start()
  {
    // bool running = true;

    int choice = 0;
    while (choice != 6)
    {
      Console.WriteLine($"\nYou have {_score} points");
      Console.WriteLine("\nMenu Options:");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6. Quit");

      Console.Write("Select a choice from the menu: ");
      string inpMenu = Console.ReadLine();
      choice = int.Parse(inpMenu);

      if (choice == 1)
      {
        CreateGoal();
      }
      else if (choice == 2)
      {
        ListGoalDetails();
      }
      else if (choice == 3)
      {
        SaveGoals();
      }
      else if (choice == 4)
      {
        LoadGoals();
      }
      else if (choice == 5)
      {
        RecordEvent();
      }
      else if (choice == 6)
      {
        Console.WriteLine("See you later! BYE.");
      }
      else
      {
        Console.WriteLine("Please enter a valid choice! ");
      }
    }
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score} points ");
  }

  public void ListGoalNames()
  {
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
    }
  }

  public void ListGoalDetails()
  {
    foreach (Goal g in _goals)
    {
      string status = g.IsComplete() ? "[x]" : "[ ]";
      Console.WriteLine($"{status} {g.GetDetailsString()}");
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("\nThe types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string goalChoice = Console.ReadLine();
    int choice = int.Parse(goalChoice);

    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string desc = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal?  ");
    string points = Console.ReadLine();

    if (choice == 1)
    {
      _goals.Add(new SimpleGoal(name, desc, points));
    }
    else if (choice == 2)
    {
      _goals.Add(new EternalGoal(name, desc, points));
    }
    else if (choice == 3)
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? : ");
      int target = int.Parse(Console.ReadLine());

      Console.Write("What is the bonus for completing it that many times? : ");
      int bonus = int.Parse(Console.ReadLine());

      _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
    }
  }

  public void RecordEvent()
  {
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    Console.Write("Select goal: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    Goal goal = _goals[index];
    goal.RecordEvent();

    _score += int.Parse(goal.GetPoints());

    if (goal is ChecklistGoal checklist)
    {
      if (checklist.IsComplete())
      {
        _score += checklist.GetBonus();
      }
    }
  }


  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(filename))
    {
      writer.WriteLine(_score);

      foreach (Goal g in _goals)
      {
        writer.WriteLine(g.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();
    string[] lines = File.ReadAllLines(filename);

    _goals.Clear(); // important

    _score = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
    {
      string[] parts = lines[i].Split("|");

      string type = parts[0];

      if (type == "SimpleGoal")
      {
        string name = parts[1];
        string desc = parts[2];
        string points = parts[3];
        bool isComplete = bool.Parse(parts[4]);

        SimpleGoal goal = new SimpleGoal(name, desc, points);

        if (isComplete)
        {
          goal.RecordEvent(); // restore completion
        }

        _goals.Add(goal);
      }
      else if (type == "EternalGoal")
      {
        string name = parts[1];
        string desc = parts[2];
        string points = parts[3];

        _goals.Add(new EternalGoal(name, desc, points));
      }
      else if (type == "ChecklistGoal")
      {
        string name = parts[1];
        string desc = parts[2];
        string points = parts[3];
        int completed = int.Parse(parts[4]);
        int target = int.Parse(parts[5]);
        int bonus = int.Parse(parts[6]);

        ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);

        // restore progress
        for (int j = 0; j < completed; j++)
        {
          goal.RecordEvent();
        }

        _goals.Add(goal);
      }
    }

    Console.WriteLine("Goals loaded successfully!");
  }
}