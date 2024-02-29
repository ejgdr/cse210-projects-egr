public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _ending;

    public Activity(string actName, string descrip)
    {
        _activityName = actName;
        _description = descrip;
    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"{_activityName}.\n\n{_description}\n");
    }
    public void AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage(){}
    public void RunIt(){}
    public void ShowSpinner(){}
    public void ShowCountdown(){}
    
}