using System;
using System.Net.WebSockets;
using System.Xml.Serialization;

namespace QuestionThree
{
    public static class Driver
    {
        public static void Main()
        {
            var factory = new Creator();
            factory.FactoryMethod().Operation();
            factory.FactoryMethod("One").Operation();
            factory.FactoryMethod("Two").Operation();
            factory.FactoryMethod("Three").Operation();
            factory.FactoryMethod("Four").Operation();
        }
    }
}