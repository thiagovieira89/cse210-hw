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
        test.GetRandomQuestion();
        test.GetRandomQuestion();
        Console.WriteLine("How many time do you want to spend in this activity (in seconds)?  ");
        string answer = Console.ReadLine();
        int duration = int.Parse(answer);
        Console.WriteLine("Considering the following prompt:  ");
        test.DisplayPrompt();
        Console.WriteLine("Think about and after press ENTER to continue.");
        Console.Write("You will star in...");
        test.ShowCountDown(5);


        DateTime starTime = DateTime.Now;
        DateTime futureTime = starTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < futureTime)
        {
            test.DisplayQuestion(); test.ShowSpinner();
            currentTime = DateTime.Now;
            count++;
        }
    }
    List<string> prompt = new List<string>();

    List<string> questions = new List<string>();

    public string GetRandomQuestion()
    {
        prompt.Add("Think of a time when you stood up for someone else.");
        prompt.Add("Think of a time when you did something really difficult.");
        prompt.Add("Think of a time when you helped someone in need.");
        prompt.Add("Think of a time when you did something truly selfless.");
        Random random = new Random();
        int choice = random.Next(questions.Count);
        string randomChoice = questions[choice];

        return randomChoice;
    }
    public string GetRandomPrompt()
    {
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");
        Random random = new Random();
        int phrase = random.Next(prompt.Count);
        string randomChoice = prompt[phrase];

        return randomChoice;
    }
    public void DisplayPrompt()
    {
        ReflectingActivity showRandomPrompt = new ReflectingActivity("", "", 0, prompt, questions);
        showRandomPrompt.GetRandomPrompt();
    }
    public void DisplayQuestion()
    {
        ReflectingActivity showRandomQuestion = new ReflectingActivity("", "", 0, prompt, questions);
        showRandomQuestion.GetRandomQuestion(); Thread.Sleep(8000);

    }
}