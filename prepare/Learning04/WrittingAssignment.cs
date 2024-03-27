public class WrittingAssignmente : Assignment
{
    private string _title;

    public WrittingAssignmente(string student, string topic,string title) : base (student, topic)
    {
        _title = title;
    
    }
    public string GetWrittingInfo()
    {
        return $"{_title}";
    }
}