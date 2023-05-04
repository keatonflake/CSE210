using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Programer";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "earth";
        job2._jobTitle = "monkey";
        job2._startYear = 5019;
        job2._endYear = 5021;

        Resume resume1 = new Resume();
        resume1._name = "Sheela";
        resume1._jobs.Add("scrapbooking");
        resume1._jobs.Add("Racecar Driving");

        resume1.Display();
        job1.Display();
        job2.Display();

    }
}