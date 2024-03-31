public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration):base(name,description,duration)
    {

    }
    public void Run()
    {
        
        
        BreathingActivity time = new BreathingActivity("","",1);
        Console.WriteLine("How many time do you spent in this activity in seconds? ");
        string duration = Console.ReadLine();
        int duration1 = int.Parse(duration);
        Console.Write("Lets start...  ");time.ShowCountDown(duration1);
        
        int count = duration1;
        while(count >= 0){
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("breathe in...  ");time.ShowCountDown(count);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Now breathe out...  ");time.ShowCountDown(count);
            count -=20;
        }
        Console.WriteLine("");
        Thread.Sleep(3000);
        ShowSpinner();
        Console.WriteLine("");
        Console.WriteLine("");       
    }
}