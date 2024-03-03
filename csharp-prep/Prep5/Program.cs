using System;

class Program
{
    static void Main(string[] args)
    {
    void DisplayMessage()
{
    Console.WriteLine("Welcome to the program!");
}
    
    DisplayMessage();
    
    string name = UserName();
    int number = FavoriteNumber();
    int square = SquareNumber(number);

    Console.WriteLine($"Brother {name},the square of your number is {square}");


    static string UserName ()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int FavoriteNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber (int number)
    {
        int dubloSquare = number * number;
        return dubloSquare;
    }
}
}