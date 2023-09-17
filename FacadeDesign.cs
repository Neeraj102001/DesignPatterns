using System.Collections.Generic;
using static NotificationApp.FactoryDesign;
using static NotificationApp.Singleton;

namespace NotificationApp
{
    class FacadeDesign
    {
        // Facade Design Pattern for unifying the user and notification sending
         public class NotificationFacade
        {
            private readonly INotificationSender sender;
            public UserList userList;

            //sending the notification to each user in the user list
            public NotificationFacade(string mode)
            {
                sender = new FactoryofNotificationSendType().CreateNotificationSendType(mode);
                userList = UserList.GetUserInstance();
            }

            public void ActualSendNotification(string subject, string body)
            {
                List<string> users = userList.GetUsers();
                foreach (string user in users)
                {
                    sender.Send($"and is send to: {user} - {subject}", body);  // Sending notifications to users using the selected mode 
                }
            }
        }
    }
}
