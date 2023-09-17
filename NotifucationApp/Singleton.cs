using System.Collections.Generic;

namespace NotificationApp
{
    class Singleton
    {
        // Singleton Design Pattern for creating only one instance of users and accessing these users globally
        public sealed class UserList
        {
            private static UserList userinstance;
            private List<string> users;

            private UserList()
            {
                // user data
                users = new List<string> { "Neeraj Yadav", "Ajeet Kumar", "Pradeep" , "Naresh Singh"};
            }

            public static UserList GetUserInstance()
            {
                if (userinstance == null)
                {
                    userinstance = new UserList();
                }
                return userinstance;
            }

            public List<string> GetUsers()
            {
                return users;
            }
        }
    }
}
