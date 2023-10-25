public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, int length, float speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetDistance()
    {
        float distance = (_speed * GetLength()) / 60.0f;
        return distance;
    }

    public override float GetPace()
    {
        return 60.0f / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToLongDateString()} Cycling ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kmh ,Pace: {GetPace()} min per km";
    }
}
