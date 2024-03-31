using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Xml.Serialization;

class Program
{
    class Test
    {
        static string ShowTheMenu()
        {
            List<string> prompt = new List<string>();
            prompt.Add("1- Breathing Activity");
            prompt.Add("2- Listenig Activity");
            prompt.Add("3- Reflecting Activity");
            prompt.Add("4- Quit");

            foreach (string i in prompt)
            {
                Console.WriteLine(i);
            }
            string choice = Console.ReadLine();
            return $"{choice}";
        }
        static void Main(string[] args)
        {
            string choice = "";
            while (choice.ToLower() != "quit")
            {
                choice = ShowTheMenu();

                if (choice == "1")
                {
                    BreathingActivity test = new BreathingActivity("", "", 0);
                    test.DisplayStartingMessage();
                    test.Run();
                    test.DisplayEndingMessage();
                    Console.WriteLine($"You completed another seconds of the breathing activity");
                    test.ShowSpinner();
                }

                if (choice == "2")
                {
                    ListeningActivity test = new ListeningActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                    test.SetName("Listening Activity \n");
                    test.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
                    Console.WriteLine("List as many responses you can to the following prompt:");
                    test.GetListFromUser();
                    test.GetRandomPrompt();
                    test.Run();
                    Console.WriteLine("");
                    Console.WriteLine("Well Done.");
                    test.ShowSpinner();

                }

                if (choice == "3")
                {
                    List<string> prompt = new List<string>();
                    prompt.Add("Think of a time when you stood up for someone else.");
                    prompt.Add("Think of a time when you did something really difficult.");
                    prompt.Add("Think of a time when you helped someone in need.");
                    prompt.Add("Think of a time when you did something truly selfless.");


                    List<string> questions = new List<string>();



                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "Reflect on past experiences", 60, prompt, questions);

                    reflectingActivity.GetName();
                    Console.WriteLine("");
                    reflectingActivity.GetDescription();
                    reflectingActivity.Run();
                    Console.WriteLine("");
                    Console.WriteLine("Well done");


                }
            }
        }
    }
}

