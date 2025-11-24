using System;
using System.Collections.Generic;

namespace Freelance.Controllers
{
    public class loginattempt_control
    {
        private static Dictionary<string, int> failedAttempts = new Dictionary<string, int>();
        private static Dictionary<string, DateTime> lockoutTime = new Dictionary<string, DateTime>();


        public static bool IsLocked(string username)
        {
            return lockoutTime.ContainsKey(username) && DateTime.Now < lockoutTime[username];
        }

        public static void RegisterFailure(string username)
        {
            if (!failedAttempts.ContainsKey(username))
                failedAttempts[username] = 0;

            failedAttempts[username]++;

            if (failedAttempts[username] >= 3)
            {
                lockoutTime[username] = DateTime.Now.AddSeconds(30); 
            }
        }

        public static void ResetAttempts(string username)
        {
            if (failedAttempts.ContainsKey(username))
                failedAttempts[username] = 0;

            if (lockoutTime.ContainsKey(username))
                lockoutTime.Remove(username);
        }
    }
}
