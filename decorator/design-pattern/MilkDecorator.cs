namespace design_pattern;

public class MilkDecorator : BeverageDecorator
{

    public MilkDecorator(IBeverage beverage) : base(beverage){}

    public override string GetDescription()
    {
        return base.GetDescription()+", Milk";
    }

    public override double GetCost()
    {
        return base.GetCost()+0.50;
    }
}
    
public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage){}

    public override string GetDescription()
    {
        return base.GetDescription()+", Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost()+0.30;
    }
}
