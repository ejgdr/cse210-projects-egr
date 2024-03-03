public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _ending;
    private List<string> spinnerAnimation = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\"};


    public Activity(string actName, string descrip)
    {
        _activityName = actName;
        _description = descrip;
        _duration = 1;
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
            Thread.Sleep(800);
            Console.Write("\b \b");
        }

    }
    public void ShowCountdown()
    {

    }
    
}