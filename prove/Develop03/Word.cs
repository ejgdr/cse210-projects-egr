public class Word{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden = false)
    {
        _word = word;
        _isHidden = isHidden;
    }
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

    public string GetRenderedText(string word)
    {
        string newWord = Hidde(word);
        return newWord;
    }
}