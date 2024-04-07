using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public string Start()
    {
        string answer = "";
        
        while(answer.ToLower()!= "quit")
        {
            DisplayPlayerInfo();
            List<string> menu = new List<string>();
            
            menu.Add("Menu Options:");
            menu.Add("1- Create a new Goal ");
            menu.Add("2- List Goals");
            menu.Add("3- Save Goals ");
            menu.Add("4- Load Goals");
            menu.Add("5- Record Event");
            menu.Add("6- Quit");
            
            
            foreach(string i in menu)
            {
                Console.WriteLine(i);
            }
            Console.Write("Select a choice from menu: ");
            answer = Console.ReadLine();

            if(answer =="1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1- Simple Goal");
                Console.WriteLine("2- Eternal Goal");
                Console.WriteLine("3- Checklist Goal");
                Console.Write("Which type of goal you want? ");
                string answer2 = "";
                answer2 = Console.ReadLine();

                if (answer2 == "1")
                {

                }
                else if (answer2 =="2")
                {

                }   
                else if (answer2 =="3")
                {

                }             
            }
            else if(answer == "2")
            {

            }
        }
        return answer;
    }
        static void DisplayPlayerInfo()
        {
            List<Goal> goals = new List<Goal>();
            string score = "0";
            foreach (Goal goal in goals)
            {
                if(goal.IsCompleted())
                {
                    score += goal.GetPoints();
                    int totalScore = int.Parse(score);
                    Console.Write($"You Have {totalScore}");
                }
            }
            
        }
}