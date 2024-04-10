using System.Numerics;

public class Comment
{
    public string _name{get;set;}
    public List<string> _comment{get;set;}

    public Comment (string name, List<string> coment)
    {
        _name = name;
        _comment = coment;
    }
     public void DisplayComments()
    {
        Console.WriteLine($"Comments by {_name}:");
        foreach (string comment1 in _comment)
        {
            Console.WriteLine($"- {comment1}\n");
        }
    }
}
