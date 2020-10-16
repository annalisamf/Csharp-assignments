using System;

namespace QuestionThree
{
    public class ConcreteProductTwo : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("{ConcreteProductTwo: implements IProduct; Calling Operation()}");
        }
        
        
    }
}