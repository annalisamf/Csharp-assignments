namespace Decorator
{
    public class Meat : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public Meat(IPizza pizza)
        {
            _pizza = pizza;
        }

        
        public override string Description
        {
            get => $"{_pizza.Description}, Meat (14.25)";
            set {}
        }

        public override decimal Price
        {
            get => _pizza.Price + (decimal) 14.25;
            set => Price = value;
        }

        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";

        }
    }
}