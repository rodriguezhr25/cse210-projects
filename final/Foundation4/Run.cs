public class Running : Activity
{
    private float _distance;
    
    public Running(DateTime date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
     public override float GetSpeed()
    {
        float speed = (_distance/(float)GetLength()) * 60.0f;
        return speed;
    }
     public override float GetPace()
    {
        return 60.0f/GetSpeed();
    }
     public override string GetSummary()
    {
        return $"{GetDate().ToLongDateString()} Running ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kmh , Pace: {GetPace()} min per km";
    }
}