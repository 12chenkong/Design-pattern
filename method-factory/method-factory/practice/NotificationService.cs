namespace method_factory.practice;

public class NotificationService
{
    public static void sendNotification(String type, String message)
    {
        NotificationCreator notify;
        if (type.Equals("email"))
        {
            notify = new EmailNotificationCreator();
            notify.send(message);
            
        }else if (type.Equals("sms"))
        {
            notify = new SMSNotificationCreator();
            notify.send(message);
        }
        else
        {
            notify = new SMSNotificationCreator();
            notify.send(message);
        }
        
    }
    
}