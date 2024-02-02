using System;
using System.IO;
using System.Runtime.InteropServices;
public class FileManager
{
    // This is the class that allow me to have the code to save, append, load,
    // and read data
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
        // 'true' allow me to append without duplicates
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
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        // Helps with duplicates
        list.Clear(); 

        foreach (string line in lines)
        {
            list.Add(line);
        }
        
    }
}