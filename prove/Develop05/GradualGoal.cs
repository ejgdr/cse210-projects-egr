public class GradualGoal : Goal
{
    // Goals that will be marked as checked, when all its stages are completed.
    private int _goalLength;
    private int _progress;
    private int _extraBonus;
    public GradualGoal() : base ()
    {
        _type = "Gradual";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalLength = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _extraBonus = int.Parse(Console.ReadLine());
        _progress = 0;
        _done = false;
    }
    public GradualGoal(string line) : base()
    {
        Deserialize(line);
    }
    public override string DisplayGoal()
    {
        return $"[{(_done ? 'X':' ')}] {_name} ({_description}) -- Currently completed: {_progress}/{_goalLength}";
    }
    public override string Serialize()
    {
        return $"{_type}~{_name}~{_description}~{_points}~{_extraBonus}~{_progress}~{_goalLength}";
    }
    public override void Deserialize(string content)
    {
        string[] splitting = content.Split("~");
        if (splitting.Length < 6)
        {
            Console.WriteLine("Missing content");
        }
        else
        {
            _type = splitting[0];
            _name = splitting[1];
            _description = splitting[2];
            _points = int.Parse(splitting[3]);
            _extraBonus = int.Parse(splitting[4]);
            _progress = int.Parse(splitting[5]);
            _goalLength = int.Parse(splitting[6]);
        }
    }
    public override void RecordEvent()
    {
        if (_progress < _goalLength)
        {
            _score += _points;
            _progress += 1;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            if (_progress == _goalLength)
            {
                _done = true;
                _score += _extraBonus;
                Console.WriteLine($"So great! You also earned {_extraBonus} points for your Bonus!");
            } 
        }
        
                    
        
    }

}