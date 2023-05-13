using System;

class Program
{
    static void Main(string[] args)
    {
        bool resume = true;
        List<Entry> EntriesList = new List<Entry>();

        while (resume){
        Console.WriteLine();
        Console.WriteLine("Welcome! Please type the number that corresponds with the action you wish to take.");
        Console.WriteLine($" 1) Write new entry\n 2) Display entries\n 3) Load from file\n 4) save entries\n 5) Quit\n");

        string selection = Console.ReadLine();
        // Console.WriteLine(selection);
        switch(selection) {
            case "1":
                // Create new 
                PromptGen JournalPrompt = new PromptGen();
                string prompt = JournalPrompt.RandomPrompt();
                
                Entry newEntry = new Entry();
                string date = newEntry.Date();

                Console.WriteLine($"{date}\n{prompt}");
                string reponse = Console.ReadLine();

                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._response = reponse;
                EntriesList.Add(newEntry);
                // Console.WriteLine(newEntry._response);
                break;
            case "2":
                Console.WriteLine("case 2");
                for (int i = 0; i < EntriesList.Count; i++){
                    Console.WriteLine(EntriesList[i]._date);
                    Console.WriteLine(EntriesList[i]._prompt);
                    Console.WriteLine(EntriesList[i]._response);
                    Console.WriteLine();

                }
                break;
            case "3":
                Console.WriteLine("case 3");
                Journal loadJournal = new Journal();
                Console.WriteLine(loadJournal.LoadJournal());

                break;
            case "4":
                Console.WriteLine("case 4");
                // Journal journal = new Journal();
                // journal.SaveJournal();
                Console.WriteLine("Type the file name you wish to save to");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach(Entry line in EntriesList){
                        outputFile.WriteLine(line._date);
                        outputFile.WriteLine(line._prompt);
                        outputFile.WriteLine(line._response);

                    }
                }

                break;
            case "5":
                Console.WriteLine("Have a Great Day! Bye :)");
                resume = false;
                break;
            default:
                Console.WriteLine("please make a selection");
                selection = Console.ReadLine();
                break;
        }
    }
}
}