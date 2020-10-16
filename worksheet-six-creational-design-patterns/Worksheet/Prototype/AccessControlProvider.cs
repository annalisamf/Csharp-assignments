using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Channels;

namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static readonly Dictionary<string, AccessControl> Dic = new Dictionary<string, AccessControl>();

        static AccessControlProvider()
        {
            Console.WriteLine("Fetching data from external resources and creating access control objects...");
            Dic.Add("USER", new AccessControl("USER", Access.DoWork));
            Dic.Add("MANAGER", new AccessControl("MANAGER", Access.ReadReports));
            // Dic.Add("USER", new AccessControl("USER", "DO_WORK"));
            // Dic.Add("USER", new AccessControl("USER", "DO_WORK"));
        }

        public static AccessControl GetAccessControlObject(string controlLevel)
        {
            var accessControl = Dic[controlLevel];
            return accessControl?.Clone();
        }
    }
}
