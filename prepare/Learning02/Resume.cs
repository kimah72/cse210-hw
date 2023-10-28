using System;

// The Resume holds the variable for the name and jobs
public class Resume
{
    // Create the member variable for the person's name
    public string _name;

    // Create the member variable for the list of Jobs
    // Make sure to initialize your list to a new List before you use it.
    // Pulls from the Job program
    public List<Job> _jobs = new List<Job>();

    // add a method to display its details
    public void Display()
    {
        // display the person's name and then iterate through each Job instance in the list of jobs and display them.
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: {_jobs}");
        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job in the list
            job.Display();
        }
    }
}