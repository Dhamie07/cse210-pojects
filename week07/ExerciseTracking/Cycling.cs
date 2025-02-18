using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    public double SpeedInKph { get; set; }

    public override double GetDistance()
    {
        return (SpeedInKph * DurationInMinutes) / 60; // Distance in km
    }

    public override double GetSpeed()
    {
        return SpeedInKph;
    }

    public override double GetPace()
    {
        return 60 / SpeedInKph; // Pace in minutes per km
    }
}
