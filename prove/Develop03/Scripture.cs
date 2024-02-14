public class Scripture
{
    private Store _scriptureContent = new Store();

    public void HideWords(){}

    public string GetRenderedText(Reference reference)
    {
        return _scriptureContent.GenerateScripture(reference.AssambleReference());
    }

    private void IsCompletelyHidden(){}
}