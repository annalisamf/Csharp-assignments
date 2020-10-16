using System;

namespace Bridge
{
    public class GearLocking : IProduct
    {
        public GearLocking(string name)
        {
            ProductName = name;
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            Console.WriteLine($"Producing {ProductName}");
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}