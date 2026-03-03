using prototype;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Build a Concrete House\n");
        HouseTemplate houseTemplate = new ConcreteHouse();
// call the template method
        houseTemplate.BuildHouse();
        Console.WriteLine();
        Console.WriteLine("Build a Wooden House\n");
        houseTemplate = new WoodenHouse();
// call the template method
        houseTemplate.BuildHouse();
        Console.Read();
    }
}