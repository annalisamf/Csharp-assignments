using System;

namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        public string Level { get; set; }
        public AccessControl AccessControl { get; set; }

        public User(string userName, string level, AccessControl accessControl)
        {
            UserName = userName;
            Level = level;
            AccessControl = accessControl;
        }

        public override string ToString() =>
            $"Name: {UserName}, Level: {Level}, Access Control Level: {AccessControl.ControlLevel}, Access: {AccessControl.Access}";
    }
}