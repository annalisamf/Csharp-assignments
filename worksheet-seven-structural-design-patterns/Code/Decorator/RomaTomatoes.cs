using System.Diagnostics;

namespace Decorator
{
    public class RomaTomatoes : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public RomaTomatoes(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description
        {
            get => $"{_pizza.Description}, Roma Tomatoes (5.20)";
            set {}
        }


        public override decimal Price
        {
            get => _pizza.Price + (decimal) 5.20;
            set => Price = value;
        }
        
        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}