using System.IO; 
public class Journal{
    
    public List<Entry> _entries = new List<Entry>();

    public void SaveJournal(Journal journal, string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)){
        foreach (var entry in journal._entries){
            string data = $"{entry._date};{entry._prompt};{entry._response}";
            outputFile.WriteLine(data);
        }}
    }
    
    public Journal LoadJournal(){
        Console.Write("Enter the File name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();

        foreach (string line in lines) {
            string[] parts = line.Split("\n");

            Entry entry = new Entry();
            // entry._date = date;
            // entry._prompt = prompt;
            // entry._response = response;
            Console.WriteLine(parts[0]);
            // journal._entries.Add(entry);
        }

        return journal;
    }
}