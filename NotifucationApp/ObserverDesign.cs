using System;

namespace NotificationApp
{
     public class ObserverDesign
    {
        // Observer Pattern
        public interface INotificationObserver
        {
            void NotificationtoAllSubscribedUsers(string message);
        }

        public class NotifyingMultipleUsers : INotificationObserver
        {
            public void NotificationtoAllSubscribedUsers(string message)
            {
                Console.WriteLine($"\n{message}");
            }
        }

         

    }
}
