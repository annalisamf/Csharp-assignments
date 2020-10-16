using System;

namespace QuestionThree
{
    public class ConcreteProductOne : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("{ConcreteProductOne: implements IProduct; Calling Operation()}");
        }
        
        
    }
}