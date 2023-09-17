using System;

namespace NotificationApp
{
    class FactoryDesign
    {
        // Factory Design Pattern
        public interface INotificationSender
        {
            void Send(string subject, string body);
        }

        class SendEmail : INotificationSender
        {
            public void Send(string subject, string body)
            {
                Console.WriteLine($"\nSelected Mode is Email {subject} - {body}");
            }
        }

        class SendSMS : INotificationSender
        {
            public void Send(string subject, string body)
            {
                Console.WriteLine($"\nSelected Mode is SMS {subject} - {body}");
            }
        }

         public class FactoryofNotificationSendType
        {
            public INotificationSender CreateNotificationSendType(string mode)
            {
                switch (mode)
                {
                    case "email":
                        return new SendEmail();
                    case "sms":
                        return new SendSMS();
                    default:
                        throw new Exception("Invalid notification mode");
                }
            }
        }
    }
}
