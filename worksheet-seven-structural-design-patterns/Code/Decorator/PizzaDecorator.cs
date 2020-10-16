namespace Decorator
{
    public abstract class PizzaDecorator: IPizza
    {
        public abstract string Description { get; set; }
        public abstract decimal Price { get; set; }
    }
}