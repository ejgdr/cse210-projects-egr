public class FileManager
{
    // This is the class that allow me to have the code to save, load,
    // and record
    public FileManager()
    {
    }

    public void CreateFile(string filename, List<Goal> list)
    {    
        // To create content for the first time
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            foreach (Goal item in list)
            {
                outputFile.WriteLine(item.Serialize());
            }
        }
    }

    public void AddToFile(string filename, List<Goal> list)
    {
        // Allow me to record on file
        using (StreamWriter outputFile = new StreamWriter(filename, false)) 
        {
            foreach (Goal item in list)
            {
                outputFile.WriteLine(item.Serialize());
            }
        }
    }

    public string[] ReadFile(string filename)
    {
        // Help me reading the files
        string[] lines = File.ReadAllLines(filename);
    
        return lines;
    }
}