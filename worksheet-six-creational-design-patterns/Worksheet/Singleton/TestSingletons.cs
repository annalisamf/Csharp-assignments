using System;

namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {
            // testing Singleton
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            // getting hashcode for each instance to check if they are the same
            var a = singleton1.GetHashCode();
            var b = singleton2.GetHashCode();

            Console.WriteLine(a == b ? "singleton1 and singleton2 have the same hashcode" : "singleton1 and singleton2 have not the same hashcode");
            Console.WriteLine(singleton1 == singleton2 ? "singleton1 and singleton2 are equals" : "singleton1 and singleton2 are not equals");
            
            // testing LazySingleton
            LazySingleton lazySingleton1 = LazySingleton.GetInstance();
            LazySingleton lazySingleton2 = LazySingleton.GetInstance();

            // getting hashcode for each instance to check if they are the same
            var lazyA = lazySingleton1.GetHashCode();
            var lazyB = lazySingleton2.GetHashCode();

            Console.WriteLine(lazyA == lazyB ? "lazySingleton1 and lazySingleton2 have the same hashcode" : "lazySingleton1 and lazySingleton2 have not the same hashcode");
            Console.WriteLine(lazySingleton1 == lazySingleton2 ? "lazySingleton1 and lazySingleton2 are equals" : "lazySingleton1 and lazySingleton2 are not equals");

            
        }
        
    }
}