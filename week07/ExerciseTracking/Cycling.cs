class Cycling : Activity
{
  private double _speed;

  public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    double dist = _speed * GetMins() / 60;
    return dist;
  }

  public override double GetSpeed()
  {
    return _speed;
  }

  public override double GetLapNo()
  {
    return 60 / _speed;
  }
}