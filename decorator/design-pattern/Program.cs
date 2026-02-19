
using design_pattern;

class Program
{
    static void Main(string[] args)
    {
       IBeverage coffee = new PlainCoffee();
       Console.WriteLine($"{coffee.GetDescription()}=>${coffee.GetCost()}");
       
       // wrap with milk 
       coffee = new MilkDecorator(coffee);
       Console.WriteLine($"{coffee.GetDescription()}=>${coffee.GetCost()}");
       
       // wrap with sugar
       coffee=new  SugarDecorator(coffee);
       Console.WriteLine($"{coffee.GetDescription()}=>{coffee.GetCost()}");
    }
}
