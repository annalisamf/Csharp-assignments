﻿using System;

namespace QuestionFour
{
    public static class TestPrototypePattern
    {
        public static void Main(string[] args)
        {
            var userAccessControl = AccessControlProvider.GetAccessControlObject("USER");
            var user = new User("User A", "USER Level", userAccessControl);

            Console.WriteLine("************************************");
            Console.WriteLine(user);

            userAccessControl = AccessControlProvider.GetAccessControlObject("USER");
            user = new User("User B", "USER Level", userAccessControl);
            Console.WriteLine($"Changing access control of: {user.UserName}");
            user.AccessControl = Access.ReadReports;
            Console.WriteLine(user);

            Console.WriteLine("************************************");

            AccessControl managerAccessControl = AccessControlProvider.GetAccessControlObject("MANAGER");
            user = new User("User C", "MANAGER Level", managerAccessControl);
            Console.WriteLine(user);
        }
    }
}
/*
Fetching data from external resources and creating access control objects...
************************************
Name: User A, Level: USER Level, Access Control Level:USER, Access: DO_WORK
Changing access of: User B
Name: User B, Level: USER Level, Access Control Level:USER, Access: READ REPORTS 
************************************
Name: User C, Level: MANAGER Level, Access Control Level:MANAGER, Access: GENERATE/READ REPORTS	
*/