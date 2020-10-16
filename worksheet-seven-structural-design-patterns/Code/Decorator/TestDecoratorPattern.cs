using System;

namespace Decorator
{
    public static class TestDecoratorPattern
    {
        public static void Main(string[] args)
        {
            IPizza pizza = new SimplyVegPizza();
            Console.WriteLine(pizza);
            
            pizza = new RomaTomatoes(pizza);
            Console.WriteLine(pizza);
            
            pizza = new GreenOlives(pizza);
            Console.WriteLine(pizza);
            
            pizza = new Spinach(pizza);
            Console.WriteLine(pizza);

            pizza = new SimplyNonVegPizza();
            Console.WriteLine(pizza);

            pizza = new Meat(pizza);
            Console.WriteLine(pizza);

            pizza = new Cheese(pizza);
            Console.WriteLine(pizza);

            pizza = new Ham(pizza);
            Console.WriteLine(pizza);
        }
    }
}

/*
	Desc: SimplyVegPizza (230), Roma Tomatoes (5.20), Green Olives (5.47), Spinach (7.92)
	Price: 248.59
	Desc: SimplyNonVegPizza (350), Meat (14.25), Cheese (20.72), Cheese (20.72), Ham (18.12)
	Price: 423.81
 */