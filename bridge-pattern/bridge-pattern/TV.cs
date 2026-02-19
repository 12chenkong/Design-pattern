namespace bridge_pattern;

public class TV : IDevice
{
    private bool _IsOn = false;
    private int _channel = 1;

    public void TurnOn()
    { 
        _IsOn = true;
      Console.WriteLine("TV is on Now");
    }

    public void TurnOff()
    {
        _IsOn = false;
        Console.WriteLine("TV is off now");
    }
    public void SetChannel(int channel)
    {
        _channel = channel;
        
        Console.WriteLine($"Tv channel set to {_channel}");
    }

    public string GetStatus()
    {
        return $"TV channel status is {_channel} and Power {(_IsOn?"ON":"OFF")}";
    }
}