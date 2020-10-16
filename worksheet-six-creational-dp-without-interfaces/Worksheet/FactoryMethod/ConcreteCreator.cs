namespace QuestionThree
{
    public class ConcreteCreator : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
        
        // any additional code that is required
    }
}