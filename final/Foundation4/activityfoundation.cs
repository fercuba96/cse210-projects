class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} - Unknown Activity ({DurationInMinutes} min)";
    }
}