namespace design_pattern;

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;
    
    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual string GetDescription()=>_beverage.GetDescription();
    public virtual double GetCost()=>_beverage.GetCost();
    
  
}