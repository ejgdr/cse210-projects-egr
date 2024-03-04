public class Activity
{
    // Parent class, contains all the common features for the children activities

    // Attributes
    private string _activityName;
    private string _description;
    protected int _duration;
    private List<string> spinnerAnimation = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    // Constructor
    public Activity(string actName, string descrip)
    {
        _activityName = actName;
        _description = descrip;
    }
    
    //Behaviors
    public void DisplayGreeting()
    {
        // Shows the name of the activity and description of the activity being shown to the user
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_description}\n");
    }
    public void AskDuration()
    {
        // Controller for the duration of the activity
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage()
    {
        // Conclusion of the activity, greeting and recorder of how long the user was on the activity
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        ShowSpinner();
    }
    public void RunIt()
    {
        // Time out to start the Activity, preparation behavior
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        // Animation: A spinner
        foreach (string s in spinnerAnimation)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void ShowCountdown()
    {
        // Animation: Countdown
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }
    
}