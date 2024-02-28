public class ReflectingActivity: Activity
{
    private string[] _prompts;
    private string[] _questions;
    
    public ReflectingActivity(string actName, string descrip) : base(actName, descrip){}
    private void RandomPrompt(){}
    private void RandomQuestion(){}
    public void DisplayPrompt(){}
    public void DisplayQuestion(){}
}