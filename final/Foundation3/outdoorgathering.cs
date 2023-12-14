class OutdoorGathering : Event
{
    public string WeatherStatement { get; set; }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        return $"{details}\nType: Outdoor Gathering\nWeather: {WeatherStatement}";
    }
}