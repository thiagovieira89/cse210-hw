using System.ComponentModel.Design.Serialization;

public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListeningActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
    public void Run()
    {
        ListeningActivity test = new ListeningActivity("", "", 0);
        Console.Write("How many time do you want to spend in this activity (in seconds)?  ");
        string time = Console.ReadLine();
        int duration = int.Parse(time);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.Write("Get ready...");
        ShowSpinner();
        Console.WriteLine("You will begin in...  ");
        ShowCountDown(5);
        int count = 0;
        List<string> user = new List<string>();
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write(">");
            string userPhrase = Console.ReadLine();
            user.Add(userPhrase);
            count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {count} items.");
    }
    public void GetRandomPrompt()
    {
        if (prompts.Count > 0)
        {
            Random random = new Random();
            int phrase = random.Next(prompts.Count);
            string randomChoice = prompts[phrase];
            Console.WriteLine($"{randomChoice}");
        }
        else
        {
            Console.WriteLine("No prompts available.");
        }

    }
    private static List<string> prompts = new List<string>();
    public void GetListFromUser()
    {

        prompts.Add("---Who are people that you appreciate?---");
        prompts.Add("---What are personal strengths of yours?---");
        prompts.Add("---Who are people that you have helped this week?---");
        prompts.Add("---When have you felt the Holy Ghost this month?---");
        prompts.Add("---Who are some of your personal heroes?---");

    }
}

