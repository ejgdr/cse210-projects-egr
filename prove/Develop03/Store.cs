public class Store
{
    /**
       Responsible to provide the content of the scripture based on the reference
    **/
    private Dictionary<string, string> _scriptures = new Dictionary<string, string>()
    {
        {"Proverbs 3:5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding."},
        {"Proverbs 3:6", "In all thy ways acknowledge him, and he shall direct thy paths."}
    };

    public string GenerateScripture(string reference)
    {
        // Passing one verse
        return $"{reference} {_scriptures[reference]}";
    }

    public string GenerateBlock(List<string> references, string reference)
    {
        string display = $"{reference}";
        foreach (string refer in references)
        {
            display += $"{_scriptures[refer]}\n";
        }
        return display;
    }

}