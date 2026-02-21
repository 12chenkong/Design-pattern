namespace bridge_pattern;

public abstract class Remote
{
    // 🌉 This is the BRIDGE — a reference to the implementation
    protected IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetChannel(int  channel);
    
    
    

}