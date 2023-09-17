using System;

namespace NotificationApp
{
    class StrategyDesign
    {
        // Strategy Design Pattern
        
        public interface IStrategySendType
        {
            void ActualSendNotification(string subject, string body);
        }

        class SendEmailStrategy : IStrategySendType
        {
            public void ActualSendNotification(string subject, string body)
            {
                Console.WriteLine($"Sending Email: {subject} - {body}");
            }
        }

        class SendSMSStrategy : IStrategySendType
        {
            public void ActualSendNotification(string subject, string body)
            {
                Console.WriteLine($"Sending SMS: {subject} - {body}");
            }
        }

    }
}
