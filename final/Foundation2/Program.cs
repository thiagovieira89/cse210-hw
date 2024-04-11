using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        new Product("soup","122",12,3);
        new Product("Shampoo","133",3,1);
        new Product("water","144",1,10);

        Address address = new Address("","","","");
        address.SetStreetAddress("Washington Street");
        address.SetCity("New York");
        address.SetState("New York");
        address.SetCountry("USA");

        
        Address address2 = new Address("","","","");
        address2.SetStreetAddress("Av.Paulista");
        address2.SetCity("São Paulo");
        address2.SetState("São Paulo");
        address2.SetCountry("Brazil");

        
    }
       
}    