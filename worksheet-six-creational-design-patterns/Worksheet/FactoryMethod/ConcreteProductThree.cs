using System;

namespace QuestionThree
{
    public class ConcreteProductThree : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("{ConcreteProductThree: implements IProduct; Calling Operation()}");
        }
    }
}