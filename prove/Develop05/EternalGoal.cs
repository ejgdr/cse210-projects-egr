public class EternalGoal : Goal
{
    // Goals that will never be marked as checked, they don't have an end.
    public EternalGoal(string type) : base ()
    {
        _type = type;
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        _done = false;
    }
    public override void RecordEvent(){}

}