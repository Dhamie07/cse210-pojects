using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Common method to generate summary
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min) - Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0} min per km";
    }
}
