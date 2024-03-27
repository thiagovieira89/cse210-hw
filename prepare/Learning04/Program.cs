using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment text = new Assignment("Samuel", "Multiplication");
        Console.WriteLine(text.GetSummary());

        MathAssignment test = new MathAssignment("Section 7.3", "Problems 8-19", "Thiago Vieira","Fraction");
        Console.WriteLine(test.GetSummary());
        Console.WriteLine(test.GetHomeWorkList());

        WrittingAssignmente title = new WrittingAssignmente("Thiago Vieira","European History","The Worl war!");
        Console.WriteLine(title.GetSummary());
        Console.WriteLine(title.GetWrittingInfo());

    }
}