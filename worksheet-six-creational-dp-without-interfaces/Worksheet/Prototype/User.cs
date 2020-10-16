namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        public string Level { get; set; }
        public Access AccessControl { get; set; }

        public User(string name, string level, AccessControl userAccessControl)
        {
            // do something appropriate here
        }

    }
}