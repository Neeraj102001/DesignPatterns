using System;
using static NotificationApp.FacadeDesign;
using static NotificationApp.ObserverDesign;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the notification sending mode (email or sms):");
        string mode = Console.ReadLine();//reading notification sending mode  

        Console.WriteLine("Enter subject:");
        string subject = Console.ReadLine();

        Console.WriteLine("Enter body:");
        string body = Console.ReadLine();

       
        var notificationFacade = new NotificationFacade(mode);  // Instantiation of the necessary objects of the Facade Design Pattern
        notificationFacade.ActualSendNotification(subject, body);  //printing the sended message on screen using the selected mode and to All Users 

        
        

        // Instantiation and notifying subscribed observers(or Users)
        var logger = new NotifyingMultipleUsers();
        logger.NotificationtoAllSubscribedUsers("Notification sent successfully to the subscribed users!!!");
        
        Console.ReadKey();
    }
}
