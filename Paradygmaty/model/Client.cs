namespace Paradygmaty.model;

public class Client
{
    private string firstName;
    private string lastName;
    private readonly string personalID;

    private Address address;
    public Client()
    {
        Console.WriteLine("Wywołanie konstruktora bezparametrowego");
    }

    public Client(string firstName, string lastName, string personalId, Address address)
    {
        setFirstName(firstName);
        setLastName(lastName);
        if (IsValidPersonalID(personalId))
        {
            this.personalID = personalId;
        }
        else
        {
            throw new ArgumentException("Nieprawidłowy numer PESEL");
        }
        Console.WriteLine("Wywołano konstruktor z parametrami");
        this.address = address;
    }
    
    public string getClinetInfo()
    {
        return $"Kinent imię {firstName} {lastName}, pesel: {personalID} zamieszkały {address.getAddress()}";
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string getFirstName()
    {
        return this.firstName;
    }
    
    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string getLastName()
    {
        return this.lastName;
    }

    /*public void setPersonalID(string personalId)
    {
        this.personalID = personalId;
    }*/

    public string getPersonalID()
    {
        return this.personalID;
    }

    private bool IsValidPersonalID(string personalID)
    {
        if (string.IsNullOrEmpty(personalID) || personalID.Length != 11 || !personalID.All(char.IsDigit))
        {
            return false;
        }

        int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
        int sum = 0;

        for (int i = 0; i < 11; i++)
        {
            sum += (personalID[i] - '0') * weights[i];
        }

        return sum % 10 == 0;
    }
}