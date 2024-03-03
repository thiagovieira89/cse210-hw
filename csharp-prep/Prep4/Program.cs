using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int user = 1;

        while (user != 0)
        {
           Console.Write("Enter Number:");
           user = int.Parse(Console.ReadLine());
           numbers.Add(user);
           
        }
        int sum = 0;
        int largest = 0;
        
        foreach(int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }  
        }
        Console.WriteLine($"The sum is {sum}");
        float average = (float)sum / (numbers.Count - 1);
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}