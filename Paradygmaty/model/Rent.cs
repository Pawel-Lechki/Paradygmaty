namespace Paradygmaty.model;

public class Rent
{
    private Guid id;
    private DateTime startRent;
    private DateTime endRent;
    private int rentCost;
    private Vehicle vehicle;
    private Client client;

    public Rent(Vehicle vehicle, Client client, DateTime? endRent = null)
    {
        this.id = new Guid();
        this.vehicle = vehicle;
        this.client = client;
        this.startRent = DateTime.Now;
        if (endRent.HasValue)
        {
            this.endRent = endRent.Value;
            this.rentCost = CalculateRentCost(vehicle);
        } 
        else if(endRent < DateTime.Now)
        {
            this.rentCost = 0;
        }
        else
        {
            this.rentCost = 0;
        }
    }

    public DateTime setStartRent()
    {
        return DateTime.Now;
    }

    public void setRentCost(int value)
    {
        this.rentCost = value;
    }

    public int CalculateRentCost(Vehicle vehicle)
    {
        TimeSpan duration = this.endRent - this.startRent;
        int days = duration.Days;
        return days * vehicle.getBaseRentPrice();
    }

    public int getRentTime()
    {
        TimeSpan duration = this.endRent - this.startRent;
        int days = duration.Days;
        if (days <= 0) return 0;
        return days;
    }

    public void returnVehicle(DateTime dateTime)
    {
        this.endRent = dateTime;
        int days = getRentTime();
        this.rentCost = days * this.vehicle.getBaseRentPrice();
    }

    public string rentInfo()
    {
        TimeSpan days = endRent - startRent;
        
        return "\nId: " + this.id + " Wypożyczono od: " + this.startRent + " do " + this.endRent 
               + "\nCzas wypożyczenia: " + days 
               + "\nKoszt wypożycznie: " + this.rentCost
               + "\nWypożyczający: " + this.client.getFirstName() + " " + this.client.getLastName()
               + "\nWpożyczony pojazd: " + this.vehicle.vehicleInfo();
    }
}