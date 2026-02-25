namespace method_factory.practice;

public class SMSNotification : Notification
{
    public void send(string message)
    {
        Console.WriteLine("sending SMS: " + message);
    }
}