public class Reception : Event
{
    // Email List AKA RSVP List
    List<string> emails = new List<string>();

    public void SetEmail(string email)
    {
        emails.Add(email);
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("Reception: ");
        Console.WriteLine("The RSVP Email List: ");
        foreach (string email in emails)
        {
            Console.WriteLine(
                email + "\n"
            );
        }
        GetStandardDetails();
    }

    public override void GetShortDescription()
    {
        Console.WriteLine("Reception: ");
        Console.WriteLine(_title);
        Console.WriteLine(_date);
    }
}