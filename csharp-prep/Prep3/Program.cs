using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        int guess_number = -1;

        while (magic_number != guess_number)
        {
            Console.Write("What is you guess number? ");
            guess_number =int.Parse(Console.ReadLine());
            
            if (magic_number == guess_number)
            {
                Console.WriteLine("Congratulations!");
            }
            else if (guess_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_number > magic_number)
            {
                Console.WriteLine("Lower");
            }
        }

    }
}