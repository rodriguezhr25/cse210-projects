public class Swimming : Activity
{
    private int _laps;
    private const float lapLength = 50; // meters

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return ((float)_laps * lapLength) / 1000.0f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / (float)GetLength()) * 60.0f;
    }

    public override float GetPace()
    {
        return 60.0f / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToLongDateString()} Swimming ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kmh ,Pace: {GetPace()} min per km - Number of Laps {_laps}";
    }
}
