namespace Paradygmaty.model;

public class Address
{
    private string street;
    private string number;

    public Address(string street, string number)
    {
        this.street = street;
        this.number = number;
    }

    public string getAddress()
    {
        return $"ul. {this.street} {this.number}";
    }
    
}