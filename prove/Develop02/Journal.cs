public class Journal
{
    // The heart of the application, main features are managed in this Class
    // Extra feature is how it manages the files and the info that goes to them
    public List<string> _entries = new List<string>();
    public Entry _entry = new Entry();
    public FileManager _fileManager = new FileManager();
    public Journal()
    {
    }

    public void AddJournalEntry()
    {
        string entry = _entry.DisplayEntry();
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void LoadData()
    {
        // Here if the user makes a mistake typing the name of the file, he can get a list of the files
        // in memory. Also if attempting to load a file without having any, the program asks to go and create
        // one before that step.
        Console.WriteLine("Enter the file name (Ex: name.txt): ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            var path = ".";
            var fullPath = Path.GetFullPath(path);
            string[] files = Directory.GetFiles(fullPath, "*.txt", 0);
            if (files.Length == 0)
            {
                Console.WriteLine("You cannot load without an existing file, go and save your work first\n");
            }
            else
            {
                Console.WriteLine("That file doesn't exist, these are your current files in memory:"); 
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    Console.WriteLine(fi.Name);
                }
                Console.Write("Please type the desired one (Ex: name.txt): ");
                fileName = Console.ReadLine();
                _fileManager.ReadFile(fileName, _entries);
            }
        }
        
    }

    public void SaveData()
    {
        // Extra feature, it's not going to crash and gives the option to
        // add to an existing file or create a new file for it.
        Console.WriteLine("Enter the file name (Ex: name.txt): ");
        string fileName = Console.ReadLine();
        string fileN = fileName;
        
        if (File.Exists(fileN)) 
        {
            Console.Write("This file already exists. Would you like to add to it? (y/n): ");
            string option = Console.ReadLine();
            if (option.ToLower() == "y")
            {
                fileName = fileN;
                _fileManager.CreateFile(fileName, _entries);
                _entries.Clear();
            }
            else if (option.ToLower() == "n")
            {
                Console.Write("Please type the new file name (Ex: name.txt): ");
                fileName = Console.ReadLine();
                _fileManager.CreateFile(fileName, _entries);
            }               
        }
        else
        {
            _fileManager.CreateFile(fileName, _entries);
        }
        
    }   
}