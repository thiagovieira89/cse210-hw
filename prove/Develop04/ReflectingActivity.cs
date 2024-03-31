using System.Collections.Specialized;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }
    public void Run()
    {
        ReflectingActivity test = new ReflectingActivity("", "", 0, prompt, questions);
        Console.Write("Get ready");
        test.ShowSpinner();
        Console.WriteLine("");
        
        Console.WriteLine("How many time do you want to intend to do this activity (in seconds)?  ");
        string answer = Console.ReadLine();
        int duration = int.Parse(answer);
        
        Console.WriteLine("Considering the following prompt:  \n");
        test.DisplayPrompt();
        Console.WriteLine("Think about and after press ENTER to continue.\n");
        Console.Write("You will star in...");
        test.ShowCountDown(5);
        Console.WriteLine("");
        

        DateTime starTime = DateTime.Now;
        DateTime futureTime = starTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        int count = 0;

        while (currentTime < futureTime)
        {
            test.DisplayQuestion();test.ShowSpinner();
            Thread.Sleep(8000);
            currentTime = DateTime.Now;
            count++;
        }
        Console.WriteLine($"You finished this activity in {duration} seconds");
    }
    List<string> prompt = new List<string>();

    List<string> questions = new List<string>();

    public string GetRandomQuestion()
    {
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");

        Random random  = new Random();
        int choice = random.Next(questions.Count);
        string randomChoice = questions[choice];

        return randomChoice;
    }
    
    public string GetRandomPrompt()
    {
        prompt.Add("Think of a time when you stood up for someone else.");
        prompt.Add("Think of a time when you did something really difficult.");
        prompt.Add("Think of a time when you helped someone in need.");
        prompt.Add("Think of a time when you did something truly selfless.");
        
        Random random = new Random();
        
        int phrase = random.Next(prompt.Count);
        string randomChoice = prompt[phrase];

        return randomChoice;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}