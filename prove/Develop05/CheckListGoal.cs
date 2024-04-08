using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus ) : base(name, description, points)
    {
        
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
        if(_amountCompleted < _target){
            _amountCompleted ++;
            IsCompleted();
        }
    }

    public override bool IsCompleted()
    {
        if(_amountCompleted >= _target){
            return true;
        }
        return false;
    }
    public override string GetDetailsString()
    {
        string retorno = "[ ]";
        if(IsCompleted()){
            retorno = "[ X ]";
        }
        return $"{retorno} - {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
     public override string GetStringRepresentation()
    {
        return $"CheckListGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {GetBonus()}, {GetTarget()}, {GetAmountCompleted()}";
    }
}