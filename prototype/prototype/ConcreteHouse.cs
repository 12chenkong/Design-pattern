namespace prototype;

public class ConcreteHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement, iron rods and sand");
    }

    protected override void BuildPillar()
    {
        Console.WriteLine("Building Concrete Pillars with Cement and Sand");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building Concrete Walls");
    }

    protected override void BuildWindow()
    {
        Console.WriteLine("Building Concrete Windows");    }

    public override string ToString()
    {
        return base.ToString();
    }
}