public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    
    public void SetStreetAddress(string address)
    {
        _streetAddress = address;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetProvance(string provance)
    {
        _province = provance;
    }

    public void SetCountry(string country)
    {
            _country = country;
    }

    public string GetAddressString()
    {
        return 
        _streetAddress + "\n" +
        _city + "\n" +
        _state + "\n" +
        _province + "\n" +
        _country + "\n";
    }

    public bool StatesideConformation()
    {
        if(_country.ToLower() == "united states")
        {
            return true;
        }
        else{
            return false;
        }
    }
}