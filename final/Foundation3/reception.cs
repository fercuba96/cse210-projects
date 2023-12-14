class Reception : Event
{
    public string RsvpEmail { get; set; }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        return $"{details}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}