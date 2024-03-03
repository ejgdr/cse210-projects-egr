public class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;
    private List<string> spinnerAnimation = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\"};

    public Activity(string actName, string descrip)
    {
        _activityName = actName;
        _description = descrip;
    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_description}\n");
    }
    public void AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
    }
    public void RunIt()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        foreach (string s in spinnerAnimation)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void ShowCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }
    
}