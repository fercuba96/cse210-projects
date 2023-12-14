class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        return $"{details}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}