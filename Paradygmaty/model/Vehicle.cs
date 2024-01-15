namespace Paradygmaty.model;

public class Vehicle
{
    private readonly int baseRentPrice;
    private readonly string id;

    public Vehicle(int baseRantPrice, string id)
    {
        this.baseRentPrice = baseRantPrice;
        this.id = id;
    }

    public string vehicleInfo()
    {
        return id + " " + baseRentPrice.ToString();
    }

    public int getBaseRentPrice()
    {
        return this.baseRentPrice;
    }
}