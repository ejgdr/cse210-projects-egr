public class SimpleGoal : Goal
{
    // Goals that will be marked as checked once they are completed
    public SimpleGoal(string type) : base ()
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