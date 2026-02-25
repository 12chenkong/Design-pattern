namespace method_factory;

public abstract class VehicleCreator 
{
    public abstract IVehicle CreateVehicle(string id, string model, string price);

    public void orderVehicle(string id, string model, string price)
    {
        IVehicle vehicle = this.CreateVehicle(id, model, price);
        vehicle.DisplayInfo();

    }
    
}