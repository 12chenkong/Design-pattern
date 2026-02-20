namespace bridge_pattern;

public class AdvanceRemote : Remote
{
    public  AdvanceRemote(IDevice device) : base(device){}

    public override void TurnOn()
    {
        _device.TurnOn();
    }
    
    public  override void TurnOff()=>_device.TurnOff();
    public override void SetChannel(int channel)
    {
        _device.SetChannel(channel);
    }
    
    public void Mute()
    {
        Console.WriteLine("Muting Device....");
        _device.SetChannel(0);
    }

    public void PrintingStatus()
    {
        _device.GetStatus();
    }
    
}