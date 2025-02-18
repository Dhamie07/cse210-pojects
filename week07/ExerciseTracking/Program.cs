using System;

class Program
{
    static void Main(string[] args)
    {
       var activities = new List<Activity>
        {
            new Running { Date = new DateTime(2022, 11, 3), DurationInMinutes = 30, DistanceInKm = 5.0 },
            new Cycling { Date = new DateTime(2022, 11, 3), DurationInMinutes = 45, SpeedInKph = 25.0 },
            new Swimming { Date = new DateTime(2022, 11, 3), DurationInMinutes = 30, Laps = 40 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}