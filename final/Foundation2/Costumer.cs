using System.Security.Cryptography;

public class Costumer
{
    private string _name;
    private Address _address;

    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool LivesInUSA()
    {
        return true;
        // if(country.GetCountry() == "USA")
        // {
        //     Console.Write("The country in USA");
        // }else{
        //     Console.Write("Is not USA");
        // }
        // return country;
    }
}