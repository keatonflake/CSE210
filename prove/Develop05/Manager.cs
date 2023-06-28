class Manager
{

    public void Report()
    {

    }
    public void WriteToFile(List<Goal> goals)
    {
        Console.WriteLine("Enter the file path to save goals: ");
        string filePath = Console.ReadLine();

        // Write file using StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
                if (goal.ToString() == "Checklist")
                {
                    writer.WriteLine(goal + "|" + goal.GetName() + "|" + goal.GetDescription() + "|" + goal.GetPointValue() + "|" + goal.GetNeededTimes() + "|" + goal.GetCompletedTimes() + "|" + goal.GetBonusPoints() + "|");
                }
                else
                {
                    writer.WriteLine(goal + "|" + goal.GetName() + "|" + goal.GetDescription() + "|" + goal.GetPointValue() + "|" + goal.GetCompletedTimes() + "|");
                }
        }
    }

    public string[] ReadFromFile()
    {
        Console.WriteLine("Enter the file path the goals are located or type quit to exit program: ");
        string filePath = Console.ReadLine();
        // if file path == quit end program
        if (filePath.ToLower() == "quit")
        {
            System.Environment.Exit(0);
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines;

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
            string[] str = new string[] { };
            return str;
        }
    }
}