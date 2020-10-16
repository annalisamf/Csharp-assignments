namespace Decorator
{
    public class Ham : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public Ham(IPizza pizza)
        {
            _pizza = pizza;
        }
        
        public override string Description
        {
            get => $"{_pizza.Description}, Ham (18.12)";
            set {}
        }

        public override decimal Price
        {
            get => _pizza.Price + (decimal) 18.12;
            set => Price = value;
        }

        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}