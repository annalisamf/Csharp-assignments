namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public string Description
        {
            get => "SimplyNonVegPizza (350)";
            set { }
        }

        public decimal Price
        {
            get => 350;
            set { }
        }

        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";
        }
    }
}