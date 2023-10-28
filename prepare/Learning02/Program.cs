using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1
        Job job1 = new Job();
        // Set the member variables using the dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create a second job, set its variables
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create a new instance of the Resume class
        // Pulls from the Resume program
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        // Add the two jobs you  created earlier, to the list of jobs in the resume object
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line
        myResume.Display();

    }
}