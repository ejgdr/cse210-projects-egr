public class GoalManager
{
    // Help to manage my score, display my goals, save them and load them
    private FileManager _fileManage = new FileManager();
    protected int _score;
    protected int _numberGoal = 0;
    protected SimpleGoal _simple;
    protected EternalGoal _eternal;
    protected GradualGoal _gradual;
    protected List<Goal> _goals = new List<Goal>(){};
    public GoalManager(){}

    public void CurrentScore(){}
    public void CreateGoal(string selection)
    {
        if (selection == "1")
        {
            _simple = new SimpleGoal(selection);
            _simple.CreateGoal(selection);
            _goals.Add(_simple);
        }
        else if (selection == "2")
        {
            _eternal = new EternalGoal(selection);
            _eternal.CreateGoal(selection);
            _goals.Add(_eternal);
        }
        else if (selection == "3")
        {
            _gradual = new GradualGoal(selection);
            _gradual.CreateGoal(selection);
            _goals.Add(_gradual);
        }
        else
        {
            Console.WriteLine("Wrong input, stick to the menu to pick a type of Goal");
        }
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_numberGoal += 1}. {goal.DisplayGoal()}");
        }
    }
    public void SaveGoals(){}
    public void LoadGoals(){}


}