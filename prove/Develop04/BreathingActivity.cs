public class BreathingActivity : Activity
{
    // Child activity, inheriting from Activity on charge of a Breathing exercise

    // Constructor
    public BreathingActivity(string actName, string descrip) : base(actName, descrip){}

    // Behaviors 
    public void DisplayBreathing()
    {
        // Shows the user a breathing exercise to calm down
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