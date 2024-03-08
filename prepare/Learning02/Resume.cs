using System;
public class Resume
{
    public string PersonName ;
    public List<Job> _ListJob = new List<Job>();
    
    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {PersonName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _ListJob)
        {
            job.DisplayJobs();
        }
    }
}