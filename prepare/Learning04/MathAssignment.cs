public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _section;

    public MathAssignment(string textBookSection, string section,string student, string topic ) : base (student, topic)
    {
        _textBookSection = textBookSection;
        _section = section;
    }   
    public string GetHomeWorkList(){

        return $"{_textBookSection} {_section}";
    } 
}