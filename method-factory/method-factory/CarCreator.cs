namespace method_factory;

public class CarCreator : VehicleCreator
{
    public override IVehicle CreateVehicle(string id, string model, string price)
    {
       return new Bike(id, model, price);
    }
}