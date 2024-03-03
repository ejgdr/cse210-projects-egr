public class BreathingActivity : Activity
{
    protected int _splitDuration;

    public BreathingActivity(string actName, string descrip) : base(actName, descrip)
    {
        _splitDuration = _duration;
    }
    public void DisplayBreathing()
    {
    
        for (int i = _duration; i > 0; i++)
        {
            Console.Write("Breathe in...");
            ShowCountdown();
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown();
            Console.WriteLine();
            Console.WriteLine();
            i -= 10;
        }
    }
}