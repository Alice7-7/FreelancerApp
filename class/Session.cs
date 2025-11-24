using System;

namespace Freelance.Class
{

    // Session Manage :::

    public static class Session_manage
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int? UserId { get; set; }  
        public static string FullName { get; set; }


        // Clearing Session :::

        public static void Session_Clear()
        {
            Username = null;
            Role = null;
            UserId = null;
            FullName = null;
        }
    }
}
