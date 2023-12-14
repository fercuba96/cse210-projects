class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string Address { get; set; }

    public string GetStandardDetails()
    {
        return $"{Title}\n{Description}\nDate: {Date} Time: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {Title}, {Date}";
    }
}