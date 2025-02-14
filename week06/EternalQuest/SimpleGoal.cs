using System;
using System.Collections.Generic;

class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
            Console.WriteLine($"Completed {_shortName}! Gained {_points} points.");
        }
    }

    public override bool IsComplete() => _isComplete;
    public override string GetStringRepresentation() => base.GetStringRepresentation() + $",{_isComplete}";
}