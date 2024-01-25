public class Resume
{
     // Responsibilities or attributes or member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume()
    {
    }

    // Behaviors, or methods or member functions
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