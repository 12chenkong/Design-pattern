namespace method_factory.practice;

public class SMSNotificationCreator : NotificationCreator
{
    public override Notification notification(string message)
    {
       return new SMSNotification();
    }
}