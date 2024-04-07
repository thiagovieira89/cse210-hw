using System;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, string points, bool completed) : base(name, description, points)
    {
        _isCompleted = completed;
    }
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public void SetIscompleted(bool completed)
    {
        _isCompleted = completed;
    }
   
    public override void RecordEvent()
    {
        _isCompleted = true;
    }
    public override bool IsCompleted()
    {   
        return _isCompleted;
    }
    public override string GetDetailsString()
    {
        return $"[ ] - {GetName()} ({GetDescription()})";
    }
     public override string GetStringRepresentation()
    {
        return $"[ ] - {GetName()} ({GetDescription()}) {IsCompleted()}";
    }

}