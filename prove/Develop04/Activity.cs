public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {   
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public string GetActivity()
    {
        return $"{_name} {_description} {_duration}";
    }
    
    public void DisplayStartingMessage()
    {
        string text = $"Today we can practicethis.";
        Console.WriteLine(text);
    }
    public void DisplayEndingMessage()
    {
        string text =  "finished the program. Thanks";
        Console.WriteLine(text);
    }
    public void ShowSpinner()
    {
        List<string> stringAnimation = new List<string>();
        stringAnimation.Add("|");
        stringAnimation.Add("/");
        stringAnimation.Add("-");
        stringAnimation.Add("\\");
        stringAnimation.Add("|");
        stringAnimation.Add("/");
        stringAnimation.Add("-");
        stringAnimation.Add("\\");
        
        foreach (string i in stringAnimation)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int second)
    {
        for(second=5; second > 0; second--)
        {
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}