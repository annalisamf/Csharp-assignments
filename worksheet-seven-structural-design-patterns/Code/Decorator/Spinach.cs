namespace Decorator
{
    public class Spinach : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public Spinach(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description
        {
            get => $"{_pizza.Description}, Spinach (7.92)";
            set {}
        }

        public override decimal Price
        {
            get => _pizza.Price + (decimal) 7.92;
            set => Price = value;
        }
        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}