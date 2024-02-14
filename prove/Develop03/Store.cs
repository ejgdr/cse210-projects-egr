public class Store
{
    private Dictionary<string, string> _scriptures = new Dictionary<string, string>()
    {
        {"Proverbs 3: 5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding."},
        {"Proverbs 3: 6", "In all thy ways acknowledge him, and he shall direct thy paths."}
    };

    public string GenerateScripture(string reference)
    {
        // An attempt to pass the second verse, thought not completed
        if (reference.Contains("-"))
        {
            string workingRef = reference.Substring(reference.IndexOf(":"));
            string verses = string.Empty;

            for (int i = 0; i < workingRef.Length; i++)
            {
            if (Char.IsDigit(workingRef[i]))
               verses += workingRef[i];
            }

            string root = reference.Substring(0, reference.IndexOf(":"));

            return $"{reference} {_scriptures[reference]}\n{_scriptures[reference]}";
        }
        // Passing one verse
        return $"{reference} {_scriptures[reference]}";
    }

}