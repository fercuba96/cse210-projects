using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running
        {
            Date = new DateTime(2022, 11, 3),
            DurationInMinutes = 30,
            Distance = 3.0
        };
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling
        {
            Date = new DateTime(2022, 11, 3),
            DurationInMinutes = 30,
            Speed = 20.0
        };
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming
        {
            Date = new DateTime(2022, 11, 3),
            DurationInMinutes = 30,
            Laps = 20
        };
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}