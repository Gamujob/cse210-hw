public class ChecklistGoal : Goal
{
  private int _amountCompleted = 0;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus)
      : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
  }

  public override void RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted++;

      if (_amountCompleted == _target)
      {
        Console.WriteLine($"Congragulations! You have earned a {_bonus} bonus.");
      }
    }
  }

  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetDetailsString()
  {
    return $"{ShortName} ({Description}) -- Current Completed: {_amountCompleted}/{_target}";
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal|{ShortName}|{Description}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
  }
  public int GetBonus()
  {
    return _bonus;
  }
}