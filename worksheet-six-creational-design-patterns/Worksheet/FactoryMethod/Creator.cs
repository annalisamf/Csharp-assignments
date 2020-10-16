using System;

namespace QuestionThree
{
    // Creator — declares the factory method, which returns an object of type IProduct.
    // Creator may also define a default implementation of the factory method that returns a default
    // ConcreteProduct object. We may call the factory method to create a IProduct object.
    public class Creator : ICreator
    {
        public IProduct FactoryMethod(string s) // some type of argument - you might change this
        {
            return new ConcreteCreator().FactoryMethod(s);
        }

        public IProduct FactoryMethod()
        {
            return new ConcreteCreator().FactoryMethod();
        }

        // public string SomeOperation()
        // {
        //     // return FactoryMethod().Operation();
        //     return "Creator: the same creator's code has just worked with " + FactoryMethod().Operation();
        // }
    }
}