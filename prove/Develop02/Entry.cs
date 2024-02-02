public class Entry
{
    public Prompt _prompt = new Prompt();
    public string _entry;
    public DateTime currentDate = DateTime.Now;
    public Entry()
    {
    }

    public string DisplayEntry()
    {
        // The second face of the program and how the entry is assambled 
        string date =  currentDate.ToShortDateString();
        string prompt = _prompt.GenerateAleatoryPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        _entry = Console.ReadLine();
        return $"Date: {date} - Prompt: {prompt}\n{_entry}\n";
    }
}