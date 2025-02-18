using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0; // Distance in km (50 meters per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // Pace in minutes per km
    }
}