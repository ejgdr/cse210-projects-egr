public class Job
{
    // Responsibilities or attributes or member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job()
    {
    }

    // Behaviors, or methods or member functions
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }
}