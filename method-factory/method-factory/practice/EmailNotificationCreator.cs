namespace method_factory.practice;

public class EmailNotificationCreator : NotificationCreator
{
    public override Notification notification(string message)
    {
        return new EmailNotification();
    }
}