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