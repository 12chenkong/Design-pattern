// See https://aka.ms/new-console-template for more information

using method_factory;
using method_factory.practice;

public  class Program{

    private static void Main(string[] args)
    {

       
        NotificationService.sendNotification("sms","I love you ha!!!");
        NotificationService.sendNotification("email","We'll do our project at 10: bro");


    }
}