using System;
using System.Collections.Generic;

public class Resume
{
    //Member variables
    public string _name = "";

    //List to hold Job objects
    public List<Job> _jobs = new List<Job>();

    //Methods
    public void Display()
    {
        //Display the name and jobs on the resume
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Iterate through the list of jobs and call the Display method for each job
        foreach (Job job in _jobs)
        {
            //Call the Display method of the Job class to show job details
            job.Display();
        }
    }
}