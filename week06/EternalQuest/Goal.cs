using System.Drawing;
using System.Runtime.InteropServices.Marshalling;

public abstract class Goal
{
  private string _shotName;
  private string _description;
  private string _points;

  public Goal(string name, string description, string points)
  {
    _shotName = name;
    _description = description;
    _points = points;
  }

  public abstract void RecordEvent();

  public abstract bool IsComplete();

  public string GetDetailsString()
  {
    return _description;
  }

  public abstract string GetStringRepresentation();
}