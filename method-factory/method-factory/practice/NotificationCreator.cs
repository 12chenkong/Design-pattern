namespace method_factory.practice;

public abstract class NotificationCreator 
{
 // factory method 
  public abstract Notification notification(string message);

  public void send(string message)
  {
      Notification notification=this.notification(message);
      notification.send(message);
  }
  
}