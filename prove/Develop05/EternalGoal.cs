public class EternalGoal : Goal
{
    // Goals that will never be marked as checked, they don't have an end.
    public EternalGoal() : base ()
    {
        _type = "Eternal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        _done = false;
    }
    public EternalGoal(string line) : base()
    {
        Deserialize(line);
    }
    public override string Serialize()
    {
        return $"{_type}~{_name}~{_description}~{_points}";
    }
    public override void Deserialize(string content)
    {
        string[] splitting = content.Split("~");
        if (splitting.Length < 3)
        {
            Console.WriteLine("Missing content");
        }
        else
        {
            _type = splitting[0];
            _name = splitting[1];
            _description = splitting[2];
            _points = int.Parse(splitting[3]);
        }
    }
    public override void RecordEvent()
    {
        if (_type == "Eternal")
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _score += _points;
        }
    }

}