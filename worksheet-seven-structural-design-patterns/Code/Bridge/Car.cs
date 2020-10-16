using System.Net.Http.Headers;

namespace Bridge
{
    public abstract class Car
    {
        private IProduct Product;
        private string CarType;

        public Car(IProduct product, string carType)
        {
            Product = product;
            CarType = carType;
        }

        public abstract void Assemble();
        public abstract void ProduceProduct();

        public override string ToString()
        {
            return $"Car: {CarType}, Product: {Product.ProductName}";
        }
    }
}