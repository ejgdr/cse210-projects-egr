using System.Formats.Asn1;

public class GoalManager
{
    // Help to manage my score, display my goals, save them and load them
    private FileManager _fileManage = new FileManager();
    private int score;
    protected SimpleGoal _simple;
    protected EternalGoal _eternal;
    protected GradualGoal _gradual;
    protected List<Goal> _goals = new List<Goal>(){};
    public GoalManager(){}

    public void CreateGoal(string selection)
    {
        if (selection == "1")
        {
            _simple = new SimpleGoal();
            _goals.Add(_simple);
        }
        else if (selection == "2")
        {
            _eternal = new EternalGoal();
            _goals.Add(_eternal);
        }
        else if (selection == "3")
        {
            _gradual = new GradualGoal();
            _goals.Add(_gradual);
        }
        else
        {
            Console.WriteLine("Wrong input, stick to the menu to pick a type of Goal");
        }
    }
    public void DisplayGoals()
    {
        int _numberGoal = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_numberGoal += 1}. {goal.DisplayGoal()}");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the name of your file? ");
        var filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            _fileManage.CreateFile(filename, _goals, score);
        }        
        else
        {
            _fileManage.AddToFile(filename, _goals, score);
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the name for the goal file? ");
        var filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            string[] fileContent = _fileManage.ReadFile(filename);
            
            int temp = int.Parse(fileContent[0]);
            score = temp;
            CurrentScore();
            foreach (string line in fileContent)
            {
                var toUse = line.Split("~");
                var typeGoal = toUse[0];
                
                if (typeGoal == "Simple")
                {
                    _simple = new SimpleGoal(line);
                    _goals.Add(_simple);
                }
                else if (typeGoal == "Eternal")
                {
                    _eternal = new EternalGoal(line);
                    _goals.Add(_eternal);
                }
                else if (typeGoal == "Gradual")
                {
                    _gradual = new GradualGoal(line);
                    _goals.Add(_gradual);
                }
                else
                {
                    Console.WriteLine("Your file is empty or with the wrong data");
                }
            }
        }
        else
        {
            Console.WriteLine($"The file '{filename}' wasn't found!");
        }
    }
    public void RecordGoals()
    {
        Console.Write("Which goal did you accomplish? ");
        var selection = Console.ReadLine();
        int index = int.Parse(selection);
        _goals[index - 1].RecordEvent();
        score += _goals[index - 1].ScoreCount();
        Console.WriteLine($"You now have {score} points.\n");
    }

    public int CurrentScore()
    {
        return score; 
    }
}