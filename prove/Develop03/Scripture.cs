using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Scripture
{
    /**
       Responsible for handling the block of scriptures, when the words hide,
       what happens when is completely hidden, and what is being rendered to
       the screen 
    **/
    
    private Store _scriptureContent = new Store();
    private Word _operateWord = new Word();
    public string _blockOfScripture;
    Random random = new Random();
    
    // What the user sees on the screen
    public string GetRenderedText(Reference reference)
    {
        _blockOfScripture = _scriptureContent.GenerateScripture(reference.AssambleReference());
        return _blockOfScripture;
    }

    // Select three words at a time to hide
    public string HideWords()
    {
        string[] listWordsScripture = _blockOfScripture.Split(' ');
        int index1 = random.Next(0, listWordsScripture.Length);
        int index2 = random.Next(0, listWordsScripture.Length);
        int index3 = random.Next(0, listWordsScripture.Length);
        listWordsScripture[index1] = _operateWord.GetRenderedText(listWordsScripture[index1]);
        listWordsScripture[index2] = _operateWord.GetRenderedText(listWordsScripture[index2]);
        listWordsScripture[index3] = _operateWord.GetRenderedText(listWordsScripture[index3]);
        return string.Join(" ", listWordsScripture);
    }

    // Check if the whole block has been hidden
    public bool IsCompletelyHidden()
    {
        string[] listWordsScripture = _blockOfScripture.Split(' ');
        int lengthOfList = listWordsScripture.Length;
        int count = 0;
        foreach (string word in listWordsScripture)
        {
            if (word.StartsWith('_'))
            {
                count += 1;
            }
            if (lengthOfList == count)
            {
                return true;
            }
        }     
    return false;
    }
}