namespace prototype;

public class WoodenHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
    }

    protected override void BuildPillar()
    {
        Console.WriteLine("Building wood Pillars with wood coating");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building Wood Walls");
    }

    protected override void BuildWindow()
    {
        Console.WriteLine("Building Wood Windows");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}