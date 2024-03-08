using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job ();
        job1._company = "Microsoft";
        job1._jobTitle = "Engineer Software";
        job1._startYear = 2010;
        job1._endYear = 2018;

        Job job2 = new Job ();
        job2._company ="Tesla";
        job2._jobTitle = "Engineer Automotive";
        job2._startYear = 2018;
        job2._endYear = 2022;

        job1.DisplayJobs();
        job2.DisplayJobs();

        Resume myResume = new Resume();
        myResume.PersonName = "Thiago Vieira";

        myResume._ListJob.Add(job1);
        myResume._ListJob.Add(job2);

        myResume.DisplayJobs();
    }
}