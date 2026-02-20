namespace bridge_pattern;

public class BasicRemote : Remote
{

    public BasicRemote(IDevice device) : base(device){}

    public override void TurnOff()
    {
        _device.TurnOff();
    }

    public override void TurnOn()
    {
        _device.TurnOn();
    }

    public override void SetChannel(int channel)
    {
        _device.SetChannel(channel);
    }
}