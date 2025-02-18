using System;
using System.Collections.Generic;

public class Running : Activity
{
    public double DistanceInKm { get; set; }

    public override double GetDistance()
    {
        return DistanceInKm;
    }

    public override double GetSpeed()
    {
        return (DistanceInKm / DurationInMinutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInKm; // Pace in minutes per km
    }
}
