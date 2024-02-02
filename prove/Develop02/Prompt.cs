public class Prompt
{
    // List of question for the user to pick from
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Which impressions of the Holy Ghost did I receive today?",
        "What application from scriptures passages did I experience today?",
        "How did I serve someone else today?",
        "How the Atonement of Jesus Christ was applied today in my life?"
    };
    // Used to select our daily question randomly
    Random random = new Random();
    public Prompt()
    {
    }
    // Return a random prompt from the prepared list
    public string GenerateAleatoryPrompt()
    {
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}