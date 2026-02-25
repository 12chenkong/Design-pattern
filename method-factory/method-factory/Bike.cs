namespace method_factory;

public class Bike : IVehicle
{
    private string id;
    private string model;
    private string price;


    public Bike(string id, string model, string price)
    {
        this.id = id;
        this.model = model;
        this.price = price;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine("More Info of bike...!");
    }
}