// Customer class
// The responsability of holding data about products

public class Customer
{
    private string _name;
    private Address _address;
  

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //Getters
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAdrress();
    }

    //Methods

    public bool isUSACustomer(){
       return _address.IsUSAAddress();
    }

   
}
