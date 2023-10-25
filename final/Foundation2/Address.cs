// Address class
// The responsability of holding data about adresses

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // getters
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    //Methods

    public bool IsUSAAddress()
    {
        if(_country == "USA" || _country=="US" || _country=="EEUU" || _country=="U.S" || _country=="U.S.A"){
            return true;
        }   
        return false;
    }

    public string GetFullAdrress()
    {
        string address = $"{_street}  {_city} , {_state} , {_country} ";
        return address;
    }
}
