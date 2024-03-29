public class ListingActivity : Activity
{
    // Child activity, inheriting from Activity on charge of an exercise of listing thoughts

    // Attributes
    private string[] _prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _answers = new List<string>{};
    private Random _random = new Random();

    // Constructor
    public ListingActivity(string actName, string descrip) : base(actName, descrip){}

    // Behaviors
    public void DisplayPrompt()
    {
        // Display a prompt to the user to inspire and write thoughts about it
        int index = _random.Next(_prompts.Count());
        string prompt = _prompts[index];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown();
        Console.WriteLine();
    }
    public void CollectAnswers()
    {
        // Gather the answers given from an user to help us count
        for (int i = _duration; i > 0; i++)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _answers.Add(answer);
            i -= 10;
        }
    }
    public void DisplayCount()
    {
        // Count display 
        int count = _answers.Count;
        Console.WriteLine($"You listed {count} items!\n");
    }
}