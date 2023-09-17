using Microsoft.VisualStudio.TestTools.UnitTesting;
using static NotificationApp.ObserverDesign;
using System;

namespace TestNotificationApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObserver()
        {
            string a = "Notification  not sent successfully to the subscribed users!!!";
            var log = new NotifyingMultipleUsers();
            log.NotificationtoAllSubscribedUsers("Notification sent successfully to the subscribed users!!!");
            Assert.AreNotEqual(a, log);
        }
    }
}
