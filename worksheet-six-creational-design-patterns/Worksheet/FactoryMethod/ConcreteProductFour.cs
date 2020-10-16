using System;

namespace QuestionThree
{
    public class ConcreteProductFour : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("{ConcreteProductFour: implements IProduct; Calling Operation()}");
        }
    }
}