class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({DurationInMinutes} min) - Distance {Distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}