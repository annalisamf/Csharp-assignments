namespace QuestionThree
{
    // ConcreteCreator - overrides the factory method to return an instance of a ConcreteProduct.
    public class ConcreteCreator : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
        
        public IProduct FactoryMethod(string s)
        {
            return s switch
            {
                "One" => new ConcreteProductOne(),
                "Two" => new ConcreteProductTwo(),
                "Three" => new ConcreteProductThree(),
                _ => new ConcreteProductFour()
            };
        }       
    }
}