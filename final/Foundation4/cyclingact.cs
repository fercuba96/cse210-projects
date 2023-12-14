class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        return Speed * (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / Speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({DurationInMinutes} min) - Distance {GetDistance()} miles, Speed {Speed} mph, Pace: {GetPace()} min per mile";
    }
}
