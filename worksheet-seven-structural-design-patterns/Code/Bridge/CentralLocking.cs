using System;

namespace Bridge
{
    public class CentralLocking : IProduct
    {
        public CentralLocking(string name)
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