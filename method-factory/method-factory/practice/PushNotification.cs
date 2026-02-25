namespace method_factory.practice;

public class PushNotification : Notification
{
    public void send(string message)
    {
        Console.WriteLine("sending push notification: " + message);
    }
}