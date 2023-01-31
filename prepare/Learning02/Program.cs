using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("resume tu vida");
        //this is how to create an instance = new job intance
        Job job1 = new Job(); 
        //using the DOT notation 
        job1._jobTitle = "Nurse Assistant";
        job1._company = "ASB";
        //int iwhtout comillas
        job1._startYear = 2020;
        job1._endYear = 2022;

        //Console.WriteLine($"{job1._company}");
        
        job1.Display(); 


        Job job2 = new Job();
        job2._jobTitle = "Warehouse Assistant";
        job2._company = "LPP Deutschland GmbH";
        job2._startYear = 2018;
        job2._endYear = 2019;

        
        //Console.WriteLine($"{job2._company}");

        job2.Display(); 
        
        //create a NEW INSTANCE of the Resume class.
        Resume resume1 = new Resume();
        //Create the MEMBER VARIABLE for the person's name.
        resume1._name = "Yamil Claure";
        //step 8 add a call at the end to the Display method 
        //from your Resume class to display the name and all the jobs in one line.
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        //resume1.Display($"_jobs[0]._jobTitle");



    }
}