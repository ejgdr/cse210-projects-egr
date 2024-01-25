using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiation for Job Class
        Job job1 = new()
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new()
        {
            _jobTitle = "Manager",
            _company = "Apple",
            _startYear = 2022,
            _endYear = 2023
        };

        // Instantiation for Resume Class
        Resume resume1 = new()
        {
            _name = "Allison Rose"
        };

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
        
    }
}