class Swimming : Activity
{
    private const double LapLengthMeters = 50;

    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * LapLengthMeters / 1000.0; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({DurationInMinutes} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}