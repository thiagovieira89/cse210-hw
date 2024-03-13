using System;
using System.Formats.Asn1;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        int prompt = 0;
        List<Questions> daily = new List<Questions>();

        while (prompt != 5)
        {
            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");
            Console.Write("What do you like to do? ");
            prompt = int.Parse(Console.ReadLine());
            if (prompt == 1)
            {
                List<string> questions = new List<string>
                {
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?"
                };
                Random random = new Random();

                int randomIndex = random.Next(questions.Count);

                string question = questions[randomIndex];

                Console.WriteLine(questions[randomIndex]);
                string answer = Console.ReadLine();
                //Console.WriteLine(journal);

                Questions journal = new Questions
                {
                    _question = question,
                    _answer = answer
                };

                daily.Add(journal);
            }
            else if (prompt == 2)
            {   
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine("Displaying journal entries:");
                foreach (Questions entry in daily)
                {
                    
                    Console.WriteLine($"{dateText} Prompt: {entry._question}");
                    Console.WriteLine(entry._answer);
                    Console.WriteLine("");
                }
            }
            
            else if (prompt == 3)
            {
                List<Questions> newDaily = ReadFromFile();
                
                if (newDaily.Count > 0)
                {
                    
                    Console.WriteLine(" Displaying the journal load... ");
                    Console.WriteLine();
                    
                    foreach (Questions d in newDaily)
                    {
                    Console.WriteLine($"{theCurrentTime.ToShortDateString()} Prompt: {d._question}");
                    Console.WriteLine(d._answer);
                    Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("No data loaded.");
                }
                
            }
            else if (prompt == 4)
            {
                SaveToFile(daily);
            }

            static List<Questions> ReadFromFile()
    {
        Console.WriteLine("Type filename: ");
        string filename = Console.ReadLine();

        List<Questions> daily = new List<Questions>();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                
                string[] parts = line.Split(';'); 

                if (parts.Length == 2)
                {
                    Questions entry = new Questions
                    {
                        _question = parts[0],
                        _answer = parts[1]
                    };

                    daily.Add(entry);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No data loaded.");
        }

        return daily;
    }

           
            static void SaveToFile(List<Questions> daily)
            
                {
                    Console.WriteLine("Type filename: ");
                    string filename = Console.ReadLine();

                    using (StreamWriter outputFilename = new StreamWriter(filename))
                    {
                        foreach(Questions d in daily)
                        {
                            outputFilename.WriteLine($"{d._question};{d._answer}");
                        }
                    }

                }

        }
    }
}

