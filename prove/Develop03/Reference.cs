public class Reference
{
    /**
       Responsible for getting the reference to work with
    **/
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor
    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Prepare to work with more verses
    private List<string> splitVerses()
    {
        List<int> verses = new List<int>();
        verses.Add(_startVerse);
        int sum = _startVerse;
        while (_endVerse - sum != 0)
        {
            verses.Add(sum + 1);
        }
        List<string> sVerses = verses.ConvertAll<string>(delegate(int i) {return i.ToString();});
        return sVerses;
    }

    // More than one verse
    public List<string> SeveralVerses()
    {
        List<string> listVerses = splitVerses();
        List<string> references = new List<string>();
        foreach(string verse in listVerses)
        {
            references.Add($"{_book} {_chapter}:{verse}");
        }
        return references;
    }
    
    // Give the format to the reference with its components
    public string AssambleReference()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}