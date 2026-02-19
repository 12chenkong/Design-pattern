namespace bridge_pattern;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
    string GetStatus();
}