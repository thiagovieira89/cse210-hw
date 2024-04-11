public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
         _city = city;
    }
    public string GetState()
    {
        return _stateOrProvince;
    }
    public void SetState(string state)
    {
        _stateOrProvince = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public bool isUSA()
    {
        return true;
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress} {_city} {_stateOrProvince} {_country}";
    }
}