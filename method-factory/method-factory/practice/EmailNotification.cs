namespace method_factory.practice;

public class EmailNotification : Notification
{
    public void send(string message)
    {
        Console.WriteLine("sending email: " + message);
    }
}