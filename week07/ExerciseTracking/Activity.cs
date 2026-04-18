public abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public Activity(DateTime date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public string GetDate()
  {
    return _date.ToString("dd MMM yyyy");
  }
  public int GetMins()
  {
    return _minutes;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetLapNo();

  // Summary method (shared)
  public virtual string GetSummary()
  {
    return $"{GetDate()} {GetType().Name} ({_minutes} min)- " +
    $"Distance {GetDistance():0.0} miles, " +
    $"Speed {GetSpeed():0.0} mph, " +
    $"Pace: {GetLapNo():0.0} min per mile";
  }
}
