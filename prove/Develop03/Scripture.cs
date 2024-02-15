public class Scripture
{
    /**
       Responsible for handling the block of scriptures, when the words hide,
       what happens when is completely hidden, and what is being rendered to
       the screen 
    **/
    private Store _scriptureContent = new Store();
    // Select three words at a time to hide
    public void HideWords()
    {
         
    }
    // What the user sees on the screen
    public string GetRenderedText(Reference reference)
    {
        return _scriptureContent.GenerateScripture(reference.AssambleReference());
    }
    // Check if the whole block has been hidden
    private void IsCompletelyHidden(){}
}