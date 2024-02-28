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
    public void DisplayGreeting(){}
    public void DisplayEndMessage(){}
    public void RunIt(){}
    public void ShowSpinner(){}
    public void ShowCountdown(){}
    public void AskDuration(){}
}