public class FileManager
{
    // This is the class that allow me to have the code to save, load,
    // and record
    public FileManager()
    {
    }

    public void CreateFile(string fileName, List<string> list)
    {    
        // To create content for the first time
        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            foreach (string item in list)
            {
                outputFile.WriteLine(item);
            }
        }
    }

    public void AddToFile(string fileName, List<string> list)
    {
        // Allow me to record on file
        using (StreamWriter outputFile = new StreamWriter(fileName, true)) 
        {
            foreach (string item in list)
            {
                outputFile.WriteLine(item);
            }
        }
    }

    public void ReadFile(string fileName, List<string> list)
    {
        // Help me reading the files
        string[] lines = File.ReadAllLines(fileName);
        
        list.Clear(); 

        foreach (string line in lines)
        {
            list.Add(line);
        }
        
    }
}