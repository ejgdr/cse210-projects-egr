public class ReflectingActivity: Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();
    
    public ReflectingActivity(string actName, string descrip) : base(actName, descrip){}

    public void DisplayPrompt()
    {
        int index = _random.Next(_prompts.Count());
        string prompt = _prompts[index];
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {prompt} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
    }

    public void CallToPonder()
    {
        Console.WriteLine("Now ponder in each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown();
        Console.WriteLine();
    }
    public void DisplayQuestion()
    {
        
        Console.Clear();
        
        for (int i = _duration; i > 0; i++)
        {
            int index = _random.Next(_questions.Count());
            string question = _questions[index];
            Console.Write($"> {question}");
            ShowSpinner();
            Console.WriteLine();
            i -= 10;
        }
        Console.WriteLine();
    }
}