using System;
using System.Collections.Generic;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        _amountCompleted++;
        int totalPoints = _points;
        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Goal {_shortName} completed! Bonus {_bonus} points awarded!");
        }
        score += totalPoints;
        Console.WriteLine($"Recorded {_shortName}! Gained {totalPoints} points.");
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => base.GetDetailsString() + $" (Completed {_amountCompleted}/{_target} times)";
    public override string GetStringRepresentation() => base.GetStringRepresentation() + $",{_amountCompleted},{_target},{_bonus}";
}