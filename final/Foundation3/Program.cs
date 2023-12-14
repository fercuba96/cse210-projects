using System;

class Program
{
    static void Main(string[] args)
    {
       Lecture lectureEvent = new Lecture
        {
            Title = "C# Workshop",
            Description = "Learn C# programming",
            Date = "2023-03-25",
            Time = "15:00",
            Address = "123 Main St",
            Speaker = "Jane Doe",
            Capacity = 30
        };

        Reception receptionEvent = new Reception
        {
            Title = "Networking Mixer",
            Description = "Network with professionals",
            Date = "2023-04-10",
            Time = "18:30",
            Address = "456 Oak St",
            RsvpEmail = "rsvp@example.com"
        };

        OutdoorGathering outdoorEvent = new OutdoorGathering
        {
            Title = "Summer Picnic",
            Description = "Enjoy outdoor activities",
            Date = "2023-07-01",
            Time = "12:00",
            Address = "789 Pine St",
            WeatherStatement = "Sunny"
        };

        // Generate messages
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
