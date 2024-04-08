using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;
    //private List<Goal> goals = new List<Goal>();

    public string Start()
    {
        string answer = "";
        _score = 0;
        _goals = new List<Goal>();

        List<string> menu =
        [
            "Menu Options:",
            "1- Create a new Goal ",
            "2- List Goals",
            "3- Save Goals ",
            "4- Load Goals",
            "5- Record Event",
            "6- Quit"
        ];

        while (answer.ToLower() != "quit")
        {
            DisplayPlayerInfo();

            foreach (string i in menu)
            {
                Console.WriteLine(i);
            }
            Console.Write("Select a choice from menu: \n");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateGoal();
            }
            else if (answer == "2")
            {
                ListGoalsDetails();
            }
            else if (answer == "3")
            {
                SaveGoals();
            }
            else if (answer == "4")
            {
                LoadGoals();
            }
            else if (answer == "5")
            {
                RecordEvent();
            }
            else if (answer == "6")
            {
                answer = "quit";
            }
        }
        return answer;
    }

    public void DisplayPlayerInfo()
    {
        Console.Write($"You Have {_score} points.\n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1- Simple Goal");
        Console.WriteLine("2- Eternal Goal");
        Console.WriteLine("3- Checklist Goal");
        Console.Write("Which type of goal you want? ");
        string answer2 = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Goal Points: ");
        string points = Console.ReadLine();

        if (answer2 == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (answer2 == "2")
        {
            _goals.Add(new EternalGoals(name, description, points));

        }
        else if (answer2 == "3")
        {
            Console.Write("Target: ");
            string target = Console.ReadLine();
            int target1 = int.Parse(target);
            Console.Write("Bonus: ");
            string bonus = Console.ReadLine();
            int bonus1 = int.Parse(bonus);
            _goals.Add(new CheckListGoal(name, description, points, target1, bonus1));
        }
    }
    
    public void ListGoalsNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
    }

    public void RecordEvent()
    {
        ListGoalsNames();
        Console.Write("Which goal did you accomplish? ");
        string answer2 = Console.ReadLine();
        int resposta = int.Parse(answer2);
        if (resposta <= _goals.Count)
        {
            Goal goal = _goals[resposta - 1];
            goal.RecordEvent();
            _score += int.Parse(goal.GetPoints());
            if(goal is CheckListGoal clg){
                if(clg.IsCompleted()){
                    _score += clg.GetBonus();
                    Console.Write($"You earned {clg.GetBonus()} points.\n");
                }
            }
            Console.Write($"You now have {_score} points.\n");
            _goals[resposta - 1] = goal;
        }
    }

    public void ListGoalsDetails()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goals file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        for (int index = 1; index < lines.Count(); index++)
        {
            string line = lines[index];
            string[] parts = line.Split(": ");

            string type = parts[0];
            string[] attributes = parts[1].Split(", ");

            string name = attributes[0];
            string description = attributes[1];
            string points = attributes[2];

            if (type == "SimpleGoal")
            {
                string complete = attributes[3];
                _goals.Add(new SimpleGoal(name, description, points, Boolean.Parse(complete)));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoals(name, description, points));

            }
            else if (type == "CheckListGoal")
            {
                string bonus = attributes[3];
                int bonus1 = int.Parse(bonus);
                string target = attributes[4];
                int target1 = int.Parse(target);
                string amountCompleted = attributes[5];
                int amountCompleted1 = int.Parse(amountCompleted);
                CheckListGoal clg = new CheckListGoal(name, description, points, target1, bonus1);
                clg.SetAmountCompleted(amountCompleted1);
                _goals.Add(clg);
            }
        }
        
    }
}