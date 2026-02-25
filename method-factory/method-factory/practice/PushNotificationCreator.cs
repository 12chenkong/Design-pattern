namespace method_factory.practice;

public class PushNotificationCreator: NotificationCreator
{
    public override Notification notification(string message)
    {
        return new PushNotification();
    }
}