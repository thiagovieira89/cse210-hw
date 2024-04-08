using System;

public class EternalGoals : Goal
{
    public EternalGoals(string name, string description, string points) : base(name, description, points)
    {

    }

     public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        string retorno = "[ ]";
        if(IsCompleted()){
            retorno = "[ X ]";
        }
        return $"{retorno} - {GetName()} ({GetDescription()})";
    }
     public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
    }
}