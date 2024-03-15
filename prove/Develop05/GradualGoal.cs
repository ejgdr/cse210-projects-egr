public class GradualGoal : Goal
{
    // Goals that will be marked as checked, when all its stages are completed.
    private int _goalLength;
    private int _progress;
    private int _extraBonus;
    public GradualGoal(string type) : base ()
    {
        _type = type;
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
    public override string DisplayGoal()
    {
        return $"[ ] {_name} ({_description}) -- Currently completed: {_progress}/{_goalLength}";
    }
    public override void RecordEvent(){}

}