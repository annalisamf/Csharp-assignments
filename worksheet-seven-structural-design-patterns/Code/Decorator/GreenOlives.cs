namespace Decorator
{
    public class GreenOlives : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public GreenOlives(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description
        {
            get => $"{_pizza.Description}, Green Olives (5.47)";
            set {}
        }

        public override decimal Price
        {
            get => _pizza.Price + (decimal) 5.47;
            set{ }

        }
            

        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}