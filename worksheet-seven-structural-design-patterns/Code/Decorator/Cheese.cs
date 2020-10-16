namespace Decorator
{
    public class Cheese : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public Cheese(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description
        {
            get => $"{_pizza.Description}, Cheese (20.72)";
            set { }
        }

        public override decimal Price
        {
            get => _pizza.Price + (decimal) 20.72;
            set => Price = value;
        }


        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}