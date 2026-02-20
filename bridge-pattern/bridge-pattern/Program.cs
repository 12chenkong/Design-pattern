// See https://aka.ms/new-console-template for more information

using bridge_pattern;

public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("======Basic remote=======");
        IDevice TV = new TV();
        BasicRemote basicRemote = new BasicRemote(TV);
        basicRemote.TurnOn();
        basicRemote.TurnOff();
        basicRemote.SetChannel(100);
        basicRemote.TurnOff();
        
        
        Console.WriteLine("=======Advance Remote=======");
        AdvanceRemote advanceRemote=new AdvanceRemote(TV);
        advanceRemote.TurnOff();
        advanceRemote.TurnOn();
        advanceRemote.Mute();
        advanceRemote.PrintingStatus();
    }
}