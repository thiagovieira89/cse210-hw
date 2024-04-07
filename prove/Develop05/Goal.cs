using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
   public string GetPoints()
   {
    return _points;
   }
   public string GetName()
   {
    return _shortName;
   }
   public string GetDescription()
   {
    return _description;
   }
    public abstract void RecordEvent();

    public abstract bool IsCompleted();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}