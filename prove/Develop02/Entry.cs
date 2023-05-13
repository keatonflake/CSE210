public class Entry{

    public string _prompt;
    public string _response;
    public string _date;

    public string Date(){
         // grab time
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}
