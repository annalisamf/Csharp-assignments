namespace QuestionFive
{
    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        private static LazySingleton _lazyInstance;

        public static LazySingleton GetInstance()
        {
            // ?? checks if the previous variable is null, otherwise it returns the second statement
            return _lazyInstance ??= new LazySingleton();
        }
    }
}