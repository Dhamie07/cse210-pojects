using System;
using System.Collections.Generic;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}
    
    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"Recorded {_shortName}! Gained {_points} points.");
    }

    public override bool IsComplete() => false;
}
