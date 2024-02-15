public class Word
{
    /**
       Responsible for handling a word, the change that needs to be made
       to be converted in underscores to hide it.
    **/
    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string word, bool isHidden = false)
    {
        _word = word;
        _isHidden = isHidden;
    }
    // check if the word is hidden
    private bool IsHidden(string word)
    {
        foreach (char letter in word)
        {
            if (letter == '_')
                _isHidden = true;
                return true;
        }
        return false;
    }

    // Hide a word that is not hidden
    private string Hidde(string word)
    {
        if (IsHidden(word) == false)
        {
            foreach (char letter in word)
            {
                word.Replace(letter, '_');
            }
        return word;
        }
        return word;    
    }
    // Show the hidden word
    public string GetRenderedText(string word)
    {
        string newWord = Hidde(word);
        return newWord;
    }
}