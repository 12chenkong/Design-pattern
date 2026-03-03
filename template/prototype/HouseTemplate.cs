namespace prototype;

public abstract class HouseTemplate
{

    public void BuildHouse()
    {
        BuildFoundation();
        BuildPillar();
        BuildWalls();
        BuildWindow();
        Console.WriteLine("House built successfully!");
    }

    protected abstract void BuildFoundation();
    protected abstract void BuildPillar();
    protected abstract void BuildWalls ();
    protected abstract void BuildWindow();

}