public class Event
{
protected string _title;
protected string _description;
protected string _date;
protected string _time;
protected Address _address;

public string GetTitle()
{
    return _title;
}
public void SetTitle(string title)
{
    _title = title;
}
public string GetDescription()
{
    return _description;
}
public void SetDescription(string text)
{
    _description = text;
}
public string GetDate()
{
    return _date;
}
public void SetDate(string text)
{
    _date = text;
}
public string GetTime()
{
    return _time;
}
public void SetTime(string text)
{
    _time = text;
}
public Address GetAddress()
{
    return _address;
}
public void SetAddress(Address text)
{
    _address = text;
}
public void GetStandardDetails()
{
    Console.WriteLine(
    _title + "\n" +
    _description  + "\n" +
    _date  + "\n" +
    _time  + "\n" +
    _address.GetAddressString()  + "\n"
    );
}
public virtual void GetFullDetails()
{
    GetStandardDetails();
}
public virtual void GetShortDescription()
{
    Console.WriteLine("EVENT");
    Console.WriteLine(_title);
    Console.WriteLine(_date);
}
}