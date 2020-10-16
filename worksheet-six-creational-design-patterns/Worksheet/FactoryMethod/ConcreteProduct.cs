using System;

namespace QuestionThree
{
    public class ConcreteProduct : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("{ConcreteProduct: implements IProduct; Calling Operation()}");
        }
    }
}