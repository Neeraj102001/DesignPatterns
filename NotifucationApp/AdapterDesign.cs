using System;
using static NotificationApp.FactoryDesign;

namespace NotificationApp
{
    class AdapterDesign
    {
        // Adapter Design Pattern
        class SMSSenderAdapterPattern : INotificationSender
        {
            private readonly SMSTypeProvider smsTypeProvider;

            public SMSSenderAdapterPattern(SMSTypeProvider provider)
            {
                smsTypeProvider = provider;
            }

            public void Send(string subject, string body)
            {
                smsTypeProvider.SendMessage(subject, body);  // Adapting or making two incompatible objects compatible to communicate
                                                         // the SMSTypeProvider's interface with INotificationSender
            }
        }
        //SMSTypeprovider class acting as bridge to provide the message
        class SMSTypeProvider
        {
            public void SendMessage(string subject, string body)
            {
                Console.WriteLine($"Selected mode is SMS \n: {subject} - {body}");
            }
        }
    }
}
// we can similarly create an Email provider class with help of Adapter pattern to communicate with INotificationSender
