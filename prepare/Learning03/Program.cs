using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction object1 = new Fraction(1,1);
        Console.WriteLine(object1.GetFractionsString());
        Console.WriteLine(object1.GetDecimalValue());

        Fraction object2 = new Fraction(5);
        Console.WriteLine(object2.GetFractionsString());
        Console.WriteLine(object2.GetDecimalValue());

        Fraction object3 = new Fraction(3,4);
        Console.WriteLine(object3.GetFractionsString());
        Console.WriteLine(object3.GetDecimalValue());

        Fraction object4 = new Fraction(1,3);
        Console.WriteLine(object4.GetFractionsString());
        Console.WriteLine(object4.GetDecimalValue());
    }

}

