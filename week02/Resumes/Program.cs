using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        Console.WriteLine(job1._company);
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Amazon";
        Console.WriteLine(job2._company);
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Nestor Gomez Artiles";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }
}