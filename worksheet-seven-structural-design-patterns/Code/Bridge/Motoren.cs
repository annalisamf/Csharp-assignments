using System;

namespace Bridge
{
    public class Motoren : Car
    {
        private readonly IProduct _product;
        private readonly string _v;

        public Motoren(IProduct product, string v) : base(product, v)
        {
            _product = product;
            _v = v;
        }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling {_product} for {_v}");
        }

        public override void ProduceProduct()
        {
            _product.Produce();
            Console.WriteLine($"Modifying product {_product} according to {_v}");
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}