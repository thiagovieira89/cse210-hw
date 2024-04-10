public class Video
{
    public string _title{get;set;}
    public string _author{get;set;}
    public double _length{get;set;}

    public Video (string title, string author, double time)
    {
        _title = title;
        _author = author;
        _length = time;
    }



}