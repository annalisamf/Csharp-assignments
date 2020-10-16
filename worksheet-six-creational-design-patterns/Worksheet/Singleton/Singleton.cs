namespace QuestionFive
{
    public class Singleton
    {
        private Singleton(){}
        private static readonly Singleton Instance = new Singleton();

        public static Singleton GetInstance()
        {
            return Instance;
        }
    }
}