using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your score: ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        
        }
        else if (grade >= 80)
        {
            letter = "B";
            
        }
         else if (grade >= 70)
        {
            letter = "C";
            
        }
         else if (grade >= 60)
        {
            letter = "D";
            
        }
         else
        {
            letter = "F";
            
        }
        Console.WriteLine($"Your grade score is {letter}");
    if (grade >=70)
    {
        Console.WriteLine("Congratulations! You passed.");
    }
    else
    {
        Console.WriteLine("You will need to study more!");
    }
    } 
}