public abstract class Goal
{
    // Help to have all common attributes and behaviors of my Goals
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _done;

    public string TransformType(string input)
    {
        if (input == "1")
        {
            return "Simple";
        }
        else if (input == "2")
        {
            return "Eternal";
        }
        else if (input == "3")
        {
            return "Gradual";
        }
        else
        {
            return "Unknown";
        }
    }
    public string Serialize()
    {
        return $"{_type}~{_name}~{_description}~{_points}~{_done}";
    }
    public void Deserialize(string content)
    {
        string[] splitting = content.Split("~");
        if (splitting.Length < 4)
        {
            Console.WriteLine("Missing content");
        }
        else
        {
            _type = splitting[0];
            _name = splitting[1];
            _description = splitting[2];
            _points = int.Parse(splitting[3]);
            _done = bool.Parse(splitting[4]);
        }
    }
    public string CreateGoal(string selection)
    {
        _type = TransformType(selection);
        return _type;
    }
    public virtual string DisplayGoal()
    {
        return $"[ ] {_name} ({_description})";
    }
    public void ScoreCount(){}
    public void MarkOffGoal(){}
    public abstract void RecordEvent();


}