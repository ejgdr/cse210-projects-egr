public abstract class Goal
{
    // Help to have all common attributes and behaviors of my Goals
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _score;
    protected bool _done;

    public virtual string Serialize()
    {
        return $"{_type}~{_name}~{_description}~{_points}~{_done}";
    }
    public virtual void Deserialize(string content)
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

    public virtual string DisplayGoal()
    {
        return $"[{(_done ? 'X':' ')}] {_name} ({_description})";
    }
    public virtual int ScoreCount()
    {
        return _score;
    }
    public abstract void RecordEvent();


}