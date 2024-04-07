using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int amountCompleted, int target, int bonus ) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target=target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        _amountCompleted ++;
        IsCompleted();


    }

    public override bool IsCompleted()
    {
      return IsCompleted();
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