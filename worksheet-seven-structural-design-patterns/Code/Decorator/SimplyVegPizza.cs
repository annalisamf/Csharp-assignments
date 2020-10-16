namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        public string Description
        {
            get => "SimplyVegPizza (230)";
            set { }
        }
        
        public decimal Price
        {
            get => 230;
            set { }
        }


        public override string ToString()
        {
            return $"Desc: {Description}, Price: {Price}";


        }
    }
}