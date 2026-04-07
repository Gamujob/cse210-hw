public class Assignment
{
  private string _studentName;
  private string _topic;
  public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

  // PROVIDE THE GETTERS FOR OUR PRIVATE VARIABLES TO BE ACCESSED LATER
  // BOTH OUTSIDE THE CLASS AS WELL IS IN DERIVED CLASSES
  public string GetStudentName()
  {
    return _studentName;
  }
  public string GetTopic()
  {
    return _topic;
  }
  public string GetSummary()
  {
    return _studentName + " - " + _topic;
  }
}