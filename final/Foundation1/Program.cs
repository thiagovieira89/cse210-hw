using System;
using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> movie1 = new List<Video>()
        {
            new Video("Inception", "Christopher Nolan", 8880), 
            
        };

        List<Comment> comment1 = new List<Comment>()
        {
            new Comment ("john",["Mind-bending masterpiece!"]),
            new Comment ("Luke", ["Fantastic visuals and concept."]),
            new Comment("Peter",["Brilliantly directed and executed."]),
            new Comment("Mark",["One of Nolan's finest works."]),
            new Comment("Oliver",["Iconic soundtrack that adds to the experience."])
                
        };

        foreach(Video movie in movie1)
        {
            Console.WriteLine($"Movie:{movie._title}. Author: {movie._author}. The duration in seconds: {movie._length}");
        }
        int total2 = 0;
        foreach(Comment userOpnion in comment1)
        {
            userOpnion.DisplayComments();
            total2++;
        }
        Console.WriteLine($"This movie has {total2} comments!");

        Console.WriteLine("------------------------------------------------");
        List<Video> movie2 = new List<Video>()
        {
            new Video("The Shawshank Redemption", "Frank Darabont", 9120), 
            
        };

        List<Comment> comment2 = new List<Comment>()
        {
            new Comment ("Mary",["Tim Robbins and Morgan Freeman shine!"]),
            new Comment ("Lisa", ["The friendship depicted is heartwarming."]),
            new Comment("Oaks",["A story of resilience and redemption."]),     
        };

        foreach(Video movie in movie2)
        {
            Console.WriteLine($"Movie:{movie._title}. Author: {movie._author}. The duration in seconds: {movie._length}");
        }
        int total1 = 0;
        foreach(Comment userOpnion in comment2)
        {
            userOpnion.DisplayComments();
            total1++;
        }
        Console.WriteLine($"This movie has {total1} comments!");

        Console.WriteLine("------------------------------------------------");
        List<Video> movie3 = new List<Video>()
        {
            new Video("The Godfather", "Francis Ford Coppola", 10500), 
            
        };

        List<Comment> comment3 = new List<Comment>()
        {
            new Comment ("Mary",["Flawlessly executed from beginning to end."]),
            new Comment ("Lisa", ["A cinematic masterpiece."]),
            new Comment("Bednar",["Marlon Brando's performance is legendary."]),  
            new Comment("John",["An epic crime saga."]),     
            new Comment("Nelson",["Captivating storytelling."]),     
            new Comment("Bruce",["A gripping portrayal of the mafia underworld."]),     
            new Comment("Millet",[ "A timeless classic that never gets old."]),     
   
        };

        foreach(Video movie in movie3)
        {
            Console.WriteLine($"Movie:{movie._title}. Author: {movie._author}. The duration in seconds: {movie._length}");
        }
        int total = 0;
        foreach(Comment userOpnion in comment3)
        {
            userOpnion.DisplayComments();
            total++;
        }
        Console.WriteLine($"This movie has {total} comments!");

    }
}

