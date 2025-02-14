using System;
using System.Collections.Generic;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(ref int score);
    public abstract bool IsComplete();
    public virtual string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description}";
    public virtual string GetStringRepresentation() => $"{GetType().Name},{_shortName},{_description},{_points}";
}