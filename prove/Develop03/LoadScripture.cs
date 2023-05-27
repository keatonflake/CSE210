class LoadScripture
{
    public string OpenScriptureFromFile()
    {
        Console.WriteLine("Enter the file path or type quit to exit program: ");
        string filePath = Console.ReadLine();
        // if file path == quit end program
        if (filePath.ToLower() == "quit")
        {
            System.Environment.Exit(0);
        }

        try
        {
            return File.ReadAllText(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
            return string.Empty;
        }
    }
}