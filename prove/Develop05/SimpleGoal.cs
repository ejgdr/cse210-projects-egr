public class SimpleGoal : Goal
{
    // Goals that will be marked as checked once they are completed
    public SimpleGoal() : base ()
    {
        _type = "Simple";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        _done = false;
    }

    public SimpleGoal(string line) : base()
    {
        Deserialize(line);
    }
    
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _done = true;
        _score += _points;
    }

}