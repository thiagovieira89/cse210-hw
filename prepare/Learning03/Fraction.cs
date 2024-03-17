 public class Fraction
   {
       private int _top{get;set;}
       private int _bottom{get;set;}

       
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1 ;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public override string ToString()
    {
        return $"{_top}/{_bottom}";
    }
    public int GetTop()
    {
        return _top;
    }
    public int SetTop(int top)
    {
        _top = top;
        return top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        return _bottom;
    }

    public string GetFractionsString()
    {
        return $"{_top}/ {_bottom}";
    }
    public double GetDecimalValue()
    {
        
        return (double)_top / (double)_bottom;
    }
   }
