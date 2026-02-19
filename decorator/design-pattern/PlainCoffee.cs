namespace design_pattern;

public class PlainCoffee : IBeverage
{
   // Override the method from the interface
   public string GetDescription() => "Plain coffee";
   public double GetCost() => 1.5;
   
}