using System;
public class Resume
{
    //Create the member variable for the person's name.
    public string _name;

    //Create the member variable = public.... for the LIST of Jobs. List<Job>... what is next
    public List<Job> _jobs = new List<Job>();
    //add a method to display its details.

    //This method should not have any 
    //parameters and should not return anything.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

    




}